namespace RapidApplicationAssignment
{
    partial class AddCustomerForm
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameOfPetLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label sizeCategoryLabel;
            System.Windows.Forms.Label ageAtFirstApptLabel;
            System.Windows.Forms.Label primaryContactFirstNameLabel;
            System.Windows.Forms.Label primaryContactLastNameLabel;
            System.Windows.Forms.Label primaryContactPhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label secondaryContactInfoLabel;
            System.Windows.Forms.Label vetInfoLabel;
            System.Windows.Forms.Label importantNotesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.furzaflynDataSet = new RapidApplicationAssignment.furzaflynDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new RapidApplicationAssignment.furzaflynDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.furzaflynDataSetTableAdapters.TableAdapterManager();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameOfPetTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.sizeCategoryTextBox = new System.Windows.Forms.TextBox();
            this.ageAtFirstApptTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.secondaryContactInfoTextBox = new System.Windows.Forms.TextBox();
            this.vetInfoTextBox = new System.Windows.Forms.TextBox();
            this.importantNotesTextBox = new System.Windows.Forms.TextBox();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UpLoadImageButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            customerIDLabel = new System.Windows.Forms.Label();
            nameOfPetLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            sizeCategoryLabel = new System.Windows.Forms.Label();
            ageAtFirstApptLabel = new System.Windows.Forms.Label();
            primaryContactFirstNameLabel = new System.Windows.Forms.Label();
            primaryContactLastNameLabel = new System.Windows.Forms.Label();
            primaryContactPhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            secondaryContactInfoLabel = new System.Windows.Forms.Label();
            vetInfoLabel = new System.Windows.Forms.Label();
            importantNotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(566, 398);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "Customer ID:";
            customerIDLabel.Visible = false;
            // 
            // nameOfPetLabel
            // 
            nameOfPetLabel.AutoSize = true;
            nameOfPetLabel.Location = new System.Drawing.Point(14, 44);
            nameOfPetLabel.Name = "nameOfPetLabel";
            nameOfPetLabel.Size = new System.Drawing.Size(75, 13);
            nameOfPetLabel.TabIndex = 0;
            nameOfPetLabel.Text = "*Name Of Pet:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(315, 42);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(69, 13);
            breedTypeLabel.TabIndex = 0;
            breedTypeLabel.Text = "*Breed Type:";
            // 
            // sizeCategoryLabel
            // 
            sizeCategoryLabel.AutoSize = true;
            sizeCategoryLabel.Location = new System.Drawing.Point(10, 83);
            sizeCategoryLabel.Name = "sizeCategoryLabel";
            sizeCategoryLabel.Size = new System.Drawing.Size(79, 13);
            sizeCategoryLabel.TabIndex = 0;
            sizeCategoryLabel.Text = "*Size Category:";
            // 
            // ageAtFirstApptLabel
            // 
            ageAtFirstApptLabel.AutoSize = true;
            ageAtFirstApptLabel.Location = new System.Drawing.Point(291, 81);
            ageAtFirstApptLabel.Name = "ageAtFirstApptLabel";
            ageAtFirstApptLabel.Size = new System.Drawing.Size(89, 13);
            ageAtFirstApptLabel.TabIndex = 0;
            ageAtFirstApptLabel.Text = "Age At First Appt:";
            // 
            // primaryContactFirstNameLabel
            // 
            primaryContactFirstNameLabel.AutoSize = true;
            primaryContactFirstNameLabel.Location = new System.Drawing.Point(10, 141);
            primaryContactFirstNameLabel.Name = "primaryContactFirstNameLabel";
            primaryContactFirstNameLabel.Size = new System.Drawing.Size(141, 13);
            primaryContactFirstNameLabel.TabIndex = 0;
            primaryContactFirstNameLabel.Text = "*Primary Contact First Name:";
            // 
            // primaryContactLastNameLabel
            // 
            primaryContactLastNameLabel.AutoSize = true;
            primaryContactLastNameLabel.Location = new System.Drawing.Point(9, 178);
            primaryContactLastNameLabel.Name = "primaryContactLastNameLabel";
            primaryContactLastNameLabel.Size = new System.Drawing.Size(142, 13);
            primaryContactLastNameLabel.TabIndex = 0;
            primaryContactLastNameLabel.Text = "*Primary Contact Last Name:";
            // 
            // primaryContactPhoneLabel
            // 
            primaryContactPhoneLabel.AutoSize = true;
            primaryContactPhoneLabel.Location = new System.Drawing.Point(29, 216);
            primaryContactPhoneLabel.Name = "primaryContactPhoneLabel";
            primaryContactPhoneLabel.Size = new System.Drawing.Size(122, 13);
            primaryContactPhoneLabel.TabIndex = 0;
            primaryContactPhoneLabel.Text = "*Primary Contact Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(78, 252);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(69, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email (if any):";
            // 
            // secondaryContactInfoLabel
            // 
            secondaryContactInfoLabel.AutoSize = true;
            secondaryContactInfoLabel.Location = new System.Drawing.Point(25, 288);
            secondaryContactInfoLabel.Name = "secondaryContactInfoLabel";
            secondaryContactInfoLabel.Size = new System.Drawing.Size(122, 13);
            secondaryContactInfoLabel.TabIndex = 0;
            secondaryContactInfoLabel.Text = "Secondary Contact Info:";
            // 
            // vetInfoLabel
            // 
            vetInfoLabel.AutoSize = true;
            vetInfoLabel.Location = new System.Drawing.Point(414, 120);
            vetInfoLabel.Name = "vetInfoLabel";
            vetInfoLabel.Size = new System.Drawing.Size(81, 13);
            vetInfoLabel.TabIndex = 0;
            vetInfoLabel.Text = "Vet Info (if any):";
            // 
            // importantNotesLabel
            // 
            importantNotesLabel.AutoSize = true;
            importantNotesLabel.Location = new System.Drawing.Point(414, 231);
            importantNotesLabel.Name = "importantNotesLabel";
            importantNotesLabel.Size = new System.Drawing.Size(85, 13);
            importantNotesLabel.TabIndex = 0;
            importantNotesLabel.Text = "Important Notes:";
            // 
            // furzaflynDataSet
            // 
            this.furzaflynDataSet.DataSetName = "furzaflynDataSet";
            this.furzaflynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.furzaflynDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentLogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = RapidApplicationAssignment.furzaflynDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(640, 395);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(45, 20);
            this.customerIDTextBox.TabIndex = 0;
            this.customerIDTextBox.Visible = false;
            // 
            // nameOfPetTextBox
            // 
            this.nameOfPetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.NameOfPet", true));
            this.nameOfPetTextBox.Location = new System.Drawing.Point(91, 41);
            this.nameOfPetTextBox.Name = "nameOfPetTextBox";
            this.nameOfPetTextBox.Size = new System.Drawing.Size(183, 20);
            this.nameOfPetTextBox.TabIndex = 1;
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(386, 39);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(147, 20);
            this.breedTypeTextBox.TabIndex = 2;
            // 
            // sizeCategoryTextBox
            // 
            this.sizeCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.SizeCategory", true));
            this.sizeCategoryTextBox.Location = new System.Drawing.Point(91, 80);
            this.sizeCategoryTextBox.Name = "sizeCategoryTextBox";
            this.sizeCategoryTextBox.Size = new System.Drawing.Size(183, 20);
            this.sizeCategoryTextBox.TabIndex = 3;
            // 
            // ageAtFirstApptTextBox
            // 
            this.ageAtFirstApptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.AgeAtFirstAppt", true));
            this.ageAtFirstApptTextBox.Location = new System.Drawing.Point(386, 78);
            this.ageAtFirstApptTextBox.Name = "ageAtFirstApptTextBox";
            this.ageAtFirstApptTextBox.Size = new System.Drawing.Size(147, 20);
            this.ageAtFirstApptTextBox.TabIndex = 4;
            // 
            // primaryContactFirstNameTextBox
            // 
            this.primaryContactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.PrimaryContactFirstName", true));
            this.primaryContactFirstNameTextBox.Location = new System.Drawing.Point(153, 138);
            this.primaryContactFirstNameTextBox.Name = "primaryContactFirstNameTextBox";
            this.primaryContactFirstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.primaryContactFirstNameTextBox.TabIndex = 5;
            // 
            // primaryContactLastNameTextBox
            // 
            this.primaryContactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.PrimaryContactLastName", true));
            this.primaryContactLastNameTextBox.Location = new System.Drawing.Point(153, 175);
            this.primaryContactLastNameTextBox.Name = "primaryContactLastNameTextBox";
            this.primaryContactLastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.primaryContactLastNameTextBox.TabIndex = 6;
            // 
            // primaryContactPhoneTextBox
            // 
            this.primaryContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.PrimaryContactPhone", true));
            this.primaryContactPhoneTextBox.Location = new System.Drawing.Point(153, 213);
            this.primaryContactPhoneTextBox.Name = "primaryContactPhoneTextBox";
            this.primaryContactPhoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.primaryContactPhoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(153, 249);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // secondaryContactInfoTextBox
            // 
            this.secondaryContactInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.SecondaryContactInfo", true));
            this.secondaryContactInfoTextBox.Location = new System.Drawing.Point(153, 285);
            this.secondaryContactInfoTextBox.Multiline = true;
            this.secondaryContactInfoTextBox.Name = "secondaryContactInfoTextBox";
            this.secondaryContactInfoTextBox.Size = new System.Drawing.Size(121, 80);
            this.secondaryContactInfoTextBox.TabIndex = 9;
            // 
            // vetInfoTextBox
            // 
            this.vetInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.ImportantNotes", true));
            this.vetInfoTextBox.Location = new System.Drawing.Point(386, 136);
            this.vetInfoTextBox.Multiline = true;
            this.vetInfoTextBox.Name = "vetInfoTextBox";
            this.vetInfoTextBox.Size = new System.Drawing.Size(147, 91);
            this.vetInfoTextBox.TabIndex = 10;
            // 
            // importantNotesTextBox
            // 
            this.importantNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furzaflynDataSet, "Customers.ImportantNotes", true));
            this.importantNotesTextBox.Location = new System.Drawing.Point(386, 247);
            this.importantNotesTextBox.Multiline = true;
            this.importantNotesTextBox.Name = "importantNotesTextBox";
            this.importantNotesTextBox.Size = new System.Drawing.Size(147, 116);
            this.importantNotesTextBox.TabIndex = 11;
            // 
            // MainMenuToolStripMenuItem
            // 
            this.MainMenuToolStripMenuItem.AccessibleDescription = "This main dropdown menu will redirect the user to another window in application b" +
    "ased on selection from options listed .";
            this.MainMenuToolStripMenuItem.AccessibleName = "MainMenu";
            this.MainMenuToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeScreenToolStripMenuItem,
            this.AboutThisApplicationToolStripMenuItem});
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
            this.HomeScreenToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.HomeScreenToolStripMenuItem.Text = "Go to Home Screen";
            this.HomeScreenToolStripMenuItem.Click += new System.EventHandler(this.HomeScreenToolStripMenuItem_Click_1);
            // 
            // AboutThisApplicationToolStripMenuItem
            // 
            this.AboutThisApplicationToolStripMenuItem.AccessibleDescription = "This main menu option takes the user to a screen that provides further informatio" +
    "n on this application";
            this.AboutThisApplicationToolStripMenuItem.AccessibleName = "AboutAppMenuOption";
            this.AboutThisApplicationToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem";
            this.AboutThisApplicationToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.AboutThisApplicationToolStripMenuItem.Text = "About this Application";
            this.AboutThisApplicationToolStripMenuItem.Click += new System.EventHandler(this.AboutThisApplicationToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UpLoadImageButton
            // 
            this.UpLoadImageButton.Location = new System.Drawing.Point(591, 178);
            this.UpLoadImageButton.Name = "UpLoadImageButton";
            this.UpLoadImageButton.Size = new System.Drawing.Size(94, 23);
            this.UpLoadImageButton.TabIndex = 12;
            this.UpLoadImageButton.Text = "Upload Image";
            this.UpLoadImageButton.UseVisualStyleBackColor = true;
            this.UpLoadImageButton.Click += new System.EventHandler(this.UpLoadImageButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(576, 307);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 56);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Reset Form";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(576, 249);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 52);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.BackgroundImage")));
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.customersBindingSource, "Image", true));
            this.imagePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.InitialImage")));
            this.imagePictureBox.Location = new System.Drawing.Point(563, 27);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(151, 145);
            this.imagePictureBox.TabIndex = 5;
            this.imagePictureBox.TabStop = false;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 375);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.UpLoadImageButton);
            this.Controls.Add(importantNotesLabel);
            this.Controls.Add(this.importantNotesTextBox);
            this.Controls.Add(vetInfoLabel);
            this.Controls.Add(this.vetInfoTextBox);
            this.Controls.Add(secondaryContactInfoLabel);
            this.Controls.Add(this.secondaryContactInfoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(primaryContactPhoneLabel);
            this.Controls.Add(this.primaryContactPhoneTextBox);
            this.Controls.Add(primaryContactLastNameLabel);
            this.Controls.Add(this.primaryContactLastNameTextBox);
            this.Controls.Add(primaryContactFirstNameLabel);
            this.Controls.Add(this.primaryContactFirstNameTextBox);
            this.Controls.Add(ageAtFirstApptLabel);
            this.Controls.Add(this.ageAtFirstApptTextBox);
            this.Controls.Add(sizeCategoryLabel);
            this.Controls.Add(this.sizeCategoryTextBox);
            this.Controls.Add(breedTypeLabel);
            this.Controls.Add(this.breedTypeTextBox);
            this.Controls.Add(nameOfPetLabel);
            this.Controls.Add(this.nameOfPetTextBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer to Directory:     *These fields are required";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private furzaflynDataSet furzaflynDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private furzaflynDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private furzaflynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox nameOfPetTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox sizeCategoryTextBox;
        private System.Windows.Forms.TextBox ageAtFirstApptTextBox;
        private System.Windows.Forms.TextBox primaryContactFirstNameTextBox;
        private System.Windows.Forms.TextBox primaryContactLastNameTextBox;
        private System.Windows.Forms.TextBox primaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox secondaryContactInfoTextBox;
        private System.Windows.Forms.TextBox vetInfoTextBox;
        private System.Windows.Forms.TextBox importantNotesTextBox;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutThisApplicationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button UpLoadImageButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
    }
}