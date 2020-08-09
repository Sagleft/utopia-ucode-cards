using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
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

namespace uCodeCards
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
    	//string voucher_referenceNumber = "";
		
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
			
			listBox_fontcolor.SelectedIndex = 0;
			listBox_font.SelectedIndex = 1;
			
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
		
		public Bitmap uCodeEncode(string code = "", int size = 256) {
			string ucode_b64 = client.ucodeEncode(code, size, "BASE64", "PNG");
			byte[] ucode_bytes = System.Convert.FromBase64String(ucode_b64);
			Bitmap ucode_bitmap;
			using (var ms = new MemoryStream(ucode_bytes))
			{
			    ucode_bitmap = new Bitmap(ms);
			}
			return ucode_bitmap;
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
				
				is_connected = client.checkClientConnection();
				if(is_connected) {
					appendLog("Success!");
				} else {
					appendLog("Failed to connect");
				}
			} catch(Exception ex) {
				appendLog("Failed to connect: " + ex.Message);
				is_connected = false;
			}
		}
		
		void Button_githubClick(object sender, EventArgs e)
		{
			//view source on github
			Process.Start("https://github.com/Sagleft/utopia-ucode-cards");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			if(!is_connected) {
				alert("First connect to the client in step #1");
				return;
			}
			
			is_generated = false;
			renderCard();
		}
		
		void resumeForm() {
			timer_NetConfirmations.Enabled = false;
			timer_NetConfirmations.Stop();
			this.ResumeLayout();
		}
		
		void renderCard() {
			JObject my_profile;
			try {
				my_profile = client.getOwnContact();
			} catch(Exception ex) {
				alert("failed to get self profile. error: " + ex.Message); return;
			}
			
			//constants
			const int x_radius    = 20;
			const int y_radius    = 20;
			const int ucode_posX  = 700;
			const int ucode_posY  = 90;
			const int ucode_width = 300;
			const int border_width = 20;
			
			//prepare skin & canvas
			string skin_path = wallet_skins[selected_skin_index];
			Bitmap bmp_skin = new Bitmap(skin_path);
			Graphics canvas = Graphics.FromImage(bmp_skin);
			
			if(checkBox_addBorder.Checked) {
				//render uCode background
				//canvas.draw
				Rectangle rect = new Rectangle(
					ucode_posX - border_width,
					ucode_posY - border_width,
					ucode_width - border_width,
					ucode_width - border_width
				);
				
				using (Pen pen = new Pen(Color.White, 5))
				{
				    GraphicsPath path = GraphicHelpers.MakeRoundedRect(
				        rect, x_radius, y_radius, true, true, true, true);
				    canvas.FillPath(Brushes.White, path);
				    canvas.DrawPath(pen, path);
				}
			}
			
			//render uCode
			string pubkey = my_profile["pk"].ToString();
			Bitmap bmp_qr = uCodeEncode(pubkey, ucode_width);
			canvas.DrawImage(bmp_qr, ucode_posX, ucode_posY);
			
			//load font
			System.Drawing.Text.PrivateFontCollection fontCollection = new System.Drawing.Text.PrivateFontCollection();
 			//TODO: check fonts exists
 			fontCollection.AddFontFile("fonts/Akrobat-" + listBox_font.Items[listBox_font.SelectedIndex] + ".otf");
 			Font font_big = new Font(fontCollection.Families[0], 57);
 			Font font_medium = new Font(fontCollection.Families[0], 30);
 			
 			//render data
 			Color fontColor = Color.Black;
 			SolidBrush drawBrush = new SolidBrush(fontColor);
 			switch(listBox_fontcolor.Items[listBox_fontcolor.SelectedIndex].ToString()) {
 				case "black":
 					fontColor = Color.Black;
 					break;
 				case "white":
 					fontColor = Color.White;
 					break;
 			}
 			drawBrush.Color = fontColor;
 			
 			canvas.DrawString(card_username.Text, font_big, drawBrush, 87, 87);
 			canvas.DrawString(card_userqualifi.Text, font_medium, drawBrush, 90, 180);
 			canvas.DrawString(card_contactinfo.Text, font_medium, drawBrush, 90, 280);
 			canvas.DrawString(card_userservices.Text, font_medium, drawBrush, 600, 415);
			
 			//set image
			pictureBox_preview.Image = bmp_skin;
			is_generated = true;
		}
		
		void showVoucher(string voucher_code = "") {
			//label_last_voucher.Text = voucher_code;
			is_generated = true;
			//btn_copy_code.Visible = true;
			btn_print_voucher.Visible = true;
			btn_save_file.Visible = true;
		}
		
		void Btn_copy_codeClick(object sender, EventArgs e)
		{
			if(is_generated) {
				//Clipboard.SetText(label_last_voucher.Text);
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
