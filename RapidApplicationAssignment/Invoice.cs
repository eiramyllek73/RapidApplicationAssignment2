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
    public partial class InvoiceForm : Form
    {
        // PRIVATE VARIABLES
        private const int MAX_SERVICES_Integer = 3;  // Number of services to be saved to invoice    
        private ServicesUsed[] listedServices = new ServicesUsed[MAX_SERVICES_Integer];  // List Array to save services inputted
        private string selectedRadioButtonString = null;
        private int serviceListInteger = 0;

        private struct ServicesUsed
        {
            public string sizeString;
            public string serviceString;
            public decimal priceDecimal;
        }

        public InvoiceForm()
        {
            InitializeComponent();
        }

        /**
        * This method will set the current date and time as well as set all radio buttons to be unchecked when the dashboard loads.
        */
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            
        }

        // Directs the user back to main dashboard upon Home Screen selection from main menu
        private void HomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
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

        private void PrintInvoiceButton_Click(object sender, EventArgs e)
        {
            // Preview the invoice and print if required
            if (serviceListInteger > 0)
            {
                //PrintPreviewDialog
                // Print the invoice details for the customer         
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Currently, there are no services added to this invoice to print.  Please return to the invoice form, make your selection, then press 'Add to Invoice' button.  Repeat as necessary before pressing the 'Print Invoice' button.",
                    "Input Required: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        // Click action for Reset button - clears the form
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Confirmation message for user before clearing inputs/outputs
            DialogResult responseDialogResult = MessageBox.Show("Are you sure you want to clear the contents of this invoice?", "Confirmation Required:  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(responseDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                FullSpaRadioButton.Checked = false;
                FleaTrtRadioButton.Checked = false;
                MedicatedRadioButton.Checked = false;
                SizeOptionComboBox.SelectedIndex = -1;
                PriceTextBox.Clear();
            }
        }

        // This 1-D Array will display the price of service based on combo box selection
        private void SizeOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal[,] priceDecimal = {
                                        {50.00m, 60.00m, 75.00m, 90.00m},
                                        {2.00m, 3.00m, 4.50m, 5.75m},
                                        {10.00m, 12.00m, 15.00m, 20.00m }
                                      };

            int rowInteger, columnInteger;
            decimal servicesPriceDecimal;

            // Allow maximum number of services entered into form
            if (serviceListInteger < MAX_SERVICES_Integer)
            {
                // Find Price of service based on selected size category
                columnInteger = SizeOptionComboBox.SelectedIndex;
                if (columnInteger != -1)
                {
                    switch (selectedRadioButtonString)
                    {
                        case "FullSpaRadioButton":
                            rowInteger = 0;
                            listedServices[serviceListInteger].sizeString = "Small";
                            rowInteger = 1;
                            listedServices[serviceListInteger].sizeString = "Medium";
                            rowInteger = 2;
                            listedServices[serviceListInteger].sizeString = "Large";
                            rowInteger = 3;
                            listedServices[serviceListInteger].sizeString = "XLarge";
                            break;

                        /**case "MedicatedRadioButton":
                            rowInteger = 4;
                            listedServices[serviceListInteger].sizeString = "Small";
                            rowInteger = 5;
                            listedServices[serviceListInteger].sizeString = "Medium";
                            rowInteger = 6;
                            listedServices[serviceListInteger].sizeString = "Large";
                            rowInteger = 7;
                            listedServices[serviceListInteger].sizeString = "XLarge";
                            break;

                        case "FleaTrtRadioButton":
                            rowInteger = 8;
                            listedServices[serviceListInteger].sizeString = "Small";
                            rowInteger = 9;
                            listedServices[serviceListInteger].sizeString = "Medium";
                            rowInteger = 10;
                            listedServices[serviceListInteger].sizeString = "Large";
                            rowInteger = 11;
                            listedServices[serviceListInteger].sizeString = "XLarge";
                            break; */
                        default:
                            rowInteger = 0;
                            listedServices[serviceListInteger].sizeString = "Small";
                            break;
                    } // End of Switch Statement

                    // Retrieve the price of service for the selected customer size
                    servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                    listedServices[serviceListInteger].serviceString = SizeOptionComboBox.Items[columnInteger].ToString();
                    listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;

                    serviceListInteger++;

                    // Display the price
                    PriceTextBox.Text = servicesPriceDecimal.ToString("c");
                      
                } 
                else
                {
                    MessageBox.Show("Please select a size for your customer in order to determine a price for service.",
                        "Size Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("You have already entered all of the listed services into this invoice.",
                    "Maximum Services Entered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddToInvoiceButton_Click(object sender, EventArgs e)
        {

        }
    }
}
