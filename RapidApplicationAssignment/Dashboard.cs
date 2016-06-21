/* Programmer: Kelly McAlpine (200269425)
 * Due Date: June 23, 2016
 * Purpose: This application will manage customers and their appointment information
 * Purpose of this form:  This form is the introductory/main dashboard that will provide starting options for the user to be directed to. 
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
    public partial class Dashboard : Form
    {
        // PRIVATE VARIABLES
        private RadioButton selectedRadioButton = null;

        public Dashboard()
        {
            InitializeComponent();
        }

        /**
         * This method will set the default values to null on the dashboard form
         */
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Set current date & time


            selectedRadioButton.Checked = false;
        }

        /**
        * This method will take the radio button that was clicked, and assign the event to a new RadioButton.
        */
        private void radioButton_Checked(object sender, EventArgs e)
        {
            selectedRadioButton = (RadioButton)sender;
        }


        /**
        * This method will activate once the OK button is clicked; redirecting the user to the selected form in the application.
        */
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                // if user does not make a selection
                if (!ViewDirectoryRadioButton.Checked && !AddNewRadioButton.Checked && !LogApptRadioButton.Checked)
                {

                    MessageBox.Show("A selection is required in order to proceed.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Switch to check which radio button has been clicked, then perform directed task
                    switch (selectedRadioButton.Name)
                    {
                        case "ViewDirectoryRadioButton":
                            Directory directory = new Directory();
                            Show(directory);
                            this.Hide();

                            break;
                        case "AddNewRadioButton":
                            this.Hide();

                            break;
                        case "LogApptRadioButton":
                            this.Hide();

                            break;

                    }

                }  
                
            }

            // Catch exception not previously caught
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred. Error: " +
                    ex.Message, "Exception Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        /**
        * This method will activate when the exit application menu option is clicked, and exit the program.
        */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }
    }
}
