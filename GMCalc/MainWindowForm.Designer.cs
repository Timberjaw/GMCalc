namespace GMCalc
{
    partial class MainWindowForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdbModeStandard = new System.Windows.Forms.RadioButton();
            this.rdbModeEquation = new System.Windows.Forms.RadioButton();
            this.btnM1 = new System.Windows.Forms.Button();
            this.btnM2 = new System.Windows.Forms.Button();
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnM4 = new System.Windows.Forms.Button();
            this.btnM5 = new System.Windows.Forms.Button();
            this.btnM6 = new System.Windows.Forms.Button();
            this.btnM7 = new System.Windows.Forms.Button();
            this.btnM8 = new System.Windows.Forms.Button();
            this.btnM9 = new System.Windows.Forms.Button();
            this.btnM10 = new System.Windows.Forms.Button();
            this.btnMn = new System.Windows.Forms.Button();
            this.btnD2 = new System.Windows.Forms.Button();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD10 = new System.Windows.Forms.Button();
            this.btnD12 = new System.Windows.Forms.Button();
            this.btnD20 = new System.Windows.Forms.Button();
            this.btnD100 = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lastResultTwo = new System.Windows.Forms.Label();
            this.lastResultOne = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTokAddParens = new System.Windows.Forms.Button();
            this.btnTokAddLast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTokAddAns = new System.Windows.Forms.Button();
            this.btnTokAddRightParen = new System.Windows.Forms.Button();
            this.btnTokAddLeftParen = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnX0 = new System.Windows.Forms.Button();
            this.radXMinus = new System.Windows.Forms.RadioButton();
            this.radXPlus = new System.Windows.Forms.RadioButton();
            this.btnX9 = new System.Windows.Forms.Button();
            this.btnXn = new System.Windows.Forms.Button();
            this.btnX8 = new System.Windows.Forms.Button();
            this.btnX7 = new System.Windows.Forms.Button();
            this.btnX6 = new System.Windows.Forms.Button();
            this.btnX5 = new System.Windows.Forms.Button();
            this.btnX4 = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnX1 = new System.Windows.Forms.Button();
            this.entryBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.parseWorker = new System.ComponentModel.BackgroundWorker();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.equationToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.equationToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Checked = true;
            this.standardToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.standardToolStripMenuItem.Text = "Standard Mode";
            // 
            // equationToolStripMenuItem1
            // 
            this.equationToolStripMenuItem1.Enabled = false;
            this.equationToolStripMenuItem1.Name = "equationToolStripMenuItem1";
            this.equationToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.equationToolStripMenuItem1.Text = "Equation Mode";
            // 
            // equationToolStripMenuItem
            // 
            this.equationToolStripMenuItem.Enabled = false;
            this.equationToolStripMenuItem.Name = "equationToolStripMenuItem";
            this.equationToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.equationToolStripMenuItem.Text = "Equation";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rdbModeStandard
            // 
            this.rdbModeStandard.AutoSize = true;
            this.rdbModeStandard.Checked = true;
            this.rdbModeStandard.Location = new System.Drawing.Point(13, 28);
            this.rdbModeStandard.Name = "rdbModeStandard";
            this.rdbModeStandard.Size = new System.Drawing.Size(68, 17);
            this.rdbModeStandard.TabIndex = 3;
            this.rdbModeStandard.TabStop = true;
            this.rdbModeStandard.Text = "Standard";
            this.rdbModeStandard.UseVisualStyleBackColor = true;
            // 
            // rdbModeEquation
            // 
            this.rdbModeEquation.AutoSize = true;
            this.rdbModeEquation.Enabled = false;
            this.rdbModeEquation.Location = new System.Drawing.Point(87, 28);
            this.rdbModeEquation.Name = "rdbModeEquation";
            this.rdbModeEquation.Size = new System.Drawing.Size(125, 17);
            this.rdbModeEquation.TabIndex = 4;
            this.rdbModeEquation.TabStop = true;
            this.rdbModeEquation.Text = "Equation (Advanced)";
            this.rdbModeEquation.UseVisualStyleBackColor = true;
            // 
            // btnM1
            // 
            this.btnM1.Location = new System.Drawing.Point(13, 15);
            this.btnM1.Name = "btnM1";
            this.btnM1.Size = new System.Drawing.Size(37, 31);
            this.btnM1.TabIndex = 5;
            this.btnM1.Text = "1";
            this.btnM1.UseVisualStyleBackColor = true;
            this.btnM1.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM2
            // 
            this.btnM2.Location = new System.Drawing.Point(13, 52);
            this.btnM2.Name = "btnM2";
            this.btnM2.Size = new System.Drawing.Size(37, 31);
            this.btnM2.TabIndex = 6;
            this.btnM2.Text = "2";
            this.btnM2.UseVisualStyleBackColor = true;
            this.btnM2.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM3
            // 
            this.btnM3.Location = new System.Drawing.Point(13, 89);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(37, 31);
            this.btnM3.TabIndex = 7;
            this.btnM3.Text = "3";
            this.btnM3.UseVisualStyleBackColor = true;
            this.btnM3.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM4
            // 
            this.btnM4.Location = new System.Drawing.Point(13, 126);
            this.btnM4.Name = "btnM4";
            this.btnM4.Size = new System.Drawing.Size(37, 31);
            this.btnM4.TabIndex = 8;
            this.btnM4.Text = "4";
            this.btnM4.UseVisualStyleBackColor = true;
            this.btnM4.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM5
            // 
            this.btnM5.Location = new System.Drawing.Point(13, 163);
            this.btnM5.Name = "btnM5";
            this.btnM5.Size = new System.Drawing.Size(37, 31);
            this.btnM5.TabIndex = 9;
            this.btnM5.Text = "5";
            this.btnM5.UseVisualStyleBackColor = true;
            this.btnM5.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM6
            // 
            this.btnM6.Location = new System.Drawing.Point(56, 15);
            this.btnM6.Name = "btnM6";
            this.btnM6.Size = new System.Drawing.Size(37, 31);
            this.btnM6.TabIndex = 10;
            this.btnM6.Text = "6";
            this.btnM6.UseVisualStyleBackColor = true;
            this.btnM6.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM7
            // 
            this.btnM7.Location = new System.Drawing.Point(56, 52);
            this.btnM7.Name = "btnM7";
            this.btnM7.Size = new System.Drawing.Size(37, 31);
            this.btnM7.TabIndex = 11;
            this.btnM7.Text = "7";
            this.btnM7.UseVisualStyleBackColor = true;
            this.btnM7.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM8
            // 
            this.btnM8.Location = new System.Drawing.Point(56, 89);
            this.btnM8.Name = "btnM8";
            this.btnM8.Size = new System.Drawing.Size(37, 31);
            this.btnM8.TabIndex = 12;
            this.btnM8.Text = "8";
            this.btnM8.UseVisualStyleBackColor = true;
            this.btnM8.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM9
            // 
            this.btnM9.Location = new System.Drawing.Point(56, 126);
            this.btnM9.Name = "btnM9";
            this.btnM9.Size = new System.Drawing.Size(37, 31);
            this.btnM9.TabIndex = 15;
            this.btnM9.Text = "9";
            this.btnM9.UseVisualStyleBackColor = true;
            this.btnM9.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnM10
            // 
            this.btnM10.Location = new System.Drawing.Point(56, 162);
            this.btnM10.Name = "btnM10";
            this.btnM10.Size = new System.Drawing.Size(37, 31);
            this.btnM10.TabIndex = 14;
            this.btnM10.Text = "10";
            this.btnM10.UseVisualStyleBackColor = true;
            this.btnM10.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnMn
            // 
            this.btnMn.Location = new System.Drawing.Point(13, 199);
            this.btnMn.Name = "btnMn";
            this.btnMn.Size = new System.Drawing.Size(80, 31);
            this.btnMn.TabIndex = 13;
            this.btnMn.Text = "n";
            this.btnMn.UseVisualStyleBackColor = true;
            this.btnMn.Click += new System.EventHandler(this.btnMn_Click);
            // 
            // btnD2
            // 
            this.btnD2.Location = new System.Drawing.Point(10, 18);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(45, 40);
            this.btnD2.TabIndex = 0;
            this.btnD2.Text = "d2";
            this.btnD2.UseVisualStyleBackColor = true;
            this.btnD2.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(58, 18);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(45, 40);
            this.btnD4.TabIndex = 8;
            this.btnD4.Text = "d4";
            this.btnD4.UseVisualStyleBackColor = true;
            this.btnD4.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD6
            // 
            this.btnD6.Location = new System.Drawing.Point(106, 18);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(45, 40);
            this.btnD6.TabIndex = 1;
            this.btnD6.Text = "d6";
            this.btnD6.UseVisualStyleBackColor = true;
            this.btnD6.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD8
            // 
            this.btnD8.Location = new System.Drawing.Point(155, 18);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(45, 40);
            this.btnD8.TabIndex = 5;
            this.btnD8.Text = "d8";
            this.btnD8.UseVisualStyleBackColor = true;
            this.btnD8.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD10
            // 
            this.btnD10.Location = new System.Drawing.Point(10, 64);
            this.btnD10.Name = "btnD10";
            this.btnD10.Size = new System.Drawing.Size(45, 40);
            this.btnD10.TabIndex = 9;
            this.btnD10.Text = "d10";
            this.btnD10.UseVisualStyleBackColor = true;
            this.btnD10.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD12
            // 
            this.btnD12.Location = new System.Drawing.Point(58, 64);
            this.btnD12.Name = "btnD12";
            this.btnD12.Size = new System.Drawing.Size(45, 40);
            this.btnD12.TabIndex = 2;
            this.btnD12.Text = "d12";
            this.btnD12.UseVisualStyleBackColor = true;
            this.btnD12.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(106, 64);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(45, 40);
            this.btnD20.TabIndex = 6;
            this.btnD20.Text = "d20";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnD100
            // 
            this.btnD100.Location = new System.Drawing.Point(155, 64);
            this.btnD100.Name = "btnD100";
            this.btnD100.Size = new System.Drawing.Size(44, 40);
            this.btnD100.TabIndex = 10;
            this.btnD100.Text = "d100";
            this.btnD100.UseVisualStyleBackColor = true;
            this.btnD100.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnDn
            // 
            this.btnDn.Location = new System.Drawing.Point(10, 110);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(93, 40);
            this.btnDn.TabIndex = 3;
            this.btnDn.Text = "dN";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.btnDn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnM9);
            this.groupBox1.Controls.Add(this.btnM10);
            this.groupBox1.Controls.Add(this.btnMn);
            this.groupBox1.Controls.Add(this.btnM8);
            this.groupBox1.Controls.Add(this.btnM7);
            this.groupBox1.Controls.Add(this.btnM6);
            this.groupBox1.Controls.Add(this.btnM5);
            this.groupBox1.Controls.Add(this.btnM4);
            this.groupBox1.Controls.Add(this.btnM3);
            this.groupBox1.Controls.Add(this.btnM2);
            this.groupBox1.Controls.Add(this.btnM1);
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 234);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGo);
            this.groupBox2.Controls.Add(this.btnD100);
            this.groupBox2.Controls.Add(this.btnD10);
            this.groupBox2.Controls.Add(this.btnD4);
            this.groupBox2.Controls.Add(this.btnD20);
            this.groupBox2.Controls.Add(this.btnD8);
            this.groupBox2.Controls.Add(this.btnDn);
            this.groupBox2.Controls.Add(this.btnD12);
            this.groupBox2.Controls.Add(this.btnD6);
            this.groupBox2.Controls.Add(this.btnD2);
            this.groupBox2.Location = new System.Drawing.Point(116, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 160);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dice";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(106, 110);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(94, 40);
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "=";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lastResultTwo);
            this.groupBox3.Controls.Add(this.lastResultOne);
            this.groupBox3.Controls.Add(this.resultBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 52);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // lastResultTwo
            // 
            this.lastResultTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastResultTwo.AutoSize = true;
            this.lastResultTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastResultTwo.ForeColor = System.Drawing.Color.DarkGray;
            this.lastResultTwo.Location = new System.Drawing.Point(6, 16);
            this.lastResultTwo.MinimumSize = new System.Drawing.Size(120, 0);
            this.lastResultTwo.Name = "lastResultTwo";
            this.lastResultTwo.Size = new System.Drawing.Size(120, 24);
            this.lastResultTwo.TabIndex = 1003;
            this.lastResultTwo.Text = "0";
            this.lastResultTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastResultOne
            // 
            this.lastResultOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lastResultOne.AutoSize = true;
            this.lastResultOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastResultOne.ForeColor = System.Drawing.Color.DimGray;
            this.lastResultOne.Location = new System.Drawing.Point(139, 16);
            this.lastResultOne.MinimumSize = new System.Drawing.Size(120, 0);
            this.lastResultOne.Name = "lastResultOne";
            this.lastResultOne.Size = new System.Drawing.Size(120, 24);
            this.lastResultOne.TabIndex = 1002;
            this.lastResultOne.Text = "0";
            this.lastResultOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultBox
            // 
            this.resultBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultBox.AutoSize = true;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultBox.Location = new System.Drawing.Point(280, 16);
            this.resultBox.MinimumSize = new System.Drawing.Size(120, 0);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(120, 24);
            this.resultBox.TabIndex = 1001;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTokAddParens);
            this.groupBox4.Controls.Add(this.btnTokAddLast);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnTokAddAns);
            this.groupBox4.Controls.Add(this.btnTokAddRightParen);
            this.groupBox4.Controls.Add(this.btnTokAddLeftParen);
            this.groupBox4.Location = new System.Drawing.Point(331, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(81, 160);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tokens";
            // 
            // btnTokAddParens
            // 
            this.btnTokAddParens.Location = new System.Drawing.Point(6, 55);
            this.btnTokAddParens.Name = "btnTokAddParens";
            this.btnTokAddParens.Size = new System.Drawing.Size(69, 29);
            this.btnTokAddParens.TabIndex = 22;
            this.btnTokAddParens.Text = "( . . . )";
            this.btnTokAddParens.UseVisualStyleBackColor = true;
            this.btnTokAddParens.Click += new System.EventHandler(this.btnTokAddParens_Click);
            // 
            // btnTokAddLast
            // 
            this.btnTokAddLast.Location = new System.Drawing.Point(6, 125);
            this.btnTokAddLast.Name = "btnTokAddLast";
            this.btnTokAddLast.Size = new System.Drawing.Size(69, 29);
            this.btnTokAddLast.TabIndex = 21;
            this.btnTokAddLast.Text = "Last";
            this.btnTokAddLast.UseVisualStyleBackColor = true;
            this.btnTokAddLast.Click += new System.EventHandler(this.btnTokAddLast_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Advanced Features Go Here";
            // 
            // btnTokAddAns
            // 
            this.btnTokAddAns.Location = new System.Drawing.Point(6, 90);
            this.btnTokAddAns.Name = "btnTokAddAns";
            this.btnTokAddAns.Size = new System.Drawing.Size(69, 29);
            this.btnTokAddAns.TabIndex = 20;
            this.btnTokAddAns.Text = "Ans";
            this.btnTokAddAns.UseVisualStyleBackColor = true;
            this.btnTokAddAns.Click += new System.EventHandler(this.btnTokAddAns_Click);
            // 
            // btnTokAddRightParen
            // 
            this.btnTokAddRightParen.Location = new System.Drawing.Point(43, 20);
            this.btnTokAddRightParen.Name = "btnTokAddRightParen";
            this.btnTokAddRightParen.Size = new System.Drawing.Size(32, 29);
            this.btnTokAddRightParen.TabIndex = 19;
            this.btnTokAddRightParen.Text = ")";
            this.btnTokAddRightParen.UseVisualStyleBackColor = true;
            this.btnTokAddRightParen.Click += new System.EventHandler(this.btnTokAddRightParen_Click);
            // 
            // btnTokAddLeftParen
            // 
            this.btnTokAddLeftParen.Location = new System.Drawing.Point(6, 20);
            this.btnTokAddLeftParen.Name = "btnTokAddLeftParen";
            this.btnTokAddLeftParen.Size = new System.Drawing.Size(32, 29);
            this.btnTokAddLeftParen.TabIndex = 18;
            this.btnTokAddLeftParen.Text = "(";
            this.btnTokAddLeftParen.UseVisualStyleBackColor = true;
            this.btnTokAddLeftParen.Click += new System.EventHandler(this.btnTokAddLeftParen_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnX0);
            this.groupBox5.Controls.Add(this.radXMinus);
            this.groupBox5.Controls.Add(this.radXPlus);
            this.groupBox5.Controls.Add(this.btnX9);
            this.groupBox5.Controls.Add(this.btnXn);
            this.groupBox5.Controls.Add(this.btnX8);
            this.groupBox5.Controls.Add(this.btnX7);
            this.groupBox5.Controls.Add(this.btnX6);
            this.groupBox5.Controls.Add(this.btnX5);
            this.groupBox5.Controls.Add(this.btnX4);
            this.groupBox5.Controls.Add(this.btnX3);
            this.groupBox5.Controls.Add(this.btnX2);
            this.groupBox5.Controls.Add(this.btnX1);
            this.groupBox5.Location = new System.Drawing.Point(116, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 68);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modifier";
            // 
            // btnX0
            // 
            this.btnX0.Location = new System.Drawing.Point(42, 12);
            this.btnX0.Name = "btnX0";
            this.btnX0.Size = new System.Drawing.Size(24, 24);
            this.btnX0.TabIndex = 18;
            this.btnX0.Text = "0";
            this.btnX0.UseVisualStyleBackColor = true;
            this.btnX0.Click += new System.EventHandler(this.btnX_Click);
            // 
            // radXMinus
            // 
            this.radXMinus.AutoSize = true;
            this.radXMinus.Location = new System.Drawing.Point(10, 45);
            this.radXMinus.Name = "radXMinus";
            this.radXMinus.Size = new System.Drawing.Size(28, 17);
            this.radXMinus.TabIndex = 17;
            this.radXMinus.Text = "-";
            this.radXMinus.UseVisualStyleBackColor = true;
            this.radXMinus.CheckedChanged += new System.EventHandler(this.radXPlusMinus_CheckedChanged);
            // 
            // radXPlus
            // 
            this.radXPlus.AutoSize = true;
            this.radXPlus.Checked = true;
            this.radXPlus.Location = new System.Drawing.Point(10, 19);
            this.radXPlus.Name = "radXPlus";
            this.radXPlus.Size = new System.Drawing.Size(31, 17);
            this.radXPlus.TabIndex = 16;
            this.radXPlus.TabStop = true;
            this.radXPlus.Text = "+";
            this.radXPlus.UseVisualStyleBackColor = true;
            this.radXPlus.CheckedChanged += new System.EventHandler(this.radXPlusMinus_CheckedChanged);
            // 
            // btnX9
            // 
            this.btnX9.Location = new System.Drawing.Point(162, 39);
            this.btnX9.Name = "btnX9";
            this.btnX9.Size = new System.Drawing.Size(24, 24);
            this.btnX9.TabIndex = 15;
            this.btnX9.Text = "9";
            this.btnX9.UseVisualStyleBackColor = true;
            this.btnX9.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnXn
            // 
            this.btnXn.Location = new System.Drawing.Point(192, 22);
            this.btnXn.Name = "btnXn";
            this.btnXn.Size = new System.Drawing.Size(98, 31);
            this.btnXn.TabIndex = 13;
            this.btnXn.Text = "n";
            this.btnXn.UseVisualStyleBackColor = true;
            this.btnXn.Click += new System.EventHandler(this.btnXn_Click);
            // 
            // btnX8
            // 
            this.btnX8.Location = new System.Drawing.Point(132, 39);
            this.btnX8.Name = "btnX8";
            this.btnX8.Size = new System.Drawing.Size(24, 24);
            this.btnX8.TabIndex = 12;
            this.btnX8.Text = "8";
            this.btnX8.UseVisualStyleBackColor = true;
            this.btnX8.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX7
            // 
            this.btnX7.Location = new System.Drawing.Point(102, 39);
            this.btnX7.Name = "btnX7";
            this.btnX7.Size = new System.Drawing.Size(24, 24);
            this.btnX7.TabIndex = 11;
            this.btnX7.Text = "7";
            this.btnX7.UseVisualStyleBackColor = true;
            this.btnX7.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX6
            // 
            this.btnX6.Location = new System.Drawing.Point(72, 39);
            this.btnX6.Name = "btnX6";
            this.btnX6.Size = new System.Drawing.Size(24, 24);
            this.btnX6.TabIndex = 10;
            this.btnX6.Text = "6";
            this.btnX6.UseVisualStyleBackColor = true;
            this.btnX6.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX5
            // 
            this.btnX5.Location = new System.Drawing.Point(42, 39);
            this.btnX5.Name = "btnX5";
            this.btnX5.Size = new System.Drawing.Size(24, 24);
            this.btnX5.TabIndex = 9;
            this.btnX5.Text = "5";
            this.btnX5.UseVisualStyleBackColor = true;
            this.btnX5.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX4
            // 
            this.btnX4.Location = new System.Drawing.Point(162, 12);
            this.btnX4.Name = "btnX4";
            this.btnX4.Size = new System.Drawing.Size(24, 24);
            this.btnX4.TabIndex = 8;
            this.btnX4.Text = "4";
            this.btnX4.UseVisualStyleBackColor = true;
            this.btnX4.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX3
            // 
            this.btnX3.Location = new System.Drawing.Point(132, 12);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(24, 24);
            this.btnX3.TabIndex = 7;
            this.btnX3.Text = "3";
            this.btnX3.UseVisualStyleBackColor = true;
            this.btnX3.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX2
            // 
            this.btnX2.Location = new System.Drawing.Point(102, 12);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(24, 24);
            this.btnX2.TabIndex = 6;
            this.btnX2.Text = "2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnX1
            // 
            this.btnX1.Location = new System.Drawing.Point(72, 12);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(24, 24);
            this.btnX1.TabIndex = 5;
            this.btnX1.Text = "1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.btnX_Click);
            // 
            // entryBox
            // 
            this.entryBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.entryBox.BackColor = System.Drawing.Color.White;
            this.entryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryBox.HideSelection = false;
            this.entryBox.Location = new System.Drawing.Point(6, 348);
            this.entryBox.Name = "entryBox";
            this.entryBox.Size = new System.Drawing.Size(406, 32);
            this.entryBox.TabIndex = 0;
            this.entryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryBox_KeyDown);
            this.entryBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.entryBox_KeyUp);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(308, 387);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(104, 14);
            this.progressBar1.TabIndex = 18;
            // 
            // parseWorker
            // 
            this.parseWorker.WorkerReportsProgress = true;
            this.parseWorker.WorkerSupportsCancellation = true;
            this.parseWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.parseWorker_DoWork);
            this.parseWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.parseWorker_RunWorkerCompleted);
            this.parseWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.parseWorker_ProgressChanged);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variableEditorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // variableEditorToolStripMenuItem
            // 
            this.variableEditorToolStripMenuItem.Name = "variableEditorToolStripMenuItem";
            this.variableEditorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.variableEditorToolStripMenuItem.Text = "Variable Editor";
            this.variableEditorToolStripMenuItem.Click += new System.EventHandler(this.variableEditorToolStripMenuItem_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 405);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbModeEquation);
            this.Controls.Add(this.rdbModeStandard);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.entryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.Text = "GMCalc v0.14";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.Click += new System.EventHandler(this.MainWindowForm_Click);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbModeStandard;
        private System.Windows.Forms.RadioButton rdbModeEquation;
        private System.Windows.Forms.Button btnM2;
        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnM4;
        private System.Windows.Forms.Button btnM5;
        private System.Windows.Forms.Button btnM8;
        private System.Windows.Forms.Button btnM7;
        private System.Windows.Forms.Button btnM6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnD100;
        private System.Windows.Forms.Button btnD10;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Button btnD12;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD2;
        private System.Windows.Forms.Button btnM10;
        private System.Windows.Forms.Button btnMn;
        private System.Windows.Forms.Button btnM1;
        private System.Windows.Forms.Button btnM9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equationToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnX9;
        private System.Windows.Forms.Button btnXn;
        private System.Windows.Forms.Button btnX8;
        private System.Windows.Forms.Button btnX7;
        private System.Windows.Forms.Button btnX6;
        private System.Windows.Forms.Button btnX5;
        private System.Windows.Forms.Button btnX4;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.RadioButton radXMinus;
        private System.Windows.Forms.RadioButton radXPlus;

        public void setEntryBoxValue(string s)
        {
            this.entryBox.Text = s;
        }

        public void setResultBoxValue(string s)
        {
            this.resultBox.Text = s;
        }

        private System.Windows.Forms.Button btnTokAddLast;
        private System.Windows.Forms.Button btnTokAddAns;
        private System.Windows.Forms.Button btnTokAddRightParen;
        private System.Windows.Forms.Button btnTokAddLeftParen;
        private System.Windows.Forms.Button btnX0;
        private System.Windows.Forms.TextBox entryBox;
        private System.Windows.Forms.Label resultBox;
        private System.Windows.Forms.Label lastResultTwo;
        private System.Windows.Forms.Label lastResultOne;
        private System.Windows.Forms.Button btnTokAddParens;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker parseWorker;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableEditorToolStripMenuItem;
    }
}

