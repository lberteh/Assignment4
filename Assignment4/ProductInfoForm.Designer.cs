namespace Assignment4
{
    partial class ProductInfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectAgain = new System.Windows.Forms.Button();
            this.lblProdID = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.gBoxProdInfo = new System.Windows.Forms.GroupBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblOS = new System.Windows.Forms.Label();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWebCam = new System.Windows.Forms.TextBox();
            this.lblWebCam = new System.Windows.Forms.Label();
            this.txtCPUSpeed = new System.Windows.Forms.TextBox();
            this.lblCPUType = new System.Windows.Forms.Label();
            this.lblCPUSpeed = new System.Windows.Forms.Label();
            this.txtCPUType = new System.Windows.Forms.TextBox();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.lblGPU = new System.Windows.Forms.Label();
            this.txtCPUNumber = new System.Windows.Forms.TextBox();
            this.lblCPUBrand = new System.Windows.Forms.Label();
            this.lblCPUNumber = new System.Windows.Forms.Label();
            this.txtCPUBrand = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.lblHDD = new System.Windows.Forms.Label();
            this.txtLCDSize = new System.Windows.Forms.TextBox();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblLCDSize = new System.Windows.Forms.Label();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gBoxProdInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1163, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+E";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApp);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+L";
            this.selectAnotherProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect another product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.ReturnToSelectForm);
            // 
            // btnSelectAgain
            // 
            this.btnSelectAgain.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAgain.Location = new System.Drawing.Point(555, 593);
            this.btnSelectAgain.Name = "btnSelectAgain";
            this.btnSelectAgain.Size = new System.Drawing.Size(271, 36);
            this.btnSelectAgain.TabIndex = 1;
            this.btnSelectAgain.Text = "Select Another Product";
            this.btnSelectAgain.UseVisualStyleBackColor = true;
            this.btnSelectAgain.Click += new System.EventHandler(this.ReturnToSelectForm);
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdID.Location = new System.Drawing.Point(104, 61);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(108, 22);
            this.lblProdID.TabIndex = 2;
            this.lblProdID.Text = "Product ID";
            // 
            // txtProdID
            // 
            this.txtProdID.BackColor = System.Drawing.Color.White;
            this.txtProdID.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.Location = new System.Drawing.Point(218, 58);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(100, 30);
            this.txtProdID.TabIndex = 3;
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.Color.White;
            this.txtCondition.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(500, 58);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(118, 30);
            this.txtCondition.TabIndex = 5;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(391, 61);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(103, 22);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Condition";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.White;
            this.txtCost.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(764, 58);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(126, 30);
            this.txtCost.TabIndex = 7;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(705, 61);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(53, 22);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost";
            // 
            // gBoxProdInfo
            // 
            this.gBoxProdInfo.Controls.Add(this.txtModel);
            this.gBoxProdInfo.Controls.Add(this.lblManufacturer);
            this.gBoxProdInfo.Controls.Add(this.lblModel);
            this.gBoxProdInfo.Controls.Add(this.txtManufacturer);
            this.gBoxProdInfo.Controls.Add(this.txtOS);
            this.gBoxProdInfo.Controls.Add(this.lblPlatform);
            this.gBoxProdInfo.Controls.Add(this.lblOS);
            this.gBoxProdInfo.Controls.Add(this.txtPlatform);
            this.gBoxProdInfo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxProdInfo.Location = new System.Drawing.Point(60, 115);
            this.gBoxProdInfo.Name = "gBoxProdInfo";
            this.gBoxProdInfo.Size = new System.Drawing.Size(1042, 189);
            this.gBoxProdInfo.TabIndex = 8;
            this.gBoxProdInfo.TabStop = false;
            this.gBoxProdInfo.Text = "Product Info";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(440, 111);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(551, 30);
            this.txtModel.TabIndex = 16;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(23, 114);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(134, 22);
            this.lblManufacturer.TabIndex = 13;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(367, 114);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(67, 22);
            this.lblModel.TabIndex = 15;
            this.lblModel.Text = "Model";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.Color.White;
            this.txtManufacturer.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(158, 111);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(172, 30);
            this.txtManufacturer.TabIndex = 14;
            // 
            // txtOS
            // 
            this.txtOS.BackColor = System.Drawing.Color.White;
            this.txtOS.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(440, 46);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(551, 30);
            this.txtOS.TabIndex = 12;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatform.Location = new System.Drawing.Point(63, 49);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(89, 22);
            this.lblPlatform.TabIndex = 9;
            this.lblPlatform.Text = "Platform";
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(399, 49);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(35, 22);
            this.lblOS.TabIndex = 11;
            this.lblOS.Text = "OS";
            // 
            // txtPlatform
            // 
            this.txtPlatform.BackColor = System.Drawing.Color.White;
            this.txtPlatform.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.Location = new System.Drawing.Point(158, 46);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(172, 30);
            this.txtPlatform.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWebCam);
            this.groupBox1.Controls.Add(this.lblWebCam);
            this.groupBox1.Controls.Add(this.txtCPUSpeed);
            this.groupBox1.Controls.Add(this.lblCPUType);
            this.groupBox1.Controls.Add(this.lblCPUSpeed);
            this.groupBox1.Controls.Add(this.txtCPUType);
            this.groupBox1.Controls.Add(this.txtGPU);
            this.groupBox1.Controls.Add(this.lblGPU);
            this.groupBox1.Controls.Add(this.txtCPUNumber);
            this.groupBox1.Controls.Add(this.lblCPUBrand);
            this.groupBox1.Controls.Add(this.lblCPUNumber);
            this.groupBox1.Controls.Add(this.txtCPUBrand);
            this.groupBox1.Controls.Add(this.txtHDD);
            this.groupBox1.Controls.Add(this.lblHDD);
            this.groupBox1.Controls.Add(this.txtLCDSize);
            this.groupBox1.Controls.Add(this.lblMemory);
            this.groupBox1.Controls.Add(this.lblLCDSize);
            this.groupBox1.Controls.Add(this.txtMemory);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 247);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // txtWebCam
            // 
            this.txtWebCam.BackColor = System.Drawing.Color.White;
            this.txtWebCam.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebCam.Location = new System.Drawing.Point(704, 173);
            this.txtWebCam.Name = "txtWebCam";
            this.txtWebCam.ReadOnly = true;
            this.txtWebCam.Size = new System.Drawing.Size(287, 30);
            this.txtWebCam.TabIndex = 26;
            // 
            // lblWebCam
            // 
            this.lblWebCam.AutoSize = true;
            this.lblWebCam.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebCam.Location = new System.Drawing.Point(610, 176);
            this.lblWebCam.Name = "lblWebCam";
            this.lblWebCam.Size = new System.Drawing.Size(88, 22);
            this.lblWebCam.TabIndex = 25;
            this.lblWebCam.Text = "WebCam";
            // 
            // txtCPUSpeed
            // 
            this.txtCPUSpeed.BackColor = System.Drawing.Color.White;
            this.txtCPUSpeed.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUSpeed.Location = new System.Drawing.Point(450, 173);
            this.txtCPUSpeed.Name = "txtCPUSpeed";
            this.txtCPUSpeed.ReadOnly = true;
            this.txtCPUSpeed.Size = new System.Drawing.Size(141, 30);
            this.txtCPUSpeed.TabIndex = 24;
            // 
            // lblCPUType
            // 
            this.lblCPUType.AutoSize = true;
            this.lblCPUType.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUType.Location = new System.Drawing.Point(54, 176);
            this.lblCPUType.Name = "lblCPUType";
            this.lblCPUType.Size = new System.Drawing.Size(98, 22);
            this.lblCPUType.TabIndex = 21;
            this.lblCPUType.Text = "CPU Type";
            // 
            // lblCPUSpeed
            // 
            this.lblCPUSpeed.AutoSize = true;
            this.lblCPUSpeed.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUSpeed.Location = new System.Drawing.Point(337, 176);
            this.lblCPUSpeed.Name = "lblCPUSpeed";
            this.lblCPUSpeed.Size = new System.Drawing.Size(107, 22);
            this.lblCPUSpeed.TabIndex = 23;
            this.lblCPUSpeed.Text = "CPU Speed";
            // 
            // txtCPUType
            // 
            this.txtCPUType.BackColor = System.Drawing.Color.White;
            this.txtCPUType.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUType.Location = new System.Drawing.Point(158, 173);
            this.txtCPUType.Name = "txtCPUType";
            this.txtCPUType.ReadOnly = true;
            this.txtCPUType.Size = new System.Drawing.Size(140, 30);
            this.txtCPUType.TabIndex = 22;
            // 
            // txtGPU
            // 
            this.txtGPU.BackColor = System.Drawing.Color.White;
            this.txtGPU.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPU.Location = new System.Drawing.Point(704, 108);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.ReadOnly = true;
            this.txtGPU.Size = new System.Drawing.Size(287, 30);
            this.txtGPU.TabIndex = 20;
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(650, 111);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(48, 22);
            this.lblGPU.TabIndex = 19;
            this.lblGPU.Text = "GPU";
            // 
            // txtCPUNumber
            // 
            this.txtCPUNumber.BackColor = System.Drawing.Color.White;
            this.txtCPUNumber.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUNumber.Location = new System.Drawing.Point(450, 108);
            this.txtCPUNumber.Name = "txtCPUNumber";
            this.txtCPUNumber.ReadOnly = true;
            this.txtCPUNumber.Size = new System.Drawing.Size(141, 30);
            this.txtCPUNumber.TabIndex = 18;
            // 
            // lblCPUBrand
            // 
            this.lblCPUBrand.AutoSize = true;
            this.lblCPUBrand.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUBrand.Location = new System.Drawing.Point(46, 111);
            this.lblCPUBrand.Name = "lblCPUBrand";
            this.lblCPUBrand.Size = new System.Drawing.Size(106, 22);
            this.lblCPUBrand.TabIndex = 15;
            this.lblCPUBrand.Text = "CPU Brand";
            // 
            // lblCPUNumber
            // 
            this.lblCPUNumber.AutoSize = true;
            this.lblCPUNumber.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUNumber.Location = new System.Drawing.Point(316, 111);
            this.lblCPUNumber.Name = "lblCPUNumber";
            this.lblCPUNumber.Size = new System.Drawing.Size(128, 22);
            this.lblCPUNumber.TabIndex = 17;
            this.lblCPUNumber.Text = "CPU Number";
            // 
            // txtCPUBrand
            // 
            this.txtCPUBrand.BackColor = System.Drawing.Color.White;
            this.txtCPUBrand.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUBrand.Location = new System.Drawing.Point(158, 108);
            this.txtCPUBrand.Name = "txtCPUBrand";
            this.txtCPUBrand.ReadOnly = true;
            this.txtCPUBrand.Size = new System.Drawing.Size(140, 30);
            this.txtCPUBrand.TabIndex = 16;
            // 
            // txtHDD
            // 
            this.txtHDD.BackColor = System.Drawing.Color.White;
            this.txtHDD.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDD.Location = new System.Drawing.Point(704, 46);
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.ReadOnly = true;
            this.txtHDD.Size = new System.Drawing.Size(287, 30);
            this.txtHDD.TabIndex = 14;
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.Location = new System.Drawing.Point(646, 49);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(52, 22);
            this.lblHDD.TabIndex = 13;
            this.lblHDD.Text = "HDD";
            // 
            // txtLCDSize
            // 
            this.txtLCDSize.BackColor = System.Drawing.Color.White;
            this.txtLCDSize.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLCDSize.Location = new System.Drawing.Point(450, 46);
            this.txtLCDSize.Name = "txtLCDSize";
            this.txtLCDSize.ReadOnly = true;
            this.txtLCDSize.Size = new System.Drawing.Size(141, 30);
            this.txtLCDSize.TabIndex = 12;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(66, 49);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(86, 22);
            this.lblMemory.TabIndex = 9;
            this.lblMemory.Text = "Memory";
            // 
            // lblLCDSize
            // 
            this.lblLCDSize.AutoSize = true;
            this.lblLCDSize.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCDSize.Location = new System.Drawing.Point(354, 49);
            this.lblLCDSize.Name = "lblLCDSize";
            this.lblLCDSize.Size = new System.Drawing.Size(90, 22);
            this.lblLCDSize.TabIndex = 11;
            this.lblLCDSize.Text = "LCD Size";
            // 
            // txtMemory
            // 
            this.txtMemory.BackColor = System.Drawing.Color.White;
            this.txtMemory.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemory.Location = new System.Drawing.Point(158, 46);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(140, 30);
            this.txtMemory.TabIndex = 10;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(56, 600);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(351, 22);
            this.lblInstructions.TabIndex = 17;
            this.lblInstructions.Text = "Click Next to confirm your selection";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(832, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.ExitApp);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(970, 593);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 36);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 654);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxProdInfo);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.btnSelectAgain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxProdInfo.ResumeLayout(false);
            this.gBoxProdInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectAgain;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.GroupBox gBoxProdInfo;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWebCam;
        private System.Windows.Forms.Label lblWebCam;
        private System.Windows.Forms.TextBox txtCPUSpeed;
        private System.Windows.Forms.Label lblCPUType;
        private System.Windows.Forms.Label lblCPUSpeed;
        private System.Windows.Forms.TextBox txtCPUType;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.TextBox txtCPUNumber;
        private System.Windows.Forms.Label lblCPUBrand;
        private System.Windows.Forms.Label lblCPUNumber;
        private System.Windows.Forms.TextBox txtCPUBrand;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.TextBox txtLCDSize;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblLCDSize;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
    }
}