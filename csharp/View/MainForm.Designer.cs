namespace PaperVoucher
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.Label label_step1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label_step2;
		private System.Windows.Forms.PictureBox skin_preview;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox input_token;
		private System.Windows.Forms.TextBox input_port;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox input_host;
		private System.Windows.Forms.TextBox logbox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button button_help1;
		private System.Windows.Forms.Button button_github;
		private System.Windows.Forms.Button btn_skin_next;
		private System.Windows.Forms.Button btn_skin_prev;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label_step3;
		private System.Windows.Forms.TextBox textBox_amount;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox_preview;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_print_voucher;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btn_save_file;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btn_minimize;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_copy_code;
		private System.Windows.Forms.Label label_last_voucher;
		private System.Windows.Forms.Panel panel_placeholder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox_loading_icon;
		private System.Windows.Forms.Timer timer_NetConfirmations;
		private System.Windows.Forms.Label label7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button_help1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.input_token = new System.Windows.Forms.TextBox();
			this.input_port = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.input_host = new System.Windows.Forms.TextBox();
			this.btn_connect = new System.Windows.Forms.Button();
			this.button_github = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.logbox = new System.Windows.Forms.TextBox();
			this.label_step1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btn_skin_prev = new System.Windows.Forms.Button();
			this.btn_skin_next = new System.Windows.Forms.Button();
			this.skin_preview = new System.Windows.Forms.PictureBox();
			this.label_step2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.panel_placeholder = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox_loading_icon = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_amount = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_copy_code = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.btn_save_file = new System.Windows.Forms.Button();
			this.btn_print_voucher = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label_last_voucher = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox_preview = new System.Windows.Forms.PictureBox();
			this.label_step3 = new System.Windows.Forms.Label();
			this.btn_minimize = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.timer_NetConfirmations = new System.Windows.Forms.Timer(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.skin_preview)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.panel_placeholder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading_icon)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(782, 453);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.button_github);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.label_step1);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(774, 417);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Step 1: connection";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button_help1);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.input_token);
			this.panel2.Controls.Add(this.input_port);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.input_host);
			this.panel2.Controls.Add(this.btn_connect);
			this.panel2.Location = new System.Drawing.Point(56, 111);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(375, 222);
			this.panel2.TabIndex = 9;
			// 
			// button_help1
			// 
			this.button_help1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.button_help1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.button_help1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_help1.Location = new System.Drawing.Point(121, 17);
			this.button_help1.Name = "button_help1";
			this.button_help1.Size = new System.Drawing.Size(238, 32);
			this.button_help1.TabIndex = 16;
			this.button_help1.Text = "Where can I find this data?";
			this.button_help1.UseVisualStyleBackColor = true;
			this.button_help1.Click += new System.EventHandler(this.Button_help1Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(15, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 27);
			this.label5.TabIndex = 13;
			this.label5.Text = "token";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(15, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 27);
			this.label4.TabIndex = 14;
			this.label4.Text = "port";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_token
			// 
			this.input_token.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.input_token.Location = new System.Drawing.Point(121, 121);
			this.input_token.Name = "input_token";
			this.input_token.Size = new System.Drawing.Size(238, 27);
			this.input_token.TabIndex = 10;
			this.input_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// input_port
			// 
			this.input_port.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.input_port.Location = new System.Drawing.Point(121, 88);
			this.input_port.Name = "input_port";
			this.input_port.Size = new System.Drawing.Size(238, 27);
			this.input_port.TabIndex = 11;
			this.input_port.Text = "22160";
			this.input_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(15, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 27);
			this.label3.TabIndex = 15;
			this.label3.Text = "host";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// input_host
			// 
			this.input_host.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.input_host.Location = new System.Drawing.Point(121, 55);
			this.input_host.Name = "input_host";
			this.input_host.Size = new System.Drawing.Size(238, 27);
			this.input_host.TabIndex = 12;
			this.input_host.Text = "http://127.0.0.1";
			this.input_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_connect
			// 
			this.btn_connect.FlatAppearance.BorderSize = 2;
			this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_connect.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_connect.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
			this.btn_connect.Location = new System.Drawing.Point(121, 154);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(238, 55);
			this.btn_connect.TabIndex = 9;
			this.btn_connect.Text = "Connect to client";
			this.btn_connect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.Btn_connectClick);
			// 
			// button_github
			// 
			this.button_github.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.button_github.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.button_github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_github.Location = new System.Drawing.Point(8, 380);
			this.button_github.Name = "button_github";
			this.button_github.Size = new System.Drawing.Size(75, 32);
			this.button_github.TabIndex = 8;
			this.button_github.Text = "Github";
			this.button_github.UseVisualStyleBackColor = true;
			this.button_github.Click += new System.EventHandler(this.Button_githubClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.logbox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(497, 68);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(274, 346);
			this.panel1.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(274, 38);
			this.label6.TabIndex = 8;
			this.label6.Text = "Connection log";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// logbox
			// 
			this.logbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.logbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.logbox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.logbox.ForeColor = System.Drawing.Color.White;
			this.logbox.Location = new System.Drawing.Point(0, 40);
			this.logbox.Multiline = true;
			this.logbox.Name = "logbox";
			this.logbox.Size = new System.Drawing.Size(274, 306);
			this.logbox.TabIndex = 7;
			// 
			// label_step1
			// 
			this.label_step1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_step1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_step1.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label_step1.Location = new System.Drawing.Point(3, 3);
			this.label_step1.Name = "label_step1";
			this.label_step1.Size = new System.Drawing.Size(768, 65);
			this.label_step1.TabIndex = 2;
			this.label_step1.Text = "Step 1: connection to the Utopia client";
			this.label_step1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage2.Controls.Add(this.btn_skin_prev);
			this.tabPage2.Controls.Add(this.btn_skin_next);
			this.tabPage2.Controls.Add(this.skin_preview);
			this.tabPage2.Controls.Add(this.label_step2);
			this.tabPage2.Location = new System.Drawing.Point(4, 32);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(774, 417);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Step 2: design";
			// 
			// btn_skin_prev
			// 
			this.btn_skin_prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_skin_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_skin_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_skin_prev.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_skin_prev.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_skin_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_skin_prev.Image")));
			this.btn_skin_prev.Location = new System.Drawing.Point(31, 179);
			this.btn_skin_prev.Name = "btn_skin_prev";
			this.btn_skin_prev.Size = new System.Drawing.Size(138, 52);
			this.btn_skin_prev.TabIndex = 6;
			this.btn_skin_prev.Text = "Prev skin";
			this.btn_skin_prev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_skin_prev.UseVisualStyleBackColor = true;
			this.btn_skin_prev.Click += new System.EventHandler(this.Btn_skin_prevClick);
			// 
			// btn_skin_next
			// 
			this.btn_skin_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_skin_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_skin_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_skin_next.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_skin_next.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_skin_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_skin_next.Image")));
			this.btn_skin_next.Location = new System.Drawing.Point(607, 179);
			this.btn_skin_next.Name = "btn_skin_next";
			this.btn_skin_next.Size = new System.Drawing.Size(138, 52);
			this.btn_skin_next.TabIndex = 6;
			this.btn_skin_next.Text = "Next skin";
			this.btn_skin_next.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_skin_next.UseVisualStyleBackColor = true;
			this.btn_skin_next.Click += new System.EventHandler(this.Btn_skin_nextClick);
			// 
			// skin_preview
			// 
			this.skin_preview.Location = new System.Drawing.Point(198, 71);
			this.skin_preview.Name = "skin_preview";
			this.skin_preview.Size = new System.Drawing.Size(378, 329);
			this.skin_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.skin_preview.TabIndex = 5;
			this.skin_preview.TabStop = false;
			// 
			// label_step2
			// 
			this.label_step2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_step2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_step2.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label_step2.Location = new System.Drawing.Point(3, 3);
			this.label_step2.Name = "label_step2";
			this.label_step2.Size = new System.Drawing.Size(768, 65);
			this.label_step2.TabIndex = 3;
			this.label_step2.Text = "Step 2: design choice";
			this.label_step2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage3.Controls.Add(this.panel_placeholder);
			this.tabPage3.Controls.Add(this.panel4);
			this.tabPage3.Controls.Add(this.btn_copy_code);
			this.tabPage3.Controls.Add(this.button6);
			this.tabPage3.Controls.Add(this.btn_save_file);
			this.tabPage3.Controls.Add(this.btn_print_voucher);
			this.tabPage3.Controls.Add(this.panel3);
			this.tabPage3.Controls.Add(this.label_step3);
			this.tabPage3.Location = new System.Drawing.Point(4, 32);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(774, 417);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Step 3: print";
			// 
			// panel_placeholder
			// 
			this.panel_placeholder.Controls.Add(this.label7);
			this.panel_placeholder.Controls.Add(this.label2);
			this.panel_placeholder.Controls.Add(this.pictureBox_loading_icon);
			this.panel_placeholder.Location = new System.Drawing.Point(8, 9);
			this.panel_placeholder.Name = "panel_placeholder";
			this.panel_placeholder.Size = new System.Drawing.Size(225, 89);
			this.panel_placeholder.TabIndex = 12;
			this.panel_placeholder.Visible = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(3, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(219, 28);
			this.label7.TabIndex = 1;
			this.label7.Text = "This may take several minutes";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(58, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 51);
			this.label2.TabIndex = 1;
			this.label2.Text = "Waiting for network confirmation...";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox_loading_icon
			// 
			this.pictureBox_loading_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_loading_icon.Image")));
			this.pictureBox_loading_icon.Location = new System.Drawing.Point(3, 5);
			this.pictureBox_loading_icon.Name = "pictureBox_loading_icon";
			this.pictureBox_loading_icon.Size = new System.Drawing.Size(49, 51);
			this.pictureBox_loading_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_loading_icon.TabIndex = 0;
			this.pictureBox_loading_icon.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.textBox_amount);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Location = new System.Drawing.Point(49, 116);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(392, 97);
			this.panel4.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(275, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 27);
			this.label1.TabIndex = 12;
			this.label1.Text = "CRP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_amount
			// 
			this.textBox_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.textBox_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_amount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox_amount.ForeColor = System.Drawing.Color.White;
			this.textBox_amount.Location = new System.Drawing.Point(65, 44);
			this.textBox_amount.Name = "textBox_amount";
			this.textBox_amount.Size = new System.Drawing.Size(204, 23);
			this.textBox_amount.TabIndex = 11;
			this.textBox_amount.Text = "0.1";
			this.textBox_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(17, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(362, 27);
			this.label9.TabIndex = 8;
			this.label9.Text = "Voucher amount";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_copy_code
			// 
			this.btn_copy_code.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_copy_code.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_copy_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_copy_code.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_copy_code.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_copy_code.Image = ((System.Drawing.Image)(resources.GetObject("btn_copy_code.Image")));
			this.btn_copy_code.Location = new System.Drawing.Point(257, 256);
			this.btn_copy_code.Name = "btn_copy_code";
			this.btn_copy_code.Size = new System.Drawing.Size(184, 52);
			this.btn_copy_code.TabIndex = 9;
			this.btn_copy_code.Text = "copy code";
			this.btn_copy_code.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_copy_code.UseVisualStyleBackColor = true;
			this.btn_copy_code.Visible = false;
			this.btn_copy_code.Click += new System.EventHandler(this.Btn_copy_codeClick);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.ForestGreen;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.ForeColor = System.Drawing.Color.GreenYellow;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(49, 256);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(184, 52);
			this.button6.TabIndex = 9;
			this.button6.Text = "gen voucher";
			this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// btn_save_file
			// 
			this.btn_save_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btn_save_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_save_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_save_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save_file.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_save_file.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_save_file.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_file.Image")));
			this.btn_save_file.Location = new System.Drawing.Point(49, 333);
			this.btn_save_file.Name = "btn_save_file";
			this.btn_save_file.Size = new System.Drawing.Size(184, 52);
			this.btn_save_file.TabIndex = 9;
			this.btn_save_file.Text = "save voucher";
			this.btn_save_file.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_save_file.UseVisualStyleBackColor = false;
			this.btn_save_file.Visible = false;
			this.btn_save_file.Click += new System.EventHandler(this.Btn_save_fileClick);
			// 
			// btn_print_voucher
			// 
			this.btn_print_voucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btn_print_voucher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_print_voucher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_print_voucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_print_voucher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_print_voucher.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_print_voucher.Image = ((System.Drawing.Image)(resources.GetObject("btn_print_voucher.Image")));
			this.btn_print_voucher.Location = new System.Drawing.Point(257, 333);
			this.btn_print_voucher.Name = "btn_print_voucher";
			this.btn_print_voucher.Size = new System.Drawing.Size(184, 52);
			this.btn_print_voucher.TabIndex = 9;
			this.btn_print_voucher.Text = "print voucher";
			this.btn_print_voucher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_print_voucher.UseVisualStyleBackColor = false;
			this.btn_print_voucher.Visible = false;
			this.btn_print_voucher.Click += new System.EventHandler(this.Btn_print_voucherClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.panel3.Controls.Add(this.label_last_voucher);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.pictureBox_preview);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(467, 65);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(307, 352);
			this.panel3.TabIndex = 8;
			// 
			// label_last_voucher
			// 
			this.label_last_voucher.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label_last_voucher.Location = new System.Drawing.Point(0, 212);
			this.label_last_voucher.Name = "label_last_voucher";
			this.label_last_voucher.Size = new System.Drawing.Size(307, 140);
			this.label_last_voucher.TabIndex = 2;
			this.label_last_voucher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(307, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "Paper Voucher Preview";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox_preview
			// 
			this.pictureBox_preview.Location = new System.Drawing.Point(3, 26);
			this.pictureBox_preview.Name = "pictureBox_preview";
			this.pictureBox_preview.Size = new System.Drawing.Size(301, 183);
			this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_preview.TabIndex = 0;
			this.pictureBox_preview.TabStop = false;
			// 
			// label_step3
			// 
			this.label_step3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_step3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_step3.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label_step3.Location = new System.Drawing.Point(0, 0);
			this.label_step3.Name = "label_step3";
			this.label_step3.Size = new System.Drawing.Size(774, 65);
			this.label_step3.TabIndex = 4;
			this.label_step3.Text = "Step 3: generate and print voucher                 ";
			this.label_step3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_minimize
			// 
			this.btn_minimize.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_minimize.FlatAppearance.BorderSize = 0;
			this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_minimize.ForeColor = System.Drawing.Color.White;
			this.btn_minimize.Location = new System.Drawing.Point(687, 14);
			this.btn_minimize.Name = "btn_minimize";
			this.btn_minimize.Size = new System.Drawing.Size(32, 32);
			this.btn_minimize.TabIndex = 12;
			this.btn_minimize.Text = "_";
			this.btn_minimize.UseVisualStyleBackColor = false;
			this.btn_minimize.Click += new System.EventHandler(this.Btn_minimizeClick);
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.IndianRed;
			this.btn_close.FlatAppearance.BorderSize = 0;
			this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_close.ForeColor = System.Drawing.Color.White;
			this.btn_close.Location = new System.Drawing.Point(727, 14);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(32, 32);
			this.btn_close.TabIndex = 13;
			this.btn_close.Text = "X";
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.Btn_closeClick);
			// 
			// timer_NetConfirmations
			// 
			this.timer_NetConfirmations.Interval = 300;
			this.timer_NetConfirmations.Tick += new System.EventHandler(this.Timer_NetConfirmationsTick);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(782, 453);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_minimize);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Paper Voucher Generator | Utopia Ecosystem";
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.skin_preview)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.panel_placeholder.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading_icon)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
