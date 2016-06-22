namespace RapidApplicationAssignment
{
    partial class Directory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Directory));
            this.furzaflynDataSet = new RapidApplicationAssignment.furzaflynDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new RapidApplicationAssignment.furzaflynDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.furzaflynDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.CustIDGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcLnameDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContactGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.AboutThisApplicationToolStripMenuItem,
            this.ExitAppToolStripMenuItem});
            this.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem";
            this.MainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
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
            this.HomeScreenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.HomeScreenToolStripMenuItem.Text = "Go to Home Screen";
            this.HomeScreenToolStripMenuItem.Click += new System.EventHandler(this.HomeScreenToolStripMenuItem_Click);
            // 
            // AboutThisApplicationToolStripMenuItem
            // 
            this.AboutThisApplicationToolStripMenuItem.AccessibleDescription = "This main menu option takes the user to a screen that provides further informatio" +
    "n on this application";
            this.AboutThisApplicationToolStripMenuItem.AccessibleName = "AboutAppMenuOption";
            this.AboutThisApplicationToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem";
            this.AboutThisApplicationToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.AboutThisApplicationToolStripMenuItem.Text = "About this Application";
            this.AboutThisApplicationToolStripMenuItem.Click += new System.EventHandler(this.AboutThisApplicationToolStripMenuItem_Click);
            // 
            // ExitAppToolStripMenuItem
            // 
            this.ExitAppToolStripMenuItem.AccessibleDescription = "This main menu option will close or end this application for the user.";
            this.ExitAppToolStripMenuItem.AccessibleName = "ExitAppMenuOption";
            this.ExitAppToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.ExitAppToolStripMenuItem.Name = "ExitAppToolStripMenuItem";
            this.ExitAppToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ExitAppToolStripMenuItem.Text = "Exit Application";
            this.ExitAppToolStripMenuItem.Click += new System.EventHandler(this.ExitAppToolStripMenuItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customersBindingNavigatorSaveItem
            // 
            this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
            this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
            this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customersBindingNavigatorSaveItem.Text = "Save Data";
            this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customersBindingNavigatorSaveItem});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1362, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustIDGridViewTextBoxColumn,
            this.PetNameDataGridViewTextBoxColumn,
            this.BreedTypeDataGridViewTextBoxColumn,
            this.SizeCategoryDataGridViewTextBoxColumn,
            this.AgeDataGridViewTextBoxColumn,
            this.PcFnameDataGridViewTextBoxColumn,
            this.PcLnameDataGridViewTextBoxColumn7,
            this.PcPhoneDataGridViewTextBoxColumn,
            this.EmailDataGridViewTextBoxColumn9,
            this.sContactGridViewTextBoxColumn,
            this.VetDataGridViewTextBoxColumn,
            this.NotesDataGridViewTextBoxColumn,
            this.ImageDataGridViewImageColumn});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 52);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(1338, 220);
            this.customersDataGridView.TabIndex = 2;
            // 
            // CustIDGridViewTextBoxColumn
            // 
            this.CustIDGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustIDGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.CustIDGridViewTextBoxColumn.HeaderText = "ID#";
            this.CustIDGridViewTextBoxColumn.MaxInputLength = 2000;
            this.CustIDGridViewTextBoxColumn.Name = "CustIDGridViewTextBoxColumn";
            this.CustIDGridViewTextBoxColumn.ReadOnly = true;
            this.CustIDGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CustIDGridViewTextBoxColumn.ToolTipText = "ID# given when customer is added to the database";
            this.CustIDGridViewTextBoxColumn.Visible = false;
            this.CustIDGridViewTextBoxColumn.Width = 50;
            // 
            // PetNameDataGridViewTextBoxColumn
            // 
            this.PetNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PetNameDataGridViewTextBoxColumn.DataPropertyName = "NameOfPet";
            this.PetNameDataGridViewTextBoxColumn.HeaderText = "Pet\'s Name:";
            this.PetNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.PetNameDataGridViewTextBoxColumn.Name = "PetNameDataGridViewTextBoxColumn";
            this.PetNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.PetNameDataGridViewTextBoxColumn.Width = 89;
            // 
            // BreedTypeDataGridViewTextBoxColumn
            // 
            this.BreedTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BreedTypeDataGridViewTextBoxColumn.DataPropertyName = "BreedType";
            this.BreedTypeDataGridViewTextBoxColumn.HeaderText = "Breed/Mix Type:";
            this.BreedTypeDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.BreedTypeDataGridViewTextBoxColumn.Name = "BreedTypeDataGridViewTextBoxColumn";
            this.BreedTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.BreedTypeDataGridViewTextBoxColumn.Width = 102;
            // 
            // SizeCategoryDataGridViewTextBoxColumn
            // 
            this.SizeCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SizeCategoryDataGridViewTextBoxColumn.DataPropertyName = "SizeCategory";
            this.SizeCategoryDataGridViewTextBoxColumn.HeaderText = "Size Category:";
            this.SizeCategoryDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.SizeCategoryDataGridViewTextBoxColumn.Name = "SizeCategoryDataGridViewTextBoxColumn";
            this.SizeCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.SizeCategoryDataGridViewTextBoxColumn.Width = 92;
            // 
            // AgeDataGridViewTextBoxColumn
            // 
            this.AgeDataGridViewTextBoxColumn.DataPropertyName = "AgeAtFirstAppt";
            this.AgeDataGridViewTextBoxColumn.HeaderText = "Age @ 1st Appt:";
            this.AgeDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn";
            this.AgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.AgeDataGridViewTextBoxColumn.Visible = false;
            // 
            // PcFnameDataGridViewTextBoxColumn
            // 
            this.PcFnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PcFnameDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContactFirstName";
            this.PcFnameDataGridViewTextBoxColumn.HeaderText = "Primary Contact 1st Name:";
            this.PcFnameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.PcFnameDataGridViewTextBoxColumn.Name = "PcFnameDataGridViewTextBoxColumn";
            this.PcFnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.PcFnameDataGridViewTextBoxColumn.Width = 115;
            // 
            // PcLnameDataGridViewTextBoxColumn7
            // 
            this.PcLnameDataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PcLnameDataGridViewTextBoxColumn7.DataPropertyName = "PrimaryContactLastName";
            this.PcLnameDataGridViewTextBoxColumn7.HeaderText = "Primary Last Name:";
            this.PcLnameDataGridViewTextBoxColumn7.MaxInputLength = 100;
            this.PcLnameDataGridViewTextBoxColumn7.Name = "PcLnameDataGridViewTextBoxColumn7";
            this.PcLnameDataGridViewTextBoxColumn7.ReadOnly = true;
            this.PcLnameDataGridViewTextBoxColumn7.Width = 113;
            // 
            // PcPhoneDataGridViewTextBoxColumn
            // 
            this.PcPhoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PcPhoneDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContactPhone";
            this.PcPhoneDataGridViewTextBoxColumn.HeaderText = "Primary Phone:";
            this.PcPhoneDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.PcPhoneDataGridViewTextBoxColumn.Name = "PcPhoneDataGridViewTextBoxColumn";
            this.PcPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.PcPhoneDataGridViewTextBoxColumn.Width = 95;
            // 
            // EmailDataGridViewTextBoxColumn9
            // 
            this.EmailDataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmailDataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.EmailDataGridViewTextBoxColumn9.HeaderText = "Primary Email:";
            this.EmailDataGridViewTextBoxColumn9.MaxInputLength = 100;
            this.EmailDataGridViewTextBoxColumn9.Name = "EmailDataGridViewTextBoxColumn9";
            this.EmailDataGridViewTextBoxColumn9.Width = 89;
            // 
            // sContactGridViewTextBoxColumn
            // 
            this.sContactGridViewTextBoxColumn.DataPropertyName = "SecondaryContactInfo";
            this.sContactGridViewTextBoxColumn.HeaderText = "SecondaryContactInfo";
            this.sContactGridViewTextBoxColumn.Name = "sContactGridViewTextBoxColumn";
            this.sContactGridViewTextBoxColumn.ReadOnly = true;
            this.sContactGridViewTextBoxColumn.Visible = false;
            // 
            // VetDataGridViewTextBoxColumn
            // 
            this.VetDataGridViewTextBoxColumn.DataPropertyName = "VetInfo";
            this.VetDataGridViewTextBoxColumn.HeaderText = "VetInfo";
            this.VetDataGridViewTextBoxColumn.MaxInputLength = 1000;
            this.VetDataGridViewTextBoxColumn.Name = "VetDataGridViewTextBoxColumn";
            this.VetDataGridViewTextBoxColumn.ReadOnly = true;
            this.VetDataGridViewTextBoxColumn.Visible = false;
            // 
            // NotesDataGridViewTextBoxColumn
            // 
            this.NotesDataGridViewTextBoxColumn.DataPropertyName = "ImportantNotes";
            this.NotesDataGridViewTextBoxColumn.HeaderText = "ImportantNotes";
            this.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn";
            this.NotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.NotesDataGridViewTextBoxColumn.Visible = false;
            // 
            // ImageDataGridViewImageColumn
            // 
            this.ImageDataGridViewImageColumn.DataPropertyName = "Image";
            this.ImageDataGridViewImageColumn.HeaderText = "Image";
            this.ImageDataGridViewImageColumn.Name = "ImageDataGridViewImageColumn";
            this.ImageDataGridViewImageColumn.ReadOnly = true;
            this.ImageDataGridViewImageColumn.Visible = false;
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 362);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.customersBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Directory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Directory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private furzaflynDataSet furzaflynDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private furzaflynDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private furzaflynDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HomeScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutThisApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustIDGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcLnameDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn sContactGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ImageDataGridViewImageColumn;
    }
}