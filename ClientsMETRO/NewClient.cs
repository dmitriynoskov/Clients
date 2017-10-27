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
using MetroFramework;

namespace ClientsMETRO
{
    public partial class NewClient : MetroForm
    {
        public Client newClient;
        Shops shop;
        public NewClient(Client client, Shops curShop, string phone)
        {
            InitializeComponent();
            newClient = client;
            shop = curShop;
            mtxbxPhone.Text = phone;
        }

        /// <summary>
        /// Обработка введеных данных при нажатии кнопки Yes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((txbxName.Text.Trim() == "") || (mtxbxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "") == "38") ||
                (txbxSum.Text.Trim() == string.Empty))
            {
                MetroMessageBox.Show(this, "Не все поля заполнены!\nЗАПОЛНИТЕ ВСЕ ДАННЫЕ", "Новый клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Int32.Parse(txbxSum.Text.Trim()) == 0)
            {
                MetroMessageBox.Show(this, "Сумма покупки должна быть больше 0", "Новый клиент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newClient.ClientName = txbxName.Text.Trim();
            newClient.PhoneNumber = mtxbxPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            newClient.BirthDate = dtpkrBirthDate.Value.Date;
            switch (shop)
            {
                case Shops.Karavan:
                    {
                        newClient.Karavan = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
                case Shops.Dafi:
                    {
                        newClient.Dafi = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
                case Shops.FourG:
                    {
                        newClient.FourG = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
                case Shops.Kiev:
                    {
                        newClient.Kiev = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
                case Shops.Odessa:
                    {
                        newClient.Odessa = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
                case Shops.Bars:
                    {
                        newClient.Bars = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
                case Shops.Outlet:
                    {
                        newClient.Outlet = Int32.Parse(txbxSum.Text.Trim());
                        break;
                    }
            }
            newClient.LastPurchaseDate = DateTime.Now.Date;
            newClient.Viber = chbxViber.Checked;
            newClient.WhatsApp = chbxWhatsApp.Checked;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Обработка введеных данных при нажатии кнопки No
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
