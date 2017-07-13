namespace PasswordGen_HashCalc
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbRipeMD256 = new System.Windows.Forms.TextBox();
            this.cbRipeMD256 = new System.Windows.Forms.CheckBox();
            this.tbRipeMD160 = new System.Windows.Forms.TextBox();
            this.cbRipeMD160 = new System.Windows.Forms.CheckBox();
            this.tbRipeMD128 = new System.Windows.Forms.TextBox();
            this.cbRipeMD128 = new System.Windows.Forms.CheckBox();
            this.tbGost = new System.Windows.Forms.TextBox();
            this.cbGost = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buCalculate = new System.Windows.Forms.Button();
            this.buBrowsePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMD5 = new System.Windows.Forms.CheckBox();
            this.tbCheck = new System.Windows.Forms.TextBox();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.tbSHA512 = new System.Windows.Forms.TextBox();
            this.cbSHA1 = new System.Windows.Forms.CheckBox();
            this.cbSHA512 = new System.Windows.Forms.CheckBox();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.tbSHA256 = new System.Windows.Forms.TextBox();
            this.cbSHA256 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbAdditional = new System.Windows.Forms.CheckBox();
            this.cbHexLower = new System.Windows.Forms.CheckBox();
            this.cbHexUpper = new System.Windows.Forms.CheckBox();
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.cbNumeric = new System.Windows.Forms.CheckBox();
            this.cbLower = new System.Windows.Forms.CheckBox();
            this.cbUpper = new System.Windows.Forms.CheckBox();
            this.buGenerate = new System.Windows.Forms.Button();
            this.tbNumberofPasswords = new System.Windows.Forms.TextBox();
            this.tbMaximumLength = new System.Windows.Forms.TextBox();
            this.tbMinimumLength = new System.Windows.Forms.TextBox();
            this.lbPasswordList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbRipeMD320 = new System.Windows.Forms.TextBox();
            this.cbRipeMD320 = new System.Windows.Forms.CheckBox();
            this.tbTiger = new System.Windows.Forms.TextBox();
            this.cbTiger = new System.Windows.Forms.CheckBox();
            this.tbWhirlpool = new System.Windows.Forms.TextBox();
            this.cbWhirlpool = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 433);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbWhirlpool);
            this.tabPage1.Controls.Add(this.cbWhirlpool);
            this.tabPage1.Controls.Add(this.tbTiger);
            this.tabPage1.Controls.Add(this.cbTiger);
            this.tabPage1.Controls.Add(this.tbRipeMD320);
            this.tabPage1.Controls.Add(this.cbRipeMD320);
            this.tabPage1.Controls.Add(this.tbRipeMD256);
            this.tabPage1.Controls.Add(this.cbRipeMD256);
            this.tabPage1.Controls.Add(this.tbRipeMD160);
            this.tabPage1.Controls.Add(this.cbRipeMD160);
            this.tabPage1.Controls.Add(this.tbRipeMD128);
            this.tabPage1.Controls.Add(this.cbRipeMD128);
            this.tabPage1.Controls.Add(this.tbGost);
            this.tabPage1.Controls.Add(this.cbGost);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbText);
            this.tabPage1.Controls.Add(this.tbPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buCalculate);
            this.tabPage1.Controls.Add(this.buBrowsePath);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbMD5);
            this.tabPage1.Controls.Add(this.tbCheck);
            this.tabPage1.Controls.Add(this.tbMD5);
            this.tabPage1.Controls.Add(this.tbSHA512);
            this.tabPage1.Controls.Add(this.cbSHA1);
            this.tabPage1.Controls.Add(this.cbSHA512);
            this.tabPage1.Controls.Add(this.tbSHA1);
            this.tabPage1.Controls.Add(this.tbSHA256);
            this.tabPage1.Controls.Add(this.cbSHA256);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text & File Hash";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbRipeMD256
            // 
            this.tbRipeMD256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRipeMD256.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRipeMD256.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRipeMD256.Location = new System.Drawing.Point(106, 252);
            this.tbRipeMD256.Name = "tbRipeMD256";
            this.tbRipeMD256.ReadOnly = true;
            this.tbRipeMD256.Size = new System.Drawing.Size(789, 20);
            this.tbRipeMD256.TabIndex = 24;
            this.tbRipeMD256.TabStop = false;
            // 
            // cbRipeMD256
            // 
            this.cbRipeMD256.AutoSize = true;
            this.cbRipeMD256.Location = new System.Drawing.Point(9, 253);
            this.cbRipeMD256.Name = "cbRipeMD256";
            this.cbRipeMD256.Size = new System.Drawing.Size(83, 17);
            this.cbRipeMD256.TabIndex = 23;
            this.cbRipeMD256.Text = "RipeMD256";
            this.cbRipeMD256.UseVisualStyleBackColor = true;
            // 
            // tbRipeMD160
            // 
            this.tbRipeMD160.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRipeMD160.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRipeMD160.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRipeMD160.Location = new System.Drawing.Point(106, 226);
            this.tbRipeMD160.Name = "tbRipeMD160";
            this.tbRipeMD160.ReadOnly = true;
            this.tbRipeMD160.Size = new System.Drawing.Size(789, 20);
            this.tbRipeMD160.TabIndex = 22;
            this.tbRipeMD160.TabStop = false;
            // 
            // cbRipeMD160
            // 
            this.cbRipeMD160.AutoSize = true;
            this.cbRipeMD160.Location = new System.Drawing.Point(9, 227);
            this.cbRipeMD160.Name = "cbRipeMD160";
            this.cbRipeMD160.Size = new System.Drawing.Size(83, 17);
            this.cbRipeMD160.TabIndex = 21;
            this.cbRipeMD160.Text = "RipeMD160";
            this.cbRipeMD160.UseVisualStyleBackColor = true;
            // 
            // tbRipeMD128
            // 
            this.tbRipeMD128.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRipeMD128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRipeMD128.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRipeMD128.Location = new System.Drawing.Point(106, 200);
            this.tbRipeMD128.Name = "tbRipeMD128";
            this.tbRipeMD128.ReadOnly = true;
            this.tbRipeMD128.Size = new System.Drawing.Size(789, 20);
            this.tbRipeMD128.TabIndex = 20;
            this.tbRipeMD128.TabStop = false;
            // 
            // cbRipeMD128
            // 
            this.cbRipeMD128.AutoSize = true;
            this.cbRipeMD128.Location = new System.Drawing.Point(9, 201);
            this.cbRipeMD128.Name = "cbRipeMD128";
            this.cbRipeMD128.Size = new System.Drawing.Size(83, 17);
            this.cbRipeMD128.TabIndex = 19;
            this.cbRipeMD128.Text = "RipeMD128";
            this.cbRipeMD128.UseVisualStyleBackColor = true;
            // 
            // tbGost
            // 
            this.tbGost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGost.Location = new System.Drawing.Point(106, 174);
            this.tbGost.Name = "tbGost";
            this.tbGost.ReadOnly = true;
            this.tbGost.Size = new System.Drawing.Size(789, 20);
            this.tbGost.TabIndex = 18;
            this.tbGost.TabStop = false;
            // 
            // cbGost
            // 
            this.cbGost.AutoSize = true;
            this.cbGost.Location = new System.Drawing.Point(9, 175);
            this.cbGost.Name = "cbGost";
            this.cbGost.Size = new System.Drawing.Size(75, 17);
            this.cbGost.TabIndex = 17;
            this.cbGost.Text = "Gost 3411";
            this.cbGost.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Text:";
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbText.Location = new System.Drawing.Point(74, 3);
            this.tbText.Name = "tbText";
            this.tbText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbText.Size = new System.Drawing.Size(759, 20);
            this.tbText.TabIndex = 0;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPath.Location = new System.Drawing.Point(74, 28);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(759, 20);
            this.tbPath.TabIndex = 1;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // buCalculate
            // 
            this.buCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buCalculate.Image = global::PasswordGen_HashCalc.Properties.Resources.calculator;
            this.buCalculate.Location = new System.Drawing.Point(871, 26);
            this.buCalculate.Name = "buCalculate";
            this.buCalculate.Size = new System.Drawing.Size(24, 23);
            this.buCalculate.TabIndex = 3;
            this.buCalculate.UseVisualStyleBackColor = true;
            this.buCalculate.Click += new System.EventHandler(this.buCalculate_Click);
            // 
            // buBrowsePath
            // 
            this.buBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buBrowsePath.Image = global::PasswordGen_HashCalc.Properties.Resources.browse;
            this.buBrowsePath.Location = new System.Drawing.Point(840, 26);
            this.buBrowsePath.Name = "buBrowsePath";
            this.buBrowsePath.Size = new System.Drawing.Size(24, 23);
            this.buBrowsePath.TabIndex = 2;
            this.buBrowsePath.UseVisualStyleBackColor = true;
            this.buBrowsePath.Click += new System.EventHandler(this.buBrowsePath_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Paste an hash here to compare with the above results:";
            // 
            // cbMD5
            // 
            this.cbMD5.AutoSize = true;
            this.cbMD5.Checked = true;
            this.cbMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMD5.Location = new System.Drawing.Point(8, 73);
            this.cbMD5.Name = "cbMD5";
            this.cbMD5.Size = new System.Drawing.Size(49, 17);
            this.cbMD5.TabIndex = 4;
            this.cbMD5.Text = "MD5";
            this.cbMD5.UseVisualStyleBackColor = true;
            // 
            // tbCheck
            // 
            this.tbCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCheck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCheck.Location = new System.Drawing.Point(8, 376);
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.Size = new System.Drawing.Size(887, 20);
            this.tbCheck.TabIndex = 8;
            // 
            // tbMD5
            // 
            this.tbMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMD5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMD5.Location = new System.Drawing.Point(106, 70);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.ReadOnly = true;
            this.tbMD5.Size = new System.Drawing.Size(789, 20);
            this.tbMD5.TabIndex = 4;
            this.tbMD5.TabStop = false;
            // 
            // tbSHA512
            // 
            this.tbSHA512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA512.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSHA512.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA512.Location = new System.Drawing.Point(106, 148);
            this.tbSHA512.Name = "tbSHA512";
            this.tbSHA512.ReadOnly = true;
            this.tbSHA512.Size = new System.Drawing.Size(789, 20);
            this.tbSHA512.TabIndex = 10;
            this.tbSHA512.TabStop = false;
            // 
            // cbSHA1
            // 
            this.cbSHA1.AutoSize = true;
            this.cbSHA1.Checked = true;
            this.cbSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSHA1.Location = new System.Drawing.Point(8, 98);
            this.cbSHA1.Name = "cbSHA1";
            this.cbSHA1.Size = new System.Drawing.Size(54, 17);
            this.cbSHA1.TabIndex = 5;
            this.cbSHA1.Text = "SHA1";
            this.cbSHA1.UseVisualStyleBackColor = true;
            // 
            // cbSHA512
            // 
            this.cbSHA512.AutoSize = true;
            this.cbSHA512.Checked = true;
            this.cbSHA512.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSHA512.Location = new System.Drawing.Point(8, 149);
            this.cbSHA512.Name = "cbSHA512";
            this.cbSHA512.Size = new System.Drawing.Size(66, 17);
            this.cbSHA512.TabIndex = 7;
            this.cbSHA512.Text = "SHA512";
            this.cbSHA512.UseVisualStyleBackColor = true;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSHA1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA1.Location = new System.Drawing.Point(106, 96);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.ReadOnly = true;
            this.tbSHA1.Size = new System.Drawing.Size(789, 20);
            this.tbSHA1.TabIndex = 6;
            this.tbSHA1.TabStop = false;
            // 
            // tbSHA256
            // 
            this.tbSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA256.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSHA256.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA256.Location = new System.Drawing.Point(106, 122);
            this.tbSHA256.Name = "tbSHA256";
            this.tbSHA256.ReadOnly = true;
            this.tbSHA256.Size = new System.Drawing.Size(789, 20);
            this.tbSHA256.TabIndex = 8;
            this.tbSHA256.TabStop = false;
            // 
            // cbSHA256
            // 
            this.cbSHA256.AutoSize = true;
            this.cbSHA256.Checked = true;
            this.cbSHA256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSHA256.Location = new System.Drawing.Point(9, 123);
            this.cbSHA256.Name = "cbSHA256";
            this.cbSHA256.Size = new System.Drawing.Size(66, 17);
            this.cbSHA256.TabIndex = 6;
            this.cbSHA256.Text = "SHA256";
            this.cbSHA256.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbAdditional);
            this.tabPage2.Controls.Add(this.cbHexLower);
            this.tabPage2.Controls.Add(this.cbHexUpper);
            this.tabPage2.Controls.Add(this.cbSpecial);
            this.tabPage2.Controls.Add(this.cbNumeric);
            this.tabPage2.Controls.Add(this.cbLower);
            this.tabPage2.Controls.Add(this.cbUpper);
            this.tabPage2.Controls.Add(this.buGenerate);
            this.tabPage2.Controls.Add(this.tbNumberofPasswords);
            this.tabPage2.Controls.Add(this.tbMaximumLength);
            this.tabPage2.Controls.Add(this.tbMinimumLength);
            this.tabPage2.Controls.Add(this.lbPasswordList);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Password Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbAdditional
            // 
            this.cbAdditional.AutoSize = true;
            this.cbAdditional.Location = new System.Drawing.Point(637, 13);
            this.cbAdditional.Name = "cbAdditional";
            this.cbAdditional.Size = new System.Drawing.Size(72, 17);
            this.cbAdditional.TabIndex = 14;
            this.cbAdditional.Text = "Additional";
            this.cbAdditional.UseVisualStyleBackColor = true;
            // 
            // cbHexLower
            // 
            this.cbHexLower.AutoSize = true;
            this.cbHexLower.Location = new System.Drawing.Point(715, 31);
            this.cbHexLower.Name = "cbHexLower";
            this.cbHexLower.Size = new System.Drawing.Size(104, 17);
            this.cbHexLower.TabIndex = 13;
            this.cbHexLower.Text = "Hex Lower Case";
            this.cbHexLower.UseVisualStyleBackColor = true;
            // 
            // cbHexUpper
            // 
            this.cbHexUpper.AutoSize = true;
            this.cbHexUpper.Location = new System.Drawing.Point(715, 13);
            this.cbHexUpper.Name = "cbHexUpper";
            this.cbHexUpper.Size = new System.Drawing.Size(104, 17);
            this.cbHexUpper.TabIndex = 12;
            this.cbHexUpper.Text = "Hex Upper Case";
            this.cbHexUpper.UseVisualStyleBackColor = true;
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Checked = true;
            this.cbSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSpecial.Location = new System.Drawing.Point(514, 32);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(112, 17);
            this.cbSpecial.TabIndex = 11;
            this.cbSpecial.Text = "Special Characters";
            this.cbSpecial.UseVisualStyleBackColor = true;
            // 
            // cbNumeric
            // 
            this.cbNumeric.AutoSize = true;
            this.cbNumeric.Checked = true;
            this.cbNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumeric.Location = new System.Drawing.Point(514, 12);
            this.cbNumeric.Name = "cbNumeric";
            this.cbNumeric.Size = new System.Drawing.Size(116, 17);
            this.cbNumeric.TabIndex = 10;
            this.cbNumeric.Text = "Numeric Characters";
            this.cbNumeric.UseVisualStyleBackColor = true;
            // 
            // cbLower
            // 
            this.cbLower.AutoSize = true;
            this.cbLower.Checked = true;
            this.cbLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLower.Location = new System.Drawing.Point(375, 31);
            this.cbLower.Name = "cbLower";
            this.cbLower.Size = new System.Drawing.Size(133, 17);
            this.cbLower.TabIndex = 9;
            this.cbLower.Text = "Lower Case Characters";
            this.cbLower.UseVisualStyleBackColor = true;
            // 
            // cbUpper
            // 
            this.cbUpper.AutoSize = true;
            this.cbUpper.Checked = true;
            this.cbUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUpper.Location = new System.Drawing.Point(375, 11);
            this.cbUpper.Name = "cbUpper";
            this.cbUpper.Size = new System.Drawing.Size(133, 17);
            this.cbUpper.TabIndex = 8;
            this.cbUpper.Text = "Upper Case Characters";
            this.cbUpper.UseVisualStyleBackColor = true;
            // 
            // buGenerate
            // 
            this.buGenerate.Image = global::PasswordGen_HashCalc.Properties.Resources.calculator;
            this.buGenerate.Location = new System.Drawing.Point(163, 31);
            this.buGenerate.Name = "buGenerate";
            this.buGenerate.Size = new System.Drawing.Size(24, 23);
            this.buGenerate.TabIndex = 7;
            this.buGenerate.UseVisualStyleBackColor = true;
            this.buGenerate.Click += new System.EventHandler(this.buGeneratePasswords_Click);
            // 
            // tbNumberofPasswords
            // 
            this.tbNumberofPasswords.Location = new System.Drawing.Point(279, 11);
            this.tbNumberofPasswords.Name = "tbNumberofPasswords";
            this.tbNumberofPasswords.Size = new System.Drawing.Size(53, 20);
            this.tbNumberofPasswords.TabIndex = 6;
            this.tbNumberofPasswords.Text = "10";
            // 
            // tbMaximumLength
            // 
            this.tbMaximumLength.Location = new System.Drawing.Point(100, 34);
            this.tbMaximumLength.Name = "tbMaximumLength";
            this.tbMaximumLength.Size = new System.Drawing.Size(53, 20);
            this.tbMaximumLength.TabIndex = 5;
            this.tbMaximumLength.Text = "10";
            // 
            // tbMinimumLength
            // 
            this.tbMinimumLength.Location = new System.Drawing.Point(100, 11);
            this.tbMinimumLength.Name = "tbMinimumLength";
            this.tbMinimumLength.Size = new System.Drawing.Size(53, 20);
            this.tbMinimumLength.TabIndex = 4;
            this.tbMinimumLength.Text = "8";
            // 
            // lbPasswordList
            // 
            this.lbPasswordList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPasswordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPasswordList.ContextMenuStrip = this.contextMenuStrip1;
            this.lbPasswordList.FormattingEnabled = true;
            this.lbPasswordList.Location = new System.Drawing.Point(10, 71);
            this.lbPasswordList.Name = "lbPasswordList";
            this.lbPasswordList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPasswordList.Size = new System.Drawing.Size(887, 327);
            this.lbPasswordList.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.clearListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 76);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem1
            // 
            this.copyAllToolStripMenuItem1.Name = "copyAllToolStripMenuItem1";
            this.copyAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.copyAllToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.copyAllToolStripMenuItem1.Text = "Copy All";
            this.copyAllToolStripMenuItem1.Click += new System.EventHandler(this.copyAllToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of Passwords:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maximum Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum Length:";
            // 
            // tbRipeMD320
            // 
            this.tbRipeMD320.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRipeMD320.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRipeMD320.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRipeMD320.Location = new System.Drawing.Point(106, 278);
            this.tbRipeMD320.Name = "tbRipeMD320";
            this.tbRipeMD320.ReadOnly = true;
            this.tbRipeMD320.Size = new System.Drawing.Size(789, 20);
            this.tbRipeMD320.TabIndex = 26;
            this.tbRipeMD320.TabStop = false;
            // 
            // cbRipeMD320
            // 
            this.cbRipeMD320.AutoSize = true;
            this.cbRipeMD320.Location = new System.Drawing.Point(9, 279);
            this.cbRipeMD320.Name = "cbRipeMD320";
            this.cbRipeMD320.Size = new System.Drawing.Size(83, 17);
            this.cbRipeMD320.TabIndex = 25;
            this.cbRipeMD320.Text = "RipeMD320";
            this.cbRipeMD320.UseVisualStyleBackColor = true;
            // 
            // tbTiger
            // 
            this.tbTiger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTiger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTiger.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiger.Location = new System.Drawing.Point(106, 304);
            this.tbTiger.Name = "tbTiger";
            this.tbTiger.ReadOnly = true;
            this.tbTiger.Size = new System.Drawing.Size(789, 20);
            this.tbTiger.TabIndex = 28;
            this.tbTiger.TabStop = false;
            // 
            // cbTiger
            // 
            this.cbTiger.AutoSize = true;
            this.cbTiger.Location = new System.Drawing.Point(9, 305);
            this.cbTiger.Name = "cbTiger";
            this.cbTiger.Size = new System.Drawing.Size(80, 17);
            this.cbTiger.TabIndex = 27;
            this.cbTiger.Text = "Tiger 192,3";
            this.cbTiger.UseVisualStyleBackColor = true;
            // 
            // tbWhirlpool
            // 
            this.tbWhirlpool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWhirlpool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWhirlpool.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWhirlpool.Location = new System.Drawing.Point(106, 330);
            this.tbWhirlpool.Name = "tbWhirlpool";
            this.tbWhirlpool.ReadOnly = true;
            this.tbWhirlpool.Size = new System.Drawing.Size(789, 20);
            this.tbWhirlpool.TabIndex = 30;
            this.tbWhirlpool.TabStop = false;
            // 
            // cbWhirlpool
            // 
            this.cbWhirlpool.AutoSize = true;
            this.cbWhirlpool.Location = new System.Drawing.Point(9, 331);
            this.cbWhirlpool.Name = "cbWhirlpool";
            this.cbWhirlpool.Size = new System.Drawing.Size(70, 17);
            this.cbWhirlpool.TabIndex = 29;
            this.cbWhirlpool.Text = "Whirlpool";
            this.cbWhirlpool.UseVisualStyleBackColor = true;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 459);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frMain";
            this.Text = "Password Generator & Hash Calulator v0.1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buCalculate;
        private System.Windows.Forms.Button buBrowsePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMD5;
        private System.Windows.Forms.TextBox tbCheck;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.TextBox tbSHA512;
        private System.Windows.Forms.CheckBox cbSHA1;
        private System.Windows.Forms.CheckBox cbSHA512;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.TextBox tbSHA256;
        private System.Windows.Forms.CheckBox cbSHA256;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbNumeric;
        private System.Windows.Forms.CheckBox cbLower;
        private System.Windows.Forms.CheckBox cbUpper;
        private System.Windows.Forms.Button buGenerate;
        private System.Windows.Forms.TextBox tbNumberofPasswords;
        private System.Windows.Forms.TextBox tbMaximumLength;
        private System.Windows.Forms.TextBox tbMinimumLength;
        private System.Windows.Forms.ListBox lbPasswordList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cbHexLower;
        private System.Windows.Forms.CheckBox cbHexUpper;
        private System.Windows.Forms.CheckBox cbAdditional;
        private System.Windows.Forms.CheckBox cbGost;
        private System.Windows.Forms.TextBox tbRipeMD256;
        private System.Windows.Forms.CheckBox cbRipeMD256;
        private System.Windows.Forms.TextBox tbRipeMD160;
        private System.Windows.Forms.CheckBox cbRipeMD160;
        private System.Windows.Forms.TextBox tbRipeMD128;
        private System.Windows.Forms.CheckBox cbRipeMD128;
        private System.Windows.Forms.TextBox tbGost;
        private System.Windows.Forms.TextBox tbRipeMD320;
        private System.Windows.Forms.CheckBox cbRipeMD320;
        private System.Windows.Forms.TextBox tbTiger;
        private System.Windows.Forms.CheckBox cbTiger;
        private System.Windows.Forms.TextBox tbWhirlpool;
        private System.Windows.Forms.CheckBox cbWhirlpool;
    }
}

