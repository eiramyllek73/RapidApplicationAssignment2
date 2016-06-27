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
         * This method will set the current date and time as well as set all radio buttons to be unchecked when the dashboard loads.
         */
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Timer.Start();
            CurrentDateLabel.Text = DateTime.Now.ToLongDateString();
            CurrentTimeLabel.Text = DateTime.Now.ToLongTimeString();
            selectedRadioButton = null;
        }

        /**
         * This method sets the timer for the current time label
         */
        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = DateTime.Now.ToLongTimeString();
            Timer.Start();
        }
        /**
        * This method will take the radio button that was clicked, and assign the event to a new RadioButton.
        */
        private void radioButton_CheckedChanged(object sender, EventArgs e)
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
                if (!ViewDirectoryRadioButton.Checked && !LogApptRadioButton.Checked)
                {

                    MessageBox.Show("A selection is required in order to proceed.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ViewDirectoryRadioButton.Checked)
                    {
                       Directory directory = new Directory();
                       this.Hide();
                       directory.ShowDialog();   
                    }

                    else if (LogApptRadioButton.Checked)
                    {
                        ApptHistoryForm appt = new ApptHistoryForm();
                        this.Hide();
                        appt.ShowDialog();
                    }

                } // End of else     
                            
            } // End of try

            // Catch exceptions not previously caught
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
