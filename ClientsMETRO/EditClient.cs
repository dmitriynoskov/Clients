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
using Common;

namespace ClientsMETRO
{
    public partial class EditClient : MetroForm
    {
        public Client client;
        public EditClient(Client client)
        {
            InitializeComponent();

            this.client = client;

            txbxName.Text = client.ClientName;
            mtxbxPhone.Text = client.PhoneNumber;
            dtpkrBirthDate.Value = client.BirthDate.Date;
            chbxViber.Checked = client.Viber;
            chbxWhatsApp.Checked = client.WhatsApp;
        }

        /// <summary>
        /// Обработка нажатия клавиши YES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            client.ClientName = txbxName.Text.Trim();
            client.PhoneNumber = mtxbxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            client.BirthDate = dtpkrBirthDate.Value.Date;
            client.Viber = chbxViber.Checked;
            client.WhatsApp = chbxWhatsApp.Checked;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Обработка нажатия клавиши No
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
