namespace UpperApp
{
    partial class UpperApp
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private const string proname = "小车上位机";
        private const string prover = "V5.0";

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpperApp));
            this.Infotext = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.RecvBox = new System.Windows.Forms.TextBox();
            this.SendBox = new System.Windows.Forms.TextBox();
            this.SerPortItem = new System.Windows.Forms.ComboBox();
            this.btnAutoSend = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnChar = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBegin = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSerial = new System.Windows.Forms.Button();
            this.FBBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.FBtext = new System.Windows.Forms.Label();
            this.RLBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.RLtext = new System.Windows.Forms.Label();
            this.btnNoRL = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabYaw = new System.Windows.Forms.Label();
            this.LabRoll = new System.Windows.Forms.Label();
            this.LabPitch = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LabDist = new System.Windows.Forms.Label();
            this.btnclRecv = new System.Windows.Forms.Button();
            this.btnclSend = new System.Windows.Forms.Button();
            this.Tim = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.smallChange = new System.Windows.Forms.TextBox();
            this.Rocker = new System.Windows.Forms.Button();
            this.ReDisp = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.SaveData = new System.Windows.Forms.CheckBox();
            this.Peer = new System.Windows.Forms.ComboBox();
            this.HostIP = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.NetType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnSerial = new System.Windows.Forms.RadioButton();
            this.rbtnNET = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AngDirDisp = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ClearAngDisp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.btnMsg8 = new System.Windows.Forms.Button();
            this.MsgBox8 = new System.Windows.Forms.TextBox();
            this.MsgHex8 = new System.Windows.Forms.CheckBox();
            this.btnMsg7 = new System.Windows.Forms.Button();
            this.MsgBox7 = new System.Windows.Forms.TextBox();
            this.MsgHex7 = new System.Windows.Forms.CheckBox();
            this.btnMsg6 = new System.Windows.Forms.Button();
            this.MsgBox6 = new System.Windows.Forms.TextBox();
            this.MsgHex6 = new System.Windows.Forms.CheckBox();
            this.btnMsg5 = new System.Windows.Forms.Button();
            this.MsgBox5 = new System.Windows.Forms.TextBox();
            this.MsgHex5 = new System.Windows.Forms.CheckBox();
            this.btnMsg4 = new System.Windows.Forms.Button();
            this.MsgBox4 = new System.Windows.Forms.TextBox();
            this.MsgHex4 = new System.Windows.Forms.CheckBox();
            this.btnMsg3 = new System.Windows.Forms.Button();
            this.MsgBox3 = new System.Windows.Forms.TextBox();
            this.MsgHex3 = new System.Windows.Forms.CheckBox();
            this.btnMsg2 = new System.Windows.Forms.Button();
            this.MsgBox2 = new System.Windows.Forms.TextBox();
            this.MsgHex2 = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnMsg1 = new System.Windows.Forms.Button();
            this.MsgBox1 = new System.Windows.Forms.TextBox();
            this.MsgHex1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RealDist = new System.Windows.Forms.MaskedTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.ClearImage = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.OpenImage = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BthConnectBtn = new System.Windows.Forms.Button();
            this.BthListenBtn = new System.Windows.Forms.Button();
            this.BthDispBtn = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MemTimer = new System.Windows.Forms.Timer(this.components);
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.BthSendBtn = new System.Windows.Forms.Button();
            this.BthRecvBox = new System.Windows.Forms.TextBox();
            this.BthSendBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FBBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Infotext
            // 
            this.Infotext.AutoSize = true;
            this.Infotext.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Infotext.ForeColor = System.Drawing.Color.Red;
            this.Infotext.Location = new System.Drawing.Point(326, 22);
            this.Infotext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Infotext.Name = "Infotext";
            this.Infotext.Size = new System.Drawing.Size(40, 17);
            this.Infotext.TabIndex = 0;
            this.Infotext.Text = "状态";
            this.Infotext.DoubleClick += new System.EventHandler(this.Info_DoubleClick);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(317, 214);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(62, 26);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // RecvBox
            // 
            this.RecvBox.Location = new System.Drawing.Point(130, 19);
            this.RecvBox.Margin = new System.Windows.Forms.Padding(2);
            this.RecvBox.Multiline = true;
            this.RecvBox.Name = "RecvBox";
            this.RecvBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecvBox.Size = new System.Drawing.Size(176, 174);
            this.RecvBox.TabIndex = 2;
            // 
            // SendBox
            // 
            this.SendBox.Location = new System.Drawing.Point(130, 216);
            this.SendBox.Margin = new System.Windows.Forms.Padding(2);
            this.SendBox.Multiline = true;
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(176, 51);
            this.SendBox.TabIndex = 3;
            // 
            // SerPortItem
            // 
            this.SerPortItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerPortItem.FormattingEnabled = true;
            this.SerPortItem.Location = new System.Drawing.Point(61, 21);
            this.SerPortItem.Margin = new System.Windows.Forms.Padding(2);
            this.SerPortItem.Name = "SerPortItem";
            this.SerPortItem.Size = new System.Drawing.Size(66, 20);
            this.SerPortItem.TabIndex = 4;
            // 
            // btnAutoSend
            // 
            this.btnAutoSend.AutoSize = true;
            this.btnAutoSend.Location = new System.Drawing.Point(323, 45);
            this.btnAutoSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoSend.Name = "btnAutoSend";
            this.btnAutoSend.Size = new System.Drawing.Size(72, 16);
            this.btnAutoSend.TabIndex = 5;
            this.btnAutoSend.Text = "自动发送";
            this.btnAutoSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnChar);
            this.panel1.Controls.Add(this.rbtnHex);
            this.panel1.Location = new System.Drawing.Point(317, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 94);
            this.panel1.TabIndex = 6;
            // 
            // rbtnChar
            // 
            this.rbtnChar.AutoSize = true;
            this.rbtnChar.Checked = true;
            this.rbtnChar.Location = new System.Drawing.Point(2, 57);
            this.rbtnChar.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnChar.Name = "rbtnChar";
            this.rbtnChar.Size = new System.Drawing.Size(47, 16);
            this.rbtnChar.TabIndex = 1;
            this.rbtnChar.TabStop = true;
            this.rbtnChar.Text = "CHAR";
            this.rbtnChar.UseVisualStyleBackColor = true;
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(2, 15);
            this.rbtnHex.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 0;
            this.rbtnHex.Text = "HEX";
            this.rbtnHex.UseVisualStyleBackColor = true;
            // 
            // SendTimer
            // 
            this.SendTimer.Tick += new System.EventHandler(this.SendTimer_Tick);
            // 
            // btnBegin
            // 
            this.btnBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBegin.Location = new System.Drawing.Point(317, 242);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(2);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(62, 25);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Tag = "";
            this.btnBegin.Text = "开始";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // Baud
            // 
            this.Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Baud.FormattingEnabled = true;
            this.Baud.Location = new System.Drawing.Point(61, 46);
            this.Baud.Margin = new System.Windows.Forms.Padding(2);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(66, 20);
            this.Baud.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "波特率";
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(61, 69);
            this.btnSerial.Margin = new System.Windows.Forms.Padding(2);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(64, 25);
            this.btnSerial.TabIndex = 13;
            this.btnSerial.Text = "打开串口";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // FBBar
            // 
            this.FBBar.Location = new System.Drawing.Point(26, 36);
            this.FBBar.Margin = new System.Windows.Forms.Padding(2);
            this.FBBar.Maximum = 100;
            this.FBBar.Name = "FBBar";
            this.FBBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.FBBar.Size = new System.Drawing.Size(45, 121);
            this.FBBar.SmallChange = 25;
            this.FBBar.TabIndex = 14;
            this.FBBar.Value = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "速度：";
            // 
            // FBtext
            // 
            this.FBtext.AutoSize = true;
            this.FBtext.Location = new System.Drawing.Point(58, 19);
            this.FBtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FBtext.Name = "FBtext";
            this.FBtext.Size = new System.Drawing.Size(17, 12);
            this.FBtext.TabIndex = 16;
            this.FBtext.Text = "50";
            // 
            // RLBar
            // 
            this.RLBar.Location = new System.Drawing.Point(110, 90);
            this.RLBar.Margin = new System.Windows.Forms.Padding(2);
            this.RLBar.Maximum = 100;
            this.RLBar.Name = "RLBar";
            this.RLBar.Size = new System.Drawing.Size(112, 45);
            this.RLBar.SmallChange = 25;
            this.RLBar.TabIndex = 17;
            this.RLBar.Value = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "方向：";
            // 
            // RLtext
            // 
            this.RLtext.AutoSize = true;
            this.RLtext.Location = new System.Drawing.Point(154, 65);
            this.RLtext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RLtext.Name = "RLtext";
            this.RLtext.Size = new System.Drawing.Size(17, 12);
            this.RLtext.TabIndex = 19;
            this.RLtext.Text = "50";
            // 
            // btnNoRL
            // 
            this.btnNoRL.Location = new System.Drawing.Point(135, 159);
            this.btnNoRL.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoRL.Name = "btnNoRL";
            this.btnNoRL.Size = new System.Drawing.Size(56, 23);
            this.btnNoRL.TabIndex = 20;
            this.btnNoRL.Text = "回正";
            this.btnNoRL.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(19, 159);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(56, 23);
            this.Stop.TabIndex = 21;
            this.Stop.Text = "停车";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "偏航角:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "横滚角:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "俯仰角:";
            // 
            // LabYaw
            // 
            this.LabYaw.AutoSize = true;
            this.LabYaw.Location = new System.Drawing.Point(4, 52);
            this.LabYaw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabYaw.Name = "LabYaw";
            this.LabYaw.Size = new System.Drawing.Size(11, 12);
            this.LabYaw.TabIndex = 26;
            this.LabYaw.Text = "0";
            // 
            // LabRoll
            // 
            this.LabRoll.AutoSize = true;
            this.LabRoll.Location = new System.Drawing.Point(67, 52);
            this.LabRoll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabRoll.Name = "LabRoll";
            this.LabRoll.Size = new System.Drawing.Size(11, 12);
            this.LabRoll.TabIndex = 27;
            this.LabRoll.Text = "0";
            // 
            // LabPitch
            // 
            this.LabPitch.AutoSize = true;
            this.LabPitch.Location = new System.Drawing.Point(133, 52);
            this.LabPitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabPitch.Name = "LabPitch";
            this.LabPitch.Size = new System.Drawing.Size(11, 12);
            this.LabPitch.TabIndex = 28;
            this.LabPitch.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(188, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "航程:";
            // 
            // LabDist
            // 
            this.LabDist.AutoSize = true;
            this.LabDist.Location = new System.Drawing.Point(188, 52);
            this.LabDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabDist.Name = "LabDist";
            this.LabDist.Size = new System.Drawing.Size(11, 12);
            this.LabDist.TabIndex = 30;
            this.LabDist.Text = "0";
            this.LabDist.TextChanged += new System.EventHandler(this.LabDist_TextChanged);
            // 
            // btnclRecv
            // 
            this.btnclRecv.Location = new System.Drawing.Point(60, 214);
            this.btnclRecv.Margin = new System.Windows.Forms.Padding(2);
            this.btnclRecv.Name = "btnclRecv";
            this.btnclRecv.Size = new System.Drawing.Size(64, 25);
            this.btnclRecv.TabIndex = 31;
            this.btnclRecv.Text = "清空接收";
            this.btnclRecv.UseVisualStyleBackColor = true;
            // 
            // btnclSend
            // 
            this.btnclSend.Location = new System.Drawing.Point(60, 242);
            this.btnclSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnclSend.Name = "btnclSend";
            this.btnclSend.Size = new System.Drawing.Size(64, 25);
            this.btnclSend.TabIndex = 32;
            this.btnclSend.Text = "清空发送";
            this.btnclSend.UseVisualStyleBackColor = true;
            // 
            // Tim
            // 
            this.Tim.Location = new System.Drawing.Point(323, 66);
            this.Tim.Margin = new System.Windows.Forms.Padding(2);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(77, 21);
            this.Tim.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(403, 61);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(143, 270);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "Rx:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(171, 270);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 36;
            this.label18.Text = "0";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 5);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(110, 17);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 40;
            this.label19.Text = "按键步进：";
            // 
            // smallChange
            // 
            this.smallChange.Location = new System.Drawing.Point(112, 36);
            this.smallChange.Margin = new System.Windows.Forms.Padding(2);
            this.smallChange.Name = "smallChange";
            this.smallChange.Size = new System.Drawing.Size(76, 21);
            this.smallChange.TabIndex = 41;
            this.smallChange.Text = "25";
            // 
            // Rocker
            // 
            this.Rocker.Location = new System.Drawing.Point(231, 22);
            this.Rocker.Margin = new System.Windows.Forms.Padding(2);
            this.Rocker.Name = "Rocker";
            this.Rocker.Size = new System.Drawing.Size(150, 160);
            this.Rocker.TabIndex = 42;
            this.Rocker.Text = "摇杆开";
            this.Rocker.UseVisualStyleBackColor = true;
            this.Rocker.Click += new System.EventHandler(this.Rocker_Click);
            this.Rocker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rocker_MouseMove);
            // 
            // ReDisp
            // 
            this.ReDisp.AutoSize = true;
            this.ReDisp.Checked = true;
            this.ReDisp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReDisp.Location = new System.Drawing.Point(317, 270);
            this.ReDisp.Margin = new System.Windows.Forms.Padding(2);
            this.ReDisp.Name = "ReDisp";
            this.ReDisp.Size = new System.Drawing.Size(72, 16);
            this.ReDisp.TabIndex = 43;
            this.ReDisp.Text = "本地回显";
            this.ReDisp.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 17);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(413, 12);
            this.label21.TabIndex = 47;
            this.label21.Text = "YAW:25(此为数据)/OVER  ROLL:70/OVER  PITCH:36/OVER  DISTANCE:99/OVER";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 19);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 49;
            this.label23.Text = "FB:25:OVER";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 39);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 50;
            this.label24.Text = "RL:50:OVER";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(4, 59);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(155, 12);
            this.label25.TabIndex = 51;
            this.label25.Text = "FR:25(速度):50(方向):OVER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(679, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(165, 80);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送数据格式:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(3, 296);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(433, 37);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收数据格式:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Port);
            this.groupBox3.Controls.Add(this.SaveData);
            this.groupBox3.Controls.Add(this.Peer);
            this.groupBox3.Controls.Add(this.HostIP);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.NetType);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.ReDisp);
            this.groupBox3.Controls.Add(this.btnclSend);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btnListen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnSerial);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SerPortItem);
            this.groupBox3.Controls.Add(this.Baud);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.Tim);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.btnclRecv);
            this.groupBox3.Controls.Add(this.btnAutoSend);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.btnBegin);
            this.groupBox3.Controls.Add(this.SendBox);
            this.groupBox3.Controls.Add(this.RecvBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(433, 291);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口工作区:";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(77, 142);
            this.Port.Margin = new System.Windows.Forms.Padding(2);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(36, 21);
            this.Port.TabIndex = 54;
            this.Port.Text = "1234";
            this.Port.TextChanged += new System.EventHandler(this.Port_TextChanged);
            // 
            // SaveData
            // 
            this.SaveData.AutoSize = true;
            this.SaveData.Location = new System.Drawing.Point(61, 270);
            this.SaveData.Margin = new System.Windows.Forms.Padding(2);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(72, 16);
            this.SaveData.TabIndex = 52;
            this.SaveData.Text = "数据转存";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.CheckedChanged += new System.EventHandler(this.SaveData_CheckedChanged);
            // 
            // Peer
            // 
            this.Peer.FormattingEnabled = true;
            this.Peer.Location = new System.Drawing.Point(161, 195);
            this.Peer.Margin = new System.Windows.Forms.Padding(2);
            this.Peer.Name = "Peer";
            this.Peer.Size = new System.Drawing.Size(144, 20);
            this.Peer.TabIndex = 51;
            this.Peer.DropDown += new System.EventHandler(this.Peer_DropDown);
            // 
            // HostIP
            // 
            this.HostIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostIP.FormattingEnabled = true;
            this.HostIP.Location = new System.Drawing.Point(4, 114);
            this.HostIP.Margin = new System.Windows.Forms.Padding(2);
            this.HostIP.Name = "HostIP";
            this.HostIP.Size = new System.Drawing.Size(122, 20);
            this.HostIP.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(128, 198);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 12);
            this.label28.TabIndex = 47;
            this.label28.Text = "Peer:";
            // 
            // NetType
            // 
            this.NetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NetType.FormattingEnabled = true;
            this.NetType.Location = new System.Drawing.Point(4, 142);
            this.NetType.Margin = new System.Windows.Forms.Padding(2);
            this.NetType.Name = "NetType";
            this.NetType.Size = new System.Drawing.Size(42, 20);
            this.NetType.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnSerial);
            this.panel2.Controls.Add(this.rbtnNET);
            this.panel2.Location = new System.Drawing.Point(370, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 94);
            this.panel2.TabIndex = 44;
            // 
            // rbtnSerial
            // 
            this.rbtnSerial.AutoSize = true;
            this.rbtnSerial.Checked = true;
            this.rbtnSerial.Location = new System.Drawing.Point(2, 57);
            this.rbtnSerial.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSerial.Name = "rbtnSerial";
            this.rbtnSerial.Size = new System.Drawing.Size(59, 16);
            this.rbtnSerial.TabIndex = 1;
            this.rbtnSerial.TabStop = true;
            this.rbtnSerial.Text = "Serial";
            this.rbtnSerial.UseVisualStyleBackColor = true;
            // 
            // rbtnNET
            // 
            this.rbtnNET.AutoSize = true;
            this.rbtnNET.Location = new System.Drawing.Point(2, 15);
            this.rbtnNET.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNET.Name = "rbtnNET";
            this.rbtnNET.Size = new System.Drawing.Size(41, 16);
            this.rbtnNET.TabIndex = 0;
            this.rbtnNET.Text = "NET";
            this.rbtnNET.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 100);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 12);
            this.label27.TabIndex = 36;
            this.label27.Text = "HostIP:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(45, 144);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 35;
            this.label26.Text = "Port:";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(61, 166);
            this.btnListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(64, 24);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "开始监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(262, 270);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(234, 270);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "Tx:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.Rocker);
            this.groupBox4.Controls.Add(this.smallChange);
            this.groupBox4.Controls.Add(this.btnNoRL);
            this.groupBox4.Controls.Add(this.Stop);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.RLBar);
            this.groupBox4.Controls.Add(this.RLtext);
            this.groupBox4.Controls.Add(this.FBtext);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.FBBar);
            this.groupBox4.Location = new System.Drawing.Point(4, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(388, 202);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "运动状态控制:";
            // 
            // AngDirDisp
            // 
            this.AngDirDisp.AutoSize = true;
            this.AngDirDisp.Location = new System.Drawing.Point(4, 78);
            this.AngDirDisp.Margin = new System.Windows.Forms.Padding(2);
            this.AngDirDisp.Name = "AngDirDisp";
            this.AngDirDisp.Size = new System.Drawing.Size(96, 16);
            this.AngDirDisp.TabIndex = 39;
            this.AngDirDisp.Text = "角度路程显示";
            this.AngDirDisp.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ClearAngDisp);
            this.groupBox5.Controls.Add(this.AngDirDisp);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.LabDist);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.LabPitch);
            this.groupBox5.Controls.Add(this.LabYaw);
            this.groupBox5.Controls.Add(this.LabRoll);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(440, 249);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(226, 102);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "小车姿态:";
            // 
            // ClearAngDisp
            // 
            this.ClearAngDisp.Location = new System.Drawing.Point(153, 71);
            this.ClearAngDisp.Margin = new System.Windows.Forms.Padding(2);
            this.ClearAngDisp.Name = "ClearAngDisp";
            this.ClearAngDisp.Size = new System.Drawing.Size(69, 26);
            this.ClearAngDisp.TabIndex = 40;
            this.ClearAngDisp.Text = "清除数据";
            this.ClearAngDisp.UseVisualStyleBackColor = true;
            this.ClearAngDisp.Click += new System.EventHandler(this.ClearAngDisp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(440, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 242);
            this.tabControl1.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(398, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "运动控制";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.btnMsg8);
            this.tabPage2.Controls.Add(this.MsgBox8);
            this.tabPage2.Controls.Add(this.MsgHex8);
            this.tabPage2.Controls.Add(this.btnMsg7);
            this.tabPage2.Controls.Add(this.MsgBox7);
            this.tabPage2.Controls.Add(this.MsgHex7);
            this.tabPage2.Controls.Add(this.btnMsg6);
            this.tabPage2.Controls.Add(this.MsgBox6);
            this.tabPage2.Controls.Add(this.MsgHex6);
            this.tabPage2.Controls.Add(this.btnMsg5);
            this.tabPage2.Controls.Add(this.MsgBox5);
            this.tabPage2.Controls.Add(this.MsgHex5);
            this.tabPage2.Controls.Add(this.btnMsg4);
            this.tabPage2.Controls.Add(this.MsgBox4);
            this.tabPage2.Controls.Add(this.MsgHex4);
            this.tabPage2.Controls.Add(this.btnMsg3);
            this.tabPage2.Controls.Add(this.MsgBox3);
            this.tabPage2.Controls.Add(this.MsgHex3);
            this.tabPage2.Controls.Add(this.btnMsg2);
            this.tabPage2.Controls.Add(this.MsgBox2);
            this.tabPage2.Controls.Add(this.MsgHex2);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.btnMsg1);
            this.tabPage2.Controls.Add(this.MsgBox1);
            this.tabPage2.Controls.Add(this.MsgHex1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(398, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "批量字串";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(148, 4);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 12);
            this.label31.TabIndex = 26;
            this.label31.Text = "待发送字串";
            // 
            // btnMsg8
            // 
            this.btnMsg8.Location = new System.Drawing.Point(340, 194);
            this.btnMsg8.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg8.Name = "btnMsg8";
            this.btnMsg8.Size = new System.Drawing.Size(56, 21);
            this.btnMsg8.TabIndex = 25;
            this.btnMsg8.Text = "发送";
            this.btnMsg8.UseVisualStyleBackColor = true;
            // 
            // MsgBox8
            // 
            this.MsgBox8.Location = new System.Drawing.Point(22, 194);
            this.MsgBox8.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox8.Name = "MsgBox8";
            this.MsgBox8.Size = new System.Drawing.Size(314, 21);
            this.MsgBox8.TabIndex = 24;
            // 
            // MsgHex8
            // 
            this.MsgHex8.AutoSize = true;
            this.MsgHex8.Location = new System.Drawing.Point(4, 197);
            this.MsgHex8.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex8.Name = "MsgHex8";
            this.MsgHex8.Size = new System.Drawing.Size(15, 14);
            this.MsgHex8.TabIndex = 23;
            this.MsgHex8.UseVisualStyleBackColor = true;
            // 
            // btnMsg7
            // 
            this.btnMsg7.Location = new System.Drawing.Point(340, 170);
            this.btnMsg7.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg7.Name = "btnMsg7";
            this.btnMsg7.Size = new System.Drawing.Size(56, 21);
            this.btnMsg7.TabIndex = 22;
            this.btnMsg7.Text = "发送";
            this.btnMsg7.UseVisualStyleBackColor = true;
            // 
            // MsgBox7
            // 
            this.MsgBox7.Location = new System.Drawing.Point(22, 170);
            this.MsgBox7.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox7.Name = "MsgBox7";
            this.MsgBox7.Size = new System.Drawing.Size(314, 21);
            this.MsgBox7.TabIndex = 21;
            // 
            // MsgHex7
            // 
            this.MsgHex7.AutoSize = true;
            this.MsgHex7.Location = new System.Drawing.Point(4, 172);
            this.MsgHex7.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex7.Name = "MsgHex7";
            this.MsgHex7.Size = new System.Drawing.Size(15, 14);
            this.MsgHex7.TabIndex = 20;
            this.MsgHex7.UseVisualStyleBackColor = true;
            // 
            // btnMsg6
            // 
            this.btnMsg6.Location = new System.Drawing.Point(340, 145);
            this.btnMsg6.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg6.Name = "btnMsg6";
            this.btnMsg6.Size = new System.Drawing.Size(56, 21);
            this.btnMsg6.TabIndex = 19;
            this.btnMsg6.Text = "发送";
            this.btnMsg6.UseVisualStyleBackColor = true;
            // 
            // MsgBox6
            // 
            this.MsgBox6.Location = new System.Drawing.Point(22, 145);
            this.MsgBox6.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox6.Name = "MsgBox6";
            this.MsgBox6.Size = new System.Drawing.Size(314, 21);
            this.MsgBox6.TabIndex = 18;
            // 
            // MsgHex6
            // 
            this.MsgHex6.AutoSize = true;
            this.MsgHex6.Location = new System.Drawing.Point(4, 147);
            this.MsgHex6.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex6.Name = "MsgHex6";
            this.MsgHex6.Size = new System.Drawing.Size(15, 14);
            this.MsgHex6.TabIndex = 17;
            this.MsgHex6.UseVisualStyleBackColor = true;
            // 
            // btnMsg5
            // 
            this.btnMsg5.Location = new System.Drawing.Point(340, 120);
            this.btnMsg5.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg5.Name = "btnMsg5";
            this.btnMsg5.Size = new System.Drawing.Size(56, 21);
            this.btnMsg5.TabIndex = 16;
            this.btnMsg5.Text = "发送";
            this.btnMsg5.UseVisualStyleBackColor = true;
            // 
            // MsgBox5
            // 
            this.MsgBox5.Location = new System.Drawing.Point(22, 120);
            this.MsgBox5.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox5.Name = "MsgBox5";
            this.MsgBox5.Size = new System.Drawing.Size(314, 21);
            this.MsgBox5.TabIndex = 15;
            // 
            // MsgHex5
            // 
            this.MsgHex5.AutoSize = true;
            this.MsgHex5.Location = new System.Drawing.Point(4, 122);
            this.MsgHex5.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex5.Name = "MsgHex5";
            this.MsgHex5.Size = new System.Drawing.Size(15, 14);
            this.MsgHex5.TabIndex = 14;
            this.MsgHex5.UseVisualStyleBackColor = true;
            // 
            // btnMsg4
            // 
            this.btnMsg4.Location = new System.Drawing.Point(340, 95);
            this.btnMsg4.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg4.Name = "btnMsg4";
            this.btnMsg4.Size = new System.Drawing.Size(56, 21);
            this.btnMsg4.TabIndex = 13;
            this.btnMsg4.Text = "发送";
            this.btnMsg4.UseVisualStyleBackColor = true;
            // 
            // MsgBox4
            // 
            this.MsgBox4.Location = new System.Drawing.Point(22, 95);
            this.MsgBox4.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox4.Name = "MsgBox4";
            this.MsgBox4.Size = new System.Drawing.Size(314, 21);
            this.MsgBox4.TabIndex = 12;
            // 
            // MsgHex4
            // 
            this.MsgHex4.AutoSize = true;
            this.MsgHex4.Location = new System.Drawing.Point(4, 98);
            this.MsgHex4.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex4.Name = "MsgHex4";
            this.MsgHex4.Size = new System.Drawing.Size(15, 14);
            this.MsgHex4.TabIndex = 11;
            this.MsgHex4.UseVisualStyleBackColor = true;
            // 
            // btnMsg3
            // 
            this.btnMsg3.Location = new System.Drawing.Point(340, 69);
            this.btnMsg3.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg3.Name = "btnMsg3";
            this.btnMsg3.Size = new System.Drawing.Size(56, 21);
            this.btnMsg3.TabIndex = 10;
            this.btnMsg3.Text = "发送";
            this.btnMsg3.UseVisualStyleBackColor = true;
            // 
            // MsgBox3
            // 
            this.MsgBox3.Location = new System.Drawing.Point(22, 69);
            this.MsgBox3.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox3.Name = "MsgBox3";
            this.MsgBox3.Size = new System.Drawing.Size(314, 21);
            this.MsgBox3.TabIndex = 9;
            // 
            // MsgHex3
            // 
            this.MsgHex3.AutoSize = true;
            this.MsgHex3.Location = new System.Drawing.Point(4, 71);
            this.MsgHex3.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex3.Name = "MsgHex3";
            this.MsgHex3.Size = new System.Drawing.Size(15, 14);
            this.MsgHex3.TabIndex = 8;
            this.MsgHex3.UseVisualStyleBackColor = true;
            // 
            // btnMsg2
            // 
            this.btnMsg2.Location = new System.Drawing.Point(340, 44);
            this.btnMsg2.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg2.Name = "btnMsg2";
            this.btnMsg2.Size = new System.Drawing.Size(56, 21);
            this.btnMsg2.TabIndex = 7;
            this.btnMsg2.Text = "发送";
            this.btnMsg2.UseVisualStyleBackColor = true;
            // 
            // MsgBox2
            // 
            this.MsgBox2.Location = new System.Drawing.Point(22, 44);
            this.MsgBox2.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox2.Name = "MsgBox2";
            this.MsgBox2.Size = new System.Drawing.Size(314, 21);
            this.MsgBox2.TabIndex = 6;
            // 
            // MsgHex2
            // 
            this.MsgHex2.AutoSize = true;
            this.MsgHex2.Location = new System.Drawing.Point(4, 46);
            this.MsgHex2.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex2.Name = "MsgHex2";
            this.MsgHex2.Size = new System.Drawing.Size(15, 14);
            this.MsgHex2.TabIndex = 5;
            this.MsgHex2.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(2, 4);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 12);
            this.label30.TabIndex = 3;
            this.label30.Text = "HEX";
            // 
            // btnMsg1
            // 
            this.btnMsg1.Location = new System.Drawing.Point(340, 18);
            this.btnMsg1.Margin = new System.Windows.Forms.Padding(2);
            this.btnMsg1.Name = "btnMsg1";
            this.btnMsg1.Size = new System.Drawing.Size(56, 21);
            this.btnMsg1.TabIndex = 2;
            this.btnMsg1.Text = "发送";
            this.btnMsg1.UseVisualStyleBackColor = true;
            // 
            // MsgBox1
            // 
            this.MsgBox1.Location = new System.Drawing.Point(22, 18);
            this.MsgBox1.Margin = new System.Windows.Forms.Padding(2);
            this.MsgBox1.Name = "MsgBox1";
            this.MsgBox1.Size = new System.Drawing.Size(314, 21);
            this.MsgBox1.TabIndex = 1;
            // 
            // MsgHex1
            // 
            this.MsgHex1.AutoSize = true;
            this.MsgHex1.Location = new System.Drawing.Point(4, 21);
            this.MsgHex1.Margin = new System.Windows.Forms.Padding(2);
            this.MsgHex1.Name = "MsgHex1";
            this.MsgHex1.Size = new System.Drawing.Size(15, 14);
            this.MsgHex1.TabIndex = 0;
            this.MsgHex1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.RealDist);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.ClearImage);
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.MapBox);
            this.tabPage3.Controls.Add(this.OpenImage);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(398, 216);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "行走路线";
            // 
            // RealDist
            // 
            this.RealDist.Location = new System.Drawing.Point(349, 127);
            this.RealDist.Margin = new System.Windows.Forms.Padding(2);
            this.RealDist.Mask = "99.99";
            this.RealDist.Name = "RealDist";
            this.RealDist.RejectInputOnFirstFailure = true;
            this.RealDist.Size = new System.Drawing.Size(44, 21);
            this.RealDist.TabIndex = 12;
            this.RealDist.TextChanged += new System.EventHandler(this.RealDist_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(332, 113);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(53, 12);
            this.label39.TabIndex = 10;
            this.label39.Text = "距离(m):";
            // 
            // ClearImage
            // 
            this.ClearImage.Location = new System.Drawing.Point(334, 189);
            this.ClearImage.Margin = new System.Windows.Forms.Padding(2);
            this.ClearImage.Name = "ClearImage";
            this.ClearImage.Size = new System.Drawing.Size(64, 25);
            this.ClearImage.TabIndex = 9;
            this.ClearImage.Text = "清除锚点";
            this.ClearImage.UseVisualStyleBackColor = true;
            this.ClearImage.Click += new System.EventHandler(this.ClearImage_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(345, 101);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 12);
            this.label38.TabIndex = 8;
            this.label38.Text = "0,0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(332, 86);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 12);
            this.label37.TabIndex = 7;
            this.label37.Text = "鼠标位置:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(345, 74);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 12);
            this.label36.TabIndex = 6;
            this.label36.Text = "0,0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(332, 62);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 12);
            this.label35.TabIndex = 5;
            this.label35.Text = "末尾点:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(345, 47);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 12);
            this.label34.TabIndex = 4;
            this.label34.Text = "0,0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(332, 32);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 12);
            this.label33.TabIndex = 3;
            this.label33.Text = "起始点:";
            // 
            // MapBox
            // 
            this.MapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MapBox.Location = new System.Drawing.Point(2, 2);
            this.MapBox.Margin = new System.Windows.Forms.Padding(2);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(327, 214);
            this.MapBox.TabIndex = 2;
            this.MapBox.TabStop = false;
            this.MapBox.Click += new System.EventHandler(this.MapBox_Click);
            this.MapBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapBox_MouseMove);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(334, 2);
            this.OpenImage.Margin = new System.Windows.Forms.Padding(2);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(64, 25);
            this.OpenImage.TabIndex = 1;
            this.OpenImage.Text = "打开";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.BthSendBox);
            this.tabPage4.Controls.Add(this.BthRecvBox);
            this.tabPage4.Controls.Add(this.BthSendBtn);
            this.tabPage4.Controls.Add(this.BthConnectBtn);
            this.tabPage4.Controls.Add(this.BthListenBtn);
            this.tabPage4.Controls.Add(this.BthDispBtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(398, 216);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "蓝牙模块";
            // 
            // BthConnectBtn
            // 
            this.BthConnectBtn.Location = new System.Drawing.Point(155, 176);
            this.BthConnectBtn.Name = "BthConnectBtn";
            this.BthConnectBtn.Size = new System.Drawing.Size(69, 24);
            this.BthConnectBtn.TabIndex = 2;
            this.BthConnectBtn.Text = "连接";
            this.BthConnectBtn.UseVisualStyleBackColor = true;
            this.BthConnectBtn.Click += new System.EventHandler(this.BthConnectBtn_Click);
            // 
            // BthListenBtn
            // 
            this.BthListenBtn.Location = new System.Drawing.Point(80, 176);
            this.BthListenBtn.Name = "BthListenBtn";
            this.BthListenBtn.Size = new System.Drawing.Size(69, 24);
            this.BthListenBtn.TabIndex = 1;
            this.BthListenBtn.Text = "监听";
            this.BthListenBtn.UseVisualStyleBackColor = true;
            this.BthListenBtn.Click += new System.EventHandler(this.BthListenBtn_Click);
            // 
            // BthDispBtn
            // 
            this.BthDispBtn.Location = new System.Drawing.Point(5, 176);
            this.BthDispBtn.Name = "BthDispBtn";
            this.BthDispBtn.Size = new System.Drawing.Size(69, 24);
            this.BthDispBtn.TabIndex = 0;
            this.BthDispBtn.Text = "设备可见";
            this.BthDispBtn.UseVisualStyleBackColor = true;
            this.BthDispBtn.Click += new System.EventHandler(this.BthDispBtn_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(34, 335);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(365, 12);
            this.label32.TabIndex = 58;
            this.label32.Text = "若无法从其他终端上通过网络连接此程序，请允许此程序通过防火墙";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Default";
            this.openFileDialog1.Filter = "所有文件|*.*|图片文件|*.jpg;*.png;*.bmp;*.JPG;*.BMP;*.PNG";
            // 
            // MemTimer
            // 
            this.MemTimer.Enabled = true;
            this.MemTimer.Interval = 500;
            this.MemTimer.Tick += new System.EventHandler(this.MemTimer_Tick);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(683, 335);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 12);
            this.label40.TabIndex = 59;
            this.label40.Text = "内存用量:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(744, 335);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 12);
            this.label41.TabIndex = 60;
            this.label41.Text = "0.0%";
            // 
            // BthSendBtn
            // 
            this.BthSendBtn.Location = new System.Drawing.Point(229, 176);
            this.BthSendBtn.Name = "BthSendBtn";
            this.BthSendBtn.Size = new System.Drawing.Size(69, 24);
            this.BthSendBtn.TabIndex = 3;
            this.BthSendBtn.Text = "发送";
            this.BthSendBtn.UseVisualStyleBackColor = true;
            this.BthSendBtn.Click += new System.EventHandler(this.BthSendBtn_Click);
            // 
            // BthRecvBox
            // 
            this.BthRecvBox.Location = new System.Drawing.Point(5, 4);
            this.BthRecvBox.Multiline = true;
            this.BthRecvBox.Name = "BthRecvBox";
            this.BthRecvBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BthRecvBox.Size = new System.Drawing.Size(293, 136);
            this.BthRecvBox.TabIndex = 4;
            // 
            // BthSendBox
            // 
            this.BthSendBox.Location = new System.Drawing.Point(5, 149);
            this.BthSendBox.Name = "BthSendBox";
            this.BthSendBox.Size = new System.Drawing.Size(219, 21);
            this.BthSendBox.TabIndex = 5;
            // 
            // UpperApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(850, 352);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Infotext);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UpperApp";
            this.Opacity = 0.98D;
            this.Text = "小车上位机V5.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpperApp_FormClosing);
            this.Load += new System.EventHandler(this.UpperApp_Load);
            this.Move += new System.EventHandler(this.UpperApp_Move);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FBBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Infotext;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox RecvBox;
        private System.Windows.Forms.TextBox SendBox;
        private System.Windows.Forms.ComboBox SerPortItem;
        private System.Windows.Forms.CheckBox btnAutoSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnChar;
        private System.Windows.Forms.RadioButton rbtnHex;
        private System.Windows.Forms.Timer SendTimer;
        private System.Windows.Forms.Button btnBegin;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.TrackBar FBBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label FBtext;
        private System.Windows.Forms.TrackBar RLBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RLtext;
        private System.Windows.Forms.Button btnNoRL;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabYaw;
        private System.Windows.Forms.Label LabRoll;
        private System.Windows.Forms.Label LabPitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabDist;
        private System.Windows.Forms.Button btnclRecv;
        private System.Windows.Forms.Button btnclSend;
        private System.Windows.Forms.TextBox Tim;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox smallChange;
        private System.Windows.Forms.Button Rocker;
        private System.Windows.Forms.CheckBox ReDisp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox AngDirDisp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnSerial;
        private System.Windows.Forms.RadioButton rbtnNET;
        private System.Windows.Forms.ComboBox NetType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox HostIP;
        private System.Windows.Forms.Button ClearAngDisp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        //private System.Windows.Forms.CheckBox[] checks = new System.Windows.Forms.CheckBox[8];
        private System.Windows.Forms.Button btnMsg1;
        private System.Windows.Forms.TextBox MsgBox1;
        private System.Windows.Forms.CheckBox MsgHex1;
        private System.Windows.Forms.Button btnMsg8;
        private System.Windows.Forms.TextBox MsgBox8;
        private System.Windows.Forms.CheckBox MsgHex8;
        private System.Windows.Forms.Button btnMsg7;
        private System.Windows.Forms.TextBox MsgBox7;
        private System.Windows.Forms.CheckBox MsgHex7;
        private System.Windows.Forms.Button btnMsg6;
        private System.Windows.Forms.TextBox MsgBox6;
        private System.Windows.Forms.CheckBox MsgHex6;
        private System.Windows.Forms.Button btnMsg5;
        private System.Windows.Forms.TextBox MsgBox5;
        private System.Windows.Forms.CheckBox MsgHex5;
        private System.Windows.Forms.Button btnMsg4;
        private System.Windows.Forms.TextBox MsgBox4;
        private System.Windows.Forms.CheckBox MsgHex4;
        private System.Windows.Forms.Button btnMsg3;
        private System.Windows.Forms.TextBox MsgBox3;
        private System.Windows.Forms.CheckBox MsgHex3;
        private System.Windows.Forms.Button btnMsg2;
        private System.Windows.Forms.TextBox MsgBox2;
        private System.Windows.Forms.CheckBox MsgHex2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.PictureBox MapBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button ClearImage;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.MaskedTextBox RealDist;
        private System.Windows.Forms.Timer MemTimer;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox Peer;
        private System.Windows.Forms.CheckBox SaveData;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button BthListenBtn;
        private System.Windows.Forms.Button BthDispBtn;
        private System.Windows.Forms.Button BthConnectBtn;
        private System.Windows.Forms.Button BthSendBtn;
        private System.Windows.Forms.TextBox BthSendBox;
        private System.Windows.Forms.TextBox BthRecvBox;
    }
}

