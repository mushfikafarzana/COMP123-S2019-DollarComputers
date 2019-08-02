namespace COMP123_S2019_Assignment5.Views
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.SystemComponentsLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.WebcamDataLabel = new System.Windows.Forms.Label();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.SalexTaxDataLabel = new System.Windows.Forms.Label();
            this.TotalDataLabel = new System.Windows.Forms.Label();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.OrderFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(884, 24);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
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
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 3;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 16;
            this.TotalLine.X2 = 364;
            this.TotalLine.Y1 = 83;
            this.TotalLine.Y2 = 83;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(675, 480);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 36);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(565, 479);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 37);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(791, 481);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(81, 35);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // SystemComponentsLabel
            // 
            this.SystemComponentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemComponentsLabel.Location = new System.Drawing.Point(12, 39);
            this.SystemComponentsLabel.Name = "SystemComponentsLabel";
            this.SystemComponentsLabel.Size = new System.Drawing.Size(186, 26);
            this.SystemComponentsLabel.TabIndex = 5;
            this.SystemComponentsLabel.Text = "System Components:";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(27, 75);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(92, 24);
            this.ConditionLabel.TabIndex = 6;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.Location = new System.Drawing.Point(125, 75);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(132, 24);
            this.ConditionDataLabel.TabIndex = 7;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(12, 111);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(107, 24);
            this.ManufacturerLabel.TabIndex = 8;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(275, 111);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(58, 24);
            this.ModelLabel.TabIndex = 10;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 13;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(263, 75);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(70, 24);
            this.PlatformLabel.TabIndex = 12;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(12, 171);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(110, 22);
            this.LCDSizeLabel.TabIndex = 14;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(73, 387);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(46, 22);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(9, 207);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(110, 22);
            this.MemoryLabel.TabIndex = 16;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(9, 494);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(110, 22);
            this.OSLabel.TabIndex = 17;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(12, 351);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(110, 22);
            this.CPUSpeedLabel.TabIndex = 18;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.Location = new System.Drawing.Point(42, 461);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(77, 22);
            this.WebcamLabel.TabIndex = 19;
            this.WebcamLabel.Text = "Webcam";
            this.WebcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Location = new System.Drawing.Point(12, 313);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(110, 22);
            this.CPUNumberLabel.TabIndex = 20;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(12, 278);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(110, 22);
            this.CPUTypeLabel.TabIndex = 21;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPULabel
            // 
            this.GPULabel.Location = new System.Drawing.Point(35, 424);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(84, 22);
            this.GPULabel.TabIndex = 22;
            this.GPULabel.Text = "GPU Type";
            this.GPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(9, 243);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(110, 22);
            this.CPUBrandLabel.TabIndex = 23;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Location = new System.Drawing.Point(10, 71);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(152, 22);
            this.SalesTaxLabel.TabIndex = 26;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            this.SalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(10, 39);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(78, 22);
            this.PriceLabel.TabIndex = 27;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Location = new System.Drawing.Point(15, 120);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(78, 22);
            this.TotalLabel.TabIndex = 28;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.BackColor = System.Drawing.Color.White;
            this.PriceDataLabel.Location = new System.Drawing.Point(211, 40);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(156, 22);
            this.PriceDataLabel.TabIndex = 29;
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(128, 171);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(358, 22);
            this.LCDSizeDataLabel.TabIndex = 30;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.BackColor = System.Drawing.Color.White;
            this.MemoryDataLabel.Location = new System.Drawing.Point(128, 208);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(358, 22);
            this.MemoryDataLabel.TabIndex = 31;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(128, 243);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(358, 22);
            this.CPUBrandDataLabel.TabIndex = 32;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(128, 278);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(358, 22);
            this.CPUTypeDataLabel.TabIndex = 33;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(128, 314);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(358, 22);
            this.CPUNumberDataLabel.TabIndex = 34;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(128, 352);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(358, 22);
            this.CPUSpeedDataLabel.TabIndex = 35;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.HDDDataLabel.Location = new System.Drawing.Point(128, 388);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(358, 22);
            this.HDDDataLabel.TabIndex = 36;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(128, 424);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(358, 22);
            this.GPUTypeDataLabel.TabIndex = 37;
            // 
            // WebcamDataLabel
            // 
            this.WebcamDataLabel.BackColor = System.Drawing.Color.White;
            this.WebcamDataLabel.Location = new System.Drawing.Point(128, 461);
            this.WebcamDataLabel.Name = "WebcamDataLabel";
            this.WebcamDataLabel.Size = new System.Drawing.Size(358, 22);
            this.WebcamDataLabel.TabIndex = 38;
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.BackColor = System.Drawing.Color.White;
            this.OSDataLabel.Location = new System.Drawing.Point(128, 492);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(358, 24);
            this.OSDataLabel.TabIndex = 39;
            // 
            // SalexTaxDataLabel
            // 
            this.SalexTaxDataLabel.BackColor = System.Drawing.Color.White;
            this.SalexTaxDataLabel.Location = new System.Drawing.Point(211, 72);
            this.SalexTaxDataLabel.Name = "SalexTaxDataLabel";
            this.SalexTaxDataLabel.Size = new System.Drawing.Size(156, 22);
            this.SalexTaxDataLabel.TabIndex = 40;
            // 
            // TotalDataLabel
            // 
            this.TotalDataLabel.BackColor = System.Drawing.Color.White;
            this.TotalDataLabel.Location = new System.Drawing.Point(211, 121);
            this.TotalDataLabel.Name = "TotalDataLabel";
            this.TotalDataLabel.Size = new System.Drawing.Size(156, 22);
            this.TotalDataLabel.TabIndex = 41;
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.Enabled = false;
            this.ComputerPictureBox.Location = new System.Drawing.Point(501, 75);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(199, 140);
            this.ComputerPictureBox.TabIndex = 25;
            this.ComputerPictureBox.TabStop = false;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.TotalDataLabel);
            this.PriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.PriceGroupBox.Controls.Add(this.SalexTaxDataLabel);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.PriceDataLabel);
            this.PriceGroupBox.Controls.Add(this.shapeContainer2);
            this.PriceGroupBox.Location = new System.Drawing.Point(501, 243);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(376, 159);
            this.PriceGroupBox.TabIndex = 42;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer2.Size = new System.Drawing.Size(370, 134);
            this.shapeContainer2.TabIndex = 42;
            this.shapeContainer2.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.OSDataLabel);
            this.Controls.Add(this.WebcamDataLabel);
            this.Controls.Add(this.GPUTypeDataLabel);
            this.Controls.Add(this.HDDDataLabel);
            this.Controls.Add(this.CPUSpeedDataLabel);
            this.Controls.Add(this.CPUNumberDataLabel);
            this.Controls.Add(this.CPUTypeDataLabel);
            this.Controls.Add(this.CPUBrandDataLabel);
            this.Controls.Add(this.MemoryDataLabel);
            this.Controls.Add(this.LCDSizeDataLabel);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.LCDSizeLabel);
            this.Controls.Add(this.HDDLabel);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.OSLabel);
            this.Controls.Add(this.CPUSpeedLabel);
            this.Controls.Add(this.WebcamLabel);
            this.Controls.Add(this.CPUNumberLabel);
            this.Controls.Add(this.CPUTypeLabel);
            this.Controls.Add(this.GPULabel);
            this.Controls.Add(this.CPUBrandLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlatformLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.ConditionDataLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.SystemComponentsLabel);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.PriceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label SystemComponentsLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceDataLabel;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label WebcamDataLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label TotalDataLabel;
        private System.Windows.Forms.Label SalexTaxDataLabel;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}