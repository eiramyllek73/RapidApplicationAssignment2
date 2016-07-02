/* Programmer: Kelly McAlpine (200269425)
 * Due Date: June 23, 2016
 * Purpose: This application will manage customers and their appointment information
 * Purpose of this form:  This form creates an invoice that subtotals inputted service prices, calculates the current HST tax rate, then outputs a final total.  
 * This form will also save the invoice to a time-stamped text file as well as print the details.
 * 
 * RESOURCES USED FOR REFERENCE:  
 * Lesson 6 CoffeeSales - Anju Chawla (Sept 2014), Lesson 8 BulkCoffeeSales - Anju Chawla (Nov 2014), VBAutoCentre Assignment - Kelly McAlpine (Oct 2014)
 * https://msdn.microsoft.com/en-us/library/system.console.readline(v=vs.110).aspx
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidApplicationAssignment
{
    public partial class InvoiceForm : Form
    {
        // ***PRIVATE VARIABLES*** //
        private ToolStripMenuItem selectedToolStripMenuItem;
        private RadioButton selectedRadioButton = null;
        private string selectedRadioButtonString = null;
        private string selectedComboBoxString = null;
        // Number of services to be saved to invoice
        private const int MAX_SERVICES_Integer = 12;
        // List Array to save services inputted
        private ServicesUsed[] listedServices = new ServicesUsed[MAX_SERVICES_Integer];  
        private int serviceListInteger = 0;
        private decimal priceTotalDecimal = 0;
        private decimal servicesPriceDecimal;
        private decimal subTotalDecimal;
        private int rowInteger, columnInteger = -1;
        // For printing
        private StreamWriter custInvoiceStreamWriter;
        // Current System Time and Date
        private DateTime now = DateTime.Now; 
        private decimal totalTaxDecimal;
        private decimal totalAmountDecimal;
        // 2D Array to store prices
        private decimal[,] priceDecimal =
        {
            {50.00m, 60.00m, 75.00m, 90.00m},
            {2.00m, 3.00m, 4.50m, 5.75m},
            {10.00m, 12.00m, 15.00m, 20.00m}
        };

        // ***CONSTANT VARIABLES*** //
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

        public InvoiceForm()
        {
            InitializeComponent();
        }

        // Useful for holding direct values instead of referencing objects
        private struct ServicesUsed
        {
            public string sizeString;
            public string serviceString;
            public decimal priceDecimal;
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

        /**
        * This Click action method will the form when the reset button is clicked
        */
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Confirmation message will display for user first before clearing all fields
            DialogResult responseDialogResult = MessageBox.Show("Are you sure you want to clear the contents of this invoice?",
                "Confirmation Required:  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (responseDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                FullSpaRadioButton.Checked = false;
                FleaTrtRadioButton.Checked = false;
                MedicatedRadioButton.Checked = false;
                SizeOptionComboBox.SelectedIndex = -1;
                PriceTextBox.Clear();
                TotalTextBox.Clear();
                SubtotalTextBox.Clear();
                TaxTextBox.Clear();
                subTotalDecimal = 0;
                columnInteger = -1;
                rowInteger = 0;
                selectedComboBoxString = "";
                selectedRadioButtonString = "";
                serviceListInteger = 0;
                listedServices = new ServicesUsed[MAX_SERVICES_Integer];
            }
        }

        /**
        * This method will take the radio button that was clicked, and assign the event to a new RadioButton.  
        * It also supports the ability to display a price (price values stored in 2D array) based on radio button selection (service) + combo box selection (animal size)
        */
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioButton = (RadioButton)sender;
            selectedRadioButtonString = selectedRadioButton.Name;

            // Error testing for purpose of writing variables to console
            Console.Write(selectedComboBoxString + "\n");
            Console.Write(selectedRadioButtonString + "\n");

            if (columnInteger == -1)
            {
                selectedComboBoxString = "";
            }
            else
            {
                selectedComboBoxString = SizeOptionComboBox.Items[columnInteger].ToString();
            }
            if (columnInteger != -1)
            {
                // Determine the price based on which Service radio button is checked + which size is selected.
                switch (selectedRadioButtonString)
                {
                    case "FullSpaRadioButton":
                        switch (selectedComboBoxString)
                        {
                            case "Small":
                                listedServices[serviceListInteger].sizeString = "Small";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                columnInteger = 0;
                                rowInteger = 0;
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Medium":
                                listedServices[serviceListInteger].sizeString = "Medium";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                columnInteger = 1;
                                rowInteger = 0;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Large":
                                listedServices[serviceListInteger].sizeString = "Large";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                columnInteger = 2;
                                rowInteger = 0;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "XLarge":
                                columnInteger = 3;
                                rowInteger = 0;
                                listedServices[serviceListInteger].sizeString = "XLarge";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                        }
                        break;

                    case "MedicatedRadioButton":
                        switch (selectedComboBoxString)
                        {
                            case "Small":
                                listedServices[serviceListInteger].sizeString = "Small";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                columnInteger = 0;
                                rowInteger = 1;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Medium":
                                listedServices[serviceListInteger].sizeString = "Medium";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                columnInteger = 1;
                                rowInteger = 1;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Large":
                                listedServices[serviceListInteger].sizeString = "Large";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                columnInteger = 2;
                                rowInteger = 1;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "XLarge":
                                columnInteger = 3;
                                rowInteger = 1;
                                listedServices[serviceListInteger].sizeString = "XLarge";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                        }
                        break;

                    case "FleaTrtRadioButton":
                        switch (selectedComboBoxString)
                        {
                            case "Small":
                                listedServices[serviceListInteger].sizeString = "Small";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                columnInteger = 0;
                                rowInteger = 2;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Medium":
                                listedServices[serviceListInteger].sizeString = "Medium";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                columnInteger = 1;
                                rowInteger = 2;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Large":
                                listedServices[serviceListInteger].sizeString = "Large";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                columnInteger = 2;
                                rowInteger = 2;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "XLarge":
                                columnInteger = 3;
                                rowInteger = 2;
                                listedServices[serviceListInteger].sizeString = "XLarge";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                        }
                        break;

                    default:
                        listedServices[serviceListInteger].sizeString = "Small";
                        listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                        columnInteger = 0;
                        rowInteger = 0;
                        break;
                } // End of Switch Statement

                // Display the price in the Price text box
                PriceTextBox.Text = servicesPriceDecimal.ToString("c");
            }
        }

        /**
        * This method will display a price (price values stored in 2D array) based on combo box selection (animal size) after a radio button (service) is checked
        */
        private void SizeOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find Price of service based on selected size category
            columnInteger = SizeOptionComboBox.SelectedIndex;
            if (columnInteger == -1)
            {
                selectedComboBoxString = "";
            }
            else
            {
                selectedComboBoxString = SizeOptionComboBox.Items[columnInteger].ToString();
            }

            // Error testing - Write variable to console
            Console.Write(selectedComboBoxString + "\n");
            Console.Write(selectedRadioButtonString + "\n");
            if (columnInteger != -1)
            {
                // Determine the price based on which Service radio button is checked + which size is selected.
                switch (selectedRadioButtonString)
                {
                    case "FullSpaRadioButton":
                        switch (selectedComboBoxString)
                        {
                            case "Small":
                                listedServices[serviceListInteger].sizeString = "Small";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                columnInteger = 0;
                                rowInteger = 0;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;

                                break;
                            case "Medium":
                                listedServices[serviceListInteger].sizeString = "Medium";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                columnInteger = 1;
                                rowInteger = 0;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Large":
                                listedServices[serviceListInteger].sizeString = "Large";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                columnInteger = 2;
                                rowInteger = 0;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "XLarge":
                                columnInteger = 3;
                                rowInteger = 0;
                                listedServices[serviceListInteger].sizeString = "XLarge";
                                listedServices[serviceListInteger].serviceString = "Full Spa Package";
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                        }
                        break;

                    case "MedicatedRadioButton":
                        switch (selectedComboBoxString)
                        {
                            case "Small":
                                listedServices[serviceListInteger].sizeString = "Small";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                columnInteger = 0;
                                rowInteger = 1;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Medium":
                                listedServices[serviceListInteger].sizeString = "Medium";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                columnInteger = 1;
                                rowInteger = 1;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Large":
                                listedServices[serviceListInteger].sizeString = "Large";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                columnInteger = 2;
                                rowInteger = 1;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "XLarge":
                                columnInteger = 3;
                                rowInteger = 1;
                                listedServices[serviceListInteger].sizeString = "XLarge";
                                listedServices[serviceListInteger].serviceString = "Medicated Shampoo";
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                        }
                        break;

                    case "FleaTrtRadioButton":
                        switch (selectedComboBoxString)
                        {
                            case "Small":
                                listedServices[serviceListInteger].sizeString = "Small";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                columnInteger = 0;
                                rowInteger = 2;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Medium":
                                listedServices[serviceListInteger].sizeString = "Medium";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                columnInteger = 1;
                                rowInteger = 2;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "Large":
                                listedServices[serviceListInteger].sizeString = "Large";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                columnInteger = 2;
                                rowInteger = 2;
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                            case "XLarge":
                                columnInteger = 3;
                                rowInteger = 2;
                                listedServices[serviceListInteger].sizeString = "XLarge";
                                listedServices[serviceListInteger].serviceString = "Flea Treatment   ";
                                servicesPriceDecimal = priceDecimal[rowInteger, columnInteger];
                                listedServices[serviceListInteger].priceDecimal = servicesPriceDecimal;
                                break;
                        }
                        break;

                    default:
                        listedServices[serviceListInteger].sizeString = "Small";
                        listedServices[serviceListInteger].serviceString = "FullSpaRadioButton";
                        columnInteger = 0;
                        rowInteger = 0;
                        break;
                } // End of Switch Statement

                // Display the price
                PriceTextBox.Text = servicesPriceDecimal.ToString("c");
            }
        }

        /**
         * This method enables the user to calculate a running total of each/every selection made while also incorporating the HST tax rate
         */
        private void AddToInvoiceButton_Click(object sender, EventArgs e)
        {
            // LOCAL VARIABLES
            decimal salesTaxDecimal;
            decimal amountDueDecimal;

            // Allow maximum number of services entered into form
            if ((PriceTextBox.Text).Equals("$0.00"))
            {
                MessageBox.Show("Please select a size for your customer in order to determine a price for service.",
                        "Size Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (serviceListInteger < MAX_SERVICES_Integer)
                {
                    try
                    {
                        // Retrieve the price of service for the selected customer size
                        Console.Write(servicesPriceDecimal + "\n");
                        serviceListInteger++;
                        subTotalDecimal += servicesPriceDecimal;
                        //PriceTextBox.Text = SubtotalTextBox.Text;
                        SubtotalTextBox.Text = subTotalDecimal.ToString("c");

                        // Enter the price of chosen service to subtotal
                        if (PriceTextBox.Text.Equals(smlSpaDecimal) || PriceTextBox.Text.Equals(medSpaDecimal)
                            || PriceTextBox.Text.Equals(lrgSpaDecimal) || PriceTextBox.Text.Equals(xlrgSpaDecimal)
                            || PriceTextBox.Text.Equals(smlShampDecimal) || PriceTextBox.Text.Equals(medShampDecimal)
                            || PriceTextBox.Text.Equals(lrgShampDecimal) || PriceTextBox.Text.Equals(xlrgShampDecimal)
                            || PriceTextBox.Text.Equals(smlFleaDecimal) || PriceTextBox.Text.Equals(medFleaDecimal)
                            || PriceTextBox.Text.Equals(lrgFleaDecimal) || PriceTextBox.Text.Equals(xlrgFleaDecimal))
                        {
                            subTotalDecimal += priceTotalDecimal;
                        }

                        // Calculations
                        salesTaxDecimal = subTotalDecimal * TAX_RATE_Decimal;
                        amountDueDecimal = subTotalDecimal + salesTaxDecimal;

                        // Display calculations
                        SubtotalTextBox.Text = subTotalDecimal.ToString("c");
                        TaxTextBox.Text = salesTaxDecimal.ToString("c");
                        TotalTextBox.Text = amountDueDecimal.ToString("c");

                        totalTaxDecimal = salesTaxDecimal;
                        totalAmountDecimal = amountDueDecimal;

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
                else
                {
                    MessageBox.Show("You have already entered all of the listed services into this invoice.",
                        "Maximum Services Entered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /**
         * This method creates a formatted layout for the document to be printed, as well as displays a print-preview
         */
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Setting up the print page for preview and print
            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial Black", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.GetHeight();
            float col1HorizontalPrintLocationFloat = e.MarginBounds.Left;
            float col2HorizontalPrintLocationFloat = 300;
            float col3HorizontalPrintLocationFloat;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            SizeF fontSizeF = new SizeF();
            string formattedPriceString;

            // Check if there are any transactions to be printed
            if (serviceListInteger > 0)
            {
                // Print the heading
                e.Graphics.DrawString("Customer Invoice - " + String.Format("{0:yyyy/MM/dd hh:mm:ss tt}", now), headingFont, Brushes.Black,
                    col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                verticalPrintLocationFloat += lineHeightFloat * 2;

                // Format headings to the columns
                e.Graphics.DrawString("Service", headingFont, Brushes.Black,
                   col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                e.Graphics.DrawString("Size", headingFont, Brushes.Black,
                   col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                e.Graphics.DrawString("Price", headingFont, Brushes.Black,
                   500, verticalPrintLocationFloat);

                verticalPrintLocationFloat += lineHeightFloat * 2;

                // Print the transactions
                for (int index = 0; index < serviceListInteger; index++)
                {
                    // Print the service
                    e.Graphics.DrawString(listedServices[index].serviceString, printFont,
                        Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                    // Print the size
                    e.Graphics.DrawString(listedServices[index].sizeString, printFont,
                       Brushes.Black, col2HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                    // Format the price to display as currency and aligned to the right
                    formattedPriceString = listedServices[index].priceDecimal.ToString("c");
                    // Measure string in this font
                    fontSizeF = e.Graphics.MeasureString(formattedPriceString, printFont);
                    // Subtract width from column position
                    col3HorizontalPrintLocationFloat = 550 - fontSizeF.Width;
                    // Print the price totals
                    e.Graphics.DrawString(formattedPriceString, printFont,
                      Brushes.Black, col3HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                    // Move to the next printing position
                    verticalPrintLocationFloat += lineHeightFloat;

                }
                verticalPrintLocationFloat += lineHeightFloat;
                e.Graphics.DrawString("Subtotal\t\t\t\t\t\t" + subTotalDecimal.ToString("c"), printFont,
                        Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                verticalPrintLocationFloat += lineHeightFloat;
                e.Graphics.DrawString("Tax\t\t\t\t\t\t" + totalTaxDecimal.ToString("c"), printFont,
                        Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
                verticalPrintLocationFloat += lineHeightFloat;
                e.Graphics.DrawString("Total\t\t\t\t\t\t" + totalAmountDecimal.ToString("c"), printFont,
                        Brushes.Black, col1HorizontalPrintLocationFloat, verticalPrintLocationFloat);
            }

        }

        /**
         * This method will save the invoice to a text file that is timestamped for unique ID purposes
         */ 
        private void SaveInvoiceButton_Click(object sender, EventArgs e)
        {
            // Show a save dialog box and save the customers invoice
            DialogResult responseDialogBox;

            if (custInvoiceStreamWriter != null)
            {
                custInvoiceStreamWriter.Close();
            }

            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory;
            saveFileDialog1.FileName = "customerInvoice_" + String.Format("{0:yyyyMMddHHmmss}", now);
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Title = "Save Customer Invoice";
            saveFileDialog1.Filter = "TextFiles(*.txt)|*.txt|All Files(*.*)|*.*";

            // Show the save dialog and get a user's response
            responseDialogBox = saveFileDialog1.ShowDialog();

            if (responseDialogBox != System.Windows.Forms.DialogResult.Cancel)
            {
                try
                {
                    custInvoiceStreamWriter = new StreamWriter(saveFileDialog1.FileName, true);

                    custInvoiceStreamWriter.WriteLine("Customer Invoice - " + String.Format("{0:yyyy/MM/dd hh:mm:ss tt}", now));
                    custInvoiceStreamWriter.WriteLine("");
                    custInvoiceStreamWriter.WriteLine("Service\t\t\t\tSize\t\tPrice");
                    Console.WriteLine("Service\t\t\t\tSize\t\tPrice\n\n");
                    // Copy the customer invoice to the file
                    for (int index = 0; index < serviceListInteger; index++)
                    {
                        Console.WriteLine(listedServices[index].serviceString + "\t\t" + listedServices[index].sizeString + "\t\t" 
                            + listedServices[index].priceDecimal.ToString("c"));
                        custInvoiceStreamWriter.WriteLine(listedServices[index].serviceString + "\t\t" 
                            + listedServices[index].sizeString + "\t\t" + listedServices[index].priceDecimal.ToString("c"));
                    }
                    Console.WriteLine("Subtotal:\t\t\t\t\t\t" + subTotalDecimal.ToString("c"));
                    custInvoiceStreamWriter.WriteLine("");
                    custInvoiceStreamWriter.WriteLine("Subtotal:\t\t\t\t\t" + subTotalDecimal.ToString("c"));
                    custInvoiceStreamWriter.WriteLine("Tax:\t\t\t\t\t\t" + totalTaxDecimal.ToString("c"));
                    custInvoiceStreamWriter.WriteLine("Total:\t\t\t\t\t\t" + totalAmountDecimal.ToString("c"));
                    custInvoiceStreamWriter.Close();
                }
                catch (Exception genericException)
                {
                    MessageBox.Show("Unknown Exception: " + genericException.Message, "Unknown Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

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

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedToolStripMenuItem = (ToolStripMenuItem)sender;
        }

        /**
         * This method will display a previewed document then print it when user presses the print button
         */
        private void PrintInvoiceButton_Click_1(object sender, EventArgs e)
        {
            //preview the transaction report and print if required
            if (serviceListInteger > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("No transactions to print", "Print Transactions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
   
}
