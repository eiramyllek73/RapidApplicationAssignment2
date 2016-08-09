namespace RapidApplicationAssignment
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintInvoiceButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.InvoiceInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountDueGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.ServicesInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SizeCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeOptionComboBox = new System.Windows.Forms.ComboBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ServicesGroupBox = new System.Windows.Forms.GroupBox();
            this.MedicatedRadioButton = new System.Windows.Forms.RadioButton();
            this.FullSpaRadioButton = new System.Windows.Forms.RadioButton();
            this.FleaTrtRadioButton = new System.Windows.Forms.RadioButton();
            this.AddToInvoiceButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SaveInvoiceButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PetNameLabel = new System.Windows.Forms.Label();
            this.InvoiceTitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.InvoiceInfoGroupBox.SuspendLayout();
            this.AmountDueGroupBox.SuspendLayout();
            this.ServicesInfoGroupBox.SuspendLayout();
            this.SizeCategoryGroupBox.SuspendLayout();
            this.ServicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuToolStripMenuItem
            // 
            this.MainMenuToolStripMenuItem.AccessibleDescription = "This main dropdown menu will redirect the user to another window in application b" +
    "ased on selection from options listed .";
            this.MainMenuToolStripMenuItem.AccessibleName = "MainMenu";
            this.MainMenuToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeScreenToolStripMenuItem,
            this.viewCustomerDirectoryToolStripMenuItem,
            this.AboutThisApplicationToolStripMenuItem,
            this.ExitAppToolStripMenuItem});
            this.MainMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem";
            this.MainMenuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.MainMenuToolStripMenuItem.Text = "Main Menu";
            this.MainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // HomeScreenToolStripMenuItem
            // 
            this.HomeScreenToolStripMenuItem.AccessibleDescription = "This main menu option will take the user to the home screen  where the applicatio" +
    "n starts from.";
            this.HomeScreenToolStripMenuItem.AccessibleName = "HomeScreenMenuOption";
            this.HomeScreenToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.HomeScreenToolStripMenuItem.Name = "HomeScreenToolStripMenuItem";
            this.HomeScreenToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.HomeScreenToolStripMenuItem.Text = "Go to Home Screen";
            this.HomeScreenToolStripMenuItem.Click += new System.EventHandler(this.HomeScreenToolStripMenuItem_Click);
            // 
            // viewCustomerDirectoryToolStripMenuItem
            // 
            this.viewCustomerDirectoryToolStripMenuItem.Name = "viewCustomerDirectoryToolStripMenuItem";
            this.viewCustomerDirectoryToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.viewCustomerDirectoryToolStripMenuItem.Text = "View Customer Directory";
            this.viewCustomerDirectoryToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerDirectoryToolStripMenuItem_Click);
            // 
            // AboutThisApplicationToolStripMenuItem
            // 
            this.AboutThisApplicationToolStripMenuItem.AccessibleDescription = "This main menu option takes the user to a screen that provides further informatio" +
    "n on this application";
            this.AboutThisApplicationToolStripMenuItem.AccessibleName = "AboutAppMenuOption";
            this.AboutThisApplicationToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem";
            this.AboutThisApplicationToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.AboutThisApplicationToolStripMenuItem.Text = "About this Application";
            this.AboutThisApplicationToolStripMenuItem.Click += new System.EventHandler(this.AboutThisApplicationToolStripMenuItem_Click);
            // 
            // ExitAppToolStripMenuItem
            // 
            this.ExitAppToolStripMenuItem.AccessibleDescription = "This main menu option will close or end this application for the user.";
            this.ExitAppToolStripMenuItem.AccessibleName = "ExitAppMenuOption";
            this.ExitAppToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.ExitAppToolStripMenuItem.Name = "ExitAppToolStripMenuItem";
            this.ExitAppToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.ExitAppToolStripMenuItem.Text = "Exit Application";
            this.ExitAppToolStripMenuItem.Click += new System.EventHandler(this.ExitAppToolStripMenuItem_Click);
            // 
            // PrintInvoiceButton
            // 
            this.PrintInvoiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintInvoiceButton.Location = new System.Drawing.Point(487, 393);
            this.PrintInvoiceButton.Name = "PrintInvoiceButton";
            this.PrintInvoiceButton.Size = new System.Drawing.Size(94, 30);
            this.PrintInvoiceButton.TabIndex = 8;
            this.PrintInvoiceButton.Text = "Print Invoice";
            this.PrintInvoiceButton.UseVisualStyleBackColor = false;
            this.PrintInvoiceButton.Click += new System.EventHandler(this.PrintInvoiceButton_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // InvoiceInfoGroupBox
            // 
            this.InvoiceInfoGroupBox.Controls.Add(this.AmountDueGroupBox);
            this.InvoiceInfoGroupBox.Controls.Add(this.ServicesInfoGroupBox);
            this.InvoiceInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceInfoGroupBox.Location = new System.Drawing.Point(23, 63);
            this.InvoiceInfoGroupBox.Name = "InvoiceInfoGroupBox";
            this.InvoiceInfoGroupBox.Size = new System.Drawing.Size(598, 324);
            this.InvoiceInfoGroupBox.TabIndex = 0;
            this.InvoiceInfoGroupBox.TabStop = false;
            this.InvoiceInfoGroupBox.Text = "Services Required:";
            // 
            // AmountDueGroupBox
            // 
            this.AmountDueGroupBox.Controls.Add(this.TotalTextBox);
            this.AmountDueGroupBox.Controls.Add(this.SubtotalTextBox);
            this.AmountDueGroupBox.Controls.Add(this.TotalLabel);
            this.AmountDueGroupBox.Controls.Add(this.TaxTextBox);
            this.AmountDueGroupBox.Controls.Add(this.TaxLabel);
            this.AmountDueGroupBox.Controls.Add(this.SubtotalLabel);
            this.AmountDueGroupBox.Location = new System.Drawing.Point(20, 199);
            this.AmountDueGroupBox.Name = "AmountDueGroupBox";
            this.AmountDueGroupBox.Size = new System.Drawing.Size(560, 108);
            this.AmountDueGroupBox.TabIndex = 13;
            this.AmountDueGroupBox.TabStop = false;
            this.AmountDueGroupBox.Text = "Amount Due:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(429, 73);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(109, 20);
            this.TotalTextBox.TabIndex = 0;
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(429, 21);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.ReadOnly = true;
            this.SubtotalTextBox.Size = new System.Drawing.Size(109, 20);
            this.SubtotalTextBox.TabIndex = 0;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(334, 76);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 13);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total:";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(429, 47);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(109, 20);
            this.TaxTextBox.TabIndex = 0;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(315, 50);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(59, 13);
            this.TaxLabel.TabIndex = 0;
            this.TaxLabel.Text = "Tax (HST):";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(325, 24);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.SubtotalLabel.TabIndex = 0;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // ServicesInfoGroupBox
            // 
            this.ServicesInfoGroupBox.Controls.Add(this.SizeCategoryGroupBox);
            this.ServicesInfoGroupBox.Controls.Add(this.ServicesGroupBox);
            this.ServicesInfoGroupBox.Controls.Add(this.AddToInvoiceButton);
            this.ServicesInfoGroupBox.Controls.Add(this.ResetButton);
            this.ServicesInfoGroupBox.Location = new System.Drawing.Point(20, 35);
            this.ServicesInfoGroupBox.Name = "ServicesInfoGroupBox";
            this.ServicesInfoGroupBox.Size = new System.Drawing.Size(560, 157);
            this.ServicesInfoGroupBox.TabIndex = 0;
            this.ServicesInfoGroupBox.TabStop = false;
            this.ServicesInfoGroupBox.Text = "Please select a service and then the customer\'s size in order to determine price " +
    "before adding to invoice.  ";
            // 
            // SizeCategoryGroupBox
            // 
            this.SizeCategoryGroupBox.Controls.Add(this.SizeLabel);
            this.SizeCategoryGroupBox.Controls.Add(this.SizeOptionComboBox);
            this.SizeCategoryGroupBox.Controls.Add(this.PriceTextBox);
            this.SizeCategoryGroupBox.Controls.Add(this.PriceLabel);
            this.SizeCategoryGroupBox.Location = new System.Drawing.Point(211, 38);
            this.SizeCategoryGroupBox.Name = "SizeCategoryGroupBox";
            this.SizeCategoryGroupBox.Size = new System.Drawing.Size(200, 100);
            this.SizeCategoryGroupBox.TabIndex = 0;
            this.SizeCategoryGroupBox.TabStop = false;
            this.SizeCategoryGroupBox.Text = "Customer\'s Size Category ";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(6, 24);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(30, 13);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size:";
            // 
            // SizeOptionComboBox
            // 
            this.SizeOptionComboBox.FormattingEnabled = true;
            this.SizeOptionComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "XLarge"});
            this.SizeOptionComboBox.Location = new System.Drawing.Point(42, 19);
            this.SizeOptionComboBox.Name = "SizeOptionComboBox";
            this.SizeOptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.SizeOptionComboBox.TabIndex = 4;
            this.SizeOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeOptionComboBox_SelectedIndexChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(42, 69);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(2, 72);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(34, 13);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price:";
            // 
            // ServicesGroupBox
            // 
            this.ServicesGroupBox.Controls.Add(this.MedicatedRadioButton);
            this.ServicesGroupBox.Controls.Add(this.FullSpaRadioButton);
            this.ServicesGroupBox.Controls.Add(this.FleaTrtRadioButton);
            this.ServicesGroupBox.Location = new System.Drawing.Point(14, 38);
            this.ServicesGroupBox.Name = "ServicesGroupBox";
            this.ServicesGroupBox.Size = new System.Drawing.Size(168, 100);
            this.ServicesGroupBox.TabIndex = 0;
            this.ServicesGroupBox.TabStop = false;
            this.ServicesGroupBox.Text = "Services";
            // 
            // MedicatedRadioButton
            // 
            this.MedicatedRadioButton.AutoSize = true;
            this.MedicatedRadioButton.Location = new System.Drawing.Point(17, 46);
            this.MedicatedRadioButton.Name = "MedicatedRadioButton";
            this.MedicatedRadioButton.Size = new System.Drawing.Size(123, 17);
            this.MedicatedRadioButton.TabIndex = 2;
            this.MedicatedRadioButton.TabStop = true;
            this.MedicatedRadioButton.Text = "Medicated Shampoo";
            this.MedicatedRadioButton.UseVisualStyleBackColor = true;
            this.MedicatedRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FullSpaRadioButton
            // 
            this.FullSpaRadioButton.AutoSize = true;
            this.FullSpaRadioButton.Location = new System.Drawing.Point(17, 22);
            this.FullSpaRadioButton.Name = "FullSpaRadioButton";
            this.FullSpaRadioButton.Size = new System.Drawing.Size(109, 17);
            this.FullSpaRadioButton.TabIndex = 1;
            this.FullSpaRadioButton.TabStop = true;
            this.FullSpaRadioButton.Text = "Full Spa Package";
            this.FullSpaRadioButton.UseVisualStyleBackColor = true;
            this.FullSpaRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // FleaTrtRadioButton
            // 
            this.FleaTrtRadioButton.AutoSize = true;
            this.FleaTrtRadioButton.Location = new System.Drawing.Point(17, 70);
            this.FleaTrtRadioButton.Name = "FleaTrtRadioButton";
            this.FleaTrtRadioButton.Size = new System.Drawing.Size(96, 17);
            this.FleaTrtRadioButton.TabIndex = 3;
            this.FleaTrtRadioButton.TabStop = true;
            this.FleaTrtRadioButton.Text = "Flea Treatment";
            this.FleaTrtRadioButton.UseVisualStyleBackColor = true;
            this.FleaTrtRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // AddToInvoiceButton
            // 
            this.AddToInvoiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddToInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToInvoiceButton.Location = new System.Drawing.Point(429, 97);
            this.AddToInvoiceButton.Name = "AddToInvoiceButton";
            this.AddToInvoiceButton.Size = new System.Drawing.Size(109, 38);
            this.AddToInvoiceButton.TabIndex = 7;
            this.AddToInvoiceButton.Text = "Add to Invoice";
            this.AddToInvoiceButton.UseVisualStyleBackColor = false;
            this.AddToInvoiceButton.Click += new System.EventHandler(this.AddToInvoiceButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(429, 48);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(109, 37);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(539, 28);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(42, 13);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "(Date)";
            // 
            // SaveInvoiceButton
            // 
            this.SaveInvoiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveInvoiceButton.Location = new System.Drawing.Point(342, 393);
            this.SaveInvoiceButton.Name = "SaveInvoiceButton";
            this.SaveInvoiceButton.Size = new System.Drawing.Size(90, 30);
            this.SaveInvoiceButton.TabIndex = 9;
            this.SaveInvoiceButton.Text = "Save to File";
            this.SaveInvoiceButton.UseVisualStyleBackColor = false;
            this.SaveInvoiceButton.Click += new System.EventHandler(this.SaveInvoiceButton_Click);
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
            // PetNameLabel
            // 
            this.PetNameLabel.AutoSize = true;
            this.PetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetNameLabel.Location = new System.Drawing.Point(98, 28);
            this.PetNameLabel.Name = "PetNameLabel";
            this.PetNameLabel.Size = new System.Drawing.Size(47, 13);
            this.PetNameLabel.TabIndex = 0;
            this.PetNameLabel.Text = "Spencer";
            // 
            // InvoiceTitleLabel
            // 
            this.InvoiceTitleLabel.AutoSize = true;
            this.InvoiceTitleLabel.Location = new System.Drawing.Point(20, 28);
            this.InvoiceTitleLabel.Name = "InvoiceTitleLabel";
            this.InvoiceTitleLabel.Size = new System.Drawing.Size(72, 13);
            this.InvoiceTitleLabel.TabIndex = 0;
            this.InvoiceTitleLabel.Text = "Invoice for:";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.SaveInvoiceButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.InvoiceInfoGroupBox);
            this.Controls.Add(this.PetNameLabel);
            this.Controls.Add(this.InvoiceTitleLabel);
            this.Controls.Add(this.PrintInvoiceButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InvoiceInfoGroupBox.ResumeLayout(false);
            this.AmountDueGroupBox.ResumeLayout(false);
            this.AmountDueGroupBox.PerformLayout();
            this.ServicesInfoGroupBox.ResumeLayout(false);
            this.SizeCategoryGroupBox.ResumeLayout(false);
            this.SizeCategoryGroupBox.PerformLayout();
            this.ServicesGroupBox.ResumeLayout(false);
            this.ServicesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutThisApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitAppToolStripMenuItem;
        private System.Windows.Forms.Button PrintInvoiceButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox InvoiceInfoGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ComboBox SizeOptionComboBox;
        private System.Windows.Forms.GroupBox ServicesInfoGroupBox;
        private System.Windows.Forms.RadioButton FleaTrtRadioButton;
        private System.Windows.Forms.RadioButton MedicatedRadioButton;
        private System.Windows.Forms.RadioButton FullSpaRadioButton;
        private System.Windows.Forms.Button AddToInvoiceButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox AmountDueGroupBox;
        private System.Windows.Forms.GroupBox ServicesGroupBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.GroupBox SizeCategoryGroupBox;
        private System.Windows.Forms.Button SaveInvoiceButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerDirectoryToolStripMenuItem;
        private System.Windows.Forms.Label PetNameLabel;
        private System.Windows.Forms.Label InvoiceTitleLabel;
    }
}