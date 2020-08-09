namespace uCodeCards
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
		private System.Windows.Forms.PictureBox pictureBox_preview;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_print_voucher;
		private System.Windows.Forms.Button btn_save_file;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btn_minimize;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Timer timer_NetConfirmations;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox card_contactinfo;
		private System.Windows.Forms.TextBox card_username;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox card_userqualifi;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox card_userservices;
		private System.Windows.Forms.ListBox listBox_fontcolor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox_font;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox_addBorder;
		
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
			this.checkBox_addBorder = new System.Windows.Forms.CheckBox();
			this.listBox_font = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox_fontcolor = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_skin_prev = new System.Windows.Forms.Button();
			this.btn_skin_next = new System.Windows.Forms.Button();
			this.skin_preview = new System.Windows.Forms.PictureBox();
			this.label_step2 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.card_userservices = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.card_userqualifi = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.card_contactinfo = new System.Windows.Forms.TextBox();
			this.card_username = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox_preview = new System.Windows.Forms.PictureBox();
			this.button6 = new System.Windows.Forms.Button();
			this.btn_save_file = new System.Windows.Forms.Button();
			this.btn_print_voucher = new System.Windows.Forms.Button();
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
			this.tabPage4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
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
			this.input_port.Text = "22324";
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
			this.tabPage2.Controls.Add(this.checkBox_addBorder);
			this.tabPage2.Controls.Add(this.listBox_font);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.listBox_fontcolor);
			this.tabPage2.Controls.Add(this.label1);
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
			// checkBox_addBorder
			// 
			this.checkBox_addBorder.Checked = true;
			this.checkBox_addBorder.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_addBorder.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_addBorder.Location = new System.Drawing.Point(556, 225);
			this.checkBox_addBorder.Name = "checkBox_addBorder";
			this.checkBox_addBorder.Size = new System.Drawing.Size(213, 38);
			this.checkBox_addBorder.TabIndex = 20;
			this.checkBox_addBorder.Text = "add a border around uCode";
			this.checkBox_addBorder.UseVisualStyleBackColor = true;
			// 
			// listBox_font
			// 
			this.listBox_font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.listBox_font.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox_font.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.listBox_font.FormattingEnabled = true;
			this.listBox_font.ItemHeight = 23;
			this.listBox_font.Items.AddRange(new object[] {
			"Regular",
			"Bold"});
			this.listBox_font.Location = new System.Drawing.Point(589, 165);
			this.listBox_font.Name = "listBox_font";
			this.listBox_font.Size = new System.Drawing.Size(138, 48);
			this.listBox_font.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(589, 143);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 19);
			this.label2.TabIndex = 18;
			this.label2.Text = "font weight";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox_fontcolor
			// 
			this.listBox_fontcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.listBox_fontcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox_fontcolor.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.listBox_fontcolor.FormattingEnabled = true;
			this.listBox_fontcolor.ItemHeight = 23;
			this.listBox_fontcolor.Items.AddRange(new object[] {
			"white",
			"black"});
			this.listBox_fontcolor.Location = new System.Drawing.Point(589, 92);
			this.listBox_fontcolor.Name = "listBox_fontcolor";
			this.listBox_fontcolor.Size = new System.Drawing.Size(138, 48);
			this.listBox_fontcolor.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(589, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 18);
			this.label1.TabIndex = 16;
			this.label1.Text = "font color";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_skin_prev
			// 
			this.btn_skin_prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_skin_prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.btn_skin_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_skin_prev.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_skin_prev.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.btn_skin_prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_skin_prev.Image")));
			this.btn_skin_prev.Location = new System.Drawing.Point(589, 332);
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
			this.btn_skin_next.Location = new System.Drawing.Point(589, 274);
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
			this.skin_preview.Location = new System.Drawing.Point(35, 71);
			this.skin_preview.Name = "skin_preview";
			this.skin_preview.Size = new System.Drawing.Size(512, 313);
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
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage4.Controls.Add(this.panel5);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Location = new System.Drawing.Point(4, 32);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(774, 417);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Step 3: data";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label14);
			this.panel5.Controls.Add(this.card_userservices);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.card_userqualifi);
			this.panel5.Controls.Add(this.label12);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.card_contactinfo);
			this.panel5.Controls.Add(this.card_username);
			this.panel5.Location = new System.Drawing.Point(154, 87);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(474, 293);
			this.panel5.TabIndex = 15;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(15, 171);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(151, 59);
			this.label14.TabIndex = 22;
			this.label14.Text = "user services";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// card_userservices
			// 
			this.card_userservices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.card_userservices.Location = new System.Drawing.Point(172, 171);
			this.card_userservices.Multiline = true;
			this.card_userservices.Name = "card_userservices";
			this.card_userservices.Size = new System.Drawing.Size(261, 59);
			this.card_userservices.TabIndex = 21;
			this.card_userservices.Text = "֍ programming\r\n֍ consultation";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(15, 138);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(151, 27);
			this.label13.TabIndex = 20;
			this.label13.Text = "user qualifications";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// card_userqualifi
			// 
			this.card_userqualifi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.card_userqualifi.Location = new System.Drawing.Point(172, 138);
			this.card_userqualifi.Name = "card_userqualifi";
			this.card_userqualifi.Size = new System.Drawing.Size(261, 27);
			this.card_userqualifi.TabIndex = 19;
			this.card_userqualifi.Text = "anonymous, utopia user";
			this.card_userqualifi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(15, 54);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(151, 78);
			this.label12.TabIndex = 18;
			this.label12.Text = "contact info";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(15, 21);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(151, 27);
			this.label11.TabIndex = 17;
			this.label11.Text = "user name";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// card_contactinfo
			// 
			this.card_contactinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.card_contactinfo.Location = new System.Drawing.Point(172, 54);
			this.card_contactinfo.Multiline = true;
			this.card_contactinfo.Name = "card_contactinfo";
			this.card_contactinfo.Size = new System.Drawing.Size(261, 78);
			this.card_contactinfo.TabIndex = 16;
			this.card_contactinfo.Text = "t.me/username\r\n@username\r\nusername@example.com";
			// 
			// card_username
			// 
			this.card_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.card_username.Location = new System.Drawing.Point(172, 21);
			this.card_username.Name = "card_username";
			this.card_username.Size = new System.Drawing.Size(261, 27);
			this.card_username.TabIndex = 15;
			this.card_username.Text = "User Name";
			this.card_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label8.Location = new System.Drawing.Point(3, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(768, 65);
			this.label8.TabIndex = 4;
			this.label8.Text = "Step 3: enter data";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.pictureBox_preview);
			this.tabPage3.Controls.Add(this.button6);
			this.tabPage3.Controls.Add(this.btn_save_file);
			this.tabPage3.Controls.Add(this.btn_print_voucher);
			this.tabPage3.Controls.Add(this.label_step3);
			this.tabPage3.Location = new System.Drawing.Point(4, 32);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(774, 417);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Step 4: print";
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Location = new System.Drawing.Point(0, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(774, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Card preview";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox_preview
			// 
			this.pictureBox_preview.Location = new System.Drawing.Point(335, 132);
			this.pictureBox_preview.Name = "pictureBox_preview";
			this.pictureBox_preview.Size = new System.Drawing.Size(301, 183);
			this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_preview.TabIndex = 10;
			this.pictureBox_preview.TabStop = false;
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
			this.button6.Location = new System.Drawing.Point(129, 141);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(184, 52);
			this.button6.TabIndex = 9;
			this.button6.Text = "gen card";
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
			this.btn_save_file.Location = new System.Drawing.Point(129, 199);
			this.btn_save_file.Name = "btn_save_file";
			this.btn_save_file.Size = new System.Drawing.Size(184, 52);
			this.btn_save_file.TabIndex = 9;
			this.btn_save_file.Text = "save image";
			this.btn_save_file.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_save_file.UseVisualStyleBackColor = false;
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
			this.btn_print_voucher.Location = new System.Drawing.Point(129, 257);
			this.btn_print_voucher.Name = "btn_print_voucher";
			this.btn_print_voucher.Size = new System.Drawing.Size(184, 52);
			this.btn_print_voucher.TabIndex = 9;
			this.btn_print_voucher.Text = "print card";
			this.btn_print_voucher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_print_voucher.UseVisualStyleBackColor = false;
			this.btn_print_voucher.Click += new System.EventHandler(this.Btn_print_voucherClick);
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
			this.label_step3.Text = "Step 4: generate and print card   ";
			this.label_step3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.tabPage4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
