/* Programmer: Kelly McAlpine (200269425)
 * Due Date: June 23, 2016
 * Purpose: This form will input data from the user, save it to the application's customers table in the database, which will update the customer directory form within the application.
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
    public partial class AddCustomer : Form
    {
        // CONSTANT VARIABLES
        Graphics photo;


        public AddCustomer()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furzaflynDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.furzaflynDataSet.Customers);


        }

        private void UploadPhotoButton_Click(object sender, EventArgs e)
        {

        }

        /**
        * This method will activate when the clear button is clicked, and ask the user if they are sure. 
        * If the user answers yes, it will restore the form back to its initial default state.
        */
        private void clearEditButton_Click(object sender, EventArgs e)
        {
            DialogResult returnDialogResult;

            returnDialogResult = MessageBox.Show("Are you sure you don't want to save these details?  All of your input will be erased.",
                "Are you sure you don't want to save these details?  All of your input will be erased.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            
            // If the user clicks OK, return all fields to empty state
            if (returnDialogResult == DialogResult.OK)
            {
                nameOfPetTextBox.Clear();
                ageAtFirstVisitTextBox.Clear();
                breedTypeTextBox.Clear();
                sizeCategoryTextBox.Clear();
                primaryContactFirstNameTextBox.Clear();
                primaryContactLastNameTextBox.Clear();
                primaryContactPhoneTextBox.Clear();
                primaryContactEmailTextBox.Clear();
                primaryAlternatePhoneTextBox.Clear();
                secondaryContactNameTextBox.Clear();
                secondaryContactPhoneTextBox.Clear();
                vetInfoTextBox.Clear();
                importantNotesTextBox.Clear();

                // invoke the clear method from the Graphics class to remove added photo to the form
                photo = Graphics.FromImage(pictureBox.Image);
                photo.Clear(PictureBox.DefaultBackColor);

          
                
            }
        }

        private void saveDetailsButton_Click(object sender, EventArgs e)
        {
            // This loads data into the 'furzAFlynShopDBDataSet.Customers' table. 
            this.customersTableAdapter.Fill(this.furzAFlynShopDBDataSet.Customers);
        }

        /**
        * This method will activate when the exit application menu option is clicked, and exit the program.
        */
        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }

        private void goToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAppointmentLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
