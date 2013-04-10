namespace BobLight
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
            this.ColorLeft = new System.Windows.Forms.PictureBox();
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
            this.label3 = new System.Windows.Forms.Label();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BlueLeft = new System.Windows.Forms.NumericUpDown();
            this.GreenLeft = new System.Windows.Forms.NumericUpDown();
            this.RedLeft = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.TopBegin = new System.Windows.Forms.NumericUpDown();
            this.TopEnd = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Colorslider = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LeftEnd = new System.Windows.Forms.NumericUpDown();
            this.LeftBegin = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.RightEnd = new System.Windows.Forms.NumericUpDown();
            this.RightBegin = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TimerDelay = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorLeft)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopEnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colorslider)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBegin)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBegin)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Interval = 20;
            this.CaptureTimer.Tick += new System.EventHandler(this.CaptureTimer_Tick);
            // 
            // ColorLeft
            // 
            this.ColorLeft.Location = new System.Drawing.Point(101, 17);
            this.ColorLeft.Name = "ColorLeft";
            this.ColorLeft.Size = new System.Drawing.Size(51, 72);
            this.ColorLeft.TabIndex = 2;
            this.ColorLeft.TabStop = false;
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
            this.serialPort1.BaudRate = 4800;
            this.serialPort1.PortName = "com4";
            // 
            // txtPortname
            // 
            this.txtPortname.Location = new System.Drawing.Point(75, 16);
            this.txtPortname.Name = "txtPortname";
            this.txtPortname.Size = new System.Drawing.Size(61, 20);
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
            this.comboBaud.Location = new System.Drawing.Point(75, 42);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(61, 21);
            this.comboBaud.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Baudrate:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BobLight";
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 79);
            // 
            // ModeCombo
            // 
            this.ModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeCombo.Items.AddRange(new object[] {
            "Gaming mode",
            "Movie mode"});
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(121, 21);
            this.ModeCombo.SelectedIndexChanged += new System.EventHandler(this.ModeCombo_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.disableToolStripMenuItem.Text = "Enable/Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // EnableBtn
            // 
            this.EnableBtn.Location = new System.Drawing.Point(76, 67);
            this.EnableBtn.Name = "EnableBtn";
            this.EnableBtn.Size = new System.Drawing.Size(61, 32);
            this.EnableBtn.TabIndex = 52;
            this.EnableBtn.Text = "Disable";
            this.EnableBtn.UseVisualStyleBackColor = true;
            this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 92);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 54;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Max multiply:";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Blue:";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Red:";
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 74;
            this.radioButton1.Text = "No expand";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 40);
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
            this.radioButton3.Location = new System.Drawing.Point(12, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 17);
            this.radioButton3.TabIndex = 76;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Expand together";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // TopBegin
            // 
            this.TopBegin.Location = new System.Drawing.Point(210, 45);
            this.TopBegin.Name = "TopBegin";
            this.TopBegin.Size = new System.Drawing.Size(45, 20);
            this.TopBegin.TabIndex = 77;
            // 
            // TopEnd
            // 
            this.TopEnd.Location = new System.Drawing.Point(285, 45);
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
            this.label14.Location = new System.Drawing.Point(177, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Vertical scan range percentage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBaud);
            this.groupBox1.Controls.Add(this.ComPort);
            this.groupBox1.Controls.Add(this.txtPortname);
            this.groupBox1.Controls.Add(this.EnableBtn);
            this.groupBox1.Location = new System.Drawing.Point(370, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 107);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Colorslider);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.TimerDelay);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(370, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 210);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voodoo settings";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 39);
            this.label21.TabIndex = 78;
            this.label21.Text = "Color:\r\n\r\n(10 equals actual color)";
            // 
            // Colorslider
            // 
            this.Colorslider.Location = new System.Drawing.Point(82, 122);
            this.Colorslider.Name = "Colorslider";
            this.Colorslider.Size = new System.Drawing.Size(45, 20);
            this.Colorslider.TabIndex = 77;
            this.Colorslider.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
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
            this.groupBox3.Size = new System.Drawing.Size(352, 107);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Left";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(258, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 90;
            this.label16.Text = "end";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(177, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "start";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Horizontal scan range percentage";
            // 
            // LeftEnd
            // 
            this.LeftEnd.Location = new System.Drawing.Point(285, 43);
            this.LeftEnd.Name = "LeftEnd";
            this.LeftEnd.Size = new System.Drawing.Size(47, 20);
            this.LeftEnd.TabIndex = 87;
            this.LeftEnd.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // LeftBegin
            // 
            this.LeftBegin.Location = new System.Drawing.Point(210, 43);
            this.LeftBegin.Name = "LeftBegin";
            this.LeftBegin.Size = new System.Drawing.Size(45, 20);
            this.LeftBegin.TabIndex = 86;
            // 
            // groupBox4
            // 
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
            this.groupBox4.Size = new System.Drawing.Size(352, 97);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "end";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(177, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 94;
            this.label19.Text = "start";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(177, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 13);
            this.label20.TabIndex = 93;
            this.label20.Text = "Horizontal scan range percentage";
            // 
            // RightEnd
            // 
            this.RightEnd.Location = new System.Drawing.Point(285, 45);
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
            this.RightBegin.Location = new System.Drawing.Point(210, 45);
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
            this.label10.Location = new System.Drawing.Point(177, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "start";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(258, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "end";
            // 
            // groupBox5
            // 
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
            this.groupBox5.Size = new System.Drawing.Size(352, 107);
            this.groupBox5.TabIndex = 86;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Top";
            // 
            // TimerDelay
            // 
            this.TimerDelay.Location = new System.Drawing.Point(82, 174);
            this.TimerDelay.Minimum = new decimal(new int[] {
            10,
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 80;
            this.label22.Text = "Timer interval:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 348);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BobLight";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColorLeft)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.BlueLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopEnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Colorslider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBegin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBegin)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CaptureTimer;
        private System.Windows.Forms.PictureBox ColorLeft;
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
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown BlueLeft;
        private System.Windows.Forms.NumericUpDown GreenLeft;
        private System.Windows.Forms.NumericUpDown RedLeft;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown TopBegin;
        private System.Windows.Forms.NumericUpDown TopEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown LeftEnd;
        private System.Windows.Forms.NumericUpDown LeftBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown RightEnd;
        private System.Windows.Forms.NumericUpDown RightBegin;
        private System.Windows.Forms.NumericUpDown Colorslider;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown TimerDelay;
        private System.Windows.Forms.Label label22;
    }
}

