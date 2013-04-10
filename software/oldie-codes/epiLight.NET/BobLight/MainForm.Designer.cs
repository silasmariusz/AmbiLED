namespace epiLight
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorRight = new System.Windows.Forms.PictureBox();
            this.ColorTop = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtPortname = new System.Windows.Forms.TextBox();
            this.ComPort = new System.Windows.Forms.Label();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModeCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnableBtn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RedTop = new System.Windows.Forms.NumericUpDown();
            this.GreenTop = new System.Windows.Forms.NumericUpDown();
            this.BlueTop = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BlueRight = new System.Windows.Forms.NumericUpDown();
            this.GreenRight = new System.Windows.Forms.NumericUpDown();
            this.RedRight = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.TopBegin = new System.Windows.Forms.NumericUpDown();
            this.TopEnd = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.AutoEnable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.CaptureCycles = new System.Windows.Forms.NumericUpDown();
            this.CaptureEvery = new System.Windows.Forms.CheckBox();
            this.label59 = new System.Windows.Forms.Label();
            this.OffsetLevel = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.DivideLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.ColorIncSmooth = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.AggressiveLevel = new System.Windows.Forms.NumericUpDown();
            this.SmoothDarkness = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.fsr = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.ModeCombo2 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.DisplaysBox = new System.Windows.Forms.ComboBox();
            this.Colorslider = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.TimerDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.RightEnd = new System.Windows.Forms.NumericUpDown();
            this.RightBegin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.BlueTopOnExit = new System.Windows.Forms.NumericUpDown();
            this.GreenTopOnExit = new System.Windows.Forms.NumericUpDown();
            this.RedTopOnExit = new System.Windows.Forms.NumericUpDown();
            this.ColorTopOnExit = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.BlueLeftOnExit = new System.Windows.Forms.NumericUpDown();
            this.GreenLeftOnExit = new System.Windows.Forms.NumericUpDown();
            this.RedLeftOnExit = new System.Windows.Forms.NumericUpDown();
            this.ColorLeftOnExit = new System.Windows.Forms.PictureBox();
            this.ColorRightOnExit = new System.Windows.Forms.PictureBox();
            this.RedRightOnExit = new System.Windows.Forms.NumericUpDown();
            this.GreenRightOnExit = new System.Windows.Forms.NumericUpDown();
            this.BlueRightOnExit = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ColorLeft = new System.Windows.Forms.PictureBox();
            this.RedLeft = new System.Windows.Forms.NumericUpDown();
            this.GreenLeft = new System.Windows.Forms.NumericUpDown();
            this.BlueLeft = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LeftBegin = new System.Windows.Forms.NumericUpDown();
            this.LeftEnd = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.AutoDetect = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTop)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopEnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivideLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorIncSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AggressiveLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colorslider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDelay)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBegin)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTopOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTopOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTopOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTopOnExit)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeftOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeftOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeftOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLeftOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRightOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedRightOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRightOnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRightOnExit)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEnd)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Interval = 20;
            this.CaptureTimer.Tick += new System.EventHandler(this.CaptureTimer_Tick);
            // 
            // ColorRight
            // 
            this.ColorRight.Location = new System.Drawing.Point(101, 17);
            this.ColorRight.Name = "ColorRight";
            this.ColorRight.Size = new System.Drawing.Size(51, 72);
            this.ColorRight.TabIndex = 3;
            this.ColorRight.TabStop = false;
            // 
            // ColorTop
            // 
            this.ColorTop.Location = new System.Drawing.Point(101, 19);
            this.ColorTop.Name = "ColorTop";
            this.ColorTop.Size = new System.Drawing.Size(51, 72);
            this.ColorTop.TabIndex = 4;
            this.ColorTop.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "com4";
            // 
            // txtPortname
            // 
            this.txtPortname.Location = new System.Drawing.Point(75, 16);
            this.txtPortname.Name = "txtPortname";
            this.txtPortname.Size = new System.Drawing.Size(60, 20);
            this.txtPortname.TabIndex = 46;
            this.txtPortname.Text = "COM4";
            // 
            // ComPort
            // 
            this.ComPort.AutoSize = true;
            this.ComPort.Location = new System.Drawing.Point(11, 19);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(58, 13);
            this.ComPort.TabIndex = 47;
            this.ComPort.Text = "Port name:";
            // 
            // comboBaud
            // 
            this.comboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaud.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBaud.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.comboBaud.Location = new System.Drawing.Point(75, 44);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(60, 21);
            this.comboBaud.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Baudrate:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "epiLight";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeCombo,
            this.toolStripSeparator1,
            this.disableToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(281, 81);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ModeCombo
            // 
            this.ModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeCombo.Items.AddRange(new object[] {
            "Gaming",
            "Movie",
            "10*Movie smooth",
            "30*Movie smooth",
            "10*Movie smooth+Fast scene"});
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(220, 23);
            this.ModeCombo.SelectedIndexChanged += new System.EventHandler(this.ModeCombo_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.disableToolStripMenuItem.Text = "Enable/Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EnableBtn
            // 
            this.EnableBtn.Location = new System.Drawing.Point(141, 15);
            this.EnableBtn.Name = "EnableBtn";
            this.EnableBtn.Size = new System.Drawing.Size(83, 21);
            this.EnableBtn.TabIndex = 52;
            this.EnableBtn.Text = "Disable";
            this.EnableBtn.UseVisualStyleBackColor = true;
            this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(227, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 54;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // RedTop
            // 
            this.RedTop.Location = new System.Drawing.Point(50, 19);
            this.RedTop.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedTop.Name = "RedTop";
            this.RedTop.Size = new System.Drawing.Size(45, 20);
            this.RedTop.TabIndex = 56;
            this.RedTop.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // GreenTop
            // 
            this.GreenTop.Location = new System.Drawing.Point(50, 45);
            this.GreenTop.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenTop.Name = "GreenTop";
            this.GreenTop.Size = new System.Drawing.Size(45, 20);
            this.GreenTop.TabIndex = 57;
            this.GreenTop.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // BlueTop
            // 
            this.BlueTop.Location = new System.Drawing.Point(50, 71);
            this.BlueTop.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueTop.Name = "BlueTop";
            this.BlueTop.Size = new System.Drawing.Size(45, 20);
            this.BlueTop.TabIndex = 58;
            this.BlueTop.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Red:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Green:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Blue:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Blue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Green:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Red:";
            // 
            // BlueRight
            // 
            this.BlueRight.Location = new System.Drawing.Point(48, 71);
            this.BlueRight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueRight.Name = "BlueRight";
            this.BlueRight.Size = new System.Drawing.Size(45, 20);
            this.BlueRight.TabIndex = 64;
            this.BlueRight.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // GreenRight
            // 
            this.GreenRight.Location = new System.Drawing.Point(48, 45);
            this.GreenRight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenRight.Name = "GreenRight";
            this.GreenRight.Size = new System.Drawing.Size(45, 20);
            this.GreenRight.TabIndex = 63;
            this.GreenRight.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // RedRight
            // 
            this.RedRight.Location = new System.Drawing.Point(48, 19);
            this.RedRight.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedRight.Name = "RedRight";
            this.RedRight.Size = new System.Drawing.Size(45, 20);
            this.RedRight.TabIndex = 62;
            this.RedRight.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 74;
            this.radioButton1.Text = "No expand";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 17);
            this.radioButton2.TabIndex = 75;
            this.radioButton2.Text = "Expand individually";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 17);
            this.radioButton3.TabIndex = 76;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Expand together";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // TopBegin
            // 
            this.TopBegin.Location = new System.Drawing.Point(315, 39);
            this.TopBegin.Name = "TopBegin";
            this.TopBegin.Size = new System.Drawing.Size(45, 20);
            this.TopBegin.TabIndex = 77;
            // 
            // TopEnd
            // 
            this.TopEnd.Location = new System.Drawing.Point(390, 39);
            this.TopEnd.Name = "TopEnd";
            this.TopEnd.Size = new System.Drawing.Size(47, 20);
            this.TopEnd.TabIndex = 78;
            this.TopEnd.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(282, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Vertical scan range percentage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProcessName);
            this.groupBox1.Controls.Add(this.label76);
            this.groupBox1.Controls.Add(this.AutoEnable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBaud);
            this.groupBox1.Controls.Add(this.ComPort);
            this.groupBox1.Controls.Add(this.txtPortname);
            this.groupBox1.Controls.Add(this.EnableBtn);
            this.groupBox1.Location = new System.Drawing.Point(649, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 75);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port settings";
            // 
            // ProcessName
            // 
            this.ProcessName.Location = new System.Drawing.Point(241, 44);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(72, 20);
            this.ProcessName.TabIndex = 55;
            this.ProcessName.Text = "mplayerc";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(144, 47);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(91, 13);
            this.label76.TabIndex = 54;
            this.label76.Text = "Process is runned";
            this.label76.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AutoEnable
            // 
            this.AutoEnable.AutoSize = true;
            this.AutoEnable.Checked = true;
            this.AutoEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoEnable.Location = new System.Drawing.Point(230, 18);
            this.AutoEnable.Name = "AutoEnable";
            this.AutoEnable.Size = new System.Drawing.Size(83, 17);
            this.AutoEnable.TabIndex = 53;
            this.AutoEnable.Text = "Auto enable";
            this.AutoEnable.UseVisualStyleBackColor = true;
            this.AutoEnable.CheckedChanged += new System.EventHandler(this.AutoEnable_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.CaptureCycles);
            this.groupBox2.Controls.Add(this.CaptureEvery);
            this.groupBox2.Controls.Add(this.label59);
            this.groupBox2.Controls.Add(this.OffsetLevel);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.DivideLevel);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.ColorIncSmooth);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.AggressiveLevel);
            this.groupBox2.Controls.Add(this.SmoothDarkness);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.fsr);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.ModeCombo2);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.DisplaysBox);
            this.groupBox2.Controls.Add(this.Colorslider);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.TimerDelay);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(649, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 317);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voodoo settings";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(212, 238);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 108;
            this.label32.Text = "cycles";
            // 
            // CaptureCycles
            // 
            this.CaptureCycles.Location = new System.Drawing.Point(156, 230);
            this.CaptureCycles.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.CaptureCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CaptureCycles.Name = "CaptureCycles";
            this.CaptureCycles.Size = new System.Drawing.Size(45, 20);
            this.CaptureCycles.TabIndex = 107;
            this.CaptureCycles.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // CaptureEvery
            // 
            this.CaptureEvery.AutoSize = true;
            this.CaptureEvery.Location = new System.Drawing.Point(14, 231);
            this.CaptureEvery.Name = "CaptureEvery";
            this.CaptureEvery.Size = new System.Drawing.Size(127, 17);
            this.CaptureEvery.TabIndex = 106;
            this.CaptureEvery.Text = "Capture screen every";
            this.CaptureEvery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CaptureEvery.UseVisualStyleBackColor = true;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(171, 207);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(81, 13);
            this.label59.TabIndex = 103;
            this.label59.Text = "Offset multiplier:";
            // 
            // OffsetLevel
            // 
            this.OffsetLevel.Location = new System.Drawing.Point(258, 205);
            this.OffsetLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.OffsetLevel.Name = "OffsetLevel";
            this.OffsetLevel.Size = new System.Drawing.Size(45, 20);
            this.OffsetLevel.TabIndex = 102;
            this.OffsetLevel.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(11, 207);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(75, 13);
            this.label58.TabIndex = 101;
            this.label58.Text = "Screen divide:";
            // 
            // DivideLevel
            // 
            this.DivideLevel.Location = new System.Drawing.Point(92, 205);
            this.DivideLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DivideLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DivideLevel.Name = "DivideLevel";
            this.DivideLevel.Size = new System.Drawing.Size(45, 20);
            this.DivideLevel.TabIndex = 100;
            this.DivideLevel.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(274, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 99;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(151, 83);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(56, 13);
            this.label46.TabIndex = 98;
            this.label46.Text = "Inc. delay:";
            this.label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ColorIncSmooth
            // 
            this.ColorIncSmooth.Location = new System.Drawing.Point(227, 79);
            this.ColorIncSmooth.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorIncSmooth.Name = "ColorIncSmooth";
            this.ColorIncSmooth.Size = new System.Drawing.Size(45, 20);
            this.ColorIncSmooth.TabIndex = 97;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(239, 171);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 13);
            this.label38.TabIndex = 93;
            this.label38.Text = "<";
            this.label38.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AggressiveLevel
            // 
            this.AggressiveLevel.Location = new System.Drawing.Point(258, 169);
            this.AggressiveLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.AggressiveLevel.Name = "AggressiveLevel";
            this.AggressiveLevel.Size = new System.Drawing.Size(45, 20);
            this.AggressiveLevel.TabIndex = 96;
            this.AggressiveLevel.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // SmoothDarkness
            // 
            this.SmoothDarkness.AutoSize = true;
            this.SmoothDarkness.Checked = true;
            this.SmoothDarkness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmoothDarkness.Location = new System.Drawing.Point(121, 170);
            this.SmoothDarkness.Name = "SmoothDarkness";
            this.SmoothDarkness.Size = new System.Drawing.Size(114, 17);
            this.SmoothDarkness.TabIndex = 91;
            this.SmoothDarkness.Text = "Smooth 3x at color";
            this.SmoothDarkness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SmoothDarkness.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(153, 118);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 13);
            this.label31.TabIndex = 90;
            this.label31.Text = "Fast scene reaction:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fsr
            // 
            this.fsr.Location = new System.Drawing.Point(258, 116);
            this.fsr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.fsr.Name = "fsr";
            this.fsr.Size = new System.Drawing.Size(45, 20);
            this.fsr.TabIndex = 89;
            this.fsr.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(14, 292);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(44, 13);
            this.label37.TabIndex = 88;
            this.label37.Text = "Current:";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(64, 292);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(13, 13);
            this.label36.TabIndex = 87;
            this.label36.Text = "?";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(11, 145);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(62, 13);
            this.label30.TabIndex = 84;
            this.label30.Text = "Light mode:";
            // 
            // ModeCombo2
            // 
            this.ModeCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeCombo2.FormattingEnabled = true;
            this.ModeCombo2.Items.AddRange(new object[] {
            "Gaming",
            "Movie",
            "10*Movie smooth",
            "30*Movie smooth",
            "10*Movie smooth+Fast scene"});
            this.ModeCombo2.Location = new System.Drawing.Point(74, 142);
            this.ModeCombo2.Name = "ModeCombo2";
            this.ModeCombo2.Size = new System.Drawing.Size(229, 21);
            this.ModeCombo2.TabIndex = 82;
            this.ModeCombo2.SelectedIndexChanged += new System.EventHandler(this.ModeCombo2_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 268);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 81;
            this.label23.Text = "Display:";
            // 
            // DisplaysBox
            // 
            this.DisplaysBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisplaysBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.DisplaysBox.Location = new System.Drawing.Point(64, 265);
            this.DisplaysBox.Name = "DisplaysBox";
            this.DisplaysBox.Size = new System.Drawing.Size(85, 21);
            this.DisplaysBox.TabIndex = 53;
            this.DisplaysBox.SelectedIndexChanged += new System.EventHandler(this.DisplaysBox_SelectedIndexChanged);
            // 
            // Colorslider
            // 
            this.Colorslider.Location = new System.Drawing.Point(227, 45);
            this.Colorslider.Name = "Colorslider";
            this.Colorslider.Size = new System.Drawing.Size(45, 20);
            this.Colorslider.TabIndex = 77;
            this.Colorslider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 80;
            this.label22.Text = "Timer interval:";
            // 
            // TimerDelay
            // 
            this.TimerDelay.Location = new System.Drawing.Point(90, 81);
            this.TimerDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerDelay.Name = "TimerDelay";
            this.TimerDelay.Size = new System.Drawing.Size(45, 20);
            this.TimerDelay.TabIndex = 79;
            this.TimerDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TimerDelay.ValueChanged += new System.EventHandler(this.TimerDelay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Max multiply:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(151, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 26);
            this.label21.TabIndex = 78;
            this.label21.Text = "Color increase:\r\n(10 equals actual color)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.label57);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.RightEnd);
            this.groupBox4.Controls.Add(this.RightBegin);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.BlueRight);
            this.groupBox4.Controls.Add(this.GreenRight);
            this.groupBox4.Controls.Add(this.RedRight);
            this.groupBox4.Controls.Add(this.ColorRight);
            this.groupBox4.Location = new System.Drawing.Point(12, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 97);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(210, 75);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(13, 13);
            this.label52.TabIndex = 101;
            this.label52.Text = "0";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(210, 49);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(13, 13);
            this.label53.TabIndex = 100;
            this.label53.Text = "0";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(210, 21);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(13, 13);
            this.label54.TabIndex = 99;
            this.label54.Text = "0";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(173, 75);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(31, 13);
            this.label55.TabIndex = 98;
            this.label55.Text = "Blue:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(165, 49);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(39, 13);
            this.label56.TabIndex = 97;
            this.label56.Text = "Green:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(174, 23);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(30, 13);
            this.label57.TabIndex = 96;
            this.label57.Text = "Red:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "end";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(282, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 94;
            this.label19.Text = "start";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(282, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 13);
            this.label20.TabIndex = 93;
            this.label20.Text = "Horizontal scan range percentage";
            // 
            // RightEnd
            // 
            this.RightEnd.Location = new System.Drawing.Point(390, 39);
            this.RightEnd.Name = "RightEnd";
            this.RightEnd.Size = new System.Drawing.Size(47, 20);
            this.RightEnd.TabIndex = 92;
            this.RightEnd.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RightBegin
            // 
            this.RightBegin.Location = new System.Drawing.Point(315, 39);
            this.RightBegin.Name = "RightBegin";
            this.RightBegin.Size = new System.Drawing.Size(45, 20);
            this.RightBegin.TabIndex = 91;
            this.RightBegin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "start";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(363, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "end";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label40);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.TopEnd);
            this.groupBox5.Controls.Add(this.TopBegin);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.BlueTop);
            this.groupBox5.Controls.Add(this.GreenTop);
            this.groupBox5.Controls.Add(this.RedTop);
            this.groupBox5.Controls.Add(this.ColorTop);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 107);
            this.groupBox5.TabIndex = 86;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Top";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(210, 73);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(13, 13);
            this.label42.TabIndex = 91;
            this.label42.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(210, 47);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(13, 13);
            this.label43.TabIndex = 90;
            this.label43.Text = "0";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(210, 19);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 13);
            this.label44.TabIndex = 89;
            this.label44.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(173, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 88;
            this.label39.Text = "Blue:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(165, 47);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(39, 13);
            this.label40.TabIndex = 87;
            this.label40.Text = "Green:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(174, 21);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 86;
            this.label41.Text = "Red:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.BlueTopOnExit);
            this.groupBox6.Controls.Add(this.GreenTopOnExit);
            this.groupBox6.Controls.Add(this.RedTopOnExit);
            this.groupBox6.Controls.Add(this.ColorTopOnExit);
            this.groupBox6.Location = new System.Drawing.Point(475, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 107);
            this.groupBox6.TabIndex = 87;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Top on Exit";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 73);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 13);
            this.label33.TabIndex = 61;
            this.label33.Text = "Blue:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(5, 47);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 13);
            this.label34.TabIndex = 60;
            this.label34.Text = "Green:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(14, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(30, 13);
            this.label35.TabIndex = 59;
            this.label35.Text = "Red:";
            // 
            // BlueTopOnExit
            // 
            this.BlueTopOnExit.Location = new System.Drawing.Point(50, 71);
            this.BlueTopOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueTopOnExit.Name = "BlueTopOnExit";
            this.BlueTopOnExit.Size = new System.Drawing.Size(45, 20);
            this.BlueTopOnExit.TabIndex = 58;
            this.BlueTopOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueTopOnExit.ValueChanged += new System.EventHandler(this.BlueTopOnExit_ValueChanged);
            // 
            // GreenTopOnExit
            // 
            this.GreenTopOnExit.Location = new System.Drawing.Point(50, 45);
            this.GreenTopOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenTopOnExit.Name = "GreenTopOnExit";
            this.GreenTopOnExit.Size = new System.Drawing.Size(45, 20);
            this.GreenTopOnExit.TabIndex = 57;
            this.GreenTopOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenTopOnExit.ValueChanged += new System.EventHandler(this.GreenTopOnExit_ValueChanged);
            // 
            // RedTopOnExit
            // 
            this.RedTopOnExit.Location = new System.Drawing.Point(50, 19);
            this.RedTopOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedTopOnExit.Name = "RedTopOnExit";
            this.RedTopOnExit.Size = new System.Drawing.Size(45, 20);
            this.RedTopOnExit.TabIndex = 56;
            this.RedTopOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedTopOnExit.ValueChanged += new System.EventHandler(this.RedTopOnExit_ValueChanged);
            // 
            // ColorTopOnExit
            // 
            this.ColorTopOnExit.Location = new System.Drawing.Point(101, 19);
            this.ColorTopOnExit.Name = "ColorTopOnExit";
            this.ColorTopOnExit.Size = new System.Drawing.Size(51, 72);
            this.ColorTopOnExit.TabIndex = 4;
            this.ColorTopOnExit.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.BlueLeftOnExit);
            this.groupBox7.Controls.Add(this.GreenLeftOnExit);
            this.groupBox7.Controls.Add(this.RedLeftOnExit);
            this.groupBox7.Controls.Add(this.ColorLeftOnExit);
            this.groupBox7.Location = new System.Drawing.Point(475, 125);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(168, 107);
            this.groupBox7.TabIndex = 88;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Left on Exit";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 61;
            this.label24.Text = "Blue:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 47);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 13);
            this.label25.TabIndex = 60;
            this.label25.Text = "Green:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 59;
            this.label26.Text = "Red:";
            // 
            // BlueLeftOnExit
            // 
            this.BlueLeftOnExit.Location = new System.Drawing.Point(50, 71);
            this.BlueLeftOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueLeftOnExit.Name = "BlueLeftOnExit";
            this.BlueLeftOnExit.Size = new System.Drawing.Size(45, 20);
            this.BlueLeftOnExit.TabIndex = 58;
            this.BlueLeftOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueLeftOnExit.ValueChanged += new System.EventHandler(this.BlueLeftOnExit_ValueChanged);
            // 
            // GreenLeftOnExit
            // 
            this.GreenLeftOnExit.Location = new System.Drawing.Point(50, 45);
            this.GreenLeftOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenLeftOnExit.Name = "GreenLeftOnExit";
            this.GreenLeftOnExit.Size = new System.Drawing.Size(45, 20);
            this.GreenLeftOnExit.TabIndex = 57;
            this.GreenLeftOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenLeftOnExit.ValueChanged += new System.EventHandler(this.GreenLeftOnExit_ValueChanged);
            // 
            // RedLeftOnExit
            // 
            this.RedLeftOnExit.Location = new System.Drawing.Point(50, 19);
            this.RedLeftOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedLeftOnExit.Name = "RedLeftOnExit";
            this.RedLeftOnExit.Size = new System.Drawing.Size(45, 20);
            this.RedLeftOnExit.TabIndex = 56;
            this.RedLeftOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedLeftOnExit.ValueChanged += new System.EventHandler(this.RedLeftOnExit_ValueChanged);
            // 
            // ColorLeftOnExit
            // 
            this.ColorLeftOnExit.Location = new System.Drawing.Point(101, 19);
            this.ColorLeftOnExit.Name = "ColorLeftOnExit";
            this.ColorLeftOnExit.Size = new System.Drawing.Size(51, 72);
            this.ColorLeftOnExit.TabIndex = 4;
            this.ColorLeftOnExit.TabStop = false;
            // 
            // ColorRightOnExit
            // 
            this.ColorRightOnExit.Location = new System.Drawing.Point(101, 19);
            this.ColorRightOnExit.Name = "ColorRightOnExit";
            this.ColorRightOnExit.Size = new System.Drawing.Size(51, 72);
            this.ColorRightOnExit.TabIndex = 4;
            this.ColorRightOnExit.TabStop = false;
            // 
            // RedRightOnExit
            // 
            this.RedRightOnExit.Location = new System.Drawing.Point(50, 19);
            this.RedRightOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedRightOnExit.Name = "RedRightOnExit";
            this.RedRightOnExit.Size = new System.Drawing.Size(45, 20);
            this.RedRightOnExit.TabIndex = 56;
            this.RedRightOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedRightOnExit.ValueChanged += new System.EventHandler(this.RedRightOnExit_ValueChanged);
            // 
            // GreenRightOnExit
            // 
            this.GreenRightOnExit.Location = new System.Drawing.Point(50, 45);
            this.GreenRightOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenRightOnExit.Name = "GreenRightOnExit";
            this.GreenRightOnExit.Size = new System.Drawing.Size(45, 20);
            this.GreenRightOnExit.TabIndex = 57;
            this.GreenRightOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenRightOnExit.ValueChanged += new System.EventHandler(this.GreenRightOnExit_ValueChanged);
            // 
            // BlueRightOnExit
            // 
            this.BlueRightOnExit.Location = new System.Drawing.Point(50, 71);
            this.BlueRightOnExit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueRightOnExit.Name = "BlueRightOnExit";
            this.BlueRightOnExit.Size = new System.Drawing.Size(45, 20);
            this.BlueRightOnExit.TabIndex = 58;
            this.BlueRightOnExit.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueRightOnExit.ValueChanged += new System.EventHandler(this.BlueRightOnExit_ValueChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 13);
            this.label29.TabIndex = 59;
            this.label29.Text = "Red:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 47);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 60;
            this.label28.Text = "Green:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 61;
            this.label27.Text = "Blue:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.label28);
            this.groupBox8.Controls.Add(this.label29);
            this.groupBox8.Controls.Add(this.BlueRightOnExit);
            this.groupBox8.Controls.Add(this.GreenRightOnExit);
            this.groupBox8.Controls.Add(this.RedRightOnExit);
            this.groupBox8.Controls.Add(this.ColorRightOnExit);
            this.groupBox8.Location = new System.Drawing.Point(475, 238);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(168, 98);
            this.groupBox8.TabIndex = 89;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Right on Exit";
            // 
            // ColorLeft
            // 
            this.ColorLeft.Location = new System.Drawing.Point(101, 17);
            this.ColorLeft.Name = "ColorLeft";
            this.ColorLeft.Size = new System.Drawing.Size(51, 72);
            this.ColorLeft.TabIndex = 2;
            this.ColorLeft.TabStop = false;
            // 
            // RedLeft
            // 
            this.RedLeft.Location = new System.Drawing.Point(50, 17);
            this.RedLeft.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedLeft.Name = "RedLeft";
            this.RedLeft.Size = new System.Drawing.Size(45, 20);
            this.RedLeft.TabIndex = 68;
            this.RedLeft.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // GreenLeft
            // 
            this.GreenLeft.Location = new System.Drawing.Point(50, 43);
            this.GreenLeft.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenLeft.Name = "GreenLeft";
            this.GreenLeft.Size = new System.Drawing.Size(45, 20);
            this.GreenLeft.TabIndex = 69;
            this.GreenLeft.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // BlueLeft
            // 
            this.BlueLeft.Location = new System.Drawing.Point(50, 69);
            this.BlueLeft.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlueLeft.Name = "BlueLeft";
            this.BlueLeft.Size = new System.Drawing.Size(45, 20);
            this.BlueLeft.TabIndex = 70;
            this.BlueLeft.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Red:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 72;
            this.label12.Text = "Green:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Blue:";
            // 
            // LeftBegin
            // 
            this.LeftBegin.Location = new System.Drawing.Point(315, 37);
            this.LeftBegin.Name = "LeftBegin";
            this.LeftBegin.Size = new System.Drawing.Size(45, 20);
            this.LeftBegin.TabIndex = 86;
            // 
            // LeftEnd
            // 
            this.LeftEnd.Location = new System.Drawing.Point(390, 37);
            this.LeftEnd.Name = "LeftEnd";
            this.LeftEnd.Size = new System.Drawing.Size(47, 20);
            this.LeftEnd.TabIndex = 87;
            this.LeftEnd.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(282, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Horizontal scan range percentage";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(282, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "start";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(363, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 90;
            this.label16.Text = "end";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.label50);
            this.groupBox3.Controls.Add(this.label51);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.LeftEnd);
            this.groupBox3.Controls.Add(this.LeftBegin);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.BlueLeft);
            this.groupBox3.Controls.Add(this.GreenLeft);
            this.groupBox3.Controls.Add(this.RedLeft);
            this.groupBox3.Controls.Add(this.ColorLeft);
            this.groupBox3.Location = new System.Drawing.Point(12, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 107);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Left";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(210, 73);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(13, 13);
            this.label45.TabIndex = 97;
            this.label45.Text = "0";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(210, 47);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(13, 13);
            this.label47.TabIndex = 96;
            this.label47.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(210, 19);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(13, 13);
            this.label48.TabIndex = 95;
            this.label48.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(173, 73);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(31, 13);
            this.label49.TabIndex = 94;
            this.label49.Text = "Blue:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(165, 47);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(39, 13);
            this.label50.TabIndex = 93;
            this.label50.Text = "Green:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(174, 21);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(30, 13);
            this.label51.TabIndex = 92;
            this.label51.Text = "Red:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label72);
            this.groupBox9.Controls.Add(this.label73);
            this.groupBox9.Controls.Add(this.label74);
            this.groupBox9.Controls.Add(this.label75);
            this.groupBox9.Controls.Add(this.label65);
            this.groupBox9.Controls.Add(this.label70);
            this.groupBox9.Controls.Add(this.label71);
            this.groupBox9.Controls.Add(this.label69);
            this.groupBox9.Controls.Add(this.label68);
            this.groupBox9.Controls.Add(this.label64);
            this.groupBox9.Controls.Add(this.label66);
            this.groupBox9.Controls.Add(this.label67);
            this.groupBox9.Controls.Add(this.label62);
            this.groupBox9.Controls.Add(this.label63);
            this.groupBox9.Controls.Add(this.label60);
            this.groupBox9.Controls.Add(this.label61);
            this.groupBox9.Location = new System.Drawing.Point(14, 345);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(628, 65);
            this.groupBox9.TabIndex = 90;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Pixel scanning diagnostic info";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(508, 40);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(13, 13);
            this.label72.TabIndex = 122;
            this.label72.Text = "0";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(439, 40);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(64, 13);
            this.label73.TabIndex = 121;
            this.label73.Text = "Scan offset:";
            this.label73.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(508, 16);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(13, 13);
            this.label74.TabIndex = 120;
            this.label74.Text = "0";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(439, 16);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(64, 13);
            this.label75.TabIndex = 119;
            this.label75.Text = "Scan offset:";
            this.label75.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(400, 40);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(13, 13);
            this.label65.TabIndex = 118;
            this.label65.Text = "0";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(247, 40);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(147, 13);
            this.label70.TabIndex = 117;
            this.label70.Text = "Total scanned pixels in line Y:";
            this.label70.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(247, 16);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(147, 13);
            this.label71.TabIndex = 116;
            this.label71.Text = "Total scanned pixels in line X:";
            this.label71.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(88, 40);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(13, 13);
            this.label69.TabIndex = 115;
            this.label69.Text = "0";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(6, 40);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(76, 13);
            this.label68.TabIndex = 114;
            this.label68.Text = "Screen height:";
            this.label68.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(400, 16);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(13, 13);
            this.label64.TabIndex = 113;
            this.label64.Text = "0";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(88, 16);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(13, 13);
            this.label66.TabIndex = 111;
            this.label66.Text = "0";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(10, 16);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(72, 13);
            this.label67.TabIndex = 110;
            this.label67.Text = "Screen width:";
            this.label67.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(206, 40);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(13, 13);
            this.label62.TabIndex = 109;
            this.label62.Text = "0";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(134, 40);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(66, 13);
            this.label63.TabIndex = 108;
            this.label63.Text = "Step by (px):";
            this.label63.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(206, 16);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(13, 13);
            this.label60.TabIndex = 107;
            this.label60.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(134, 16);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(66, 13);
            this.label61.TabIndex = 106;
            this.label61.Text = "Step by (px):";
            this.label61.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AutoDetect
            // 
            this.AutoDetect.Enabled = true;
            this.AutoDetect.Tick += new System.EventHandler(this.AutoDetect_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(986, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 91;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(486, 17);
            this.toolStripStatusLabel2.Text = "epiLight 2009 by Mariusz Grzybacz silas@qnapclub.pl (Continued work of Bob van Lo" +
                "osen).";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(342, 17);
            this.toolStripStatusLabel1.Text = "Designed to work with epiLight and MoMoLight RGB controller.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 447);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "epiLight";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ColorRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTop)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopEnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivideLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorIncSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AggressiveLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colorslider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDelay)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBegin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTopOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTopOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTopOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTopOnExit)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeftOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeftOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeftOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLeftOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorRightOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedRightOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenRightOnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRightOnExit)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEnd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CaptureTimer;
        private System.Windows.Forms.PictureBox ColorRight;
        private System.Windows.Forms.PictureBox ColorTop;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtPortname;
        private System.Windows.Forms.Label ComPort;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button EnableBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox ModeCombo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown RedTop;
        private System.Windows.Forms.NumericUpDown GreenTop;
        private System.Windows.Forms.NumericUpDown BlueTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown BlueRight;
        private System.Windows.Forms.NumericUpDown GreenRight;
        private System.Windows.Forms.NumericUpDown RedRight;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown TopBegin;
        private System.Windows.Forms.NumericUpDown TopEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown RightEnd;
        private System.Windows.Forms.NumericUpDown RightBegin;
        private System.Windows.Forms.NumericUpDown Colorslider;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown TimerDelay;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox DisplaysBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox ModeCombo2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown BlueTopOnExit;
        private System.Windows.Forms.NumericUpDown GreenTopOnExit;
        private System.Windows.Forms.NumericUpDown RedTopOnExit;
        private System.Windows.Forms.PictureBox ColorTopOnExit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown BlueLeftOnExit;
        private System.Windows.Forms.NumericUpDown GreenLeftOnExit;
        private System.Windows.Forms.NumericUpDown RedLeftOnExit;
        private System.Windows.Forms.PictureBox ColorLeftOnExit;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown fsr;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SmoothDarkness;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown AggressiveLevel;
        private System.Windows.Forms.PictureBox ColorRightOnExit;
        private System.Windows.Forms.NumericUpDown RedRightOnExit;
        private System.Windows.Forms.NumericUpDown GreenRightOnExit;
        private System.Windows.Forms.NumericUpDown BlueRightOnExit;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown ColorIncSmooth;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.PictureBox ColorLeft;
        private System.Windows.Forms.NumericUpDown RedLeft;
        private System.Windows.Forms.NumericUpDown GreenLeft;
        private System.Windows.Forms.NumericUpDown BlueLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown LeftBegin;
        private System.Windows.Forms.NumericUpDown LeftEnd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.NumericUpDown OffsetLevel;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.NumericUpDown DivideLevel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Timer AutoDetect;
        private System.Windows.Forms.TextBox ProcessName;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.CheckBox AutoEnable;
        private System.Windows.Forms.NumericUpDown CaptureCycles;
        private System.Windows.Forms.CheckBox CaptureEvery;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label32;
    }
}

