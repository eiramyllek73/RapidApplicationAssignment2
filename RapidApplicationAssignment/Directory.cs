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
    public partial class Directory : Form
    {
        //   PRIVATE VARIABLES
        private ToolStripMenuItem selectedToolStripMenuItem = null;

        public Directory()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzaflynDataSet);

        }

        private void Directory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furzaflynDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.furzaflynDataSet.Customers);

        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedToolStripMenuItem = (ToolStripMenuItem)sender;
        }

        private void HomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void AboutThisApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
