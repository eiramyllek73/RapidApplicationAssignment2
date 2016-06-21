namespace RapidApplicationAssignment
{
    partial class CustomerDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDirectory));
            this.furzAFlynShopDBDataSet = new RapidApplicationAssignment.FurzAFlynShopDBDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SelectedCustomerBindingNavigator = new System.Windows.Forms.ToolStripTextBox();
            this.TotalCountBindingNavigator = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddCustomerBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.DeleteCustomerBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.FirstCustomerBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.MovePreviousCustomerBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.MoveNextICustomerBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.LastCustomerBindingNavigator = new System.Windows.Forms.ToolStripButton();
            this.CustIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfPetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BreedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcFnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcLnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcAltPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecContactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VetInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // furzAFlynShopDBDataSet
            // 
            this.furzAFlynShopDBDataSet.DataSetName = "FurzAFlynShopDBDataSet";
            this.furzAFlynShopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.furzAFlynShopDBDataSet;
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
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = this.AddCustomerBindingNavigator;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.TotalCountBindingNavigator;
            this.customersBindingNavigator.DeleteItem = this.DeleteCustomerBindingNavigator;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstCustomerBindingNavigator,
            this.MovePreviousCustomerBindingNavigator,
            this.bindingNavigatorSeparator,
            this.SelectedCustomerBindingNavigator,
            this.TotalCountBindingNavigator,
            this.bindingNavigatorSeparator1,
            this.MoveNextICustomerBindingNavigator,
            this.LastCustomerBindingNavigator,
            this.bindingNavigatorSeparator2,
            this.AddCustomerBindingNavigator,
            this.DeleteCustomerBindingNavigator});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = this.FirstCustomerBindingNavigator;
            this.customersBindingNavigator.MoveLastItem = this.LastCustomerBindingNavigator;
            this.customersBindingNavigator.MoveNextItem = this.MoveNextICustomerBindingNavigator;
            this.customersBindingNavigator.MovePreviousItem = this.MovePreviousCustomerBindingNavigator;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.SelectedCustomerBindingNavigator;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1354, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // SelectedCustomerBindingNavigator
            // 
            this.SelectedCustomerBindingNavigator.AccessibleDescription = "This textbox displays the ID number of the slected item in the directory ";
            this.SelectedCustomerBindingNavigator.AccessibleName = "CurrentCustomerID";
            this.SelectedCustomerBindingNavigator.AutoSize = false;
            this.SelectedCustomerBindingNavigator.MaxLength = 3000;
            this.SelectedCustomerBindingNavigator.Name = "bindingNavigatorPositionItem";
            this.SelectedCustomerBindingNavigator.Size = new System.Drawing.Size(50, 23);
            this.SelectedCustomerBindingNavigator.Text = "0";
            this.SelectedCustomerBindingNavigator.ToolTipText = "Current customer id selected in directory";
            // 
            // TotalCountBindingNavigator
            // 
            this.TotalCountBindingNavigator.AccessibleDescription = "This box displays the total number of customers in the directory.";
            this.TotalCountBindingNavigator.AccessibleName = "TotalCustomerCount";
            this.TotalCountBindingNavigator.Name = "bindingNavigatorCountItem";
            this.TotalCountBindingNavigator.Size = new System.Drawing.Size(35, 22);
            this.TotalCountBindingNavigator.Text = "of {0}";
            this.TotalCountBindingNavigator.ToolTipText = "Total number of customers in directory";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustIDDataGridViewTextBoxColumn,
            this.NameOfPetDataGridViewTextBoxColumn,
            this.AgeDataGridViewTextBoxColumn,
            this.BreedDataGridViewTextBoxColumn,
            this.SizeDataGridViewTextBoxColumn,
            this.PcFnameDataGridViewTextBoxColumn,
            this.PcLnameDataGridViewTextBoxColumn,
            this.PcPhoneDataGridViewTextBoxColumn,
            this.PcEmailDataGridViewTextBoxColumn,
            this.PcAltPhoneDataGridViewTextBoxColumn,
            this.SecContactNameDataGridViewTextBoxColumn,
            this.SecPhoneDataGridViewTextBoxColumn,
            this.VetInfoDataGridViewTextBoxColumn,
            this.NotesDataGridViewTextBoxColumn,
            this.PhotoDataGridViewTextBoxColumn});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 47);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(1330, 227);
            this.customersDataGridView.TabIndex = 1;
            // 
            // AddCustomerBindingNavigator
            // 
            this.AddCustomerBindingNavigator.AccessibleDescription = "This button will take the user to the add customer form in the application,";
            this.AddCustomerBindingNavigator.AccessibleName = "AddCustomer";
            this.AddCustomerBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCustomerBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("AddCustomerBindingNavigator.Image")));
            this.AddCustomerBindingNavigator.Name = "AddCustomerBindingNavigator";
            this.AddCustomerBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.AddCustomerBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.AddCustomerBindingNavigator.ToolTipText = "Add a new customer to the directory";
            // 
            // DeleteCustomerBindingNavigator
            // 
            this.DeleteCustomerBindingNavigator.AccessibleDescription = "This button will delete a customer in the directory.";
            this.DeleteCustomerBindingNavigator.AccessibleName = "DeleteCustomer";
            this.DeleteCustomerBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCustomerBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCustomerBindingNavigator.Image")));
            this.DeleteCustomerBindingNavigator.Name = "DeleteCustomerBindingNavigator";
            this.DeleteCustomerBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.DeleteCustomerBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.DeleteCustomerBindingNavigator.ToolTipText = "Delete selected customer from directory";
            // 
            // FirstCustomerBindingNavigator
            // 
            this.FirstCustomerBindingNavigator.AccessibleDescription = "This button will take the user to the first customer in the directory.";
            this.FirstCustomerBindingNavigator.AccessibleName = "FirstCustomer";
            this.FirstCustomerBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstCustomerBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("FirstCustomerBindingNavigator.Image")));
            this.FirstCustomerBindingNavigator.Name = "FirstCustomerBindingNavigator";
            this.FirstCustomerBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.FirstCustomerBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.FirstCustomerBindingNavigator.ToolTipText = "Move to first customer in the directory";
            // 
            // MovePreviousCustomerBindingNavigator
            // 
            this.MovePreviousCustomerBindingNavigator.AccessibleDescription = "This button will move the user to the previous entry in the directory list.";
            this.MovePreviousCustomerBindingNavigator.AccessibleName = "MoveToPreviousCustomer";
            this.MovePreviousCustomerBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePreviousCustomerBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("MovePreviousCustomerBindingNavigator.Image")));
            this.MovePreviousCustomerBindingNavigator.Name = "MovePreviousCustomerBindingNavigator";
            this.MovePreviousCustomerBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.MovePreviousCustomerBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.MovePreviousCustomerBindingNavigator.ToolTipText = "Move back one customer in directory.";
            // 
            // MoveNextICustomerBindingNavigator
            // 
            this.MoveNextICustomerBindingNavigator.AccessibleDescription = "This button will move the user to the next customer in the directory.";
            this.MoveNextICustomerBindingNavigator.AccessibleName = "MoveNext";
            this.MoveNextICustomerBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNextICustomerBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("MoveNextICustomerBindingNavigator.Image")));
            this.MoveNextICustomerBindingNavigator.Name = "MoveNextICustomerBindingNavigator";
            this.MoveNextICustomerBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.MoveNextICustomerBindingNavigator.Size = new System.Drawing.Size(23, 22);
            // 
            // LastCustomerBindingNavigator
            // 
            this.LastCustomerBindingNavigator.AccessibleDescription = "This button will move the user to the last customer in the directory.";
            this.LastCustomerBindingNavigator.AccessibleName = "LastCustomer";
            this.LastCustomerBindingNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastCustomerBindingNavigator.Image = ((System.Drawing.Image)(resources.GetObject("LastCustomerBindingNavigator.Image")));
            this.LastCustomerBindingNavigator.Name = "LastCustomerBindingNavigator";
            this.LastCustomerBindingNavigator.RightToLeftAutoMirrorImage = true;
            this.LastCustomerBindingNavigator.Size = new System.Drawing.Size(23, 22);
            this.LastCustomerBindingNavigator.ToolTipText = "Move to last customer in directory";
            // 
            // CustIDDataGridViewTextBoxColumn
            // 
            this.CustIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.CustIDDataGridViewTextBoxColumn.HeaderText = "ID#";
            this.CustIDDataGridViewTextBoxColumn.MaxInputLength = 2000;
            this.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn";
            this.CustIDDataGridViewTextBoxColumn.ToolTipText = "Position # in customer database";
            this.CustIDDataGridViewTextBoxColumn.Visible = false;
            this.CustIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // NameOfPetDataGridViewTextBoxColumn
            // 
            this.NameOfPetDataGridViewTextBoxColumn.DataPropertyName = "NameOfPet";
            this.NameOfPetDataGridViewTextBoxColumn.HeaderText = "Name Of Pet";
            this.NameOfPetDataGridViewTextBoxColumn.MaxInputLength = 75;
            this.NameOfPetDataGridViewTextBoxColumn.Name = "NameOfPetDataGridViewTextBoxColumn";
            // 
            // AgeDataGridViewTextBoxColumn
            // 
            this.AgeDataGridViewTextBoxColumn.DataPropertyName = "AgeAtFirstVisit";
            this.AgeDataGridViewTextBoxColumn.HeaderText = "Age @ 1st Visit";
            this.AgeDataGridViewTextBoxColumn.MaxInputLength = 75;
            this.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn";
            // 
            // BreedDataGridViewTextBoxColumn
            // 
            this.BreedDataGridViewTextBoxColumn.DataPropertyName = "BreedType";
            this.BreedDataGridViewTextBoxColumn.HeaderText = "Breed Type";
            this.BreedDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.BreedDataGridViewTextBoxColumn.Name = "BreedDataGridViewTextBoxColumn";
            // 
            // SizeDataGridViewTextBoxColumn
            // 
            this.SizeDataGridViewTextBoxColumn.DataPropertyName = "SizeCategory";
            this.SizeDataGridViewTextBoxColumn.HeaderText = "Size Category";
            this.SizeDataGridViewTextBoxColumn.MaxInputLength = 75;
            this.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn";
            // 
            // PcFnameDataGridViewTextBoxColumn
            // 
            this.PcFnameDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContactFirstName";
            this.PcFnameDataGridViewTextBoxColumn.HeaderText = "Primary Contact 1st Name";
            this.PcFnameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.PcFnameDataGridViewTextBoxColumn.Name = "PcFnameDataGridViewTextBoxColumn";
            // 
            // PcLnameDataGridViewTextBoxColumn
            // 
            this.PcLnameDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContactLastName";
            this.PcLnameDataGridViewTextBoxColumn.HeaderText = "Primary Contact Last Name";
            this.PcLnameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.PcLnameDataGridViewTextBoxColumn.Name = "PcLnameDataGridViewTextBoxColumn";
            // 
            // PcPhoneDataGridViewTextBoxColumn
            // 
            this.PcPhoneDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContactPhone";
            this.PcPhoneDataGridViewTextBoxColumn.HeaderText = "Primary Contact Phone";
            this.PcPhoneDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.PcPhoneDataGridViewTextBoxColumn.Name = "PcPhoneDataGridViewTextBoxColumn";
            // 
            // PcEmailDataGridViewTextBoxColumn
            // 
            this.PcEmailDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContactEmail";
            this.PcEmailDataGridViewTextBoxColumn.HeaderText = "Primary Contact Email";
            this.PcEmailDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.PcEmailDataGridViewTextBoxColumn.Name = "PcEmailDataGridViewTextBoxColumn";
            // 
            // PcAltPhoneDataGridViewTextBoxColumn
            // 
            this.PcAltPhoneDataGridViewTextBoxColumn.DataPropertyName = "PrimaryAlternatePhone";
            this.PcAltPhoneDataGridViewTextBoxColumn.HeaderText = "Primary Alt Phone";
            this.PcAltPhoneDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.PcAltPhoneDataGridViewTextBoxColumn.Name = "PcAltPhoneDataGridViewTextBoxColumn";
            // 
            // SecContactNameDataGridViewTextBoxColumn
            // 
            this.SecContactNameDataGridViewTextBoxColumn.DataPropertyName = "SecondaryContactName";
            this.SecContactNameDataGridViewTextBoxColumn.HeaderText = "2nd Contact Name";
            this.SecContactNameDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.SecContactNameDataGridViewTextBoxColumn.Name = "SecContactNameDataGridViewTextBoxColumn";
            // 
            // SecPhoneDataGridViewTextBoxColumn
            // 
            this.SecPhoneDataGridViewTextBoxColumn.DataPropertyName = "SecondaryContactPhone";
            this.SecPhoneDataGridViewTextBoxColumn.HeaderText = "2nd Contact Phone";
            this.SecPhoneDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.SecPhoneDataGridViewTextBoxColumn.Name = "SecPhoneDataGridViewTextBoxColumn";
            // 
            // VetInfoDataGridViewTextBoxColumn
            // 
            this.VetInfoDataGridViewTextBoxColumn.DataPropertyName = "VetInfo";
            this.VetInfoDataGridViewTextBoxColumn.HeaderText = "Vet Info";
            this.VetInfoDataGridViewTextBoxColumn.MaxInputLength = 200;
            this.VetInfoDataGridViewTextBoxColumn.Name = "VetInfoDataGridViewTextBoxColumn";
            // 
            // NotesDataGridViewTextBoxColumn
            // 
            this.NotesDataGridViewTextBoxColumn.DataPropertyName = "ImportantNotes";
            this.NotesDataGridViewTextBoxColumn.HeaderText = "Important Notes";
            this.NotesDataGridViewTextBoxColumn.MaxInputLength = 2000;
            this.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn";
            // 
            // PhotoDataGridViewTextBoxColumn
            // 
            this.PhotoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.PhotoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.PhotoDataGridViewTextBoxColumn.Name = "PhotoDataGridViewTextBoxColumn";
            // 
            // CustomerDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 300);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.customersBindingNavigator);
            this.Name = "CustomerDirectory";
            this.Text = "CustomerDirectory";
            this.Load += new System.EventHandler(this.CustomerDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furzAFlynShopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FurzAFlynShopDBDataSet furzAFlynShopDBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private FurzAFlynShopDBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private FurzAFlynShopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton AddCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripLabel TotalCountBindingNavigator;
        private System.Windows.Forms.ToolStripButton DeleteCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton FirstCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton MovePreviousCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox SelectedCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton MoveNextICustomerBindingNavigator;
        private System.Windows.Forms.ToolStripButton LastCustomerBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfPetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcLnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcAltPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecContactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VetInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoDataGridViewTextBoxColumn;
    }
}