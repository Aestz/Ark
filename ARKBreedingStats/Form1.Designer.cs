﻿namespace ARKBreedingStats
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelHeaderW = new System.Windows.Forms.Label();
            this.labelHeaderD = new System.Windows.Forms.Label();
            this.numericUpDownLowerTEffL = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownLowerTEffU = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHBV = new System.Windows.Forms.Label();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCreatures = new System.Windows.Forms.ComboBox();
            this.listBoxPossibilities = new System.Windows.Forms.ListBox();
            this.groupBoxPossibilities = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDoc = new System.Windows.Forms.Label();
            this.buttonCopyClipboard = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelFootnote = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownXP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDomLevel = new System.Windows.Forms.Label();
            this.checkBoxAlreadyBred = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCopy2List = new System.Windows.Forms.Button();
            this.statIOHealth = new ARKBreedingStats.StatIO();
            this.statIOStamina = new ARKBreedingStats.StatIO();
            this.statIOOxygen = new ARKBreedingStats.StatIO();
            this.statIOFood = new ARKBreedingStats.StatIO();
            this.statIOWeight = new ARKBreedingStats.StatIO();
            this.statIODamage = new ARKBreedingStats.StatIO();
            this.statIOTorpor = new ARKBreedingStats.StatIO();
            this.statIOSpeed = new ARKBreedingStats.StatIO();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelCreatures = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerTEffL)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerTEffU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.groupBoxPossibilities.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(307, 125);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(154, 46);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Extract Level Distribution";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelHeaderW
            // 
            this.labelHeaderW.AutoSize = true;
            this.labelHeaderW.Location = new System.Drawing.Point(127, 35);
            this.labelHeaderW.Name = "labelHeaderW";
            this.labelHeaderW.Size = new System.Drawing.Size(28, 13);
            this.labelHeaderW.TabIndex = 17;
            this.labelHeaderW.Text = "Wild";
            // 
            // labelHeaderD
            // 
            this.labelHeaderD.AutoSize = true;
            this.labelHeaderD.Location = new System.Drawing.Point(168, 35);
            this.labelHeaderD.Name = "labelHeaderD";
            this.labelHeaderD.Size = new System.Drawing.Size(29, 13);
            this.labelHeaderD.TabIndex = 18;
            this.labelHeaderD.Text = "Dom";
            // 
            // numericUpDownLowerTEffL
            // 
            this.numericUpDownLowerTEffL.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownLowerTEffL.Name = "numericUpDownLowerTEffL";
            this.numericUpDownLowerTEffL.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownLowerTEffL.TabIndex = 0;
            this.numericUpDownLowerTEffL.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownLowerTEffL.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownLowerTEffU);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numericUpDownLowerTEffL);
            this.groupBox3.Location = new System.Drawing.Point(307, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 44);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TamingEfficiency Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // numericUpDownLowerTEffU
            // 
            this.numericUpDownLowerTEffU.Location = new System.Drawing.Point(73, 19);
            this.numericUpDownLowerTEffU.Name = "numericUpDownLowerTEffU";
            this.numericUpDownLowerTEffU.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownLowerTEffU.TabIndex = 2;
            this.numericUpDownLowerTEffU.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownLowerTEffU.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // labelHBV
            // 
            this.labelHBV.AutoSize = true;
            this.labelHBV.Location = new System.Drawing.Point(207, 35);
            this.labelHBV.Name = "labelHBV";
            this.labelHBV.Size = new System.Drawing.Size(79, 13);
            this.labelHBV.TabIndex = 19;
            this.labelHBV.Text = "Breeding Value";
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(200, 7);
            this.numericUpDownLevel.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownLevel.TabIndex = 1;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // comboBoxCreatures
            // 
            this.comboBoxCreatures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCreatures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCreatures.FormattingEnabled = true;
            this.comboBoxCreatures.Location = new System.Drawing.Point(6, 6);
            this.comboBoxCreatures.Name = "comboBoxCreatures";
            this.comboBoxCreatures.Size = new System.Drawing.Size(149, 21);
            this.comboBoxCreatures.TabIndex = 0;
            this.comboBoxCreatures.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreatures_SelectedIndexChanged);
            // 
            // listBoxPossibilities
            // 
            this.listBoxPossibilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPossibilities.FormattingEnabled = true;
            this.listBoxPossibilities.Location = new System.Drawing.Point(3, 16);
            this.listBoxPossibilities.Name = "listBoxPossibilities";
            this.listBoxPossibilities.Size = new System.Drawing.Size(162, 439);
            this.listBoxPossibilities.TabIndex = 0;
            this.listBoxPossibilities.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPossibilities_MouseClick);
            // 
            // groupBoxPossibilities
            // 
            this.groupBoxPossibilities.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxPossibilities.Location = new System.Drawing.Point(467, 6);
            this.groupBoxPossibilities.Name = "groupBoxPossibilities";
            this.groupBoxPossibilities.Size = new System.Drawing.Size(174, 477);
            this.groupBoxPossibilities.TabIndex = 13;
            this.groupBoxPossibilities.TabStop = false;
            this.groupBoxPossibilities.Text = "Possible Levels";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxPossibilities, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 458);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wild        Dom        TEfficiency";
            // 
            // labelDoc
            // 
            this.labelDoc.Location = new System.Drawing.Point(307, 174);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(154, 198);
            this.labelDoc.TabIndex = 15;
            this.labelDoc.Text = resources.GetString("labelDoc.Text");
            // 
            // buttonCopyClipboard
            // 
            this.buttonCopyClipboard.Enabled = false;
            this.buttonCopyClipboard.Location = new System.Drawing.Point(307, 381);
            this.buttonCopyClipboard.Name = "buttonCopyClipboard";
            this.buttonCopyClipboard.Size = new System.Drawing.Size(154, 45);
            this.buttonCopyClipboard.TabIndex = 13;
            this.buttonCopyClipboard.Text = "Copy retrieved Values as Table to Clipboard";
            this.buttonCopyClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyClipboard.Click += new System.EventHandler(this.buttonCopyClipboard_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(687, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(c) cad 2015";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelFootnote
            // 
            this.labelFootnote.Location = new System.Drawing.Point(6, 456);
            this.labelFootnote.Name = "labelFootnote";
            this.labelFootnote.Size = new System.Drawing.Size(295, 27);
            this.labelFootnote.TabIndex = 16;
            this.labelFootnote.Text = "label3";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.Location = new System.Drawing.Point(636, 5);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 13);
            this.labelVersion.TabIndex = 20;
            this.labelVersion.Text = "ver";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Level";
            // 
            // numericUpDownXP
            // 
            this.numericUpDownXP.DecimalPlaces = 1;
            this.numericUpDownXP.Location = new System.Drawing.Point(6, 16);
            this.numericUpDownXP.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownXP.Name = "numericUpDownXP";
            this.numericUpDownXP.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownXP.TabIndex = 22;
            this.numericUpDownXP.ValueChanged += new System.EventHandler(this.numericUpDownXP_ValueChanged);
            this.numericUpDownXP.Enter += new System.EventHandler(this.numericUpDown_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDomLevel);
            this.groupBox1.Controls.Add(this.numericUpDownXP);
            this.groupBox1.Location = new System.Drawing.Point(307, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 42);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XP";
            // 
            // labelDomLevel
            // 
            this.labelDomLevel.AutoSize = true;
            this.labelDomLevel.Location = new System.Drawing.Point(93, 18);
            this.labelDomLevel.Name = "labelDomLevel";
            this.labelDomLevel.Size = new System.Drawing.Size(50, 13);
            this.labelDomLevel.TabIndex = 23;
            this.labelDomLevel.Text = "DLevel 0";
            // 
            // checkBoxAlreadyBred
            // 
            this.checkBoxAlreadyBred.AutoSize = true;
            this.checkBoxAlreadyBred.Location = new System.Drawing.Point(307, 102);
            this.checkBoxAlreadyBred.Name = "checkBoxAlreadyBred";
            this.checkBoxAlreadyBred.Size = new System.Drawing.Size(137, 17);
            this.checkBoxAlreadyBred.TabIndex = 22;
            this.checkBoxAlreadyBred.Text = "Creature is already bred";
            this.checkBoxAlreadyBred.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 588);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCopy2List);
            this.tabPage1.Controls.Add(this.comboBoxCreatures);
            this.tabPage1.Controls.Add(this.checkBoxAlreadyBred);
            this.tabPage1.Controls.Add(this.buttonCalculate);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.labelHeaderW);
            this.tabPage1.Controls.Add(this.numericUpDownLevel);
            this.tabPage1.Controls.Add(this.labelHeaderD);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.statIOHealth);
            this.tabPage1.Controls.Add(this.labelFootnote);
            this.tabPage1.Controls.Add(this.labelHBV);
            this.tabPage1.Controls.Add(this.statIOStamina);
            this.tabPage1.Controls.Add(this.buttonCopyClipboard);
            this.tabPage1.Controls.Add(this.statIOOxygen);
            this.tabPage1.Controls.Add(this.labelDoc);
            this.tabPage1.Controls.Add(this.statIOFood);
            this.tabPage1.Controls.Add(this.groupBoxPossibilities);
            this.tabPage1.Controls.Add(this.statIOWeight);
            this.tabPage1.Controls.Add(this.statIODamage);
            this.tabPage1.Controls.Add(this.statIOTorpor);
            this.tabPage1.Controls.Add(this.statIOSpeed);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Extractor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCopy2List
            // 
            this.buttonCopy2List.Location = new System.Drawing.Point(307, 432);
            this.buttonCopy2List.Name = "buttonCopy2List";
            this.buttonCopy2List.Size = new System.Drawing.Size(154, 51);
            this.buttonCopy2List.TabIndex = 23;
            this.buttonCopy2List.Text = "Create new Creature with Values";
            this.buttonCopy2List.UseVisualStyleBackColor = true;
            this.buttonCopy2List.Click += new System.EventHandler(this.buttonCopy2List_Click);
            // 
            // statIOHealth
            // 
            this.statIOHealth.BackColor = System.Drawing.SystemColors.Control;
            this.statIOHealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOHealth.Id = 0;
            this.statIOHealth.Input = 100D;
            this.statIOHealth.Location = new System.Drawing.Point(6, 51);
            this.statIOHealth.Name = "statIOHealth";
            this.statIOHealth.Percent = false;
            this.statIOHealth.PostTame = true;
            this.statIOHealth.Size = new System.Drawing.Size(295, 45);
            this.statIOHealth.TabIndex = 2;
            this.statIOHealth.Warning = 0;
            this.statIOHealth.Click += new System.EventHandler(this.statIO_Click);
            // 
            // statIOStamina
            // 
            this.statIOStamina.BackColor = System.Drawing.SystemColors.Control;
            this.statIOStamina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOStamina.Id = 0;
            this.statIOStamina.Input = 100D;
            this.statIOStamina.Location = new System.Drawing.Point(6, 102);
            this.statIOStamina.Name = "statIOStamina";
            this.statIOStamina.Percent = false;
            this.statIOStamina.PostTame = true;
            this.statIOStamina.Size = new System.Drawing.Size(295, 45);
            this.statIOStamina.TabIndex = 3;
            this.statIOStamina.Warning = 0;
            this.statIOStamina.Click += new System.EventHandler(this.statIO_Click);
            // 
            // statIOOxygen
            // 
            this.statIOOxygen.BackColor = System.Drawing.SystemColors.Control;
            this.statIOOxygen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOOxygen.Id = 0;
            this.statIOOxygen.Input = 100D;
            this.statIOOxygen.Location = new System.Drawing.Point(6, 153);
            this.statIOOxygen.Name = "statIOOxygen";
            this.statIOOxygen.Percent = false;
            this.statIOOxygen.PostTame = true;
            this.statIOOxygen.Size = new System.Drawing.Size(295, 45);
            this.statIOOxygen.TabIndex = 4;
            this.statIOOxygen.Warning = 0;
            this.statIOOxygen.Click += new System.EventHandler(this.statIO_Click);
            // 
            // statIOFood
            // 
            this.statIOFood.BackColor = System.Drawing.SystemColors.Control;
            this.statIOFood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOFood.Id = 0;
            this.statIOFood.Input = 100D;
            this.statIOFood.Location = new System.Drawing.Point(6, 204);
            this.statIOFood.Name = "statIOFood";
            this.statIOFood.Percent = false;
            this.statIOFood.PostTame = true;
            this.statIOFood.Size = new System.Drawing.Size(295, 45);
            this.statIOFood.TabIndex = 5;
            this.statIOFood.Warning = 0;
            this.statIOFood.Click += new System.EventHandler(this.statIO_Click);
            // 
            // statIOWeight
            // 
            this.statIOWeight.BackColor = System.Drawing.SystemColors.Control;
            this.statIOWeight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOWeight.Id = 0;
            this.statIOWeight.Input = 100D;
            this.statIOWeight.Location = new System.Drawing.Point(6, 255);
            this.statIOWeight.Name = "statIOWeight";
            this.statIOWeight.Percent = false;
            this.statIOWeight.PostTame = true;
            this.statIOWeight.Size = new System.Drawing.Size(295, 45);
            this.statIOWeight.TabIndex = 6;
            this.statIOWeight.Warning = 0;
            this.statIOWeight.Click += new System.EventHandler(this.statIO_Click);
            // 
            // statIODamage
            // 
            this.statIODamage.BackColor = System.Drawing.SystemColors.Control;
            this.statIODamage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIODamage.Id = 0;
            this.statIODamage.Input = 100D;
            this.statIODamage.Location = new System.Drawing.Point(6, 306);
            this.statIODamage.Name = "statIODamage";
            this.statIODamage.Percent = false;
            this.statIODamage.PostTame = true;
            this.statIODamage.Size = new System.Drawing.Size(295, 45);
            this.statIODamage.TabIndex = 7;
            this.statIODamage.Warning = 0;
            this.statIODamage.Click += new System.EventHandler(this.statIO_Click);
            // 
            // statIOTorpor
            // 
            this.statIOTorpor.BackColor = System.Drawing.SystemColors.Control;
            this.statIOTorpor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOTorpor.Id = 0;
            this.statIOTorpor.Input = 100D;
            this.statIOTorpor.Location = new System.Drawing.Point(6, 408);
            this.statIOTorpor.Name = "statIOTorpor";
            this.statIOTorpor.Percent = false;
            this.statIOTorpor.PostTame = true;
            this.statIOTorpor.Size = new System.Drawing.Size(295, 45);
            this.statIOTorpor.TabIndex = 9;
            this.statIOTorpor.Warning = 0;
            // 
            // statIOSpeed
            // 
            this.statIOSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.statIOSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statIOSpeed.Id = 0;
            this.statIOSpeed.Input = 100D;
            this.statIOSpeed.Location = new System.Drawing.Point(6, 357);
            this.statIOSpeed.Name = "statIOSpeed";
            this.statIOSpeed.Percent = false;
            this.statIOSpeed.PostTame = true;
            this.statIOSpeed.Size = new System.Drawing.Size(295, 45);
            this.statIOSpeed.TabIndex = 8;
            this.statIOSpeed.Warning = 0;
            this.statIOSpeed.Click += new System.EventHandler(this.statIO_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanelCreatures);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Creatures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelCreatures
            // 
            this.flowLayoutPanelCreatures.AutoScroll = true;
            this.flowLayoutPanelCreatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCreatures.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelCreatures.Name = "flowLayoutPanelCreatures";
            this.flowLayoutPanelCreatures.Size = new System.Drawing.Size(745, 556);
            this.flowLayoutPanelCreatures.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 588);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ARK Breeding Stat Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerTEffL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowerTEffU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.groupBoxPossibilities.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelHeaderW;
        private System.Windows.Forms.Label labelHeaderD;
        private System.Windows.Forms.NumericUpDown numericUpDownLowerTEffL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private StatIO statIOHealth;
        private System.Windows.Forms.Label labelHBV;
        private StatIO statIOStamina;
        private StatIO statIOOxygen;
        private StatIO statIOFood;
        private StatIO statIOWeight;
        private StatIO statIODamage;
        private StatIO statIOSpeed;
        private StatIO statIOTorpor;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.ComboBox comboBoxCreatures;
        private System.Windows.Forms.ListBox listBoxPossibilities;
        private System.Windows.Forms.GroupBox groupBoxPossibilities;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Button buttonCopyClipboard;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelFootnote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownLowerTEffU;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownXP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDomLevel;
        private System.Windows.Forms.CheckBox checkBoxAlreadyBred;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCreatures;
        private System.Windows.Forms.Button buttonCopy2List;
    }
}
