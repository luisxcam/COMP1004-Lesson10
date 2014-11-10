namespace Lesson7_CoffeeFlavours
{
    partial class CoffeeFlavoursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeFlavoursForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.syrupListBox = new System.Windows.Forms.ListBox();
            this.coffeeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedFlavoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllFlavoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoffeeFlavourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCoffeeFlavourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllDocument = new System.Drawing.Printing.PrintDocument();
            this.printSelectedDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee and Syrup Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Luis Acevedo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.syrupListBox);
            this.groupBox1.Controls.Add(this.coffeeComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Coffee and Flavour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Syrup Flavour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Coffee Flavour";
            // 
            // syrupListBox
            // 
            this.syrupListBox.FormattingEnabled = true;
            this.syrupListBox.Items.AddRange(new object[] {
            "(None)",
            "Chocolate",
            "Hazel Nut",
            "Irish Creme",
            "Orange"});
            this.syrupListBox.Location = new System.Drawing.Point(346, 40);
            this.syrupListBox.Name = "syrupListBox";
            this.syrupListBox.Size = new System.Drawing.Size(120, 95);
            this.syrupListBox.TabIndex = 1;
            // 
            // coffeeComboBox
            // 
            this.coffeeComboBox.FormattingEnabled = true;
            this.coffeeComboBox.Items.AddRange(new object[] {
            "Chocolate Almond",
            "Espresso Roast",
            "Jamaica Blue Mountain",
            "Kona Blend",
            "Vanilla Nut"});
            this.coffeeComboBox.Location = new System.Drawing.Point(45, 40);
            this.coffeeComboBox.Name = "coffeeComboBox";
            this.coffeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.coffeeComboBox.Sorted = true;
            this.coffeeComboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedFlavoursToolStripMenuItem,
            this.printAllFlavoursToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printSelectedFlavoursToolStripMenuItem
            // 
            this.printSelectedFlavoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.previewSelectedToolStripMenuItem});
            this.printSelectedFlavoursToolStripMenuItem.Name = "printSelectedFlavoursToolStripMenuItem";
            this.printSelectedFlavoursToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printSelectedFlavoursToolStripMenuItem.Text = "Print &Selected Flavours";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.printToolStripMenuItem.Text = "&Print Selected";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printSelectedToolStripMenuItem_Click);
            // 
            // previewSelectedToolStripMenuItem
            // 
            this.previewSelectedToolStripMenuItem.Name = "previewSelectedToolStripMenuItem";
            this.previewSelectedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.previewSelectedToolStripMenuItem.Text = "Pre&view Selected";
            this.previewSelectedToolStripMenuItem.Click += new System.EventHandler(this.previewSelectedToolStripMenuItem_Click);
            // 
            // printAllFlavoursToolStripMenuItem
            // 
            this.printAllFlavoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printAllToolStripMenuItem,
            this.previewAllToolStripMenuItem});
            this.printAllFlavoursToolStripMenuItem.Name = "printAllFlavoursToolStripMenuItem";
            this.printAllFlavoursToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printAllFlavoursToolStripMenuItem.Text = "Print &All Flavours";
            // 
            // printAllToolStripMenuItem
            // 
            this.printAllToolStripMenuItem.Name = "printAllToolStripMenuItem";
            this.printAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.printAllToolStripMenuItem.Text = "&Print All";
            this.printAllToolStripMenuItem.Click += new System.EventHandler(this.printAllToolStripMenuItem_Click);
            // 
            // previewAllToolStripMenuItem
            // 
            this.previewAllToolStripMenuItem.Name = "previewAllToolStripMenuItem";
            this.previewAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.previewAllToolStripMenuItem.Text = "Pre&view All";
            this.previewAllToolStripMenuItem.Click += new System.EventHandler(this.previewAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCoffeeFlavourToolStripMenuItem,
            this.removeCoffeeFlavourToolStripMenuItem,
            this.clearCoffeeListToolStripMenuItem,
            this.countCoffeeListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addCoffeeFlavourToolStripMenuItem
            // 
            this.addCoffeeFlavourToolStripMenuItem.Name = "addCoffeeFlavourToolStripMenuItem";
            this.addCoffeeFlavourToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addCoffeeFlavourToolStripMenuItem.Text = "&Add Coffee Flavour";
            this.addCoffeeFlavourToolStripMenuItem.Click += new System.EventHandler(this.addCoffeeFlavourToolStripMenuItem_Click);
            // 
            // removeCoffeeFlavourToolStripMenuItem
            // 
            this.removeCoffeeFlavourToolStripMenuItem.Name = "removeCoffeeFlavourToolStripMenuItem";
            this.removeCoffeeFlavourToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.removeCoffeeFlavourToolStripMenuItem.Text = "&Remove Coffee Flavour";
            this.removeCoffeeFlavourToolStripMenuItem.Click += new System.EventHandler(this.removeCoffeeFlavourToolStripMenuItem_Click);
            // 
            // clearCoffeeListToolStripMenuItem
            // 
            this.clearCoffeeListToolStripMenuItem.Name = "clearCoffeeListToolStripMenuItem";
            this.clearCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clearCoffeeListToolStripMenuItem.Text = "&Clear Coffee List";
            this.clearCoffeeListToolStripMenuItem.Click += new System.EventHandler(this.clearCoffeeListToolStripMenuItem_Click);
            // 
            // countCoffeeListToolStripMenuItem
            // 
            this.countCoffeeListToolStripMenuItem.Name = "countCoffeeListToolStripMenuItem";
            this.countCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.countCoffeeListToolStripMenuItem.Text = "Count Coffee &List";
            this.countCoffeeListToolStripMenuItem.Click += new System.EventHandler(this.countCoffeeListToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // printAllDocument
            // 
            this.printAllDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAllDocument_PrintPage);
            // 
            // printSelectedDocument
            // 
            this.printSelectedDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSelectedDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CoffeeFlavoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CoffeeFlavoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox syrupListBox;
        private System.Windows.Forms.ComboBox coffeeComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedFlavoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllFlavoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoffeeFlavourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCoffeeFlavourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printAllDocument;
        private System.Drawing.Printing.PrintDocument printSelectedDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

