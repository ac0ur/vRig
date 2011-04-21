namespace vRig
{
    partial class Form1
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
            this.frequency_display = new System.Windows.Forms.NumericUpDown();
            this.lbl_LSB = new System.Windows.Forms.Label();
            this.lbl_USB = new System.Windows.Forms.Label();
            this.lbl_CW = new System.Windows.Forms.Label();
            this.lbl_N = new System.Windows.Forms.Label();
            this.lbl_AM = new System.Windows.Forms.Label();
            this.lbl_FM = new System.Windows.Forms.Label();
            this.lbl_VFOA = new System.Windows.Forms.Label();
            this.lbl_VFOB = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lbl_MEMO = new System.Windows.Forms.Label();
            this.btn_SSB = new System.Windows.Forms.Button();
            this.btn_CWN = new System.Windows.Forms.Button();
            this.btn_AMFM = new System.Windows.Forms.Button();
            this.btn_VFO = new System.Windows.Forms.Button();
            this.btn_SPLIT = new System.Windows.Forms.Button();
            this.btn_AeqB = new System.Windows.Forms.Button();
            this.btn_MEMO = new System.Windows.Forms.Button();
            this.btn_MSCAN = new System.Windows.Forms.Button();
            this.btn_PSCAN = new System.Windows.Forms.Button();
            this.btn_MtoVFO = new System.Windows.Forms.Button();
            this.btn_MW = new System.Windows.Forms.Button();
            this.btn_100Hz = new System.Windows.Forms.Button();
            this.btn_1kHz = new System.Windows.Forms.Button();
            this.btn_1MHz = new System.Windows.Forms.Button();
            this.PollTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_SPLIT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baudRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.parityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dTROnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTSOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC271ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC275ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC375ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC471ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC475ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC575ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.iC7000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC703ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC706ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC706MkIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC706MkIIGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC707ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC718ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC7200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC725ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC726ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC728ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC729ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC735ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC736ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC737ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC738ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC7400ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC746ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC751AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC756ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC756ProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC756ProIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC756ProIIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC761ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC765ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC775ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC7700ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC78ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC7800ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC781ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC820ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC821ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC910ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC970ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC1271ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iC1275ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCX3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iD1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaesuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kenwoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutVRigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frequency_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // frequency_display
            // 
            this.frequency_display.DecimalPlaces = 2;
            this.frequency_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequency_display.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frequency_display.Location = new System.Drawing.Point(18, 66);
            this.frequency_display.Maximum = new decimal(new int[] {
            33000,
            0,
            0,
            0});
            this.frequency_display.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.frequency_display.Name = "frequency_display";
            this.frequency_display.Size = new System.Drawing.Size(379, 80);
            this.frequency_display.TabIndex = 2;
            this.frequency_display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequency_display.ThousandsSeparator = true;
            this.frequency_display.Value = new decimal(new int[] {
            140700,
            0,
            0,
            65536});
            this.frequency_display.ValueChanged += new System.EventHandler(this.frequency_display_ValueChanged);
            // 
            // lbl_LSB
            // 
            this.lbl_LSB.AutoSize = true;
            this.lbl_LSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LSB.Location = new System.Drawing.Point(11, 26);
            this.lbl_LSB.Name = "lbl_LSB";
            this.lbl_LSB.Size = new System.Drawing.Size(77, 37);
            this.lbl_LSB.TabIndex = 3;
            this.lbl_LSB.Text = "LSB";
            this.lbl_LSB.Visible = false;
            // 
            // lbl_USB
            // 
            this.lbl_USB.AutoSize = true;
            this.lbl_USB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_USB.Location = new System.Drawing.Point(82, 26);
            this.lbl_USB.Name = "lbl_USB";
            this.lbl_USB.Size = new System.Drawing.Size(82, 37);
            this.lbl_USB.TabIndex = 4;
            this.lbl_USB.Text = "USB";
            this.lbl_USB.Visible = false;
            // 
            // lbl_CW
            // 
            this.lbl_CW.AutoSize = true;
            this.lbl_CW.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CW.Location = new System.Drawing.Point(159, 26);
            this.lbl_CW.Name = "lbl_CW";
            this.lbl_CW.Size = new System.Drawing.Size(71, 37);
            this.lbl_CW.TabIndex = 5;
            this.lbl_CW.Text = "CW";
            this.lbl_CW.Visible = false;
            // 
            // lbl_N
            // 
            this.lbl_N.AutoSize = true;
            this.lbl_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_N.Location = new System.Drawing.Point(219, 26);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(51, 37);
            this.lbl_N.TabIndex = 6;
            this.lbl_N.Text = "-N";
            this.lbl_N.Visible = false;
            // 
            // lbl_AM
            // 
            this.lbl_AM.AutoSize = true;
            this.lbl_AM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AM.Location = new System.Drawing.Point(276, 26);
            this.lbl_AM.Name = "lbl_AM";
            this.lbl_AM.Size = new System.Drawing.Size(65, 37);
            this.lbl_AM.TabIndex = 7;
            this.lbl_AM.Text = "AM";
            this.lbl_AM.Visible = false;
            // 
            // lbl_FM
            // 
            this.lbl_FM.AutoSize = true;
            this.lbl_FM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FM.Location = new System.Drawing.Point(347, 26);
            this.lbl_FM.Name = "lbl_FM";
            this.lbl_FM.Size = new System.Drawing.Size(63, 37);
            this.lbl_FM.TabIndex = 8;
            this.lbl_FM.Text = "FM";
            this.lbl_FM.Visible = false;
            // 
            // lbl_VFOA
            // 
            this.lbl_VFOA.AutoSize = true;
            this.lbl_VFOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VFOA.Location = new System.Drawing.Point(403, 63);
            this.lbl_VFOA.Name = "lbl_VFOA";
            this.lbl_VFOA.Size = new System.Drawing.Size(115, 37);
            this.lbl_VFOA.TabIndex = 9;
            this.lbl_VFOA.Text = "VFO A";
            this.lbl_VFOA.Visible = false;
            // 
            // lbl_VFOB
            // 
            this.lbl_VFOB.AutoSize = true;
            this.lbl_VFOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VFOB.Location = new System.Drawing.Point(403, 100);
            this.lbl_VFOB.Name = "lbl_VFOB";
            this.lbl_VFOB.Size = new System.Drawing.Size(114, 37);
            this.lbl_VFOB.TabIndex = 10;
            this.lbl_VFOB.Text = "VFO B";
            this.lbl_VFOB.Visible = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(541, 66);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(99, 80);
            this.numericUpDown3.TabIndex = 11;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown3.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // lbl_MEMO
            // 
            this.lbl_MEMO.AutoSize = true;
            this.lbl_MEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MEMO.Location = new System.Drawing.Point(525, 26);
            this.lbl_MEMO.Name = "lbl_MEMO";
            this.lbl_MEMO.Size = new System.Drawing.Size(115, 37);
            this.lbl_MEMO.TabIndex = 12;
            this.lbl_MEMO.Text = "MEMO";
            this.lbl_MEMO.Visible = false;
            // 
            // btn_SSB
            // 
            this.btn_SSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SSB.Location = new System.Drawing.Point(11, 152);
            this.btn_SSB.Name = "btn_SSB";
            this.btn_SSB.Size = new System.Drawing.Size(114, 38);
            this.btn_SSB.TabIndex = 13;
            this.btn_SSB.Text = "SSB";
            this.btn_SSB.UseVisualStyleBackColor = true;
            this.btn_SSB.Click += new System.EventHandler(this.btn_SSB_Click);
            // 
            // btn_CWN
            // 
            this.btn_CWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CWN.Location = new System.Drawing.Point(131, 152);
            this.btn_CWN.Name = "btn_CWN";
            this.btn_CWN.Size = new System.Drawing.Size(114, 38);
            this.btn_CWN.TabIndex = 14;
            this.btn_CWN.Text = "CW / N";
            this.btn_CWN.UseVisualStyleBackColor = true;
            this.btn_CWN.Click += new System.EventHandler(this.btn_CWN_Click);
            // 
            // btn_AMFM
            // 
            this.btn_AMFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AMFM.Location = new System.Drawing.Point(251, 152);
            this.btn_AMFM.Name = "btn_AMFM";
            this.btn_AMFM.Size = new System.Drawing.Size(114, 38);
            this.btn_AMFM.TabIndex = 15;
            this.btn_AMFM.Text = "AM / FM";
            this.btn_AMFM.UseVisualStyleBackColor = true;
            this.btn_AMFM.Click += new System.EventHandler(this.btn_AMFM_Click);
            // 
            // btn_VFO
            // 
            this.btn_VFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VFO.Location = new System.Drawing.Point(371, 152);
            this.btn_VFO.Name = "btn_VFO";
            this.btn_VFO.Size = new System.Drawing.Size(130, 38);
            this.btn_VFO.TabIndex = 16;
            this.btn_VFO.Text = "VFO";
            this.btn_VFO.UseVisualStyleBackColor = true;
            this.btn_VFO.Click += new System.EventHandler(this.btn_VFO_Click);
            // 
            // btn_SPLIT
            // 
            this.btn_SPLIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SPLIT.Location = new System.Drawing.Point(507, 152);
            this.btn_SPLIT.Name = "btn_SPLIT";
            this.btn_SPLIT.Size = new System.Drawing.Size(130, 38);
            this.btn_SPLIT.TabIndex = 17;
            this.btn_SPLIT.Text = "SPLIT";
            this.btn_SPLIT.UseVisualStyleBackColor = true;
            this.btn_SPLIT.Click += new System.EventHandler(this.btn_SPLIT_Click);
            // 
            // btn_AeqB
            // 
            this.btn_AeqB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AeqB.Location = new System.Drawing.Point(507, 196);
            this.btn_AeqB.Name = "btn_AeqB";
            this.btn_AeqB.Size = new System.Drawing.Size(130, 38);
            this.btn_AeqB.TabIndex = 18;
            this.btn_AeqB.Text = "A = B";
            this.btn_AeqB.UseVisualStyleBackColor = true;
            this.btn_AeqB.Click += new System.EventHandler(this.btn_AeqB_Click);
            // 
            // btn_MEMO
            // 
            this.btn_MEMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MEMO.Location = new System.Drawing.Point(371, 285);
            this.btn_MEMO.Name = "btn_MEMO";
            this.btn_MEMO.Size = new System.Drawing.Size(130, 38);
            this.btn_MEMO.TabIndex = 19;
            this.btn_MEMO.Text = "MEMO";
            this.btn_MEMO.UseVisualStyleBackColor = true;
            this.btn_MEMO.Click += new System.EventHandler(this.btn_MEMO_Click);
            // 
            // btn_MSCAN
            // 
            this.btn_MSCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MSCAN.Location = new System.Drawing.Point(371, 241);
            this.btn_MSCAN.Name = "btn_MSCAN";
            this.btn_MSCAN.Size = new System.Drawing.Size(130, 38);
            this.btn_MSCAN.TabIndex = 20;
            this.btn_MSCAN.Text = "M. SCAN";
            this.btn_MSCAN.UseVisualStyleBackColor = true;
            this.btn_MSCAN.Click += new System.EventHandler(this.btn_MSCAN_Click);
            // 
            // btn_PSCAN
            // 
            this.btn_PSCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PSCAN.Location = new System.Drawing.Point(507, 241);
            this.btn_PSCAN.Name = "btn_PSCAN";
            this.btn_PSCAN.Size = new System.Drawing.Size(130, 38);
            this.btn_PSCAN.TabIndex = 21;
            this.btn_PSCAN.Text = "P. SCAN";
            this.btn_PSCAN.UseVisualStyleBackColor = true;
            this.btn_PSCAN.Click += new System.EventHandler(this.btn_PSCAN_Click);
            // 
            // btn_MtoVFO
            // 
            this.btn_MtoVFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MtoVFO.Location = new System.Drawing.Point(371, 196);
            this.btn_MtoVFO.Name = "btn_MtoVFO";
            this.btn_MtoVFO.Size = new System.Drawing.Size(130, 38);
            this.btn_MtoVFO.TabIndex = 22;
            this.btn_MtoVFO.Text = "M > VFO";
            this.btn_MtoVFO.UseVisualStyleBackColor = true;
            // 
            // btn_MW
            // 
            this.btn_MW.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MW.Location = new System.Drawing.Point(510, 285);
            this.btn_MW.Name = "btn_MW";
            this.btn_MW.Size = new System.Drawing.Size(130, 38);
            this.btn_MW.TabIndex = 23;
            this.btn_MW.Text = "MW";
            this.btn_MW.UseVisualStyleBackColor = true;
            this.btn_MW.Click += new System.EventHandler(this.btn_MW_Click);
            // 
            // btn_100Hz
            // 
            this.btn_100Hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100Hz.Location = new System.Drawing.Point(251, 196);
            this.btn_100Hz.Name = "btn_100Hz";
            this.btn_100Hz.Size = new System.Drawing.Size(114, 38);
            this.btn_100Hz.TabIndex = 24;
            this.btn_100Hz.Text = "100 Hz";
            this.btn_100Hz.UseVisualStyleBackColor = true;
            this.btn_100Hz.Click += new System.EventHandler(this.btn_100Hz_Click);
            // 
            // btn_1kHz
            // 
            this.btn_1kHz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1kHz.Location = new System.Drawing.Point(131, 196);
            this.btn_1kHz.Name = "btn_1kHz";
            this.btn_1kHz.Size = new System.Drawing.Size(114, 38);
            this.btn_1kHz.TabIndex = 25;
            this.btn_1kHz.Text = "1 kHz";
            this.btn_1kHz.UseVisualStyleBackColor = true;
            this.btn_1kHz.Click += new System.EventHandler(this.btn_1kHz_Click);
            // 
            // btn_1MHz
            // 
            this.btn_1MHz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1MHz.Location = new System.Drawing.Point(11, 196);
            this.btn_1MHz.Name = "btn_1MHz";
            this.btn_1MHz.Size = new System.Drawing.Size(114, 38);
            this.btn_1MHz.TabIndex = 26;
            this.btn_1MHz.Text = "1 MHz";
            this.btn_1MHz.UseVisualStyleBackColor = true;
            this.btn_1MHz.Click += new System.EventHandler(this.btn_1MHz_Click);
            // 
            // PollTimer
            // 
            this.PollTimer.Interval = 500;
            this.PollTimer.Tick += new System.EventHandler(this.PollTimer_Tick);
            // 
            // lbl_SPLIT
            // 
            this.lbl_SPLIT.AutoSize = true;
            this.lbl_SPLIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SPLIT.Location = new System.Drawing.Point(416, 26);
            this.lbl_SPLIT.Name = "lbl_SPLIT";
            this.lbl_SPLIT.Size = new System.Drawing.Size(105, 37);
            this.lbl_SPLIT.TabIndex = 27;
            this.lbl_SPLIT.Text = "SPLIT";
            this.lbl_SPLIT.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPortToolStripMenuItem,
            this.radioToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // cOMPortToolStripMenuItem
            // 
            this.cOMPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortToolStripMenuItem,
            this.baudRateToolStripMenuItem,
            this.parityToolStripMenuItem,
            this.dataBitsToolStripMenuItem,
            this.stopBitsToolStripMenuItem,
            this.dTROnToolStripMenuItem,
            this.rTSOnToolStripMenuItem});
            this.cOMPortToolStripMenuItem.Name = "cOMPortToolStripMenuItem";
            this.cOMPortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cOMPortToolStripMenuItem.Text = "COM Port";
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            // 
            // baudRateToolStripMenuItem
            // 
            this.baudRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.baudRateToolStripMenuItem.Name = "baudRateToolStripMenuItem";
            this.baudRateToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.baudRateToolStripMenuItem.Text = "Baud Rate";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem2.Text = "300";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem3.Text = "1200";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem4.Text = "2400";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem5.Text = "4800";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem6.Text = "9600";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem7.Text = "14,400";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem8.Text = "19,200";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem9.Text = "38,400";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem10.Text = "57,600";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.setBaudRate);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem11.Text = "115,200";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.setBaudRate);
            // 
            // parityToolStripMenuItem
            // 
            this.parityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.evenToolStripMenuItem,
            this.oddToolStripMenuItem});
            this.parityToolStripMenuItem.Enabled = false;
            this.parityToolStripMenuItem.Name = "parityToolStripMenuItem";
            this.parityToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.parityToolStripMenuItem.Text = "Parity";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // evenToolStripMenuItem
            // 
            this.evenToolStripMenuItem.Name = "evenToolStripMenuItem";
            this.evenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.evenToolStripMenuItem.Text = "Even";
            // 
            // oddToolStripMenuItem
            // 
            this.oddToolStripMenuItem.Name = "oddToolStripMenuItem";
            this.oddToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.oddToolStripMenuItem.Text = "Odd";
            // 
            // dataBitsToolStripMenuItem
            // 
            this.dataBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitsToolStripMenuItem,
            this.bitsToolStripMenuItem1});
            this.dataBitsToolStripMenuItem.Enabled = false;
            this.dataBitsToolStripMenuItem.Name = "dataBitsToolStripMenuItem";
            this.dataBitsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dataBitsToolStripMenuItem.Text = "Data Bits";
            // 
            // bitsToolStripMenuItem
            // 
            this.bitsToolStripMenuItem.Name = "bitsToolStripMenuItem";
            this.bitsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.bitsToolStripMenuItem.Text = "7 Bits";
            // 
            // bitsToolStripMenuItem1
            // 
            this.bitsToolStripMenuItem1.Name = "bitsToolStripMenuItem1";
            this.bitsToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.bitsToolStripMenuItem1.Text = "8 Bits";
            // 
            // stopBitsToolStripMenuItem
            // 
            this.stopBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitToolStripMenuItem,
            this.bitToolStripMenuItem1});
            this.stopBitsToolStripMenuItem.Enabled = false;
            this.stopBitsToolStripMenuItem.Name = "stopBitsToolStripMenuItem";
            this.stopBitsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.stopBitsToolStripMenuItem.Text = "Stop Bits";
            // 
            // bitToolStripMenuItem
            // 
            this.bitToolStripMenuItem.Name = "bitToolStripMenuItem";
            this.bitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem.Text = "1 Bit";
            // 
            // bitToolStripMenuItem1
            // 
            this.bitToolStripMenuItem1.Name = "bitToolStripMenuItem1";
            this.bitToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.bitToolStripMenuItem1.Text = "2 Bit";
            // 
            // dTROnToolStripMenuItem
            // 
            this.dTROnToolStripMenuItem.Name = "dTROnToolStripMenuItem";
            this.dTROnToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dTROnToolStripMenuItem.Text = "DTR On";
            // 
            // rTSOnToolStripMenuItem
            // 
            this.rTSOnToolStripMenuItem.Name = "rTSOnToolStripMenuItem";
            this.rTSOnToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rTSOnToolStripMenuItem.Text = "RTS On";
            // 
            // radioToolStripMenuItem
            // 
            this.radioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.icomToolStripMenuItem,
            this.yaesuToolStripMenuItem,
            this.kenwoodToolStripMenuItem});
            this.radioToolStripMenuItem.Name = "radioToolStripMenuItem";
            this.radioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.radioToolStripMenuItem.Text = "Radio";
            // 
            // icomToolStripMenuItem
            // 
            this.icomToolStripMenuItem.Checked = true;
            this.icomToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.icomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iC271ToolStripMenuItem,
            this.iC275ToolStripMenuItem,
            this.iC375ToolStripMenuItem,
            this.iC471ToolStripMenuItem,
            this.iC475ToolStripMenuItem,
            this.iC575ToolStripMenu,
            this.iC7000ToolStripMenuItem,
            this.iC703ToolStripMenuItem,
            this.iC706ToolStripMenuItem,
            this.iC706MkIIToolStripMenuItem,
            this.iC706MkIIGToolStripMenuItem,
            this.iC707ToolStripMenuItem,
            this.iC718ToolStripMenuItem,
            this.iC7200ToolStripMenuItem,
            this.iC725ToolStripMenuItem,
            this.iC726ToolStripMenuItem,
            this.iC728ToolStripMenuItem,
            this.iC729ToolStripMenuItem,
            this.iC735ToolStripMenuItem,
            this.iC736ToolStripMenuItem,
            this.iC737ToolStripMenuItem,
            this.iC738ToolStripMenuItem,
            this.iC7400ToolStripMenuItem,
            this.iC746ToolStripMenuItem,
            this.iC751AToolStripMenuItem,
            this.iC756ToolStripMenuItem,
            this.iC756ProToolStripMenuItem,
            this.iC756ProIIToolStripMenuItem,
            this.iC756ProIIIToolStripMenuItem,
            this.iC761ToolStripMenuItem,
            this.iC765ToolStripMenuItem,
            this.iC775ToolStripMenuItem,
            this.iC7700ToolStripMenuItem,
            this.iC78ToolStripMenuItem,
            this.iC7800ToolStripMenuItem,
            this.iC781ToolStripMenuItem,
            this.iC820ToolStripMenuItem,
            this.iC821ToolStripMenuItem,
            this.iC910ToolStripMenuItem,
            this.iC970ToolStripMenuItem,
            this.iC1271ToolStripMenuItem,
            this.iC1275ToolStripMenuItem,
            this.iCX3ToolStripMenuItem,
            this.iD1ToolStripMenuItem});
            this.icomToolStripMenuItem.Name = "icomToolStripMenuItem";
            this.icomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.icomToolStripMenuItem.Text = "Icom";
            // 
            // iC271ToolStripMenuItem
            // 
            this.iC271ToolStripMenuItem.Name = "iC271ToolStripMenuItem";
            this.iC271ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC271ToolStripMenuItem.Text = "IC-271";
            this.iC271ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC275ToolStripMenuItem
            // 
            this.iC275ToolStripMenuItem.Name = "iC275ToolStripMenuItem";
            this.iC275ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC275ToolStripMenuItem.Text = "IC-275";
            this.iC275ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC375ToolStripMenuItem
            // 
            this.iC375ToolStripMenuItem.Name = "iC375ToolStripMenuItem";
            this.iC375ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC375ToolStripMenuItem.Text = "IC-375";
            this.iC375ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC471ToolStripMenuItem
            // 
            this.iC471ToolStripMenuItem.Name = "iC471ToolStripMenuItem";
            this.iC471ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC471ToolStripMenuItem.Text = "IC-471";
            this.iC471ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC475ToolStripMenuItem
            // 
            this.iC475ToolStripMenuItem.Name = "iC475ToolStripMenuItem";
            this.iC475ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC475ToolStripMenuItem.Text = "IC-575";
            this.iC475ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC575ToolStripMenu
            // 
            this.iC575ToolStripMenu.Name = "iC575ToolStripMenu";
            this.iC575ToolStripMenu.Size = new System.Drawing.Size(177, 22);
            this.iC575ToolStripMenu.Text = "IC-575";
            this.iC575ToolStripMenu.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC7000ToolStripMenuItem
            // 
            this.iC7000ToolStripMenuItem.Name = "iC7000ToolStripMenuItem";
            this.iC7000ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC7000ToolStripMenuItem.Text = "IC-7000";
            this.iC7000ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC703ToolStripMenuItem
            // 
            this.iC703ToolStripMenuItem.Name = "iC703ToolStripMenuItem";
            this.iC703ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC703ToolStripMenuItem.Text = "IC-703";
            this.iC703ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC706ToolStripMenuItem
            // 
            this.iC706ToolStripMenuItem.Name = "iC706ToolStripMenuItem";
            this.iC706ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC706ToolStripMenuItem.Text = "IC-706";
            this.iC706ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC706MkIIToolStripMenuItem
            // 
            this.iC706MkIIToolStripMenuItem.Name = "iC706MkIIToolStripMenuItem";
            this.iC706MkIIToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC706MkIIToolStripMenuItem.Text = "IC-706MkII";
            this.iC706MkIIToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC706MkIIGToolStripMenuItem
            // 
            this.iC706MkIIGToolStripMenuItem.Name = "iC706MkIIGToolStripMenuItem";
            this.iC706MkIIGToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC706MkIIGToolStripMenuItem.Text = "IC-706MkIIG";
            this.iC706MkIIGToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC707ToolStripMenuItem
            // 
            this.iC707ToolStripMenuItem.Name = "iC707ToolStripMenuItem";
            this.iC707ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC707ToolStripMenuItem.Text = "IC-707";
            this.iC707ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC718ToolStripMenuItem
            // 
            this.iC718ToolStripMenuItem.Name = "iC718ToolStripMenuItem";
            this.iC718ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC718ToolStripMenuItem.Text = "IC-718";
            this.iC718ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC7200ToolStripMenuItem
            // 
            this.iC7200ToolStripMenuItem.Name = "iC7200ToolStripMenuItem";
            this.iC7200ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC7200ToolStripMenuItem.Text = "IC-7200";
            this.iC7200ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC725ToolStripMenuItem
            // 
            this.iC725ToolStripMenuItem.Checked = true;
            this.iC725ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iC725ToolStripMenuItem.Name = "iC725ToolStripMenuItem";
            this.iC725ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC725ToolStripMenuItem.Text = "IC-725";
            this.iC725ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC726ToolStripMenuItem
            // 
            this.iC726ToolStripMenuItem.Name = "iC726ToolStripMenuItem";
            this.iC726ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC726ToolStripMenuItem.Text = "IC-726";
            this.iC726ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC728ToolStripMenuItem
            // 
            this.iC728ToolStripMenuItem.Name = "iC728ToolStripMenuItem";
            this.iC728ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC728ToolStripMenuItem.Text = "IC-728";
            this.iC728ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC729ToolStripMenuItem
            // 
            this.iC729ToolStripMenuItem.Name = "iC729ToolStripMenuItem";
            this.iC729ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC729ToolStripMenuItem.Text = "IC-729";
            this.iC729ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC735ToolStripMenuItem
            // 
            this.iC735ToolStripMenuItem.Name = "iC735ToolStripMenuItem";
            this.iC735ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC735ToolStripMenuItem.Text = "IC-735";
            this.iC735ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC736ToolStripMenuItem
            // 
            this.iC736ToolStripMenuItem.Name = "iC736ToolStripMenuItem";
            this.iC736ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC736ToolStripMenuItem.Text = "IC-736";
            this.iC736ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC737ToolStripMenuItem
            // 
            this.iC737ToolStripMenuItem.Name = "iC737ToolStripMenuItem";
            this.iC737ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC737ToolStripMenuItem.Text = "IC-737";
            this.iC737ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC738ToolStripMenuItem
            // 
            this.iC738ToolStripMenuItem.Name = "iC738ToolStripMenuItem";
            this.iC738ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC738ToolStripMenuItem.Text = "IC-738";
            this.iC738ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC7400ToolStripMenuItem
            // 
            this.iC7400ToolStripMenuItem.Name = "iC7400ToolStripMenuItem";
            this.iC7400ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC7400ToolStripMenuItem.Text = "IC-7400 / IC-746Pro";
            this.iC7400ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC746ToolStripMenuItem
            // 
            this.iC746ToolStripMenuItem.Name = "iC746ToolStripMenuItem";
            this.iC746ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC746ToolStripMenuItem.Text = "IC-746";
            this.iC746ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC751AToolStripMenuItem
            // 
            this.iC751AToolStripMenuItem.Name = "iC751AToolStripMenuItem";
            this.iC751AToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC751AToolStripMenuItem.Text = "IC-751A";
            this.iC751AToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC756ToolStripMenuItem
            // 
            this.iC756ToolStripMenuItem.Name = "iC756ToolStripMenuItem";
            this.iC756ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC756ToolStripMenuItem.Text = "IC-756";
            this.iC756ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC756ProToolStripMenuItem
            // 
            this.iC756ProToolStripMenuItem.Name = "iC756ProToolStripMenuItem";
            this.iC756ProToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC756ProToolStripMenuItem.Text = "IC-756Pro";
            this.iC756ProToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC756ProIIToolStripMenuItem
            // 
            this.iC756ProIIToolStripMenuItem.Name = "iC756ProIIToolStripMenuItem";
            this.iC756ProIIToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC756ProIIToolStripMenuItem.Text = "IC-756ProII";
            this.iC756ProIIToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC756ProIIIToolStripMenuItem
            // 
            this.iC756ProIIIToolStripMenuItem.Name = "iC756ProIIIToolStripMenuItem";
            this.iC756ProIIIToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC756ProIIIToolStripMenuItem.Text = "IC-756ProIII";
            this.iC756ProIIIToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC761ToolStripMenuItem
            // 
            this.iC761ToolStripMenuItem.Name = "iC761ToolStripMenuItem";
            this.iC761ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC761ToolStripMenuItem.Text = "IC-761";
            this.iC761ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC765ToolStripMenuItem
            // 
            this.iC765ToolStripMenuItem.Name = "iC765ToolStripMenuItem";
            this.iC765ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC765ToolStripMenuItem.Text = "IC765";
            this.iC765ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC775ToolStripMenuItem
            // 
            this.iC775ToolStripMenuItem.Name = "iC775ToolStripMenuItem";
            this.iC775ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC775ToolStripMenuItem.Text = "IC-775";
            this.iC775ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC7700ToolStripMenuItem
            // 
            this.iC7700ToolStripMenuItem.Name = "iC7700ToolStripMenuItem";
            this.iC7700ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC7700ToolStripMenuItem.Text = "IC-7700";
            this.iC7700ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC78ToolStripMenuItem
            // 
            this.iC78ToolStripMenuItem.Name = "iC78ToolStripMenuItem";
            this.iC78ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC78ToolStripMenuItem.Text = "IC-78";
            this.iC78ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC7800ToolStripMenuItem
            // 
            this.iC7800ToolStripMenuItem.Name = "iC7800ToolStripMenuItem";
            this.iC7800ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC7800ToolStripMenuItem.Text = "IC-7800";
            this.iC7800ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC781ToolStripMenuItem
            // 
            this.iC781ToolStripMenuItem.Name = "iC781ToolStripMenuItem";
            this.iC781ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC781ToolStripMenuItem.Text = "IC-781";
            this.iC781ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC820ToolStripMenuItem
            // 
            this.iC820ToolStripMenuItem.Name = "iC820ToolStripMenuItem";
            this.iC820ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC820ToolStripMenuItem.Text = "iC820";
            this.iC820ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC821ToolStripMenuItem
            // 
            this.iC821ToolStripMenuItem.Name = "iC821ToolStripMenuItem";
            this.iC821ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC821ToolStripMenuItem.Text = "IC-821";
            this.iC821ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC910ToolStripMenuItem
            // 
            this.iC910ToolStripMenuItem.Name = "iC910ToolStripMenuItem";
            this.iC910ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC910ToolStripMenuItem.Text = "IC-910";
            this.iC910ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC970ToolStripMenuItem
            // 
            this.iC970ToolStripMenuItem.Name = "iC970ToolStripMenuItem";
            this.iC970ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC970ToolStripMenuItem.Text = "IC-970";
            this.iC970ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC1271ToolStripMenuItem
            // 
            this.iC1271ToolStripMenuItem.Name = "iC1271ToolStripMenuItem";
            this.iC1271ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC1271ToolStripMenuItem.Text = "IC-1271";
            this.iC1271ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iC1275ToolStripMenuItem
            // 
            this.iC1275ToolStripMenuItem.Name = "iC1275ToolStripMenuItem";
            this.iC1275ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iC1275ToolStripMenuItem.Text = "IC-1275";
            this.iC1275ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iCX3ToolStripMenuItem
            // 
            this.iCX3ToolStripMenuItem.Enabled = false;
            this.iCX3ToolStripMenuItem.Name = "iCX3ToolStripMenuItem";
            this.iCX3ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iCX3ToolStripMenuItem.Text = "IC-X3";
            this.iCX3ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // iD1ToolStripMenuItem
            // 
            this.iD1ToolStripMenuItem.Name = "iD1ToolStripMenuItem";
            this.iD1ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.iD1ToolStripMenuItem.Text = "ID-1";
            this.iD1ToolStripMenuItem.Click += new System.EventHandler(this.icomMenu);
            // 
            // yaesuToolStripMenuItem
            // 
            this.yaesuToolStripMenuItem.Name = "yaesuToolStripMenuItem";
            this.yaesuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yaesuToolStripMenuItem.Text = "Yaesu";
            this.yaesuToolStripMenuItem.Click += new System.EventHandler(this.yaesuToolStripMenuItem_Click);
            // 
            // kenwoodToolStripMenuItem
            // 
            this.kenwoodToolStripMenuItem.Enabled = false;
            this.kenwoodToolStripMenuItem.Name = "kenwoodToolStripMenuItem";
            this.kenwoodToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kenwoodToolStripMenuItem.Text = "Kenwood";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutVRigToolStripMenuItem,
            this.onlineHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutVRigToolStripMenuItem
            // 
            this.aboutVRigToolStripMenuItem.Name = "aboutVRigToolStripMenuItem";
            this.aboutVRigToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aboutVRigToolStripMenuItem.Text = "About vRig";
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.onlineHelpToolStripMenuItem.Text = "Online Help";
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 335);
            this.Controls.Add(this.lbl_SPLIT);
            this.Controls.Add(this.btn_1MHz);
            this.Controls.Add(this.btn_1kHz);
            this.Controls.Add(this.btn_100Hz);
            this.Controls.Add(this.btn_MW);
            this.Controls.Add(this.btn_MtoVFO);
            this.Controls.Add(this.btn_PSCAN);
            this.Controls.Add(this.btn_MSCAN);
            this.Controls.Add(this.btn_MEMO);
            this.Controls.Add(this.btn_AeqB);
            this.Controls.Add(this.btn_SPLIT);
            this.Controls.Add(this.btn_VFO);
            this.Controls.Add(this.btn_AMFM);
            this.Controls.Add(this.btn_CWN);
            this.Controls.Add(this.btn_SSB);
            this.Controls.Add(this.lbl_MEMO);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.lbl_VFOB);
            this.Controls.Add(this.lbl_VFOA);
            this.Controls.Add(this.lbl_FM);
            this.Controls.Add(this.lbl_AM);
            this.Controls.Add(this.lbl_N);
            this.Controls.Add(this.lbl_CW);
            this.Controls.Add(this.lbl_USB);
            this.Controls.Add(this.lbl_LSB);
            this.Controls.Add(this.frequency_display);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "vRig 1.0.0 BETA";
            ((System.ComponentModel.ISupportInitialize)(this.frequency_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown frequency_display;
        private System.Windows.Forms.Label lbl_LSB;
        private System.Windows.Forms.Label lbl_USB;
        private System.Windows.Forms.Label lbl_CW;
        private System.Windows.Forms.Label lbl_N;
        private System.Windows.Forms.Label lbl_AM;
        private System.Windows.Forms.Label lbl_FM;
        private System.Windows.Forms.Label lbl_VFOA;
        private System.Windows.Forms.Label lbl_VFOB;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lbl_MEMO;
        private System.Windows.Forms.Button btn_SSB;
        private System.Windows.Forms.Button btn_CWN;
        private System.Windows.Forms.Button btn_AMFM;
        private System.Windows.Forms.Button btn_VFO;
        private System.Windows.Forms.Button btn_SPLIT;
        private System.Windows.Forms.Button btn_AeqB;
        private System.Windows.Forms.Button btn_MEMO;
        private System.Windows.Forms.Button btn_MSCAN;
        private System.Windows.Forms.Button btn_PSCAN;
        private System.Windows.Forms.Button btn_MtoVFO;
        private System.Windows.Forms.Button btn_MW;
        private System.Windows.Forms.Button btn_100Hz;
        private System.Windows.Forms.Button btn_1kHz;
        private System.Windows.Forms.Button btn_1MHz;
        private System.Windows.Forms.Timer PollTimer;
        private System.Windows.Forms.Label lbl_SPLIT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC725ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaesuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kenwoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC271ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC275ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC375ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC471ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC475ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC7000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC703ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC706MkIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC706MkIIGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC707ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC718ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC7200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC726ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC728ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC729ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC735ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC736ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC737ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC738ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC7400ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC746ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC751AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC756ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC756ProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC756ProIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC756ProIIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC761ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC765ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC775ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC7700ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC78ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC7800ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC781ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC820ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC821ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC910ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC970ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC1271ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC1275ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCX3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iC575ToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem iC706ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutVRigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baudRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTROnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTSOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitToolStripMenuItem1;
        
    }
}

