namespace rgb_strip_handler
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1_light = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deskLight_toggle = new MetroFramework.Controls.MetroToggle();
            this.deskLight_tbar = new MetroFramework.Controls.MetroTrackBar();
            this.blink_btn = new MetroFramework.Controls.MetroButton();
            this.fade_btn = new MetroFramework.Controls.MetroButton();
            this.knight_rider_btn = new MetroFramework.Controls.MetroButton();
            this.rainbow_cycle_btn = new MetroFramework.Controls.MetroButton();
            this.rainbow_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.color_blue_tbox = new MetroFramework.Controls.MetroTextBox();
            this.color_green_tbox = new MetroFramework.Controls.MetroTextBox();
            this.color_red_tbox = new MetroFramework.Controls.MetroTextBox();
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.metroTabPage1_tv_light = new MetroFramework.Controls.MetroTabPage();
            this.openToken_btn = new MetroFramework.Controls.MetroButton();
            this.color_blue_TV_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.color_green_TV_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.color_red_TV_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tv_brightness_tbar = new MetroFramework.Controls.MetroTrackBar();
            this.colorWheel2 = new Cyotek.Windows.Forms.ColorWheel();
            this.metroTabPage2_temp = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.avgTemp_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.celsius_lb = new MetroFramework.Controls.MetroLabel();
            this.temp_tbox = new MetroFramework.Controls.MetroTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroTabPage3_notice = new MetroFramework.Controls.MetroTabPage();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.password_tbox = new MetroFramework.Controls.MetroTextBox();
            this.email_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage4_settings = new MetroFramework.Controls.MetroTabPage();
            this.connect_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.port_names_cbox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightEffectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knightRiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serverURL_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.blynkPin_tbox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1_light.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage1_tv_light.SuspendLayout();
            this.metroTabPage2_temp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroTabPage3_notice.SuspendLayout();
            this.metroTabPage4_settings.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 10;
            this.serialPort1.WriteTimeout = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1_light);
            this.metroTabControl1.Controls.Add(this.metroTabPage1_tv_light);
            this.metroTabControl1.Controls.Add(this.metroTabPage2_temp);
            this.metroTabControl1.Controls.Add(this.metroTabPage3_notice);
            this.metroTabControl1.Controls.Add(this.metroTabPage4_settings);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(592, 487);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1_light
            // 
            this.metroTabPage1_light.Controls.Add(this.groupBox1);
            this.metroTabPage1_light.Controls.Add(this.blink_btn);
            this.metroTabPage1_light.Controls.Add(this.fade_btn);
            this.metroTabPage1_light.Controls.Add(this.knight_rider_btn);
            this.metroTabPage1_light.Controls.Add(this.rainbow_cycle_btn);
            this.metroTabPage1_light.Controls.Add(this.rainbow_btn);
            this.metroTabPage1_light.Controls.Add(this.metroLabel4);
            this.metroTabPage1_light.Controls.Add(this.metroTrackBar1);
            this.metroTabPage1_light.Controls.Add(this.metroLabel3);
            this.metroTabPage1_light.Controls.Add(this.metroLabel2);
            this.metroTabPage1_light.Controls.Add(this.metroLabel1);
            this.metroTabPage1_light.Controls.Add(this.color_blue_tbox);
            this.metroTabPage1_light.Controls.Add(this.color_green_tbox);
            this.metroTabPage1_light.Controls.Add(this.color_red_tbox);
            this.metroTabPage1_light.Controls.Add(this.colorWheel1);
            this.metroTabPage1_light.HorizontalScrollbarBarColor = true;
            this.metroTabPage1_light.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1_light.HorizontalScrollbarSize = 10;
            this.metroTabPage1_light.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1_light.Name = "metroTabPage1_light";
            this.metroTabPage1_light.Size = new System.Drawing.Size(584, 445);
            this.metroTabPage1_light.TabIndex = 0;
            this.metroTabPage1_light.Text = "Ambient Light";
            this.metroTabPage1_light.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1_light.VerticalScrollbarBarColor = true;
            this.metroTabPage1_light.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1_light.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deskLight_toggle);
            this.groupBox1.Controls.Add(this.deskLight_tbar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(379, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 51);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk light";
            // 
            // deskLight_toggle
            // 
            this.deskLight_toggle.AutoSize = true;
            this.deskLight_toggle.Location = new System.Drawing.Point(6, 23);
            this.deskLight_toggle.Name = "deskLight_toggle";
            this.deskLight_toggle.Size = new System.Drawing.Size(80, 17);
            this.deskLight_toggle.TabIndex = 0;
            this.deskLight_toggle.Text = "Off";
            this.deskLight_toggle.UseSelectable = true;
            this.deskLight_toggle.CheckedChanged += new System.EventHandler(this.deskLight_toggle_CheckedChanged);
            // 
            // deskLight_tbar
            // 
            this.deskLight_tbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deskLight_tbar.BackColor = System.Drawing.Color.Transparent;
            this.deskLight_tbar.Location = new System.Drawing.Point(6, 19);
            this.deskLight_tbar.Maximum = 255;
            this.deskLight_tbar.Name = "deskLight_tbar";
            this.deskLight_tbar.Size = new System.Drawing.Size(174, 23);
            this.deskLight_tbar.TabIndex = 10;
            this.deskLight_tbar.Text = "metroTrackBar1";
            this.deskLight_tbar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.deskLight_tbar.Value = 100;
            this.deskLight_tbar.Visible = false;
            this.deskLight_tbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.deskLight_tbar_MouseUp);
            // 
            // blink_btn
            // 
            this.blink_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blink_btn.Location = new System.Drawing.Point(379, 83);
            this.blink_btn.Name = "blink_btn";
            this.blink_btn.Size = new System.Drawing.Size(90, 23);
            this.blink_btn.TabIndex = 16;
            this.blink_btn.Text = "Blink";
            this.blink_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.blink_btn.UseSelectable = true;
            this.blink_btn.Click += new System.EventHandler(this.blink_btn_Click);
            // 
            // fade_btn
            // 
            this.fade_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fade_btn.Location = new System.Drawing.Point(475, 54);
            this.fade_btn.Name = "fade_btn";
            this.fade_btn.Size = new System.Drawing.Size(90, 23);
            this.fade_btn.TabIndex = 15;
            this.fade_btn.Text = "Fade";
            this.fade_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fade_btn.UseSelectable = true;
            this.fade_btn.Click += new System.EventHandler(this.fade_btn_Click);
            // 
            // knight_rider_btn
            // 
            this.knight_rider_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.knight_rider_btn.Location = new System.Drawing.Point(379, 54);
            this.knight_rider_btn.Name = "knight_rider_btn";
            this.knight_rider_btn.Size = new System.Drawing.Size(90, 23);
            this.knight_rider_btn.TabIndex = 14;
            this.knight_rider_btn.Text = "Knight Rider";
            this.knight_rider_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.knight_rider_btn.UseSelectable = true;
            this.knight_rider_btn.Click += new System.EventHandler(this.knight_rider_btn_Click);
            // 
            // rainbow_cycle_btn
            // 
            this.rainbow_cycle_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rainbow_cycle_btn.Location = new System.Drawing.Point(475, 25);
            this.rainbow_cycle_btn.Name = "rainbow_cycle_btn";
            this.rainbow_cycle_btn.Size = new System.Drawing.Size(90, 23);
            this.rainbow_cycle_btn.TabIndex = 13;
            this.rainbow_cycle_btn.Text = "Rainbow cycle";
            this.rainbow_cycle_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rainbow_cycle_btn.UseSelectable = true;
            this.rainbow_cycle_btn.Click += new System.EventHandler(this.rainbow_cycle_btn_Click);
            // 
            // rainbow_btn
            // 
            this.rainbow_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rainbow_btn.Location = new System.Drawing.Point(379, 25);
            this.rainbow_btn.Name = "rainbow_btn";
            this.rainbow_btn.Size = new System.Drawing.Size(90, 23);
            this.rainbow_btn.TabIndex = 12;
            this.rainbow_btn.Text = "Rainbow";
            this.rainbow_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rainbow_btn.UseSelectable = true;
            this.rainbow_btn.Click += new System.EventHandler(this.rainbow_btn_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(379, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Light effects";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(-4, 418);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(377, 23);
            this.metroTrackBar1.TabIndex = 10;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTrackBar1.Value = 100;
            this.metroTrackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.metroTrackBar1_MouseUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(233, 388);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(20, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "B:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(142, 388);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "G:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 388);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "R:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // color_blue_tbox
            // 
            this.color_blue_tbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.color_blue_tbox.CustomButton.Image = null;
            this.color_blue_tbox.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.color_blue_tbox.CustomButton.Name = "";
            this.color_blue_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.color_blue_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.color_blue_tbox.CustomButton.TabIndex = 1;
            this.color_blue_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color_blue_tbox.CustomButton.UseSelectable = true;
            this.color_blue_tbox.CustomButton.Visible = false;
            this.color_blue_tbox.Lines = new string[] {
        "127"};
            this.color_blue_tbox.Location = new System.Drawing.Point(257, 388);
            this.color_blue_tbox.MaxLength = 32767;
            this.color_blue_tbox.Name = "color_blue_tbox";
            this.color_blue_tbox.PasswordChar = '\0';
            this.color_blue_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color_blue_tbox.SelectedText = "";
            this.color_blue_tbox.SelectionLength = 0;
            this.color_blue_tbox.SelectionStart = 0;
            this.color_blue_tbox.ShortcutsEnabled = true;
            this.color_blue_tbox.Size = new System.Drawing.Size(58, 23);
            this.color_blue_tbox.TabIndex = 5;
            this.color_blue_tbox.Text = "127";
            this.color_blue_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.color_blue_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.color_blue_tbox.UseSelectable = true;
            this.color_blue_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.color_blue_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.color_blue_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.color_blue_tbox_KeyDown);
            // 
            // color_green_tbox
            // 
            this.color_green_tbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.color_green_tbox.CustomButton.Image = null;
            this.color_green_tbox.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.color_green_tbox.CustomButton.Name = "";
            this.color_green_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.color_green_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.color_green_tbox.CustomButton.TabIndex = 1;
            this.color_green_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color_green_tbox.CustomButton.UseSelectable = true;
            this.color_green_tbox.CustomButton.Visible = false;
            this.color_green_tbox.Lines = new string[] {
        "127"};
            this.color_green_tbox.Location = new System.Drawing.Point(167, 388);
            this.color_green_tbox.MaxLength = 32767;
            this.color_green_tbox.Name = "color_green_tbox";
            this.color_green_tbox.PasswordChar = '\0';
            this.color_green_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color_green_tbox.SelectedText = "";
            this.color_green_tbox.SelectionLength = 0;
            this.color_green_tbox.SelectionStart = 0;
            this.color_green_tbox.ShortcutsEnabled = true;
            this.color_green_tbox.Size = new System.Drawing.Size(58, 23);
            this.color_green_tbox.TabIndex = 4;
            this.color_green_tbox.Text = "127";
            this.color_green_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.color_green_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.color_green_tbox.UseSelectable = true;
            this.color_green_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.color_green_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.color_green_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.color_green_tbox_KeyDown);
            // 
            // color_red_tbox
            // 
            this.color_red_tbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.color_red_tbox.CustomButton.Image = null;
            this.color_red_tbox.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.color_red_tbox.CustomButton.Name = "";
            this.color_red_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.color_red_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.color_red_tbox.CustomButton.TabIndex = 1;
            this.color_red_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color_red_tbox.CustomButton.UseSelectable = true;
            this.color_red_tbox.CustomButton.Visible = false;
            this.color_red_tbox.Lines = new string[] {
        "127"};
            this.color_red_tbox.Location = new System.Drawing.Point(76, 388);
            this.color_red_tbox.MaxLength = 32767;
            this.color_red_tbox.Name = "color_red_tbox";
            this.color_red_tbox.PasswordChar = '\0';
            this.color_red_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color_red_tbox.SelectedText = "";
            this.color_red_tbox.SelectionLength = 0;
            this.color_red_tbox.SelectionStart = 0;
            this.color_red_tbox.ShortcutsEnabled = true;
            this.color_red_tbox.Size = new System.Drawing.Size(58, 23);
            this.color_red_tbox.TabIndex = 3;
            this.color_red_tbox.Text = "127";
            this.color_red_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.color_red_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.color_red_tbox.UseSelectable = true;
            this.color_red_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.color_red_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.color_red_tbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.color_red_tbox_KeyDown);
            // 
            // colorWheel1
            // 
            this.colorWheel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(0, 3);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(373, 373);
            this.colorWheel1.TabIndex = 2;
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            this.colorWheel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorWheel1_MouseUp);
            // 
            // metroTabPage1_tv_light
            // 
            this.metroTabPage1_tv_light.Controls.Add(this.metroLabel18);
            this.metroTabPage1_tv_light.Controls.Add(this.blynkPin_tbox);
            this.metroTabPage1_tv_light.Controls.Add(this.metroLabel17);
            this.metroTabPage1_tv_light.Controls.Add(this.serverURL_tbox);
            this.metroTabPage1_tv_light.Controls.Add(this.openToken_btn);
            this.metroTabPage1_tv_light.Controls.Add(this.color_blue_TV_tbox);
            this.metroTabPage1_tv_light.Controls.Add(this.metroLabel16);
            this.metroTabPage1_tv_light.Controls.Add(this.color_green_TV_tbox);
            this.metroTabPage1_tv_light.Controls.Add(this.metroLabel15);
            this.metroTabPage1_tv_light.Controls.Add(this.color_red_TV_tbox);
            this.metroTabPage1_tv_light.Controls.Add(this.metroLabel14);
            this.metroTabPage1_tv_light.Controls.Add(this.tv_brightness_tbar);
            this.metroTabPage1_tv_light.Controls.Add(this.colorWheel2);
            this.metroTabPage1_tv_light.HorizontalScrollbarBarColor = true;
            this.metroTabPage1_tv_light.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1_tv_light.HorizontalScrollbarSize = 10;
            this.metroTabPage1_tv_light.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1_tv_light.Name = "metroTabPage1_tv_light";
            this.metroTabPage1_tv_light.Size = new System.Drawing.Size(584, 445);
            this.metroTabPage1_tv_light.TabIndex = 4;
            this.metroTabPage1_tv_light.Text = "TV lights";
            this.metroTabPage1_tv_light.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1_tv_light.VerticalScrollbarBarColor = true;
            this.metroTabPage1_tv_light.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1_tv_light.VerticalScrollbarSize = 10;
            // 
            // openToken_btn
            // 
            this.openToken_btn.Location = new System.Drawing.Point(471, 9);
            this.openToken_btn.Name = "openToken_btn";
            this.openToken_btn.Size = new System.Drawing.Size(110, 23);
            this.openToken_btn.TabIndex = 10;
            this.openToken_btn.Text = "Open token...";
            this.openToken_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.openToken_btn.UseSelectable = true;
            this.openToken_btn.Click += new System.EventHandler(this.openToken_btn_Click);
            // 
            // color_blue_TV_tbox
            // 
            // 
            // 
            // 
            this.color_blue_TV_tbox.CustomButton.Image = null;
            this.color_blue_TV_tbox.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.color_blue_TV_tbox.CustomButton.Name = "";
            this.color_blue_TV_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.color_blue_TV_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.color_blue_TV_tbox.CustomButton.TabIndex = 1;
            this.color_blue_TV_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color_blue_TV_tbox.CustomButton.UseSelectable = true;
            this.color_blue_TV_tbox.CustomButton.Visible = false;
            this.color_blue_TV_tbox.Lines = new string[] {
        "metroTextBox3"};
            this.color_blue_TV_tbox.Location = new System.Drawing.Point(257, 388);
            this.color_blue_TV_tbox.MaxLength = 32767;
            this.color_blue_TV_tbox.Name = "color_blue_TV_tbox";
            this.color_blue_TV_tbox.PasswordChar = '\0';
            this.color_blue_TV_tbox.ReadOnly = true;
            this.color_blue_TV_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color_blue_TV_tbox.SelectedText = "";
            this.color_blue_TV_tbox.SelectionLength = 0;
            this.color_blue_TV_tbox.SelectionStart = 0;
            this.color_blue_TV_tbox.ShortcutsEnabled = true;
            this.color_blue_TV_tbox.Size = new System.Drawing.Size(58, 23);
            this.color_blue_TV_tbox.TabIndex = 9;
            this.color_blue_TV_tbox.Text = "metroTextBox3";
            this.color_blue_TV_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.color_blue_TV_tbox.UseSelectable = true;
            this.color_blue_TV_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.color_blue_TV_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(233, 388);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(20, 19);
            this.metroLabel16.TabIndex = 8;
            this.metroLabel16.Text = "B:";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // color_green_TV_tbox
            // 
            // 
            // 
            // 
            this.color_green_TV_tbox.CustomButton.Image = null;
            this.color_green_TV_tbox.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.color_green_TV_tbox.CustomButton.Name = "";
            this.color_green_TV_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.color_green_TV_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.color_green_TV_tbox.CustomButton.TabIndex = 1;
            this.color_green_TV_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color_green_TV_tbox.CustomButton.UseSelectable = true;
            this.color_green_TV_tbox.CustomButton.Visible = false;
            this.color_green_TV_tbox.Lines = new string[] {
        "metroTextBox2"};
            this.color_green_TV_tbox.Location = new System.Drawing.Point(167, 388);
            this.color_green_TV_tbox.MaxLength = 32767;
            this.color_green_TV_tbox.Name = "color_green_TV_tbox";
            this.color_green_TV_tbox.PasswordChar = '\0';
            this.color_green_TV_tbox.ReadOnly = true;
            this.color_green_TV_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color_green_TV_tbox.SelectedText = "";
            this.color_green_TV_tbox.SelectionLength = 0;
            this.color_green_TV_tbox.SelectionStart = 0;
            this.color_green_TV_tbox.ShortcutsEnabled = true;
            this.color_green_TV_tbox.Size = new System.Drawing.Size(58, 23);
            this.color_green_TV_tbox.TabIndex = 7;
            this.color_green_TV_tbox.Text = "metroTextBox2";
            this.color_green_TV_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.color_green_TV_tbox.UseSelectable = true;
            this.color_green_TV_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.color_green_TV_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(142, 388);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(21, 19);
            this.metroLabel15.TabIndex = 6;
            this.metroLabel15.Text = "G:";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // color_red_TV_tbox
            // 
            // 
            // 
            // 
            this.color_red_TV_tbox.CustomButton.Image = null;
            this.color_red_TV_tbox.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.color_red_TV_tbox.CustomButton.Name = "";
            this.color_red_TV_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.color_red_TV_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.color_red_TV_tbox.CustomButton.TabIndex = 1;
            this.color_red_TV_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.color_red_TV_tbox.CustomButton.UseSelectable = true;
            this.color_red_TV_tbox.CustomButton.Visible = false;
            this.color_red_TV_tbox.Lines = new string[] {
        "metroTextBox1"};
            this.color_red_TV_tbox.Location = new System.Drawing.Point(76, 388);
            this.color_red_TV_tbox.MaxLength = 32767;
            this.color_red_TV_tbox.Name = "color_red_TV_tbox";
            this.color_red_TV_tbox.PasswordChar = '\0';
            this.color_red_TV_tbox.ReadOnly = true;
            this.color_red_TV_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.color_red_TV_tbox.SelectedText = "";
            this.color_red_TV_tbox.SelectionLength = 0;
            this.color_red_TV_tbox.SelectionStart = 0;
            this.color_red_TV_tbox.ShortcutsEnabled = true;
            this.color_red_TV_tbox.Size = new System.Drawing.Size(58, 23);
            this.color_red_TV_tbox.TabIndex = 5;
            this.color_red_TV_tbox.Text = "metroTextBox1";
            this.color_red_TV_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.color_red_TV_tbox.UseSelectable = true;
            this.color_red_TV_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.color_red_TV_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(52, 388);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(20, 19);
            this.metroLabel14.TabIndex = 4;
            this.metroLabel14.Text = "R:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tv_brightness_tbar
            // 
            this.tv_brightness_tbar.BackColor = System.Drawing.Color.Transparent;
            this.tv_brightness_tbar.Location = new System.Drawing.Point(-1, 418);
            this.tv_brightness_tbar.Name = "tv_brightness_tbar";
            this.tv_brightness_tbar.Size = new System.Drawing.Size(377, 23);
            this.tv_brightness_tbar.TabIndex = 3;
            this.tv_brightness_tbar.Text = "metroTrackBar2";
            this.tv_brightness_tbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tv_brightness_tbar_MouseUp);
            // 
            // colorWheel2
            // 
            this.colorWheel2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel2.Location = new System.Drawing.Point(0, 3);
            this.colorWheel2.Name = "colorWheel2";
            this.colorWheel2.Size = new System.Drawing.Size(373, 373);
            this.colorWheel2.TabIndex = 2;
            this.colorWheel2.ColorChanged += new System.EventHandler(this.colorWheel2_ColorChanged);
            this.colorWheel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorWheel2_MouseUp);
            // 
            // metroTabPage2_temp
            // 
            this.metroTabPage2_temp.Controls.Add(this.metroLabel13);
            this.metroTabPage2_temp.Controls.Add(this.avgTemp_tbox);
            this.metroTabPage2_temp.Controls.Add(this.metroLabel12);
            this.metroTabPage2_temp.Controls.Add(this.metroLabel11);
            this.metroTabPage2_temp.Controls.Add(this.celsius_lb);
            this.metroTabPage2_temp.Controls.Add(this.temp_tbox);
            this.metroTabPage2_temp.Controls.Add(this.chart1);
            this.metroTabPage2_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metroTabPage2_temp.HorizontalScrollbarBarColor = true;
            this.metroTabPage2_temp.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2_temp.HorizontalScrollbarSize = 10;
            this.metroTabPage2_temp.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2_temp.Name = "metroTabPage2_temp";
            this.metroTabPage2_temp.Size = new System.Drawing.Size(584, 445);
            this.metroTabPage2_temp.TabIndex = 1;
            this.metroTabPage2_temp.Text = "Temperature";
            this.metroTabPage2_temp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2_temp.VerticalScrollbarBarColor = true;
            this.metroTabPage2_temp.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2_temp.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(514, 111);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(23, 19);
            this.metroLabel13.TabIndex = 15;
            this.metroLabel13.Text = "°C";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // avgTemp_tbox
            // 
            this.avgTemp_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.avgTemp_tbox.CustomButton.Image = null;
            this.avgTemp_tbox.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.avgTemp_tbox.CustomButton.Name = "";
            this.avgTemp_tbox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.avgTemp_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.avgTemp_tbox.CustomButton.TabIndex = 1;
            this.avgTemp_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.avgTemp_tbox.CustomButton.UseSelectable = true;
            this.avgTemp_tbox.CustomButton.Visible = false;
            this.avgTemp_tbox.Lines = new string[] {
        "0"};
            this.avgTemp_tbox.Location = new System.Drawing.Point(477, 111);
            this.avgTemp_tbox.MaxLength = 32767;
            this.avgTemp_tbox.Name = "avgTemp_tbox";
            this.avgTemp_tbox.PasswordChar = '\0';
            this.avgTemp_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.avgTemp_tbox.SelectedText = "";
            this.avgTemp_tbox.SelectionLength = 0;
            this.avgTemp_tbox.SelectionStart = 0;
            this.avgTemp_tbox.ShortcutsEnabled = true;
            this.avgTemp_tbox.Size = new System.Drawing.Size(35, 20);
            this.avgTemp_tbox.TabIndex = 14;
            this.avgTemp_tbox.Text = "0";
            this.avgTemp_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.avgTemp_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.avgTemp_tbox.UseSelectable = true;
            this.avgTemp_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.avgTemp_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(477, 89);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 19);
            this.metroLabel12.TabIndex = 13;
            this.metroLabel12.Text = "Average:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(474, 44);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(111, 19);
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "Last temperature:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // celsius_lb
            // 
            this.celsius_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.celsius_lb.AutoSize = true;
            this.celsius_lb.Location = new System.Drawing.Point(514, 67);
            this.celsius_lb.Name = "celsius_lb";
            this.celsius_lb.Size = new System.Drawing.Size(23, 19);
            this.celsius_lb.TabIndex = 5;
            this.celsius_lb.Text = "°C";
            this.celsius_lb.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // temp_tbox
            // 
            this.temp_tbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.temp_tbox.CustomButton.Image = null;
            this.temp_tbox.CustomButton.Location = new System.Drawing.Point(17, 2);
            this.temp_tbox.CustomButton.Name = "";
            this.temp_tbox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.temp_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.temp_tbox.CustomButton.TabIndex = 1;
            this.temp_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.temp_tbox.CustomButton.UseSelectable = true;
            this.temp_tbox.CustomButton.Visible = false;
            this.temp_tbox.Lines = new string[] {
        "0"};
            this.temp_tbox.Location = new System.Drawing.Point(477, 66);
            this.temp_tbox.MaxLength = 32767;
            this.temp_tbox.Name = "temp_tbox";
            this.temp_tbox.PasswordChar = '\0';
            this.temp_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.temp_tbox.SelectedText = "";
            this.temp_tbox.SelectionLength = 0;
            this.temp_tbox.SelectionStart = 0;
            this.temp_tbox.ShortcutsEnabled = true;
            this.temp_tbox.Size = new System.Drawing.Size(35, 20);
            this.temp_tbox.TabIndex = 4;
            this.temp_tbox.Text = "0";
            this.temp_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.temp_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.temp_tbox.UseSelectable = true;
            this.temp_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.temp_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DeepSkyBlue;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Szoba";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(584, 445);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // metroTabPage3_notice
            // 
            this.metroTabPage3_notice.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage3_notice.Controls.Add(this.metroToggle1);
            this.metroTabPage3_notice.Controls.Add(this.metroLabel8);
            this.metroTabPage3_notice.Controls.Add(this.metroLabel7);
            this.metroTabPage3_notice.Controls.Add(this.metroComboBox1);
            this.metroTabPage3_notice.Controls.Add(this.password_tbox);
            this.metroTabPage3_notice.Controls.Add(this.email_tbox);
            this.metroTabPage3_notice.Controls.Add(this.metroLabel6);
            this.metroTabPage3_notice.Controls.Add(this.metroLabel5);
            this.metroTabPage3_notice.HorizontalScrollbarBarColor = true;
            this.metroTabPage3_notice.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3_notice.HorizontalScrollbarSize = 10;
            this.metroTabPage3_notice.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3_notice.Name = "metroTabPage3_notice";
            this.metroTabPage3_notice.Size = new System.Drawing.Size(584, 445);
            this.metroTabPage3_notice.TabIndex = 2;
            this.metroTabPage3_notice.Text = "Notifications";
            this.metroTabPage3_notice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3_notice.VerticalScrollbarBarColor = true;
            this.metroTabPage3_notice.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3_notice.VerticalScrollbarSize = 10;
            // 
            // metroToggle1
            // 
            this.metroToggle1.Location = new System.Drawing.Point(195, 170);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(92, 20);
            this.metroToggle1.TabIndex = 1;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(87, 19);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(289, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Light notification, when you receive a new email.";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(71, 127);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Color/Effect:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Color - Red",
            "Color - Green",
            "Color - Blue",
            "Effect - Fade",
            "Effect - Blink"});
            this.metroComboBox1.Location = new System.Drawing.Point(159, 123);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(179, 29);
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.UseSelectable = true;
            // 
            // password_tbox
            // 
            // 
            // 
            // 
            this.password_tbox.CustomButton.Image = null;
            this.password_tbox.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.password_tbox.CustomButton.Name = "";
            this.password_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password_tbox.CustomButton.TabIndex = 1;
            this.password_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password_tbox.CustomButton.UseSelectable = true;
            this.password_tbox.CustomButton.Visible = false;
            this.password_tbox.Lines = new string[0];
            this.password_tbox.Location = new System.Drawing.Point(159, 88);
            this.password_tbox.MaxLength = 32767;
            this.password_tbox.Name = "password_tbox";
            this.password_tbox.PasswordChar = '*';
            this.password_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_tbox.SelectedText = "";
            this.password_tbox.SelectionLength = 0;
            this.password_tbox.SelectionStart = 0;
            this.password_tbox.ShortcutsEnabled = true;
            this.password_tbox.Size = new System.Drawing.Size(179, 23);
            this.password_tbox.TabIndex = 5;
            this.password_tbox.UseSelectable = true;
            this.password_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // email_tbox
            // 
            // 
            // 
            // 
            this.email_tbox.CustomButton.Image = null;
            this.email_tbox.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.email_tbox.CustomButton.Name = "";
            this.email_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.email_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.email_tbox.CustomButton.TabIndex = 1;
            this.email_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.email_tbox.CustomButton.UseSelectable = true;
            this.email_tbox.CustomButton.Visible = false;
            this.email_tbox.Lines = new string[0];
            this.email_tbox.Location = new System.Drawing.Point(159, 54);
            this.email_tbox.MaxLength = 32767;
            this.email_tbox.Name = "email_tbox";
            this.email_tbox.PasswordChar = '\0';
            this.email_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.email_tbox.SelectedText = "";
            this.email_tbox.SelectionLength = 0;
            this.email_tbox.SelectionStart = 0;
            this.email_tbox.ShortcutsEnabled = true;
            this.email_tbox.Size = new System.Drawing.Size(179, 23);
            this.email_tbox.TabIndex = 4;
            this.email_tbox.UseSelectable = true;
            this.email_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.email_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(86, 88);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Password:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(109, 54);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Email:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage4_settings
            // 
            this.metroTabPage4_settings.BackColor = System.Drawing.Color.Transparent;
            this.metroTabPage4_settings.Controls.Add(this.connect_btn);
            this.metroTabPage4_settings.Controls.Add(this.metroLabel10);
            this.metroTabPage4_settings.Controls.Add(this.port_names_cbox);
            this.metroTabPage4_settings.Controls.Add(this.metroLabel9);
            this.metroTabPage4_settings.HorizontalScrollbarBarColor = true;
            this.metroTabPage4_settings.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4_settings.HorizontalScrollbarSize = 10;
            this.metroTabPage4_settings.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4_settings.Name = "metroTabPage4_settings";
            this.metroTabPage4_settings.Size = new System.Drawing.Size(584, 445);
            this.metroTabPage4_settings.TabIndex = 3;
            this.metroTabPage4_settings.Text = "Settings";
            this.metroTabPage4_settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage4_settings.VerticalScrollbarBarColor = true;
            this.metroTabPage4_settings.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4_settings.VerticalScrollbarSize = 10;
            // 
            // connect_btn
            // 
            this.connect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connect_btn.Location = new System.Drawing.Point(222, 42);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(90, 23);
            this.connect_btn.TabIndex = 17;
            this.connect_btn.Text = "Connect";
            this.connect_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.connect_btn.UseSelectable = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 42);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Port Name:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // port_names_cbox
            // 
            this.port_names_cbox.FormattingEnabled = true;
            this.port_names_cbox.ItemHeight = 23;
            this.port_names_cbox.Location = new System.Drawing.Point(95, 42);
            this.port_names_cbox.Name = "port_names_cbox";
            this.port_names_cbox.Size = new System.Drawing.Size(121, 29);
            this.port_names_cbox.TabIndex = 9;
            this.port_names_cbox.UseSelectable = true;
            this.port_names_cbox.SelectedIndexChanged += new System.EventHandler(this.port_names_cbox_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(171, 100);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(49, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "Sorry...";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Room temperature";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem,
            this.lightEffectsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.cyanToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // lightEffectsToolStripMenuItem
            // 
            this.lightEffectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rainbowToolStripMenuItem,
            this.rainbowCycleToolStripMenuItem,
            this.knightRiderToolStripMenuItem});
            this.lightEffectsToolStripMenuItem.Name = "lightEffectsToolStripMenuItem";
            this.lightEffectsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.lightEffectsToolStripMenuItem.Text = "Light effects";
            // 
            // rainbowToolStripMenuItem
            // 
            this.rainbowToolStripMenuItem.Name = "rainbowToolStripMenuItem";
            this.rainbowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rainbowToolStripMenuItem.Text = "Rainbow";
            this.rainbowToolStripMenuItem.Click += new System.EventHandler(this.rainbowToolStripMenuItem_Click);
            // 
            // rainbowCycleToolStripMenuItem
            // 
            this.rainbowCycleToolStripMenuItem.Name = "rainbowCycleToolStripMenuItem";
            this.rainbowCycleToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rainbowCycleToolStripMenuItem.Text = "Rainbow cycle";
            this.rainbowCycleToolStripMenuItem.Click += new System.EventHandler(this.rainbowCycleToolStripMenuItem_Click);
            // 
            // knightRiderToolStripMenuItem
            // 
            this.knightRiderToolStripMenuItem.Name = "knightRiderToolStripMenuItem";
            this.knightRiderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.knightRiderToolStripMenuItem.Text = "Knight Rider";
            this.knightRiderToolStripMenuItem.Click += new System.EventHandler(this.knightRiderToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // emailTimer
            // 
            this.emailTimer.Interval = 300000;
            this.emailTimer.Tick += new System.EventHandler(this.emailTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serverURL_tbox
            // 
            // 
            // 
            // 
            this.serverURL_tbox.CustomButton.Image = null;
            this.serverURL_tbox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.serverURL_tbox.CustomButton.Name = "";
            this.serverURL_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serverURL_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serverURL_tbox.CustomButton.TabIndex = 1;
            this.serverURL_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serverURL_tbox.CustomButton.UseSelectable = true;
            this.serverURL_tbox.CustomButton.Visible = false;
            this.serverURL_tbox.Lines = new string[] {
        "http://blynk-cloud.com/"};
            this.serverURL_tbox.Location = new System.Drawing.Point(436, 38);
            this.serverURL_tbox.MaxLength = 32767;
            this.serverURL_tbox.Name = "serverURL_tbox";
            this.serverURL_tbox.PasswordChar = '\0';
            this.serverURL_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serverURL_tbox.SelectedText = "";
            this.serverURL_tbox.SelectionLength = 0;
            this.serverURL_tbox.SelectionStart = 0;
            this.serverURL_tbox.ShortcutsEnabled = true;
            this.serverURL_tbox.Size = new System.Drawing.Size(145, 23);
            this.serverURL_tbox.TabIndex = 11;
            this.serverURL_tbox.Text = "http://blynk-cloud.com/";
            this.serverURL_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serverURL_tbox.UseSelectable = true;
            this.serverURL_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serverURL_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(379, 38);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(51, 19);
            this.metroLabel17.TabIndex = 12;
            this.metroLabel17.Text = "Server:";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel18
            // 
            this.metroLabel18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(397, 67);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(33, 19);
            this.metroLabel18.TabIndex = 14;
            this.metroLabel18.Text = "PIN:";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // blynkPin_tbox
            // 
            // 
            // 
            // 
            this.blynkPin_tbox.CustomButton.Image = null;
            this.blynkPin_tbox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.blynkPin_tbox.CustomButton.Name = "";
            this.blynkPin_tbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.blynkPin_tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.blynkPin_tbox.CustomButton.TabIndex = 1;
            this.blynkPin_tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.blynkPin_tbox.CustomButton.UseSelectable = true;
            this.blynkPin_tbox.CustomButton.Visible = false;
            this.blynkPin_tbox.Lines = new string[] {
        "V1"};
            this.blynkPin_tbox.Location = new System.Drawing.Point(436, 67);
            this.blynkPin_tbox.MaxLength = 32767;
            this.blynkPin_tbox.Name = "blynkPin_tbox";
            this.blynkPin_tbox.PasswordChar = '\0';
            this.blynkPin_tbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.blynkPin_tbox.SelectedText = "";
            this.blynkPin_tbox.SelectionLength = 0;
            this.blynkPin_tbox.SelectionStart = 0;
            this.blynkPin_tbox.ShortcutsEnabled = true;
            this.blynkPin_tbox.Size = new System.Drawing.Size(145, 23);
            this.blynkPin_tbox.TabIndex = 13;
            this.blynkPin_tbox.Text = "V1";
            this.blynkPin_tbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.blynkPin_tbox.UseSelectable = true;
            this.blynkPin_tbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.blynkPin_tbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(632, 567);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(520, 355);
            this.Name = "Home";
            this.Opacity = 0.9D;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Home";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1_light.ResumeLayout(false);
            this.metroTabPage1_light.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage1_tv_light.ResumeLayout(false);
            this.metroTabPage1_tv_light.PerformLayout();
            this.metroTabPage2_temp.ResumeLayout(false);
            this.metroTabPage2_temp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroTabPage3_notice.ResumeLayout(false);
            this.metroTabPage3_notice.PerformLayout();
            this.metroTabPage4_settings.ResumeLayout(false);
            this.metroTabPage4_settings.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1_light;
        private MetroFramework.Controls.MetroTabPage metroTabPage2_temp;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
        private MetroFramework.Controls.MetroTextBox color_red_tbox;
        private MetroFramework.Controls.MetroTextBox color_blue_tbox;
        private MetroFramework.Controls.MetroTextBox color_green_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroButton rainbow_cycle_btn;
        private MetroFramework.Controls.MetroButton rainbow_btn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel celsius_lb;
        private MetroFramework.Controls.MetroTextBox temp_tbox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightEffectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowCycleToolStripMenuItem;
        private MetroFramework.Controls.MetroButton knight_rider_btn;
        private System.Windows.Forms.ToolStripMenuItem knightRiderToolStripMenuItem;
        private MetroFramework.Controls.MetroButton fade_btn;
        private MetroFramework.Controls.MetroButton blink_btn;
        private MetroFramework.Controls.MetroTabPage metroTabPage3_notice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox password_tbox;
        private MetroFramework.Controls.MetroTextBox email_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Timer emailTimer;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4_settings;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton connect_btn;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox port_names_cbox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox avgTemp_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroToggle deskLight_toggle;
        private MetroFramework.Controls.MetroTrackBar deskLight_tbar;
        private MetroFramework.Controls.MetroTabPage metroTabPage1_tv_light;
        private MetroFramework.Controls.MetroTrackBar tv_brightness_tbar;
        private Cyotek.Windows.Forms.ColorWheel colorWheel2;
        private MetroFramework.Controls.MetroTextBox color_red_TV_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox color_blue_TV_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox color_green_TV_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton openToken_btn;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox serverURL_tbox;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox blynkPin_tbox;
    }
}

