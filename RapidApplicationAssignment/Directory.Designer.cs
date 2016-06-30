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
            this.editSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.furzaflynDataSet1 = new RapidApplicationAssignment.furzaflynDataSet1();
            this.furzaflynDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petCustomersTableAdapter = new RapidApplicationAssignment.furzaflynDataSet1TableAdapters.PetCustomersTableAdapter();
            this.tableAdapterManager1 = new RapidApplicationAssignment.furzaflynDataSet1TableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfPetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageAtFirstVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importantNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersBindingSource)).BeginInit();
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
            this.MainMenuToolStripMenuItem,
            this.editSelectionToolStripMenuItem,
            this.deleteSelectedCustomerToolStripMenuItem,
            this.createCustomerInvoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
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
            // editSelectionToolStripMenuItem
            // 
            this.editSelectionToolStripMenuItem.Name = "editSelectionToolStripMenuItem";
            this.editSelectionToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.editSelectionToolStripMenuItem.Text = "Edit Customer Details";
            // 
            // deleteSelectedCustomerToolStripMenuItem
            // 
            this.deleteSelectedCustomerToolStripMenuItem.Name = "deleteSelectedCustomerToolStripMenuItem";
            this.deleteSelectedCustomerToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.deleteSelectedCustomerToolStripMenuItem.Text = "View Customer Appt Log";
            // 
            // createCustomerInvoiceToolStripMenuItem
            // 
            this.createCustomerInvoiceToolStripMenuItem.Name = "createCustomerInvoiceToolStripMenuItem";
            this.createCustomerInvoiceToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.createCustomerInvoiceToolStripMenuItem.Text = "Create Customer Invoice";
            this.createCustomerInvoiceToolStripMenuItem.Click += new System.EventHandler(this.createCustomerInvoiceToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameOfPetDataGridViewTextBoxColumn,
            this.breedTypeDataGridViewTextBoxColumn,
            this.sizeCategoryDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.ageAtFirstVisitDataGridViewTextBoxColumn,
            this.primaryPhoneDataGridViewTextBoxColumn,
            this.importantNotesDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.petCustomersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // furzaflynDataSet1
            // 
            this.furzaflynDataSet1.DataSetName = "furzaflynDataSet1";
            this.furzaflynDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furzaflynDataSet1BindingSource
            // 
            this.furzaflynDataSet1BindingSource.DataSource = this.furzaflynDataSet1;
            this.furzaflynDataSet1BindingSource.Position = 0;
            // 
            // petCustomersBindingSource
            // 
            this.petCustomersBindingSource.DataMember = "PetCustomers";
            this.petCustomersBindingSource.DataSource = this.furzaflynDataSet1;
            // 
            // petCustomersTableAdapter
            // 
            this.petCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AppointmentsLogTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomerContactsTableAdapter = null;
            this.tableAdapterManager1.PetCustomersTableAdapter = this.petCustomersTableAdapter;
            this.tableAdapterManager1.UpdateOrder = RapidApplicationAssignment.furzaflynDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Pet ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameOfPetDataGridViewTextBoxColumn
            // 
            this.nameOfPetDataGridViewTextBoxColumn.DataPropertyName = "NameOfPet";
            this.nameOfPetDataGridViewTextBoxColumn.HeaderText = "Name of Pet";
            this.nameOfPetDataGridViewTextBoxColumn.Name = "nameOfPetDataGridViewTextBoxColumn";
            // 
            // breedTypeDataGridViewTextBoxColumn
            // 
            this.breedTypeDataGridViewTextBoxColumn.DataPropertyName = "BreedType";
            this.breedTypeDataGridViewTextBoxColumn.HeaderText = "Breed/Mix Type";
            this.breedTypeDataGridViewTextBoxColumn.Name = "breedTypeDataGridViewTextBoxColumn";
            // 
            // sizeCategoryDataGridViewTextBoxColumn
            // 
            this.sizeCategoryDataGridViewTextBoxColumn.DataPropertyName = "SizeCategory";
            this.sizeCategoryDataGridViewTextBoxColumn.HeaderText = "Size Category";
            this.sizeCategoryDataGridViewTextBoxColumn.Name = "sizeCategoryDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // ageAtFirstVisitDataGridViewTextBoxColumn
            // 
            this.ageAtFirstVisitDataGridViewTextBoxColumn.DataPropertyName = "AgeAtFirstVisit";
            this.ageAtFirstVisitDataGridViewTextBoxColumn.HeaderText = "Age at First Visit";
            this.ageAtFirstVisitDataGridViewTextBoxColumn.Name = "ageAtFirstVisitDataGridViewTextBoxColumn";
            // 
            // primaryPhoneDataGridViewTextBoxColumn
            // 
            this.primaryPhoneDataGridViewTextBoxColumn.DataPropertyName = "PrimaryPhone";
            this.primaryPhoneDataGridViewTextBoxColumn.HeaderText = "Primary Phone #";
            this.primaryPhoneDataGridViewTextBoxColumn.Name = "primaryPhoneDataGridViewTextBoxColumn";
            // 
            // importantNotesDataGridViewTextBoxColumn
            // 
            this.importantNotesDataGridViewTextBoxColumn.DataPropertyName = "ImportantNotes";
            this.importantNotesDataGridViewTextBoxColumn.HeaderText = "Important Notes";
            this.importantNotesDataGridViewTextBoxColumn.Name = "importantNotesDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(963, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Directory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Directory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Directory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ToolStripMenuItem editSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerInvoiceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource furzaflynDataSet1BindingSource;
        private furzaflynDataSet1 furzaflynDataSet1;
        private System.Windows.Forms.BindingSource petCustomersBindingSource;
        private furzaflynDataSet1TableAdapters.PetCustomersTableAdapter petCustomersTableAdapter;
        private furzaflynDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfPetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageAtFirstVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importantNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
    }
}