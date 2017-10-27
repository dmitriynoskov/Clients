using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ClientsMETRO
{
    public partial class SendingForm : MetroForm
    {
        public DateTime FilterDate
        {
            get
            {
                return dtpckrFilterDate.Value;
            }

            private set
            {
                dtpckrFilterDate.Value = value;
            }
        }
        public SendingForm()
        {
            InitializeComponent();
        }

        private void btnFormingReport_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
