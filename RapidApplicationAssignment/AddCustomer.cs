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
        //   PRIVATE VARIABLES
        private ToolStripMenuItem selectedToolStripMenuItem = null;
        private ComboBox selectedSexOfPetComboBox = null;
        private ComboBox selectedSizeComboBox = null;
        private string selectedSexOfPetComboBoxString = null;
        private string selectedSizeComboBoxString = null;
        private int PetCustomerID;
        private string NameOfPet;
        private string BreedType;
        private string SizeCategory;
        private string AgeAtFirstAppt;
        private string PrimaryContactFirstName;
        private string PrimaryContactLastName;
        private string PrimaryContactPhone;
        private string Email;
        private string SecondaryContactInfo;
        private string VetInfo;
        private string ImportantNotes;
        private byte[] Photo;
        private PetCustomer petCustomer;

        public PetCustomer petCustomerInfo
        {
            get { return petCustomerBindingSource.Current as PetCustomer; }
        }

        public CustomerContact petContactInfo
        {
          get  { return customerContactBindingSource.Current as CustomerContact; }
        }

        public AddCustomerForm(PetCustomer obj, CustomerContact custObj)
        {
            InitializeComponent();
            petCustomerBindingSource.DataSource = obj;
            customerContactBindingSource.DataSource = custObj;

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

        public AddCustomerForm()
        {
        }

        public AddCustomerForm(PetCustomer petCustomer)
        {
            this.petCustomer = petCustomer;
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
            // TODO: This line of code loads data into the 'furzaflynDataSet3.CustomerContacts' table. You can move, or remove it, as needed.
            this.customerContactsTableAdapter.Fill(this.furzaflynDataSet3.CustomerContacts);
            // TODO: This line of code loads data into the 'furzaflynDataSet3.PetCustomers' table. You can move, or remove it, as needed.
            this.petCustomersTableAdapter.Fill(this.furzaflynDataSet3.PetCustomers);
            // Set the defaults that the form will begin with when it is initialized
            nameOfPetTextBox.Select();
            nameOfPetTextBox.Focus();

        }

        private void UpLoadImageButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                petCustomerBindingSource.EndEdit();
                customerContactBindingSource.EndEdit();
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

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
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
            if (selectedSexOfPetComboBox.SelectedIndex != -1)
            {
                selectedSexOfPetComboBoxString = selectedSexOfPetComboBox.Items.ToString();
            }
            else selectedSexOfPetComboBoxString = "";
        }

        private void SizeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedSizeComboBox.SelectedIndex != -1)
            {
                selectedSizeComboBoxString = selectedSizeComboBox.Items.ToString();
            }
            else selectedSizeComboBoxString = "";
        }
    }
}
