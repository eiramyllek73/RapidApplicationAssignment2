namespace RapidApplicationAssignment
{
    partial class AddCustomer
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
            System.Windows.Forms.Label PetNameLabel;
            System.Windows.Forms.Label ageAtFirstVisitLabel;
            System.Windows.Forms.Label breedTypeLabel;
            System.Windows.Forms.Label sizeCategoryLabel;
            System.Windows.Forms.Label primaryContactFirstNameLabel;
            System.Windows.Forms.Label primaryContactLastNameLabel;
            System.Windows.Forms.Label primaryContactPhoneLabel;
            System.Windows.Forms.Label primaryContactEmailLabel;
            System.Windows.Forms.Label secondaryContactInfoLabel;
            System.Windows.Forms.Label vetInfoLabel;
            System.Windows.Forms.Label importantNotesLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameOfPetTextBox = new System.Windows.Forms.TextBox();
            this.ageAtFirstVisitTextBox = new System.Windows.Forms.TextBox();
            this.breedTypeTextBox = new System.Windows.Forms.TextBox();
            this.sizeCategoryTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactLastNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.primaryContactEmailTextBox = new System.Windows.Forms.TextBox();
            this.secondaryContactNameTextBox = new System.Windows.Forms.TextBox();
            this.vetInfoTextBox = new System.Windows.Forms.TextBox();
            this.importantNotesTextBox = new System.Windows.Forms.TextBox();
            this.saveDetailsButton = new System.Windows.Forms.Button();
            this.clearEditButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.UploadPhotoButton = new System.Windows.Forms.Button();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furzAFlynShopDBDataSet = new RapidApplicationAssignment.FurzAFlynShopDBDataSet();
            this.customersTableAdapter = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager();
            this.furzaflynDataSet = new RapidApplicationAssignment.furzaflynDataSet();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new RapidApplicationAssignment.furzaflynDataSetTableAdapters.CustomersTableAdapter();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            PetNameLabel = new System.Windows.Forms.Label();
            ageAtFirstVisitLabel = new System.Windows.Forms.Label();
            breedTypeLabel = new System.Windows.Forms.Label();
            sizeCategoryLabel = new System.Windows.Forms.Label();
            primaryContactFirstNameLabel = new System.Windows.Forms.Label();
            primaryContactLastNameLabel = new System.Windows.Forms.Label();
            primaryContactPhoneLabel = new System.Windows.Forms.Label();
            primaryContactEmailLabel = new System.Windows.Forms.Label();
            secondaryContactInfoLabel = new System.Windows.Forms.Label();
            vetInfoLabel = new System.Windows.Forms.Label();
            importantNotesLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // PetNameLabel
            // 
            PetNameLabel.AccessibleDescription = "Label for the name of customer.";
            PetNameLabel.AccessibleName = "PetNameLabel";
            PetNameLabel.AutoSize = true;
            PetNameLabel.Location = new System.Drawing.Point(72, 30);
            PetNameLabel.Name = "PetNameLabel";
            PetNameLabel.Size = new System.Drawing.Size(68, 13);
            PetNameLabel.TabIndex = 0;
            PetNameLabel.Text = "Name of pet:";
            // 
            // ageAtFirstVisitLabel
            // 
            ageAtFirstVisitLabel.AccessibleDescription = "Label for the age of customer at first appointment";
            ageAtFirstVisitLabel.AccessibleName = "AgeLabel";
            ageAtFirstVisitLabel.AutoSize = true;
            ageAtFirstVisitLabel.Location = new System.Drawing.Point(59, 56);
            ageAtFirstVisitLabel.Name = "ageAtFirstVisitLabel";
            ageAtFirstVisitLabel.Size = new System.Drawing.Size(81, 13);
            ageAtFirstVisitLabel.TabIndex = 0;
            ageAtFirstVisitLabel.Text = "Age at first visit:";
            // 
            // breedTypeLabel
            // 
            breedTypeLabel.AccessibleDescription = "Label for the type of mixed or pure breed of pet customer.";
            breedTypeLabel.AccessibleName = "BreedTypeLabel";
            breedTypeLabel.AutoSize = true;
            breedTypeLabel.Location = new System.Drawing.Point(75, 82);
            breedTypeLabel.Name = "breedTypeLabel";
            breedTypeLabel.Size = new System.Drawing.Size(65, 13);
            breedTypeLabel.TabIndex = 0;
            breedTypeLabel.Text = "Breed Type:";
            // 
            // sizeCategoryLabel
            // 
            sizeCategoryLabel.AccessibleDescription = "Label for the size catagory of customer, which is either small, medium or large.";
            sizeCategoryLabel.AccessibleName = "SizeCategoryLabel";
            sizeCategoryLabel.AutoSize = true;
            sizeCategoryLabel.Location = new System.Drawing.Point(65, 108);
            sizeCategoryLabel.Name = "sizeCategoryLabel";
            sizeCategoryLabel.Size = new System.Drawing.Size(75, 13);
            sizeCategoryLabel.TabIndex = 0;
            sizeCategoryLabel.Text = "Size Category:";
            // 
            // primaryContactFirstNameLabel
            // 
            primaryContactFirstNameLabel.AccessibleDescription = "Label for the first name of the primary contact for pet customer.";
            primaryContactFirstNameLabel.AccessibleName = "PrimaryContactFirstNameLabel";
            primaryContactFirstNameLabel.AutoSize = true;
            primaryContactFirstNameLabel.Location = new System.Drawing.Point(3, 134);
            primaryContactFirstNameLabel.Name = "primaryContactFirstNameLabel";
            primaryContactFirstNameLabel.Size = new System.Drawing.Size(137, 13);
            primaryContactFirstNameLabel.TabIndex = 0;
            primaryContactFirstNameLabel.Text = "Primary Contact First Name:";
            // 
            // primaryContactLastNameLabel
            // 
            primaryContactLastNameLabel.AccessibleDescription = "Label for the last name of the primary contact for pet customer.";
            primaryContactLastNameLabel.AccessibleName = "PrimaryContactLastNameTextBox";
            primaryContactLastNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            primaryContactLastNameLabel.AutoSize = true;
            primaryContactLastNameLabel.Location = new System.Drawing.Point(2, 160);
            primaryContactLastNameLabel.Name = "primaryContactLastNameLabel";
            primaryContactLastNameLabel.Size = new System.Drawing.Size(138, 13);
            primaryContactLastNameLabel.TabIndex = 0;
            primaryContactLastNameLabel.Text = "Primary Contact Last Name:";
            // 
            // primaryContactPhoneLabel
            // 
            primaryContactPhoneLabel.AccessibleDescription = "Label for the main phone number of the primary contact .";
            primaryContactPhoneLabel.AccessibleName = "PrimaryContactPhone";
            primaryContactPhoneLabel.AutoSize = true;
            primaryContactPhoneLabel.Location = new System.Drawing.Point(22, 186);
            primaryContactPhoneLabel.Name = "primaryContactPhoneLabel";
            primaryContactPhoneLabel.Size = new System.Drawing.Size(118, 13);
            primaryContactPhoneLabel.TabIndex = 0;
            primaryContactPhoneLabel.Text = "Primary Contact Phone:";
            // 
            // primaryContactEmailLabel
            // 
            primaryContactEmailLabel.AccessibleDescription = "Label for the email address of the primary contact.";
            primaryContactEmailLabel.AccessibleName = "PrimaryContactEmailLabel";
            primaryContactEmailLabel.AutoSize = true;
            primaryContactEmailLabel.Location = new System.Drawing.Point(28, 212);
            primaryContactEmailLabel.Name = "primaryContactEmailLabel";
            primaryContactEmailLabel.Size = new System.Drawing.Size(112, 13);
            primaryContactEmailLabel.TabIndex = 0;
            primaryContactEmailLabel.Text = "Primary Contact Email:";
            // 
            // secondaryContactInfoLabel
            // 
            secondaryContactInfoLabel.AccessibleDescription = "Label describing secondary contact info for pet customer.";
            secondaryContactInfoLabel.AccessibleName = "SecondaryContactInfoLabel";
            secondaryContactInfoLabel.AutoSize = true;
            secondaryContactInfoLabel.Location = new System.Drawing.Point(8, 264);
            secondaryContactInfoLabel.Name = "secondaryContactInfoLabel";
            secondaryContactInfoLabel.Size = new System.Drawing.Size(122, 13);
            secondaryContactInfoLabel.TabIndex = 0;
            secondaryContactInfoLabel.Text = "Secondary Contact Info:";
            // 
            // vetInfoLabel
            // 
            vetInfoLabel.AccessibleDescription = "Label of the pet customer\'s vet info";
            vetInfoLabel.AccessibleName = "VetInfoLabel";
            vetInfoLabel.AutoSize = true;
            vetInfoLabel.Location = new System.Drawing.Point(93, 316);
            vetInfoLabel.Name = "vetInfoLabel";
            vetInfoLabel.Size = new System.Drawing.Size(47, 13);
            vetInfoLabel.TabIndex = 0;
            vetInfoLabel.Text = "Vet Info:";
            // 
            // importantNotesLabel
            // 
            importantNotesLabel.AccessibleDescription = "Label for important notes for future appts.";
            importantNotesLabel.AccessibleName = "ImportantNotesLabel";
            importantNotesLabel.AutoSize = true;
            importantNotesLabel.Location = new System.Drawing.Point(55, 342);
            importantNotesLabel.Name = "importantNotesLabel";
            importantNotesLabel.Size = new System.Drawing.Size(85, 13);
            importantNotesLabel.TabIndex = 0;
            importantNotesLabel.Text = "Important Notes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenuToolStrip
            // 
            this.MainMenuToolStrip.AccessibleName = "This is a drop down menu of naviagtion options ";
            this.MainMenuToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MainMenuToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAppointmentLogToolStripMenuItem,
            this.editCustomerDetailsToolStripMenuItem,
            this.viewDirectoryToolStripMenuItem,
            this.goToMainMenuToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.MainMenuToolStrip.Name = "MainMenuToolStrip";
            this.MainMenuToolStrip.Size = new System.Drawing.Size(50, 20);
            this.MainMenuToolStrip.Text = "Menu";
            this.MainMenuToolStrip.ToolTipText = "Main Menu";
            // 
            // viewAppointmentLogToolStripMenuItem
            // 
            this.viewAppointmentLogToolStripMenuItem.AccessibleDescription = "This menu option will take the user to view the appointment log for the selected " +
    "customer";
            this.viewAppointmentLogToolStripMenuItem.AccessibleName = "ViewAppointmentLogMenuOption";
            this.viewAppointmentLogToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.viewAppointmentLogToolStripMenuItem.Name = "viewAppointmentLogToolStripMenuItem";
            this.viewAppointmentLogToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.viewAppointmentLogToolStripMenuItem.Text = "View Appt Log for this Customer";
            this.viewAppointmentLogToolStripMenuItem.Click += new System.EventHandler(this.viewAppointmentLogToolStripMenuItem_Click);
            // 
            // editCustomerDetailsToolStripMenuItem
            // 
            this.editCustomerDetailsToolStripMenuItem.AccessibleDescription = "This menu option will enable the user to edit the details of this customer";
            this.editCustomerDetailsToolStripMenuItem.AccessibleName = "EditCustomerOption";
            this.editCustomerDetailsToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.editCustomerDetailsToolStripMenuItem.Name = "editCustomerDetailsToolStripMenuItem";
            this.editCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.editCustomerDetailsToolStripMenuItem.Text = "Edit Customer Details";
            this.editCustomerDetailsToolStripMenuItem.ToolTipText = "Edit Customer Details";
            this.editCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.editCustomerDetailsToolStripMenuItem_Click);
            // 
            // viewDirectoryToolStripMenuItem
            // 
            this.viewDirectoryToolStripMenuItem.AccessibleDescription = "This menu option will take the user to view the whole customer directory";
            this.viewDirectoryToolStripMenuItem.AccessibleName = "ViewDirectory";
            this.viewDirectoryToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.viewDirectoryToolStripMenuItem.Name = "viewDirectoryToolStripMenuItem";
            this.viewDirectoryToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.viewDirectoryToolStripMenuItem.Text = "View entire Customer Directory";
            this.viewDirectoryToolStripMenuItem.Click += new System.EventHandler(this.viewDirectoryToolStripMenuItem_Click);
            // 
            // goToMainMenuToolStripMenuItem
            // 
            this.goToMainMenuToolStripMenuItem.AccessibleDescription = "This menu option takes the user to the main menu screen of the application.";
            this.goToMainMenuToolStripMenuItem.AccessibleName = "GoToMainMenu";
            this.goToMainMenuToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.goToMainMenuToolStripMenuItem.Name = "goToMainMenuToolStripMenuItem";
            this.goToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.goToMainMenuToolStripMenuItem.Text = "Go to Main Menu";
            this.goToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.goToMainMenuToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.AccessibleDescription = "This menu option will close the application for the user.";
            this.exitApplicationToolStripMenuItem.AccessibleName = "ExitApplication";
            this.exitApplicationToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // nameOfPetTextBox
            // 
            this.nameOfPetTextBox.AccessibleDescription = "This textbox displays the  name of the pet customer";
            this.nameOfPetTextBox.AccessibleName = "PetNameLabel";
            this.nameOfPetTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.nameOfPetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "NameOfPet", true));
            this.nameOfPetTextBox.Location = new System.Drawing.Point(146, 27);
            this.nameOfPetTextBox.Name = "nameOfPetTextBox";
            this.nameOfPetTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameOfPetTextBox.TabIndex = 1;
            // 
            // ageAtFirstVisitTextBox
            // 
            this.ageAtFirstVisitTextBox.AccessibleDescription = "This text box displays  the age of the pet at first visit.";
            this.ageAtFirstVisitTextBox.AccessibleName = "AgeOfPetTextBox";
            this.ageAtFirstVisitTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.ageAtFirstVisitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "AgeAtFirstAppt", true));
            this.ageAtFirstVisitTextBox.Location = new System.Drawing.Point(146, 53);
            this.ageAtFirstVisitTextBox.Name = "ageAtFirstVisitTextBox";
            this.ageAtFirstVisitTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageAtFirstVisitTextBox.TabIndex = 2;
            // 
            // breedTypeTextBox
            // 
            this.breedTypeTextBox.AccessibleDescription = "Text box that displays the breed or mix of the pet animal.";
            this.breedTypeTextBox.AccessibleName = "BreedTextBox";
            this.breedTypeTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.breedTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "BreedType", true));
            this.breedTypeTextBox.Location = new System.Drawing.Point(146, 79);
            this.breedTypeTextBox.Name = "breedTypeTextBox";
            this.breedTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.breedTypeTextBox.TabIndex = 3;
            // 
            // sizeCategoryTextBox
            // 
            this.sizeCategoryTextBox.AccessibleDescription = "This text box displays the size category of the pet, which is either small, mediu" +
    "m or large";
            this.sizeCategoryTextBox.AccessibleName = "BreedTextBox";
            this.sizeCategoryTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.sizeCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "SizeCategory", true));
            this.sizeCategoryTextBox.Location = new System.Drawing.Point(146, 105);
            this.sizeCategoryTextBox.Name = "sizeCategoryTextBox";
            this.sizeCategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeCategoryTextBox.TabIndex = 4;
            // 
            // primaryContactFirstNameTextBox
            // 
            this.primaryContactFirstNameTextBox.AccessibleDescription = "This text box displays the pet animal\'s primary contact\'s first name";
            this.primaryContactFirstNameTextBox.AccessibleName = "PrimaryContactFirstNameTextBox";
            this.primaryContactFirstNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.primaryContactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "PrimaryContactFirstName", true));
            this.primaryContactFirstNameTextBox.Location = new System.Drawing.Point(146, 131);
            this.primaryContactFirstNameTextBox.Name = "primaryContactFirstNameTextBox";
            this.primaryContactFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactFirstNameTextBox.TabIndex = 5;
            // 
            // primaryContactLastNameTextBox
            // 
            this.primaryContactLastNameTextBox.AccessibleDescription = "This text box displays the pet animal\'s primary contact\'s last name";
            this.primaryContactLastNameTextBox.AccessibleName = "PrimaryContactLastNameTextBox";
            this.primaryContactLastNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.primaryContactLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "PrimaryContactLastName", true));
            this.primaryContactLastNameTextBox.Location = new System.Drawing.Point(146, 157);
            this.primaryContactLastNameTextBox.Name = "primaryContactLastNameTextBox";
            this.primaryContactLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactLastNameTextBox.TabIndex = 6;
            // 
            // primaryContactPhoneTextBox
            // 
            this.primaryContactPhoneTextBox.AccessibleDescription = "This text box displays the pet animal\'s primary contact\'s main phone number.";
            this.primaryContactPhoneTextBox.AccessibleName = "PrimaryContactPhoneTextBox";
            this.primaryContactPhoneTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.primaryContactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "PrimaryContactPhone", true));
            this.primaryContactPhoneTextBox.Location = new System.Drawing.Point(146, 186);
            this.primaryContactPhoneTextBox.Name = "primaryContactPhoneTextBox";
            this.primaryContactPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactPhoneTextBox.TabIndex = 7;
            // 
            // primaryContactEmailTextBox
            // 
            this.primaryContactEmailTextBox.AccessibleDescription = "This text box displays the pet animal\'s primary contact\'s main phone number.";
            this.primaryContactEmailTextBox.AccessibleName = "PrimaryContactEmailTextBox";
            this.primaryContactEmailTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.primaryContactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "Email", true));
            this.primaryContactEmailTextBox.Location = new System.Drawing.Point(146, 209);
            this.primaryContactEmailTextBox.Name = "primaryContactEmailTextBox";
            this.primaryContactEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryContactEmailTextBox.TabIndex = 8;
            // 
            // secondaryContactNameTextBox
            // 
            this.secondaryContactNameTextBox.AccessibleDescription = "This text box displays the customer\'s secondary contact info";
            this.secondaryContactNameTextBox.AccessibleName = "SecondaryContactInfoTextBox";
            this.secondaryContactNameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.secondaryContactNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "SecondaryContactInfo", true));
            this.secondaryContactNameTextBox.Location = new System.Drawing.Point(146, 261);
            this.secondaryContactNameTextBox.Multiline = true;
            this.secondaryContactNameTextBox.Name = "secondaryContactNameTextBox";
            this.secondaryContactNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryContactNameTextBox.TabIndex = 10;
            // 
            // vetInfoTextBox
            // 
            this.vetInfoTextBox.AccessibleDescription = "This text box displays the pet animal\'s vet info";
            this.vetInfoTextBox.AccessibleName = "VetInfoTextBox";
            this.vetInfoTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.vetInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "VetInfo", true));
            this.vetInfoTextBox.Location = new System.Drawing.Point(146, 313);
            this.vetInfoTextBox.Multiline = true;
            this.vetInfoTextBox.Name = "vetInfoTextBox";
            this.vetInfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vetInfoTextBox.TabIndex = 12;
            // 
            // importantNotesTextBox
            // 
            this.importantNotesTextBox.AccessibleDescription = "This text box displays the pet animal\'s important notes";
            this.importantNotesTextBox.AccessibleName = "ImportantNotesTextBox";
            this.importantNotesTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.importantNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "ImportantNotes", true));
            this.importantNotesTextBox.Location = new System.Drawing.Point(146, 339);
            this.importantNotesTextBox.Multiline = true;
            this.importantNotesTextBox.Name = "importantNotesTextBox";
            this.importantNotesTextBox.Size = new System.Drawing.Size(100, 20);
            this.importantNotesTextBox.TabIndex = 13;
            // 
            // saveDetailsButton
            // 
            this.saveDetailsButton.AccessibleDescription = "This button will save the details entered and create a new customer in the direct" +
    "ory.";
            this.saveDetailsButton.AccessibleName = "SaveNewCustomerButton";
            this.saveDetailsButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.saveDetailsButton.Location = new System.Drawing.Point(262, 337);
            this.saveDetailsButton.Name = "saveDetailsButton";
            this.saveDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.saveDetailsButton.TabIndex = 15;
            this.saveDetailsButton.Text = "Save";
            this.saveDetailsButton.UseVisualStyleBackColor = true;
            this.saveDetailsButton.Click += new System.EventHandler(this.saveDetailsButton_Click);
            // 
            // clearEditButton
            // 
            this.clearEditButton.AccessibleDescription = "This button will clear the details entered  without saving to the database.";
            this.clearEditButton.AccessibleName = "CancelButton";
            this.clearEditButton.Location = new System.Drawing.Point(343, 337);
            this.clearEditButton.Name = "clearEditButton";
            this.clearEditButton.Size = new System.Drawing.Size(75, 23);
            this.clearEditButton.TabIndex = 16;
            this.clearEditButton.Text = "Clear";
            this.clearEditButton.UseVisualStyleBackColor = true;
            this.clearEditButton.Click += new System.EventHandler(this.clearEditButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.AccessibleDescription = "This picture box will display a photo of the user\'s choice for this customer entr" +
    "y in the customer directory database.";
            this.pictureBox.AccessibleName = "PhotoPictureBox";
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.customersBindingSource1, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(262, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(155, 147);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // UploadPhotoButton
            // 
            this.UploadPhotoButton.AccessibleDescription = "This is a button that when pressed, will allow the user to upload a photo to repr" +
    "esent this customer.";
            this.UploadPhotoButton.AccessibleName = "UploadPhotoButton";
            this.UploadPhotoButton.Location = new System.Drawing.Point(262, 182);
            this.UploadPhotoButton.Name = "UploadPhotoButton";
            this.UploadPhotoButton.Size = new System.Drawing.Size(156, 23);
            this.UploadPhotoButton.TabIndex = 14;
            this.UploadPhotoButton.Text = "Upload Photo";
            this.UploadPhotoButton.UseVisualStyleBackColor = true;
            this.UploadPhotoButton.Click += new System.EventHandler(this.UploadPhotoButton_Click);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.furzAFlynShopDBDataSet;
            // 
            // furzAFlynShopDBDataSet
            // 
            this.furzAFlynShopDBDataSet.DataSetName = "FurzAFlynShopDBDataSet";
            this.furzAFlynShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.UpdateOrder = RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // furzaflynDataSet
            // 
            this.furzaflynDataSet.DataSetName = "furzaflynDataSet";
            this.furzaflynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.furzaflynDataSet;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.furzaflynDataSet;
            // 
            // customersBindingSource3
            // 
            this.customersBindingSource3.DataMember = "Customers";
            this.customersBindingSource3.DataSource = this.furzaflynDataSet;
            // 
            // customersBindingSource4
            // 
            this.customersBindingSource4.DataMember = "Customers";
            this.customersBindingSource4.DataSource = this.furzaflynDataSet;
            // 
            // AddCustomer
            // 
            this.AccessibleDescription = "This form is for entering new details, creating a new customer in the database di" +
    "rectory";
            this.AccessibleName = "AddCustomerForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 380);
            this.Controls.Add(this.UploadPhotoButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.clearEditButton);
            this.Controls.Add(this.saveDetailsButton);
            this.Controls.Add(importantNotesLabel);
            this.Controls.Add(this.importantNotesTextBox);
            this.Controls.Add(vetInfoLabel);
            this.Controls.Add(this.vetInfoTextBox);
            this.Controls.Add(secondaryContactInfoLabel);
            this.Controls.Add(this.secondaryContactNameTextBox);
            this.Controls.Add(primaryContactEmailLabel);
            this.Controls.Add(this.primaryContactEmailTextBox);
            this.Controls.Add(primaryContactPhoneLabel);
            this.Controls.Add(this.primaryContactPhoneTextBox);
            this.Controls.Add(primaryContactLastNameLabel);
            this.Controls.Add(this.primaryContactLastNameTextBox);
            this.Controls.Add(primaryContactFirstNameLabel);
            this.Controls.Add(this.primaryContactFirstNameTextBox);
            this.Controls.Add(sizeCategoryLabel);
            this.Controls.Add(this.sizeCategoryTextBox);
            this.Controls.Add(breedTypeLabel);
            this.Controls.Add(this.breedTypeTextBox);
            this.Controls.Add(ageAtFirstVisitLabel);
            this.Controls.Add(this.ageAtFirstVisitTextBox);
            this.Controls.Add(PetNameLabel);
            this.Controls.Add(this.nameOfPetTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FurzAFlynShopDBDataSet furzAFlynShopDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.TextBox nameOfPetTextBox;
        private System.Windows.Forms.TextBox ageAtFirstVisitTextBox;
        private System.Windows.Forms.TextBox breedTypeTextBox;
        private System.Windows.Forms.TextBox sizeCategoryTextBox;
        private System.Windows.Forms.TextBox primaryContactFirstNameTextBox;
        private System.Windows.Forms.TextBox primaryContactLastNameTextBox;
        private System.Windows.Forms.TextBox primaryContactPhoneTextBox;
        private System.Windows.Forms.TextBox primaryContactEmailTextBox;
        private System.Windows.Forms.TextBox secondaryContactNameTextBox;
        private System.Windows.Forms.TextBox vetInfoTextBox;
        private System.Windows.Forms.TextBox importantNotesTextBox;
        private System.Windows.Forms.Button saveDetailsButton;
        private System.Windows.Forms.Button clearEditButton;
        private System.Windows.Forms.ToolStripMenuItem editCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button UploadPhotoButton;
        private furzaflynDataSet furzaflynDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private furzaflynDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private System.Windows.Forms.BindingSource customersBindingSource3;
        private System.Windows.Forms.BindingSource customersBindingSource4;
    }
}