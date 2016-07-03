/* Programmer: Kelly McAlpine (200269425)
 * Due Date: June 23, 2016
 * Purpose: This application will manage customers and their appointment information
 * Purpose of this form:  This form displays the Customer data from the customers table in the local db, with enabled CRUD functionality
 * 
 * RESOURCES USED FOR REFERENCE:  
 * https://www.youtube.com/watch?v=KfQmQD52EPQ
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
    public partial class DirectoryForm : Form
    {
        furzaflynEntities db;

        //   PRIVATE VARIABLES
        private ToolStripMenuItem selectedToolStripMenuItem = null;

        public static string GetCurrentDirectory { get; internal set; }

        public DirectoryForm()
        {
            InitializeComponent();
        }

        private void Directory_Load(object sender, EventArgs e)
        {
            db = new furzaflynEntities();
            petCustomerBindingSource.DataSource = db.PetCustomers.ToList();

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


        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            petCustomerBindingSource.DataSource = db.PetCustomers.ToList();
        }

        private async void AddNewToolStripButton_Click(object sender, EventArgs e)
        {
            using (AddCustomerForm addCustomer = new AddCustomerForm(new PetCustomer()))
            {
                if (addCustomer.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        petCustomerBindingSource.Add(addCustomer.petCustomerInfo);
                        db.PetCustomers.Add(addCustomer.petCustomerInfo);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private async void EditToolStripButton_Click(object sender, EventArgs e)
        {
            PetCustomer obj = petCustomerBindingSource.Current as PetCustomer;

            if (obj != null)
            {
                using (AddCustomerForm addCust = new AddCustomerForm(obj))
                {
                    if (addCust.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            petCustomerBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer record?", "Confirmation Required: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < PetCustomerDataGridView.SelectedRows.Count; i++)
                {
                    db.PetCustomers.Remove(PetCustomerDataGridView.SelectedRows[i].DataBoundItem as PetCustomer);
                    petCustomerBindingSource.RemoveAt(PetCustomerDataGridView.SelectedRows[i].Index);
                }
            }
        }

        private async void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save these changes?", "Confirmation Required:  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    petCustomerBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
