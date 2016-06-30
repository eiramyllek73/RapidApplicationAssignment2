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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutThisApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petCustomersTableAdapter = new RapidApplicationAssignment.furzaflynDataSet1TableAdapters.PetCustomersTableAdapter();
            this.tableAdapterManager1 = new RapidApplicationAssignment.furzaflynDataSet1TableAdapters.TableAdapterManager();
            this.furzaflynDataSet3 = new RapidApplicationAssignment.furzaflynDataSet3();
            this.petCustomersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petCustomersTableAdapter1 = new RapidApplicationAssignment.furzaflynDataSet3TableAdapters.PetCustomersTableAdapter();
            this.tableAdapterManager = new RapidApplicationAssignment.furzaflynDataSet3TableAdapters.TableAdapterManager();
            this.petCustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem,
            this.AddCustomerToolStripMenuItem,
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
            // AddCustomerToolStripMenuItem
            // 
            this.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem";
            this.AddCustomerToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.AddCustomerToolStripMenuItem.Text = "Add new Customer ";
            this.AddCustomerToolStripMenuItem.Click += new System.EventHandler(this.AddCustomerToolStripMenuItem_Click);
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
            // furzaflynDataSet3
            // 
            this.furzaflynDataSet3.DataSetName = "furzaflynDataSet3";
            this.furzaflynDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // petCustomersBindingSource1
            // 
            this.petCustomersBindingSource1.DataMember = "PetCustomers";
            this.petCustomersBindingSource1.DataSource = this.furzaflynDataSet3;
            // 
            // petCustomersTableAdapter1
            // 
            this.petCustomersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentsLogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerContactsTableAdapter = null;
            this.tableAdapterManager.PetCustomersTableAdapter = this.petCustomersTableAdapter1;
            this.tableAdapterManager.UpdateOrder = RapidApplicationAssignment.furzaflynDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // petCustomersDataGridView
            // 
            this.petCustomersDataGridView.AutoGenerateColumns = false;
            this.petCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petCustomersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewImageColumn1});
            this.petCustomersDataGridView.DataSource = this.petCustomersBindingSource1;
            this.petCustomersDataGridView.Location = new System.Drawing.Point(12, 40);
            this.petCustomersDataGridView.Name = "petCustomersDataGridView";
            this.petCustomersDataGridView.Size = new System.Drawing.Size(939, 220);
            this.petCustomersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PetID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameOfPet";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameOfPet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BreedType";
            this.dataGridViewTextBoxColumn3.HeaderText = "BreedType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SizeCategory";
            this.dataGridViewTextBoxColumn4.HeaderText = "SizeCategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AgeAtFirstVisit";
            this.dataGridViewTextBoxColumn6.HeaderText = "AgeAtFirstVisit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrimaryPhone";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrimaryPhone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ImportantNotes";
            this.dataGridViewTextBoxColumn8.HeaderText = "ImportantNotes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(963, 386);
            this.Controls.Add(this.petCustomersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Directory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Directory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Directory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furzaflynDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petCustomersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem AddCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerInvoiceToolStripMenuItem;
        private System.Windows.Forms.BindingSource petCustomersBindingSource;
        private furzaflynDataSet1TableAdapters.PetCustomersTableAdapter petCustomersTableAdapter;
        private furzaflynDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private furzaflynDataSet3 furzaflynDataSet3;
        private System.Windows.Forms.BindingSource petCustomersBindingSource1;
        private furzaflynDataSet3TableAdapters.PetCustomersTableAdapter petCustomersTableAdapter1;
        private furzaflynDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView petCustomersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}