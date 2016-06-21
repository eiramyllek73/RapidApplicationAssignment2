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
    public partial class AppointmentLog : Form
    {
        public AppointmentLog()
        {
            InitializeComponent();
        }

        private void appointmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzAFlynShopDBDataSet);

        }

        private void AppointmentLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furzAFlynShopDBDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.furzAFlynShopDBDataSet.Appointments);

        }
    }
}
