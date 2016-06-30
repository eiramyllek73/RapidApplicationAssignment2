/* Programmer: Kelly McAlpine (200269425)
 * Due Date: June 23, 2016
 * Purpose: This application will manage customers and their appointment information
 * Purpose of this form:  This form displays the Customer data from the customers table in the local db, with enabled CRUD functionality
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidApplicationAssignment
{
    public partial class Directory : Form
    {
        //   PRIVATE VARIABLES
        private ToolStripMenuItem selectedToolStripMenuItem = null;

        public Directory()
        {
            InitializeComponent();
        }



        private void Directory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furzaflynDataSet3.PetCustomers' table. You can move, or remove it, as needed.
            this.petCustomersTableAdapter1.Fill(this.furzaflynDataSet3.PetCustomers);

        }

        // This method enables the ability to take the user to another form or exit application based on main menu selection
        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedToolStripMenuItem = (ToolStripMenuItem)sender;
        }

        // Directs the user back to main dashboard upon Home Screen selection from main menu
        private void HomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        // Directs the user to an information screen about the application
        private void AboutThisApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Hide();
            about.ShowDialog();
        }

        private void ExitAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult returnDialogueResult;

            returnDialogueResult = MessageBox.Show("Are you sure you want to quit this application?", "Confirmation Required:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // If user clicks yes, close application - if no, remain on current form
            if (returnDialogueResult == DialogResult.Yes)
            {
                // Exit the application
                Application.Exit();
            }
        }



        private void createCustomerInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice = new InvoiceForm();
            this.Hide();
            invoice.ShowDialog();
        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            this.Hide();
            addCustomer.ShowDialog();
        }
    }
}
