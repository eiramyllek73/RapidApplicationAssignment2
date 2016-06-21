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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ViewDirectoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddNewRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LogApptRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {

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
