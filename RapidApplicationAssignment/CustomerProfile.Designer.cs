namespace RapidApplicationAssignment
{
    partial class CustomerProfileForm
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
            System.Windows.Forms.Label nameOfPetLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label sizeCategoryLabel;
            System.Windows.Forms.Label ageAtFirstApptLabel;
            System.Windows.Forms.Label SexOfPetLabel;
            System.Windows.Forms.Label vetInfoLabel;
            System.Windows.Forms.Label importantNotesLabel;
            System.Windows.Forms.Label primaryContactLastNameLabel;
            System.Windows.Forms.Label primaryAlternateInfoLabel;
            System.Windows.Forms.Label primaryContactFirstNameLabel;
            System.Windows.Forms.Label primaryAddressLabel;
            System.Windows.Forms.Label secondaryContactInfoLabel;
            System.Windows.Forms.Label primaryContactPhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProfileForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PetInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.nameOfPetTextBox = new System.Windows.Forms.TextBox();
            this.ageAtFirstApptTextBox = new System.Windows.Forms.TextBox();
            this.vetInfoTextBox = new System.Windows.Forms.TextBox();
            this.importantNotesTextBox = new System.Windows.Forms.TextBox();
            this.ContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.primaryContactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryAlternateInfoTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.secondaryContactInfoTextBox = new System.Windows.Forms.TextBox();
            this.primaryAddressTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.SexOfPetTextbox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            nameOfPetLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            sizeCategoryLabel = new System.Windows.Forms.Label();
            ageAtFirstApptLabel = new System.Windows.Forms.Label();
            SexOfPetLabel = new System.Windows.Forms.Label();
            vetInfoLabel = new System.Windows.Forms.Label();
            importantNotesLabel = new System.Windows.Forms.Label();
            primaryContactLastNameLabel = new System.Windows.Forms.Label();
            primaryAlternateInfoLabel = new System.Windows.Forms.Label();
            primaryContactFirstNameLabel = new System.Windows.Forms.Label();
            primaryAddressLabel = new System.Windows.Forms.Label();
            secondaryContactInfoLabel = new System.Windows.Forms.Label();
            primaryContactPhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.PetInfoGroupBox.SuspendLayout();
            this.ContactInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
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
            this.createInvoiceToolStripMenuItem,
            this.AboutThisApplicationToolStripMenuItem,
            this.ExitAppToolStripMenuItem});
            this.MainMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem";
            this.MainMenuToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.MainMenuToolStripMenuItem.Text = "Main Menu";
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
            // createInvoiceToolStripMenuItem
            // 
            this.createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            this.createInvoiceToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.createInvoiceToolStripMenuItem.Text = "Create Invoice";
            this.createInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createInvoiceToolStripMenuItem_Click);
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
            // PetInfoGroupBox
            // 
            this.PetInfoGroupBox.Controls.Add(this.SizeTextBox);
            this.PetInfoGroupBox.Controls.Add(this.SexOfPetTextbox);
            this.PetInfoGroupBox.Controls.Add(this.breedTypeTextBox);
            this.PetInfoGroupBox.Controls.Add(this.nameOfPetTextBox);
            this.PetInfoGroupBox.Controls.Add(nameOfPetLabel);
            this.PetInfoGroupBox.Controls.Add(breedTypeLabel);
            this.PetInfoGroupBox.Controls.Add(sizeCategoryLabel);
            this.PetInfoGroupBox.Controls.Add(this.imagePictureBox);
            this.PetInfoGroupBox.Controls.Add(this.ageAtFirstApptTextBox);
            this.PetInfoGroupBox.Controls.Add(ageAtFirstApptLabel);
            this.PetInfoGroupBox.Controls.Add(SexOfPetLabel);
            this.PetInfoGroupBox.Controls.Add(vetInfoLabel);
            this.PetInfoGroupBox.Controls.Add(this.vetInfoTextBox);
            this.PetInfoGroupBox.Controls.Add(importantNotesLabel);
            this.PetInfoGroupBox.Controls.Add(this.importantNotesTextBox);
            this.PetInfoGroupBox.Location = new System.Drawing.Point(12, 37);
            this.PetInfoGroupBox.Name = "PetInfoGroupBox";
            this.PetInfoGroupBox.Size = new System.Drawing.Size(802, 218);
            this.PetInfoGroupBox.TabIndex = 1;
            this.PetInfoGroupBox.TabStop = false;
            this.PetInfoGroupBox.Text = "Pet Information";
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.Location = new System.Drawing.Point(81, 70);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.ReadOnly = true;
            this.breedTypeTextBox.Size = new System.Drawing.Size(183, 20);
            this.breedTypeTextBox.TabIndex = 0;
            this.breedTypeTextBox.Text = "Golden Retriever";
            // 
            // nameOfPetTextBox
            // 
            this.nameOfPetTextBox.Location = new System.Drawing.Point(81, 28);
            this.nameOfPetTextBox.Name = "nameOfPetTextBox";
            this.nameOfPetTextBox.ReadOnly = true;
            this.nameOfPetTextBox.Size = new System.Drawing.Size(183, 20);
            this.nameOfPetTextBox.TabIndex = 0;
            this.nameOfPetTextBox.Text = "Spencer";
            // 
            // nameOfPetLabel
            // 
            nameOfPetLabel.AutoSize = true;
            nameOfPetLabel.Location = new System.Drawing.Point(4, 31);
            nameOfPetLabel.Name = "nameOfPetLabel";
            nameOfPetLabel.Size = new System.Drawing.Size(71, 13);
            nameOfPetLabel.TabIndex = 0;
            nameOfPetLabel.Text = "Name Of Pet:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(15, 73);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(59, 13);
            breedTypeLabel.TabIndex = 0;
            breedTypeLabel.Text = "Breed/Mix:";
            // 
            // sizeCategoryLabel
            // 
            sizeCategoryLabel.AutoSize = true;
            sizeCategoryLabel.Location = new System.Drawing.Point(420, 32);
            sizeCategoryLabel.Name = "sizeCategoryLabel";
            sizeCategoryLabel.Size = new System.Drawing.Size(75, 13);
            sizeCategoryLabel.TabIndex = 0;
            sizeCategoryLabel.Text = "Size Category:";
            // 
            // ageAtFirstApptTextBox
            // 
            this.ageAtFirstApptTextBox.Location = new System.Drawing.Point(394, 70);
            this.ageAtFirstApptTextBox.Name = "ageAtFirstApptTextBox";
            this.ageAtFirstApptTextBox.ReadOnly = true;
            this.ageAtFirstApptTextBox.Size = new System.Drawing.Size(228, 20);
            this.ageAtFirstApptTextBox.TabIndex = 0;
            this.ageAtFirstApptTextBox.Text = "8 weeks";
            // 
            // ageAtFirstApptLabel
            // 
            ageAtFirstApptLabel.AutoSize = true;
            ageAtFirstApptLabel.Location = new System.Drawing.Point(299, 73);
            ageAtFirstApptLabel.Name = "ageAtFirstApptLabel";
            ageAtFirstApptLabel.Size = new System.Drawing.Size(89, 13);
            ageAtFirstApptLabel.TabIndex = 0;
            ageAtFirstApptLabel.Text = "Age At First Appt:";
            // 
            // SexOfPetLabel
            // 
            SexOfPetLabel.AutoSize = true;
            SexOfPetLabel.Location = new System.Drawing.Point(272, 32);
            SexOfPetLabel.Name = "SexOfPetLabel";
            SexOfPetLabel.Size = new System.Drawing.Size(28, 13);
            SexOfPetLabel.TabIndex = 0;
            SexOfPetLabel.Text = "Sex:";
            // 
            // vetInfoLabel
            // 
            vetInfoLabel.AutoSize = true;
            vetInfoLabel.Location = new System.Drawing.Point(358, 118);
            vetInfoLabel.Name = "vetInfoLabel";
            vetInfoLabel.Size = new System.Drawing.Size(81, 13);
            vetInfoLabel.TabIndex = 0;
            vetInfoLabel.Text = "Vet Info (if any):";
            // 
            // vetInfoTextBox
            // 
            this.vetInfoTextBox.Location = new System.Drawing.Point(445, 118);
            this.vetInfoTextBox.Multiline = true;
            this.vetInfoTextBox.Name = "vetInfoTextBox";
            this.vetInfoTextBox.ReadOnly = true;
            this.vetInfoTextBox.Size = new System.Drawing.Size(177, 83);
            this.vetInfoTextBox.TabIndex = 0;
            this.vetInfoTextBox.Text = "Washago Veterinary Services\r\n8220 County Road 169 P.O. Box 90\r\nWashago, ON, L0K 2" +
    "B0\r\n705-689-0606";
            // 
            // importantNotesLabel
            // 
            importantNotesLabel.AutoSize = true;
            importantNotesLabel.Location = new System.Drawing.Point(40, 115);
            importantNotesLabel.Name = "importantNotesLabel";
            importantNotesLabel.Size = new System.Drawing.Size(38, 13);
            importantNotesLabel.TabIndex = 0;
            importantNotesLabel.Text = "Notes:";
            // 
            // importantNotesTextBox
            // 
            this.importantNotesTextBox.Location = new System.Drawing.Point(81, 115);
            this.importantNotesTextBox.Multiline = true;
            this.importantNotesTextBox.Name = "importantNotesTextBox";
            this.importantNotesTextBox.ReadOnly = true;
            this.importantNotesTextBox.Size = new System.Drawing.Size(263, 86);
            this.importantNotesTextBox.TabIndex = 0;
            this.importantNotesTextBox.Text = "Very fearful of dryer.";
            // 
            // ContactInfoGroupBox
            // 
            this.ContactInfoGroupBox.Controls.Add(primaryContactLastNameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.primaryContactFirstNameTextBox);
            this.ContactInfoGroupBox.Controls.Add(primaryAlternateInfoLabel);
            this.ContactInfoGroupBox.Controls.Add(primaryContactFirstNameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.primaryAlternateInfoTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.primaryContactLastNameTextBox);
            this.ContactInfoGroupBox.Controls.Add(primaryAddressLabel);
            this.ContactInfoGroupBox.Controls.Add(secondaryContactInfoLabel);
            this.ContactInfoGroupBox.Controls.Add(this.secondaryContactInfoTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.primaryAddressTextBox);
            this.ContactInfoGroupBox.Controls.Add(primaryContactPhoneLabel);
            this.ContactInfoGroupBox.Controls.Add(this.primaryContactPhoneTextBox);
            this.ContactInfoGroupBox.Controls.Add(this.emailTextBox);
            this.ContactInfoGroupBox.Controls.Add(emailLabel);
            this.ContactInfoGroupBox.Location = new System.Drawing.Point(12, 261);
            this.ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            this.ContactInfoGroupBox.Size = new System.Drawing.Size(635, 239);
            this.ContactInfoGroupBox.TabIndex = 2;
            this.ContactInfoGroupBox.TabStop = false;
            this.ContactInfoGroupBox.Text = "Contact Information";
            // 
            // primaryContactLastNameLabel
            // 
            primaryContactLastNameLabel.AutoSize = true;
            primaryContactLastNameLabel.Location = new System.Drawing.Point(321, 32);
            primaryContactLastNameLabel.Name = "primaryContactLastNameLabel";
            primaryContactLastNameLabel.Size = new System.Drawing.Size(138, 13);
            primaryContactLastNameLabel.TabIndex = 0;
            primaryContactLastNameLabel.Text = "Primary Contact Last Name:";
            // 
            // primaryContactFirstNameTextBox
            // 
            this.primaryContactFirstNameTextBox.Location = new System.Drawing.Point(147, 29);
            this.primaryContactFirstNameTextBox.Name = "primaryContactFirstNameTextBox";
            this.primaryContactFirstNameTextBox.ReadOnly = true;
            this.primaryContactFirstNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.primaryContactFirstNameTextBox.TabIndex = 0;
            this.primaryContactFirstNameTextBox.Text = "Julia";
            // 
            // primaryAlternateInfoLabel
            // 
            primaryAlternateInfoLabel.AutoSize = true;
            primaryAlternateInfoLabel.Location = new System.Drawing.Point(349, 110);
            primaryAlternateInfoLabel.Name = "primaryAlternateInfoLabel";
            primaryAlternateInfoLabel.Size = new System.Drawing.Size(110, 13);
            primaryAlternateInfoLabel.TabIndex = 35;
            primaryAlternateInfoLabel.Text = "Primary Alternate Info:";
            // 
            // primaryContactFirstNameLabel
            // 
            primaryContactFirstNameLabel.AutoSize = true;
            primaryContactFirstNameLabel.Location = new System.Drawing.Point(4, 32);
            primaryContactFirstNameLabel.Name = "primaryContactFirstNameLabel";
            primaryContactFirstNameLabel.Size = new System.Drawing.Size(137, 13);
            primaryContactFirstNameLabel.TabIndex = 0;
            primaryContactFirstNameLabel.Text = "Primary Contact First Name:";
            // 
            // primaryAlternateInfoTextBox
            // 
            this.primaryAlternateInfoTextBox.Location = new System.Drawing.Point(465, 107);
            this.primaryAlternateInfoTextBox.Multiline = true;
            this.primaryAlternateInfoTextBox.Name = "primaryAlternateInfoTextBox";
            this.primaryAlternateInfoTextBox.ReadOnly = true;
            this.primaryAlternateInfoTextBox.Size = new System.Drawing.Size(157, 116);
            this.primaryAlternateInfoTextBox.TabIndex = 0;
            this.primaryAlternateInfoTextBox.Text = "Other Phone:  7057184395";
            // 
            // primaryContactLastNameTextBox
            // 
            this.primaryContactLastNameTextBox.Location = new System.Drawing.Point(465, 29);
            this.primaryContactLastNameTextBox.Name = "primaryContactLastNameTextBox";
            this.primaryContactLastNameTextBox.ReadOnly = true;
            this.primaryContactLastNameTextBox.Size = new System.Drawing.Size(157, 20);
            this.primaryContactLastNameTextBox.TabIndex = 0;
            this.primaryContactLastNameTextBox.Text = "Bannister";
            // 
            // primaryAddressLabel
            // 
            primaryAddressLabel.AutoSize = true;
            primaryAddressLabel.Location = new System.Drawing.Point(60, 55);
            primaryAddressLabel.Name = "primaryAddressLabel";
            primaryAddressLabel.Size = new System.Drawing.Size(85, 13);
            primaryAddressLabel.TabIndex = 0;
            primaryAddressLabel.Text = "Primary Address:";
            // 
            // secondaryContactInfoLabel
            // 
            secondaryContactInfoLabel.AutoSize = true;
            secondaryContactInfoLabel.Location = new System.Drawing.Point(23, 146);
            secondaryContactInfoLabel.Name = "secondaryContactInfoLabel";
            secondaryContactInfoLabel.Size = new System.Drawing.Size(122, 13);
            secondaryContactInfoLabel.TabIndex = 0;
            secondaryContactInfoLabel.Text = "Secondary Contact Info:";
            // 
            // secondaryContactInfoTextBox
            // 
            this.secondaryContactInfoTextBox.Location = new System.Drawing.Point(147, 143);
            this.secondaryContactInfoTextBox.Multiline = true;
            this.secondaryContactInfoTextBox.Name = "secondaryContactInfoTextBox";
            this.secondaryContactInfoTextBox.ReadOnly = true;
            this.secondaryContactInfoTextBox.Size = new System.Drawing.Size(153, 80);
            this.secondaryContactInfoTextBox.TabIndex = 0;
            this.secondaryContactInfoTextBox.Text = "Noah Bannister \r\ncan also pick up";
            // 
            // primaryAddressTextBox
            // 
            this.primaryAddressTextBox.Location = new System.Drawing.Point(147, 55);
            this.primaryAddressTextBox.Multiline = true;
            this.primaryAddressTextBox.Name = "primaryAddressTextBox";
            this.primaryAddressTextBox.ReadOnly = true;
            this.primaryAddressTextBox.Size = new System.Drawing.Size(153, 82);
            this.primaryAddressTextBox.TabIndex = 0;
            this.primaryAddressTextBox.Text = "261 Nottawasaga St\r\nOrillia ON L3V3K5\r\n";
            // 
            // primaryContactPhoneLabel
            // 
            primaryContactPhoneLabel.AutoSize = true;
            primaryContactPhoneLabel.Location = new System.Drawing.Point(341, 58);
            primaryContactPhoneLabel.Name = "primaryContactPhoneLabel";
            primaryContactPhoneLabel.Size = new System.Drawing.Size(118, 13);
            primaryContactPhoneLabel.TabIndex = 0;
            primaryContactPhoneLabel.Text = "Primary Contact Phone:";
            // 
            // primaryContactPhoneTextBox
            // 
            this.primaryContactPhoneTextBox.Location = new System.Drawing.Point(465, 55);
            this.primaryContactPhoneTextBox.Name = "primaryContactPhoneTextBox";
            this.primaryContactPhoneTextBox.ReadOnly = true;
            this.primaryContactPhoneTextBox.Size = new System.Drawing.Size(157, 20);
            this.primaryContactPhoneTextBox.TabIndex = 0;
            this.primaryContactPhoneTextBox.Text = "7057184390";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(465, 81);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(157, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Text = "N/A";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(390, 88);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(69, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email (if any):";
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(675, 448);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(125, 52);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.BackgroundImage")));
            this.imagePictureBox.Image = global::RapidApplicationAssignment.Properties.Resources.IMG_01121;
            this.imagePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.InitialImage")));
            this.imagePictureBox.Location = new System.Drawing.Point(647, 19);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(141, 135);
            this.imagePictureBox.TabIndex = 5;
            this.imagePictureBox.TabStop = false;
            // 
            // SexOfPetTextbox
            // 
            this.SexOfPetTextbox.Location = new System.Drawing.Point(307, 28);
            this.SexOfPetTextbox.Name = "SexOfPetTextbox";
            this.SexOfPetTextbox.ReadOnly = true;
            this.SexOfPetTextbox.Size = new System.Drawing.Size(100, 20);
            this.SexOfPetTextbox.TabIndex = 0;
            this.SexOfPetTextbox.Text = "Male";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(501, 29);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SizeTextBox.TabIndex = 8;
            this.SizeTextBox.Text = "Large";
            // 
            // CustomerProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ContactInfoGroupBox);
            this.Controls.Add(this.PetInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Profile";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PetInfoGroupBox.ResumeLayout(false);
            this.PetInfoGroupBox.PerformLayout();
            this.ContactInfoGroupBox.ResumeLayout(false);
            this.ContactInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutThisApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitAppToolStripMenuItem;
        private System.Windows.Forms.GroupBox PetInfoGroupBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox nameOfPetTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox ageAtFirstApptTextBox;
        private System.Windows.Forms.TextBox vetInfoTextBox;
        private System.Windows.Forms.TextBox importantNotesTextBox;
        private System.Windows.Forms.GroupBox ContactInfoGroupBox;
        private System.Windows.Forms.TextBox primaryContactFirstNameTextBox;
        private System.Windows.Forms.TextBox primaryAlternateInfoTextBox;
        private System.Windows.Forms.TextBox primaryContactLastNameTextBox;
        private System.Windows.Forms.TextBox secondaryContactInfoTextBox;
        private System.Windows.Forms.TextBox primaryAddressTextBox;
        private System.Windows.Forms.TextBox primaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox SexOfPetTextbox;
    }
}