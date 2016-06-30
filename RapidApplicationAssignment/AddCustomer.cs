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
        private int CustomerID;
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


        public AddCustomerForm()
        {
            InitializeComponent();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry!  The details entered did not save to the database.  Error:  "
                    + ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //RefreshDataset();
        }

       // private void RefreshDataset()
       // {
       //     this.customersTableAdapter.Fill(this.furzaflynDataSet.Customers);
       // }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Confirmation message before reset click action
            DialogResult responseDialogResult = MessageBox.Show("Are you sure you want to clear this entire form?  Your input will not be saved!", "Confirmation Required:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            // Clear the inputs
            if (responseDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                nameOfPetTextBox.Clear();
                breedTypeTextBox.Clear();
                
                ageAtFirstApptTextBox.Clear();
                primaryContactFirstNameTextBox.Clear();
                primaryContactLastNameTextBox.Clear();
                primaryContactPhoneTextBox.Clear();
                emailTextBox.Clear();
                secondaryContactInfoTextBox.Clear();
                vetInfoTextBox.Clear();
                importantNotesTextBox.Clear();
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
    }
}
