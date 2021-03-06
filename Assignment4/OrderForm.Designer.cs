﻿namespace Assignment4
{
    partial class OrderForm
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
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxSystemComponents = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtWebCam = new System.Windows.Forms.TextBox();
            this.txtGPUType = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.txtCPUSpeed = new System.Windows.Forms.TextBox();
            this.txtCPUNumber = new System.Windows.Forms.TextBox();
            this.txtCPUType = new System.Windows.Forms.TextBox();
            this.txtCPUBrand = new System.Windows.Forms.TextBox();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.txtLCDSize = new System.Windows.Forms.TextBox();
            this.lblOS = new System.Windows.Forms.Label();
            this.lblWebCam = new System.Windows.Forms.Label();
            this.lblGPUType = new System.Windows.Forms.Label();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblCPUSpeed = new System.Windows.Forms.Label();
            this.lblCPUNumber = new System.Windows.Forms.Label();
            this.lblCPUType = new System.Windows.Forms.Label();
            this.lblCPUBrand = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblLCDSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pBoxComputer = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gBoxSystemComponents.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.Back);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gBoxSystemComponents
            // 
            this.gBoxSystemComponents.Controls.Add(this.panel2);
            this.gBoxSystemComponents.Controls.Add(this.lblOS);
            this.gBoxSystemComponents.Controls.Add(this.lblWebCam);
            this.gBoxSystemComponents.Controls.Add(this.lblGPUType);
            this.gBoxSystemComponents.Controls.Add(this.lblHDD);
            this.gBoxSystemComponents.Controls.Add(this.lblCPUSpeed);
            this.gBoxSystemComponents.Controls.Add(this.lblCPUNumber);
            this.gBoxSystemComponents.Controls.Add(this.lblCPUType);
            this.gBoxSystemComponents.Controls.Add(this.lblCPUBrand);
            this.gBoxSystemComponents.Controls.Add(this.lblMemory);
            this.gBoxSystemComponents.Controls.Add(this.lblLCDSize);
            this.gBoxSystemComponents.Controls.Add(this.panel1);
            this.gBoxSystemComponents.Controls.Add(this.txtModel);
            this.gBoxSystemComponents.Controls.Add(this.lblManufacturer);
            this.gBoxSystemComponents.Controls.Add(this.lblModel);
            this.gBoxSystemComponents.Controls.Add(this.txtManufacturer);
            this.gBoxSystemComponents.Controls.Add(this.txtPlatform);
            this.gBoxSystemComponents.Controls.Add(this.lblCondition);
            this.gBoxSystemComponents.Controls.Add(this.lblPlatform);
            this.gBoxSystemComponents.Controls.Add(this.txtCondition);
            this.gBoxSystemComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxSystemComponents.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSystemComponents.Location = new System.Drawing.Point(13, 36);
            this.gBoxSystemComponents.Name = "gBoxSystemComponents";
            this.gBoxSystemComponents.Size = new System.Drawing.Size(572, 529);
            this.gBoxSystemComponents.TabIndex = 1;
            this.gBoxSystemComponents.TabStop = false;
            this.gBoxSystemComponents.Text = "System Components";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtOS);
            this.panel2.Controls.Add(this.txtWebCam);
            this.panel2.Controls.Add(this.txtGPUType);
            this.panel2.Controls.Add(this.txtHDD);
            this.panel2.Controls.Add(this.txtCPUSpeed);
            this.panel2.Controls.Add(this.txtCPUNumber);
            this.panel2.Controls.Add(this.txtCPUType);
            this.panel2.Controls.Add(this.txtCPUBrand);
            this.panel2.Controls.Add(this.txtMemory);
            this.panel2.Controls.Add(this.txtLCDSize);
            this.panel2.Location = new System.Drawing.Point(147, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 372);
            this.panel2.TabIndex = 39;
            // 
            // txtOS
            // 
            this.txtOS.BackColor = System.Drawing.Color.White;
            this.txtOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOS.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(3, 341);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(405, 23);
            this.txtOS.TabIndex = 49;
            // 
            // txtWebCam
            // 
            this.txtWebCam.BackColor = System.Drawing.Color.White;
            this.txtWebCam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWebCam.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebCam.Location = new System.Drawing.Point(3, 304);
            this.txtWebCam.Name = "txtWebCam";
            this.txtWebCam.ReadOnly = true;
            this.txtWebCam.Size = new System.Drawing.Size(405, 23);
            this.txtWebCam.TabIndex = 48;
            // 
            // txtGPUType
            // 
            this.txtGPUType.BackColor = System.Drawing.Color.White;
            this.txtGPUType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGPUType.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGPUType.Location = new System.Drawing.Point(3, 267);
            this.txtGPUType.Name = "txtGPUType";
            this.txtGPUType.ReadOnly = true;
            this.txtGPUType.Size = new System.Drawing.Size(405, 23);
            this.txtGPUType.TabIndex = 47;
            // 
            // txtHDD
            // 
            this.txtHDD.BackColor = System.Drawing.Color.White;
            this.txtHDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHDD.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHDD.Location = new System.Drawing.Point(3, 231);
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.ReadOnly = true;
            this.txtHDD.Size = new System.Drawing.Size(405, 23);
            this.txtHDD.TabIndex = 46;
            // 
            // txtCPUSpeed
            // 
            this.txtCPUSpeed.BackColor = System.Drawing.Color.White;
            this.txtCPUSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPUSpeed.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUSpeed.Location = new System.Drawing.Point(3, 194);
            this.txtCPUSpeed.Name = "txtCPUSpeed";
            this.txtCPUSpeed.ReadOnly = true;
            this.txtCPUSpeed.Size = new System.Drawing.Size(405, 23);
            this.txtCPUSpeed.TabIndex = 45;
            // 
            // txtCPUNumber
            // 
            this.txtCPUNumber.BackColor = System.Drawing.Color.White;
            this.txtCPUNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPUNumber.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUNumber.Location = new System.Drawing.Point(3, 158);
            this.txtCPUNumber.Name = "txtCPUNumber";
            this.txtCPUNumber.ReadOnly = true;
            this.txtCPUNumber.Size = new System.Drawing.Size(405, 23);
            this.txtCPUNumber.TabIndex = 44;
            // 
            // txtCPUType
            // 
            this.txtCPUType.BackColor = System.Drawing.Color.White;
            this.txtCPUType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPUType.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUType.Location = new System.Drawing.Point(3, 121);
            this.txtCPUType.Name = "txtCPUType";
            this.txtCPUType.ReadOnly = true;
            this.txtCPUType.Size = new System.Drawing.Size(405, 23);
            this.txtCPUType.TabIndex = 43;
            // 
            // txtCPUBrand
            // 
            this.txtCPUBrand.BackColor = System.Drawing.Color.White;
            this.txtCPUBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPUBrand.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPUBrand.Location = new System.Drawing.Point(3, 84);
            this.txtCPUBrand.Name = "txtCPUBrand";
            this.txtCPUBrand.ReadOnly = true;
            this.txtCPUBrand.Size = new System.Drawing.Size(405, 23);
            this.txtCPUBrand.TabIndex = 42;
            // 
            // txtMemory
            // 
            this.txtMemory.BackColor = System.Drawing.Color.White;
            this.txtMemory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemory.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemory.Location = new System.Drawing.Point(3, 48);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(405, 23);
            this.txtMemory.TabIndex = 41;
            // 
            // txtLCDSize
            // 
            this.txtLCDSize.BackColor = System.Drawing.Color.White;
            this.txtLCDSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLCDSize.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLCDSize.Location = new System.Drawing.Point(3, 11);
            this.txtLCDSize.Name = "txtLCDSize";
            this.txtLCDSize.ReadOnly = true;
            this.txtLCDSize.Size = new System.Drawing.Size(405, 23);
            this.txtLCDSize.TabIndex = 40;
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(6, 482);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(35, 22);
            this.lblOS.TabIndex = 37;
            this.lblOS.Text = "OS";
            // 
            // lblWebCam
            // 
            this.lblWebCam.AutoSize = true;
            this.lblWebCam.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebCam.Location = new System.Drawing.Point(6, 445);
            this.lblWebCam.Name = "lblWebCam";
            this.lblWebCam.Size = new System.Drawing.Size(88, 22);
            this.lblWebCam.TabIndex = 36;
            this.lblWebCam.Text = "WebCam";
            // 
            // lblGPUType
            // 
            this.lblGPUType.AutoSize = true;
            this.lblGPUType.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUType.Location = new System.Drawing.Point(6, 408);
            this.lblGPUType.Name = "lblGPUType";
            this.lblGPUType.Size = new System.Drawing.Size(99, 22);
            this.lblGPUType.TabIndex = 35;
            this.lblGPUType.Text = "GPU Type";
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDD.Location = new System.Drawing.Point(6, 372);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(52, 22);
            this.lblHDD.TabIndex = 34;
            this.lblHDD.Text = "HDD";
            // 
            // lblCPUSpeed
            // 
            this.lblCPUSpeed.AutoSize = true;
            this.lblCPUSpeed.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUSpeed.Location = new System.Drawing.Point(6, 335);
            this.lblCPUSpeed.Name = "lblCPUSpeed";
            this.lblCPUSpeed.Size = new System.Drawing.Size(107, 22);
            this.lblCPUSpeed.TabIndex = 33;
            this.lblCPUSpeed.Text = "CPU Speed";
            // 
            // lblCPUNumber
            // 
            this.lblCPUNumber.AutoSize = true;
            this.lblCPUNumber.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUNumber.Location = new System.Drawing.Point(6, 299);
            this.lblCPUNumber.Name = "lblCPUNumber";
            this.lblCPUNumber.Size = new System.Drawing.Size(128, 22);
            this.lblCPUNumber.TabIndex = 32;
            this.lblCPUNumber.Text = "CPU Number";
            // 
            // lblCPUType
            // 
            this.lblCPUType.AutoSize = true;
            this.lblCPUType.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUType.Location = new System.Drawing.Point(6, 262);
            this.lblCPUType.Name = "lblCPUType";
            this.lblCPUType.Size = new System.Drawing.Size(92, 22);
            this.lblCPUType.TabIndex = 31;
            this.lblCPUType.Text = "CPUType";
            // 
            // lblCPUBrand
            // 
            this.lblCPUBrand.AutoSize = true;
            this.lblCPUBrand.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUBrand.Location = new System.Drawing.Point(6, 225);
            this.lblCPUBrand.Name = "lblCPUBrand";
            this.lblCPUBrand.Size = new System.Drawing.Size(106, 22);
            this.lblCPUBrand.TabIndex = 30;
            this.lblCPUBrand.Text = "CPU Brand";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemory.Location = new System.Drawing.Point(6, 189);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(86, 22);
            this.lblMemory.TabIndex = 29;
            this.lblMemory.Text = "Memory";
            // 
            // lblLCDSize
            // 
            this.lblLCDSize.AutoSize = true;
            this.lblLCDSize.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCDSize.Location = new System.Drawing.Point(6, 152);
            this.lblLCDSize.Name = "lblLCDSize";
            this.lblLCDSize.Size = new System.Drawing.Size(90, 22);
            this.lblLCDSize.TabIndex = 28;
            this.lblLCDSize.Text = "LCD Size";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 3);
            this.panel1.TabIndex = 27;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.White;
            this.txtModel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(414, 76);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(141, 30);
            this.txtModel.TabIndex = 26;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.Location = new System.Drawing.Point(6, 81);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(134, 22);
            this.lblManufacturer.TabIndex = 23;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(341, 79);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(67, 22);
            this.lblModel.TabIndex = 25;
            this.lblModel.Text = "Model";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.Color.White;
            this.txtManufacturer.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(146, 76);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(140, 30);
            this.txtManufacturer.TabIndex = 24;
            // 
            // txtPlatform
            // 
            this.txtPlatform.BackColor = System.Drawing.Color.White;
            this.txtPlatform.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.Location = new System.Drawing.Point(414, 41);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(141, 30);
            this.txtPlatform.TabIndex = 22;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(37, 44);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(103, 22);
            this.lblCondition.TabIndex = 19;
            this.lblCondition.Text = "Condition";
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatform.Location = new System.Drawing.Point(319, 44);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(89, 22);
            this.lblPlatform.TabIndex = 21;
            this.lblPlatform.Text = "Platform";
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.Color.White;
            this.txtCondition.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(146, 41);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(140, 30);
            this.txtCondition.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.lblSalesTax);
            this.groupBox1.Controls.Add(this.txtSalesTax);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(607, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 212);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Components";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 22);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(313, 162);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(140, 30);
            this.txtTotal.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(20, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 3);
            this.panel4.TabIndex = 27;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTax.Location = new System.Drawing.Point(20, 81);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(96, 22);
            this.lblSalesTax.TabIndex = 23;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.BackColor = System.Drawing.Color.White;
            this.txtSalesTax.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesTax.Location = new System.Drawing.Point(313, 78);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(140, 30);
            this.txtSalesTax.TabIndex = 24;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(51, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 22);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(313, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(140, 30);
            this.txtPrice.TabIndex = 20;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(964, 529);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(132, 36);
            this.btnFinish.TabIndex = 42;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(826, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(688, 529);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 36);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.Back);
            // 
            // pBoxComputer
            // 
            this.pBoxComputer.Location = new System.Drawing.Point(620, 52);
            this.pBoxComputer.Name = "pBoxComputer";
            this.pBoxComputer.Size = new System.Drawing.Size(204, 196);
            this.pBoxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxComputer.TabIndex = 2;
            this.pBoxComputer.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 578);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBoxComputer);
            this.Controls.Add(this.gBoxSystemComponents);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "Complete Your Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gBoxSystemComponents.ResumeLayout(false);
            this.gBoxSystemComponents.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxSystemComponents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtWebCam;
        private System.Windows.Forms.TextBox txtGPUType;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.TextBox txtCPUSpeed;
        private System.Windows.Forms.TextBox txtCPUNumber;
        private System.Windows.Forms.TextBox txtCPUType;
        private System.Windows.Forms.TextBox txtCPUBrand;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TextBox txtLCDSize;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblWebCam;
        private System.Windows.Forms.Label lblGPUType;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblCPUSpeed;
        private System.Windows.Forms.Label lblCPUNumber;
        private System.Windows.Forms.Label lblCPUType;
        private System.Windows.Forms.Label lblCPUBrand;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblLCDSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.PictureBox pBoxComputer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
    }
}