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
    public partial class ApptHistoryForm : Form
    {
        public ApptHistoryForm()
        {
            InitializeComponent();
        }

        private void appointmentLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentLogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.furzaflynDataSet);

        }

        private void ApptHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'furzaflynDataSet.AppointmentLog' table. You can move, or remove it, as needed.
            this.appointmentLogTableAdapter.Fill(this.furzaflynDataSet.AppointmentLog);

        }
    }
}
