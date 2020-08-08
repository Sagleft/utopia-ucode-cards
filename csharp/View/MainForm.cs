using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using ZXing;
using ZXing.Rendering;
using ZXing.Common;
using ZXing.Datamatrix.Encoder;
using ZXing.QrCode;

namespace PaperVoucher
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int x, y;
    	bool s = false;
    	const string skins_folder = "skins";
    	string[] wallet_skins = {};
    	int selected_skin_index = 0;
    	UtopiaLib.Client client;
    	bool is_connected = false;
    	bool is_generated = false;
    	string voucher_referenceNumber = "";
		
		public MainForm()
		{
			InitializeComponent();
			this.SuspendLayout();
			this.KeyPreview = true;
			
			if(!Directory.Exists(skins_folder)) {
				alert("Skins folder not found"); exit();
			}
			
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			
			this.tabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.tabPage1.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.tabPage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.tabPage2.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.tabPage3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.tabPage3.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			
			this.label_step1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.label_step1.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.label_step2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.label_step2.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.label_step3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			this.label_step3.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.dragForm);
			
			this.ResumeLayout(false);
		}
		
		private void dragForm(object sender, MouseEventArgs e) {
			if (s == false) { x = e.X; y = e.Y; s = true; }
			if (e.Button.ToString() == "Left")
			{
				this.Location = new Point(this.Left + e.X - x, this.Top + e.Y - y);
			}
			else
			{ s = false; }
		}
		
		void updateSkin() {
			string skin_path = wallet_skins[selected_skin_index];
			skin_preview.Image = new Bitmap(skin_path);
		}
		
		void Btn_skin_prevClick(object sender, EventArgs e)
		{
			if(selected_skin_index > 0) {
				selected_skin_index--;
				updateSkin();
			}
		}
		
		void Btn_skin_nextClick(object sender, EventArgs e)
		{
			if(selected_skin_index < wallet_skins.Length-1) {
				selected_skin_index++;
				updateSkin();
			}
		}
		
		public Bitmap data2QR(string code = "", int size = 256)
		{
		     BarcodeWriter writer = new BarcodeWriter();
		     QrCodeEncodingOptions qr = new QrCodeEncodingOptions()
		     {
		     	 DisableECI = true,
		         CharacterSet = "UTF-8",
		         ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H,
		         Height = size,
		         Width = size,
		         Margin = 1
		     };
		     writer.Options = qr;
		     writer.Format = BarcodeFormat.QR_CODE;
		     Bitmap bitmap = writer.Write(code);
		     return bitmap;
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			//find skins
			wallet_skins = Directory.GetFiles(skins_folder + "/", "*.png", SearchOption.TopDirectoryOnly);
			//Debug.Print("t: " + wallet_skins[1]);
			updateSkin();
		}
		
		void alert(string info = "") {
			MessageBox.Show(info, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void exit() {
			System.Environment.Exit(0);
			//System.Environment.FailFast("oO!");
		}
		void Btn_closeClick(object sender, EventArgs e)
		{
			exit();
		}
		
		void Btn_minimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		
		void appendLog(string info = "") {
			logbox.AppendText(" > " + info + Environment.NewLine);
		}
		
		void Btn_connectClick(object sender, EventArgs e)
		{
			if(is_connected) {
				DialogResult result = MessageBox.Show("Close current connection and open new?\nCurrent processes will be canceled", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				switch(result) {
					case DialogResult.Yes:
						appendLog("I create a new connection to the client");
						resumeForm();
						break;
					case DialogResult.No:
						return;
				}
			}
			
			int port = 22160;
			Int32.TryParse(input_port.Text, out port);
			appendLog("I'm trying to connect to a client...");
			try {
				client = new UtopiaLib.Client(input_host.Text, port, input_token.Text);
				decimal balance = client.getBalance();
				appendLog("Success!");
				appendLog("Available balance: " + balance.ToString() + " CRP");
				is_connected = true;
			} catch(Exception ex) {
				appendLog("Failed to connect: " + ex.Message);
				is_connected = false;
			}
			
			//renderVoucher("test");
		}
		
		void Button_githubClick(object sender, EventArgs e)
		{
			Process.Start("https://github.com/Sagleft/utopia-paper-voucher");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if(!is_connected) {
				alert("First connect to the client in step #1");
				return;
			}
			
			//if(!is_generated) {
			//	alert("waiting for network confirmations");
			//}
			
			decimal voucher_amount = 0.1M;
			NumberStyles decimal_style = NumberStyles.Any;
			CultureInfo  culture = CultureInfo.CreateSpecificCulture("en-GB");
			decimal.TryParse(textBox_amount.Text, decimal_style, culture, out voucher_amount);
			
			//alert("parsed amount: " + voucher_amount.ToString());
			//return;
			
			//check balance
			decimal available_balance = 0;
			try {
				available_balance = client.getBalance();
				if(available_balance < voucher_amount) {
					alert("Not enough balance to create a voucher");
					return;
				}
			} catch(Exception ex) {
				alert("failed to getbalance: " + ex.Message);
				return;
			}
			
			//string referenceNumber = "";
			try {
				voucher_referenceNumber = client.createVoucher(voucher_amount);
			} catch(Exception ex) {
				alert("failed to gen new voucher:" + Environment.NewLine + ex.Message);
				return;
			}
			
			label_last_voucher.Text = "";
			is_generated = false;
			this.SuspendLayout();
			panel_placeholder.Visible = true;
			timer_NetConfirmations.Enabled = true;
			timer_NetConfirmations.Start();
		}
		
		void resumeForm() {
			timer_NetConfirmations.Enabled = false;
			timer_NetConfirmations.Stop();
			panel_placeholder.Visible = false;
			this.ResumeLayout();
		}
		
		void renderVoucher(string voucher_code = "") {
			JObject my_profile;
			try {
				my_profile = client.getOwnContact();
			} catch(Exception ex) {
				alert("failed to get self profile. error: " + ex.Message); return;
			}
			
			int size_fix = 76;
			string pubkey = my_profile["pk"].ToString();
			
			Bitmap bmp_qr = data2QR(voucher_code, 215 + size_fix);
			string skin_path = wallet_skins[selected_skin_index];
			Bitmap bmp_skin = new Bitmap(skin_path);
			Graphics gr = Graphics.FromImage(bmp_skin);
			gr.DrawImage(bmp_qr, 38, 38);
			
			Bitmap bmp_qr2 = data2QR(pubkey, 199 + size_fix);
			gr.DrawImage(bmp_qr2, 1316, 176);
			
			pictureBox_preview.Image = bmp_skin;
		}
		
		void showVoucher(string voucher_code = "") {
			label_last_voucher.Text = voucher_code;
			is_generated = true;
			btn_copy_code.Visible = true;
			btn_print_voucher.Visible = true;
			btn_save_file.Visible = true;
		}
		
		void Timer_NetConfirmationsTick(object sender, EventArgs e)
		{
			JArray financeHistory = new JArray();
			try {
				financeHistory = client.getFinanceHistory("CREATED_VOUCHERS", null, voucher_referenceNumber);
			} catch(Exception ex) {
				alert("Failed to request voucher creation status: " + ex.Message);
				resumeForm(); return;
			}
			if(financeHistory.Count == 0) {
				alert("Failed to request voucher creation status");
				resumeForm(); return;
			}
			
			string voucher_code = "";
			
			for(int i=0; i < financeHistory.Count; i++) {
				JToken finance_item = financeHistory[i];
				if(finance_item["state"].ToString() == "-1") {
					//no confirmations founded
					return;
				}
				if(finance_item["state"].ToString() == "0") {
					//voucher succesfully created
					//find voucher code
					string voucher_details = finance_item["details"].ToString();
					string[] temp = voucher_details.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
					voucher_code = temp[1];
					break;
				}
			}
			
			showVoucher(voucher_code);
			renderVoucher(voucher_code);
			resumeForm();
		}
		
		void Btn_copy_codeClick(object sender, EventArgs e)
		{
			if(is_generated) {
				Clipboard.SetText(label_last_voucher.Text);
			}
		}
		
		void Btn_save_fileClick(object sender, EventArgs e)
		{
			if(!is_generated) {
				return;
			}
			
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "Portable Network Graphics (*.png)|*.png";
			if (SFD.ShowDialog() == DialogResult.OK)
			{
				pictureBox_preview.Image.Save(SFD.FileName, ImageFormat.Png);
			}
		}
		
		private void myPrintDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pictureBox_preview.Width, pictureBox_preview.Height);
            pictureBox_preview.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox_preview.Width, pictureBox_preview.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }
		
		void Btn_print_voucherClick(object sender, EventArgs e)
		{
			if(!is_generated) {
				return;
			}
			
			PrintDocument myPrintDocument1 = new PrintDocument();
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrintDocument1.PrintPage += new PrintPageEventHandler(myPrintDocument2_PrintPage);
            myPrinDialog1.Document = myPrintDocument1;
            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
               myPrintDocument1.Print();
            }
		}
		void Button_help1Click(object sender, EventArgs e)
		{
			alert("In Utopia client:\nTools -> Settings -> API\n\nEnable API, create token");
		}
	}
}
