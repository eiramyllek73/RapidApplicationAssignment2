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
        private RadioButton selectedRadioButton = null;
        private ComboBox selectedComboBox = null;
        private string selectedRadioButtonString = null;
        private string selectedComboBoxString = null;
        private const int MAX_SERVICES_Integer = 12;  // Number of services to be saved to invoice    
        private ServicesUsed[] listedServices = new ServicesUsed[MAX_SERVICES_Integer];  // List Array to save services inputted
        private int serviceListInteger = 0;
        private decimal priceDecimal;
        private string servicesPriceDecimal;

        // CONSTANT VARIABLES
        const decimal smlSpaDecimal = 50.00m;
        const decimal medSpaDecimal = 60.00m;
        const decimal lrgSpaDecimal = 75.00m;
        const decimal xlrgSpaDecimal = 90.00m;
        const decimal smlShampDecimal = 2.00m;
        const decimal medShampDecimal = 3.00m;
        const decimal lrgShampDecimal = 4.50m;
        const decimal xlrgShampDecimal = 5.75m;
        const decimal smlFleaDecimal = 10.00m;
        const decimal medFleaDecimal = 12.00m;
        const decimal lrgFleaDecimal = 15.00m;
        const decimal xlrgFleaDecimal = 20.00m;
        const decimal TAX_RATE_Decimal = .13m;

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
            FullSpaRadioButton.Select();
            SizeOptionComboBox.Focus();
            
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

        // This 2-D Array will display the price of service based on combo box selection
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
                rowInteger = SizeOptionComboBox.SelectedIndex;

                if (columnInteger != -1)
                {
                    // Retrieve the price of service for the selected customer size
                    servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                    listedServices[serviceListInteger].serviceString = SizeOptionComboBox.Items[columnInteger].ToString();
                    serviceListInteger++;

                    // Display the price
                    PriceTextBox.Text = servicesPriceDecimal.ToString("c");

                    // Determine the price based on which Service radio button is checked + which size is selected.
                    switch (selectedRadioButtonString)
                    {
                        case "FullSpaRadioButton":
                            switch (selectedComboBoxString)
                            {
                                case "Small":
                                    listedServices[serviceListInteger].sizeString = "Small";
                                    listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                                    listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                    columnInteger = 0;
                                    rowInteger = 0;
                                    priceDecimal.Equals(smlSpaDecimal);
                                    smlSpaDecimal.Equals(PriceTextBox.Text);
                                    break;
                                case "Medium":
                                    listedServices[serviceListInteger].sizeString = "Medium";
                                    listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                                    columnInteger = 0;
                                    rowInteger = 1;
                                    priceDecimal.Equals(medSpaDecimal);
                                    medSpaDecimal.Equals(PriceTextBox.Text);
                                    break;
                                case "Large":
                                    listedServices[serviceListInteger].sizeString = "Large";
                                    listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                                    columnInteger = 0;
                                    rowInteger = 2;
                                    priceDecimal.Equals(lrgSpaDecimal);
                                    lrgSpaDecimal.Equals(PriceTextBox.Text);
                                    break;
                                case "XLarge":
                                    columnInteger = 0;
                                    rowInteger = 3;
                                    listedServices[serviceListInteger].sizeString = "XLarge";
                                    listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                                    priceDecimal.Equals(xlrgSpaDecimal);
                                    xlrgSpaDecimal.Equals(PriceTextBox.Text);
                                    break;
                            }
                            break;

                            case "MedicatedRadioButton":
                            switch (selectedComboBoxString)
                            {
                                case "Small":
                                    listedServices[serviceListInteger].sizeString = "Small";
                                    listedServices[serviceListInteger].serviceString = "MedicatedRadioButton";
                                    columnInteger = 1;
                                    rowInteger = 0;
                                    priceDecimal.Equals(smlShampDecimal);
                                    smlShampDecimal.Equals(PriceTextBox.Text);
                                    break;
                                case "Medium":
                                    listedServices[serviceListInteger].sizeString = "Medium";
                                    listedServices[serviceListInteger].serviceString = "MedicatedRadioButton";
                                    columnInteger = 1;
                                    rowInteger = 1;
                                    priceDecimal.Equals(medShampDecimal);
                                    medShampDecimal.Equals(PriceTextBox.Text);
                                    break;
                                case "Large":
                                    listedServices[serviceListInteger].sizeString = "Large";
                                    listedServices[serviceListInteger].serviceString = "MedicatedRadioButton";
                                    columnInteger = 1;
                                    rowInteger = 2;
                                    priceDecimal.Equals(lrgShampDecimal);
                                    lrgShampDecimal.Equals(PriceTextBox.Text);
                                    break;
                                case "XLarge":
                                    columnInteger = 1;
                                    rowInteger = 3;
                                    listedServices[serviceListInteger].sizeString = "XLarge";
                                    listedServices[serviceListInteger].serviceString = "MedicatedRadioButton";
                                    priceDecimal.Equals(xlrgShampDecimal);
                                    xlrgShampDecimal.Equals(PriceTextBox.Text);
                                    break;
                            }
                            break;

                            case "FleaTrtRadioButton":
                                switch (selectedComboBoxString)
                                {
                                    case "Small":
                                        listedServices[serviceListInteger].sizeString = "Small";
                                        listedServices[serviceListInteger].serviceString = "FleaTrtRadioButton";
                                        columnInteger = 2;
                                        rowInteger = 0;
                                        priceDecimal.Equals(smlFleaDecimal);
                                        smlFleaDecimal.Equals(PriceTextBox.Text);
                                        break;
                                    case "Medium":
                                        listedServices[serviceListInteger].sizeString = "Medium";
                                        listedServices[serviceListInteger].serviceString = "FleaTrtRadioButton";
                                        columnInteger = 2;
                                        rowInteger = 1;
                                        priceDecimal.Equals(medFleaDecimal);
                                        medFleaDecimal.Equals(PriceTextBox.Text);
                                        break;
                                    case "Large":
                                        listedServices[serviceListInteger].sizeString = "Large";
                                        listedServices[serviceListInteger].serviceString = "FleaTrtRadioButton";
                                        columnInteger = 2;
                                        rowInteger = 2;
                                        priceDecimal.Equals(lrgFleaDecimal);
                                        lrgFleaDecimal.Equals(PriceTextBox.Text);
                                        break;
                                    case "XLarge":
                                        columnInteger = 2;
                                        rowInteger = 3;
                                        listedServices[serviceListInteger].sizeString = "XLarge";
                                        listedServices[serviceListInteger].serviceString = "FleaTrtRadioButton";
                                        priceDecimal.Equals(xlrgFleaDecimal);
                                        xlrgFleaDecimal.Equals(PriceTextBox.Text);
                                        break;
                                }
                                break;      

                        default:
                            listedServices[serviceListInteger].sizeString = "Small";
                            listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                            columnInteger = 0;
                            rowInteger = 0;
                            priceDecimal.Equals(smlSpaDecimal);
                            smlSpaDecimal.Equals(PriceTextBox.Text);
                            break;
                            } // End of Switch Statement
                      
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
            // LOCAL VARIABLES
            decimal subTotalDecimal;
            decimal salesTaxDecimal;
            decimal amountDueDecimal;

            try
            {
                subTotalDecimal = decimal.Parse(SubtotalTextBox.Text);
                PriceTextBox.Text = SubtotalTextBox.Text;
                SubtotalTextBox.Text = subTotalDecimal.ToString("c");

                // Enter the price of chosen service to subtotal
                if (PriceTextBox.Text.Equals(smlSpaDecimal) || PriceTextBox.Text.Equals(medSpaDecimal) 
                    || PriceTextBox.Text.Equals(lrgSpaDecimal) || PriceTextBox.Text.Equals(xlrgSpaDecimal) 
                    || PriceTextBox.Text.Equals(smlShampDecimal) ||PriceTextBox.Text.Equals(medShampDecimal)
                    || PriceTextBox.Text.Equals (lrgShampDecimal)|| PriceTextBox.Text.Equals(xlrgShampDecimal)
                    || PriceTextBox.Text.Equals(smlFleaDecimal) || PriceTextBox.Text.Equals(medFleaDecimal)
                    || PriceTextBox.Text.Equals(lrgFleaDecimal) || PriceTextBox.Text.Equals(xlrgFleaDecimal))
                {
                    subTotalDecimal += priceDecimal;
                }

                // Calculations
                subTotalDecimal = priceDecimal++;
                salesTaxDecimal = subTotalDecimal * TAX_RATE_Decimal;
                amountDueDecimal = subTotalDecimal + salesTaxDecimal;

                // Display calculations
                SubtotalTextBox.Text = subTotalDecimal.ToString("c");
                TaxTextBox.Text = salesTaxDecimal.ToString("c");
                TotalTextBox.Text = amountDueDecimal.ToString("c");
                

            }
            // Catch Exceptions
            catch (Exception invoiceException)
            {
                MessageBox.Show("The following error occurred:  " +
                    invoiceException.Message, "Application Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                FullSpaRadioButton.Select();
                SizeOptionComboBox.Focus();
            }
        }
        /**
         * This method will take the radio button that was clicked, and assign the event to a new RadioButton.
        */
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioButton = (RadioButton)sender;
        }
    }
}
