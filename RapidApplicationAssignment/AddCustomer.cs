/* Programmer: Kelly McAlpine (200269425)
 * Due Date: June 23, 2016
 * Purpose: This application will manage customers and their appointment information
 * Purpose of this form:  This form creates an invoice that subtotals inputted service prices, calculates the current HST tax rate, then outputs a final total.  
 * This form will also save the invoice to a time-stamped text file as well as print the details.
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
    public partial class AddCustomerForm : Form
    {
        // ***PRIVATE VARIABLES***
        private ToolStripMenuItem selectedToolStripMenuItem = null;
        private ComboBox selectedSexOfPetComboBox = null;
        private ComboBox selectedSizeComboBox = null;
        private string selectedSexOfPetComboBoxString = null;
        private string selectedSizeComboBoxString = null;
        private PetCustomer petObj;
        private CustomerContact conObj;

        public PetCustomer petCustomerInfo
        {
            get { return petCustomerBindingSource2.Current as PetCustomer; }
        }

        public CustomerContact petContactInfo
        {
          get  { return customerContactBindingSource2.Current as CustomerContact; }
        }
        
        public AddCustomerForm()
        {
            InitializeComponent();      
        }

        public AddCustomerForm(PetCustomer petObj, CustomerContact conObj)
        {
            petCustomerBindingSource2.DataSource = petObj;
            customerContactBindingSource2.DataSource = conObj;

            // Display choices from both drop down boxes
            if (selectedSexOfPetComboBox.SelectedIndex != -1)
            {
                selectedSexOfPetComboBoxString = selectedSexOfPetComboBox.Items.ToString();
            }
            else selectedSexOfPetComboBoxString = "";

            if (selectedSizeComboBox.SelectedIndex != -1)
            {
                selectedSizeComboBoxString = selectedSizeComboBox.Items.ToString();
            }
            else selectedSizeComboBoxString = "";
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedToolStripMenuItem = (ToolStripMenuItem)sender;
        }

        private void HomeScreenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void AboutThisApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            this.Hide();
            about.ShowDialog();
        }

        private void ExitAppToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        /**
        * This method will load the initial values into each text box.
        */
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            nameOfPetTextBox.Select();
            nameOfPetTextBox.Focus();
            SexOfPetComboBox.SelectedIndex = -1;
            SizeCategoryComboBox.SelectedIndex = -1;
        }

        private void UpLoadImageButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                petCustomerBindingSource2.EndEdit();
                customerContactBindingSource2.EndEdit();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!  The details entered did not save to the database.  Error:  "
                    + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Confirmation message before reset click action
            DialogResult responseDialogResult = MessageBox.Show("Are you sure you want to clear this entire form?  Your input will not be saved!", "Confirmation Required:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            // Clear the inputs
            if (responseDialogResult == DialogResult.Yes)
            {
                nameOfPetTextBox.Clear();
                SexOfPetComboBox.SelectedIndex = -1;
                SizeCategoryComboBox.SelectedIndex = -1;
                breedTypeTextBox.Clear();                
                ageAtFirstApptTextBox.Clear();
                importantNotesTextBox.Clear();
                vetInfoTextBox.Clear();
                primaryContactFirstNameTextBox.Clear();
                primaryContactLastNameTextBox.Clear();
                primaryAddressTextBox.Clear();
                primaryContactPhoneTextBox.Clear();
                emailTextBox.Clear();
                primaryAlternateInfoTextBox.Clear();
                secondaryContactInfoTextBox.Clear();
                //imagePictureBox.Image.Dispose();
            }
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

        private void SexOfPetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedSexOfPetComboBox.SelectedIndex == -1)
            {
                selectedSexOfPetComboBoxString = "";
            }
            else if (selectedSexOfPetComboBox.SelectedIndex == 0)
            {
                selectedSexOfPetComboBox.Text = "Female";
                selectedSexOfPetComboBoxString = selectedSexOfPetComboBox.SelectedIndex.ToString();
            }
            else if (selectedSexOfPetComboBox.SelectedIndex == 1)
            {
                selectedSexOfPetComboBox.Text = "Male";
                selectedSexOfPetComboBoxString = selectedSexOfPetComboBox.SelectedIndex.ToString();
            }
        }

        private void SizeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedSizeComboBox.SelectedIndex == -1)
            {
                selectedSizeComboBoxString = "";
            }
            else if (selectedSizeComboBox.SelectedIndex == 0)
            {
                selectedSizeComboBox.Text = "Small";
                selectedSizeComboBoxString = selectedSizeComboBox.SelectedIndex.ToString();
            }
            else if (selectedSizeComboBox.SelectedIndex == 1)
            {
                selectedSizeComboBox.Text = "Medium";
                selectedSizeComboBoxString = selectedSizeComboBox.SelectedIndex.ToString();
            }
            else if (selectedSizeComboBox.SelectedIndex == 2)
            {
                selectedSizeComboBox.Text = "Large";
                selectedSizeComboBoxString = selectedSizeComboBox.SelectedIndex.ToString();
            }
            else if (selectedSizeComboBox.SelectedIndex == 3)
            {
                selectedSizeComboBox.Text = "XLarge";
                selectedSizeComboBoxString = selectedSizeComboBox.SelectedIndex.ToString();
            }
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            CustomerProfileForm profile = new CustomerProfileForm();
            this.Hide();
            profile.ShowDialog();
        }

        private void viewCustomerDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryForm directory = new DirectoryForm();
            this.Hide();
            directory.ShowDialog();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice = new InvoiceForm();
            this.Hide();
            invoice.ShowDialog();
        }
    }
}
