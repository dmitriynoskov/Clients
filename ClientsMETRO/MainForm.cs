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
using MetroFramework.Controls;
using MetroFramework;
using Microsoft.Win32;
using Common;
using AccessToDataLibrary;
using System.Threading;
using ClientsMETRO.Properties;

namespace ClientsMETRO
{
    public partial class MainForm : MetroForm
    {
        AccessToDL accessDB;

        List<Client> clients = new List<Client>();

        Client CurrentClient;

        List<Shops> shops;

        Shops CurrentShop;

        List<Client> clServ = new List<Client>();

        string shopString;

        public MainForm()
        {
            InitializeComponent();

            try
            {
                accessDB = new AccessToDL();

                //accessDB.GetAllClientsFromServ();

                clients = accessDB.GetAllClients();

                tstrlblClientsNumber.Text = string.Format("В базе зарегистрировано " + clients.Count + " человек");
                tstrlblClientsForDate.Text = string.Format("Заполнение клиентов за " + DateTime.Now.ToShortDateString() + ":");
                tstrlblExistingClients.Text = string.Format("       Существующих клиентов: " + SelectExistingClientsNumber());
                tstrlblNewClients.Text = string.Format("       Новых клиентов: " + SelectNewClientsNumber());
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Не удается подключиться к базе данных! Проверьте настройки приложения", "Ошибка подключения к базе данных", MessageBoxButtons.OK);
            }

            shops = Enum.GetValues(typeof(Shops)).Cast<Shops>().ToList();
            cmbxShops.DataSource = shops;
            CurrentShop = Provider.Provider.ReadSettingsFromRegistry();

            cmbxShops.SelectedItem = CurrentShop;

            CurrentClient = new Client();

            mlClientsDBPath.Text = Provider.Provider.ReadSettingsFromRegistry("ClientsFolder");
            mlServerDBPath.Text = Provider.Provider.ReadSettingsFromRegistry("ServerFolder");

            this.StyleManager = msmStyle;

            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
            AddingStyleTiles();
        }

        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="phone">Искомый номер телефона</param>
        private void AddClient(string phone)
        {
            lblStatus.Text = "Добавление клиента";
            lblStatusRuning.Text = "Выполняется...";

            NewClient newClient = new NewClient(CurrentClient, CurrentShop, phone);

            if (newClient.ShowDialog() == DialogResult.OK)
            {
                if (accessDB.AddNewClient(newClient.newClient, CurrentShop))
                {
                    MetroMessageBox.Show(this, "Новый клиент " + CurrentClient.ClientName + " успешно добавлен!", "Добавление клиента",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    tstrlblNewClients.Text = string.Format(" Новых клиентов: " + SelectNewClientsNumber());
                    lblStatusRuning.Text = "Выполнено";
                }
                else
                {
                    MetroMessageBox.Show(this, "Новый клиент не добавлен!", "Добавление клиента", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lblStatusRuning.Text = "Обнаружена ошибка!";
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Новый клиент не добавлен!", "Добавление клиента", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblStatusRuning.Text = "Отменено!";
            }
        }

        /// <summary>
        /// Продажа/возврат покупки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxSell_DoubleClick(object sender, EventArgs e)
        {
            int sum = Int32.Parse(txbxSum.Text.Trim());

            if (sum <= 0)
            {
                MetroMessageBox.Show(this, "Сумма покупки должна быть больше 0", "Совершение покупки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chbxVozvrat.Checked)
            {
                sum = 0 - sum;
            }

            if (accessDB.AddSum(CurrentClient, CurrentShop, sum, chbxVozvrat.Checked))
            {
                if (chbxVozvrat.Checked)
                {
                    MetroMessageBox.Show(this, "Возврат в сумме " + sum + " грн проведен.\nСумма списана с клиента " + CurrentClient.ClientName,
                    "Изъятие суммы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MetroMessageBox.Show(this, "Продажа в сумме " + sum + " грн проведена.\nСумма накоплена клиенту " + CurrentClient.ClientName,
                    "Внесение суммы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                maskedTextBox1.Clear();
                lblClientName.Text = "";
                lblBirthDate.Text = "";
                lblDiscount.Text = "%";
                lblTotal.Text = "0";
                pnlSales.Visible = false;
                txbxSum.Text = "0";
                panInfo.Visible = false;
                chbxVozvrat.Checked = false;

                tstrlblExistingClients.Text = string.Format("       Существующих клиентов: " + SelectExistingClientsNumber());

                maskedTextBox1.Focus();
            }
            else
            {
                MetroMessageBox.Show(this, "Продажа не проведена!", "Внесение суммы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загрузка данных с основного сервера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownloadFromServ_Click(object sender, EventArgs e)
        {
            int oldCount = clients.Count;

            if (MetroMessageBox.Show(this, "Вы хотите загрузить информацию с сервера?\n(Загрузка необходима только ОДИН раз УТРОМ)\nВсе несохраненные на СЕРВЕРЕ данные будут уничтожены",
               "Обновление базы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lblStatus.Text = "Загрузка данных с сервера";
                lblStatusRuning.Text = "Выполняется...";

                if (accessDB.UpdateClientDS())
                {
                    clients.Clear();
                    clients = accessDB.GetAllClients();

                    int updClientsInDS = clients.Count - oldCount;

                    MetroMessageBox.Show(this, "Копирование базы данных выполнено!\nПолучено " + updClientsInDS + " новых клиентов",
                        "Получение данных с сервера", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvClients.DataSource = null;
                    dgvClients.DataSource = clients;

                    tstrlblClientsNumber.Text = string.Format("В базе зарегистрировано " + clients.Count + " человек");
                    lblStatusRuning.Text = "Выполнено";
                    return;
                }
                else
                {
                    MetroMessageBox.Show(this, "Не удалось получить данные!\nСвяжитесь с администратором!", "Получение данных с сервера", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    lblStatusRuning.Text = "Произошла ошибка!";
                }
            }
        }

        /// <summary>
        /// Отправка данных на основной сервер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendData_Click(object sender, EventArgs e)
        {
            string s;
            if (MetroMessageBox.Show(this, "Вы хотите отправить информацию на сервер?\n(Отправка необходима только ОДИН раз ВЕЧЕРОМ)",
               "Обновление базы", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblStatus.Text = "Отправка данных на сервер";
                lblStatusRuning.Text = "Выполняется...";

                if (accessDB.SendChangesToServ(out s))
                {
                    MetroMessageBox.Show(this, "Отправка данных выполнена!", "Отправка данных на сервер", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblStatusRuning.Text = "Выполнено";
                    tstrlblExistingClients.Text = string.Format("       Существующих клиентов: " + SelectExistingClientsNumber());
                    tstrlblNewClients.Text = string.Format(" Новых клиентов: " + SelectNewClientsNumber());

                    return;
                }
                else
                {
                    MetroMessageBox.Show(this, "Не удалось отправить данные!\nСвяжитесь с администратором!", "Отправка данных на сервер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MetroMessageBox.Show(this,s, "ОШИБКА!");
                    lblStatusRuning.Text = "Произошла ошибка!";
                }
            }
        }

        /// <summary>
        /// Обновление данных на основном сервере
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void обновитьСерверныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Обновление серверных данных";
            lblStatusRuning.Text = "Выполняется...";

            if (accessDB.InsertDataToServMain())
            {
                MetroMessageBox.Show(this,"Серверные данные успешно обновлены", "Обновление серверных данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblStatusRuning.Text = "Выполнено";
            }
            else
            {
                MetroMessageBox.Show(this, "Не удалось обновить данные!!!", "Обновление серверных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblStatusRuning.Text = "Произошла ошибка!";
            }
        }

        SendingForm sendingForm;
        int num = 0;
        /// <summary>
        /// Создание файла рассылки для клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void создатьФайлДляРассылкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendingForm = new SendingForm();
            if (sendingForm.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "Генерация файла рассылки";
                lblStatusRuning.Text = "Выполняется...";

                MetroMessageBox.Show(this, "Пытаюсь сгенерировать файл!\nПожалуйста, подождите!", "Генерация файла-рассылки");

                Thread thr = new Thread(Report);
                thr.Start();

                for (int i = toolStripProgressBar1.Minimum; i < toolStripProgressBar1.Maximum; i++)
                {
                    toolStripProgressBar1.Value += 1;
                    Thread.Sleep(80);
                }

                lblStatusRuning.Text = "Завершено";
            }
        }

        /// <summary>
        /// Отображение информации о статусе создания файла-рассылки
        /// </summary>
        private void Report()
        {
            if (accessDB.FormingReport(sendingForm.FilterDate, out num))
            {
                MessageBox.Show(String.Format("Файл для рассылки успешно сгенерирован\nПолучено " + num + " телефонов клиентов", "Генерация файла рассылки", MessageBoxButtons.OK, MessageBoxIcon.Information));
            }
            else
            {
                MessageBox.Show("Не удалось сгенерировать файл для рассылки!!!", "Генерация файла рассылки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Добавление иконок стиля
        /// </summary>
        private void AddingStyleTiles()
        {
            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flowLayoutPanel1.Controls.Add(_tile);
            }
        }

        /// <summary>
        /// Выбор цвета стиля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _tile_Click(object sender, EventArgs e)
        {
            this.StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            Settings.Default.Style = this.StyleManager.Style;
            Settings.Default.Save();
        }

        /// <summary>
        /// Подсчет количества существующих клиентов
        /// </summary>
        /// <returns> Число существующих клиентов </returns>
        private int SelectExistingClientsNumber()
        {
            return accessDB.GetExistingClientsNumber();
        }

        /// <summary>
        /// Подсчет количества новых клиентов
        /// </summary>
        /// <returns>Число новых клиентов</returns>
        private int SelectNewClientsNumber()
        {
            return accessDB.GetNewClientsNumber(CurrentShop);
        }

        /// <summary>
        /// Обработка нажатия кнопки Админ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;
            btnAdmin.Visible = btnDownloadFromServ.Visible = btnSendData.Visible = false;
        }

        /// <summary>
        /// Обработка нажатия кнопки Настройка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlSettings_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            btnAdmin.Visible = btnDownloadFromServ.Visible = btnSendData.Visible = true;
        }

        /// <summary>
        /// Изменение темы оформления на Черную
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                this.StyleManager.Theme = MetroThemeStyle.Dark;
                Settings.Default.Theme = this.StyleManager.Theme;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Изменение темы оформления на Светлую
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                this.StyleManager.Theme = MetroThemeStyle.Light;
                Settings.Default.Theme = this.StyleManager.Theme;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Оброботка нажатия кнопки ОБЗОР для поиска базы клиентов на клиенте
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlSearchClientsDB_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                mlClientsDBPath.Text = ofdOpenFile.FileName;
            }
        }

        /// <summary>
        /// Оброботка нажатия кнопки ОБЗОР для поиска базы клиентов на сервере
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlSearchServerDB_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                mlServerDBPath.Text = ofdOpenFile.FileName;
            }
        }

        /// <summary>
        /// Активация кнопки Отправки данных
        /// </summary>
        private void EnablingSendButton()
        {
            switch (CurrentShop)
            {
                case Shops.Karavan:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("21:50")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
                case Shops.Dafi:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("21:35")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
                case Shops.FourG:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("21:45")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
                case Shops.Kiev:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("21:55")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
                case Shops.Odessa:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("20:51")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
                case Shops.Bars:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("20:45")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
                case Shops.Outlet:
                    {
                        if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("21:40")).ToShortTimeString()))
                        {
                            btnSendData.Enabled = true;
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Активация кнопки Получения данных
        /// </summary>
        private void DisablingLoadButton()
        {
            if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("10:30")).ToShortTimeString()))
            {
                btnDownloadFromServ.Enabled = false;
            }
        }

        /// <summary>
        /// Работа таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            EnablingSendButton();
            DisablingLoadButton();

            if (DateTime.Now >= Convert.ToDateTime((Convert.ToDateTime("22:30")).ToShortTimeString()))
            {
                accessDB.InsertDataToServMain();
                accessDB.UpdateClientDS();
                Application.Exit();
            }
        }

        /// <summary>
        /// Выполнение процедур при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "База клиентов       v2.0.0.2      " + shopString + "       ©D.Noskov 2016-" + DateTime.Now.Year.ToString();
            EnablingSendButton();
            DisablingLoadButton();
            timer1.Start();
            maskedTextBox1.Focus();
        }

        /// <summary>
        /// Выбор текущего магазина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Shops)cmbxShops.SelectedValue)
            {
                case Shops.Bars:
                    {
                        CurrentShop = Shops.Bars;
                        shopString = "BARS";
                        break;
                    }
                case Shops.Dafi:
                    {
                        CurrentShop = Shops.Dafi;
                        shopString = "WAGGON Дафи";
                        break;
                    }
                case Shops.FourG:
                    {
                        CurrentShop = Shops.FourG;
                        shopString = "4G";
                        break;
                    }
                case Shops.Karavan:
                    {
                        CurrentShop = Shops.Karavan;
                        shopString = "WAGGON Караван";
                        break;
                    }
                case Shops.Kiev:
                    {
                        CurrentShop = Shops.Kiev;
                        shopString = "WAGGON Ocean Plz";
                        break;
                    }
                case Shops.Odessa:
                    {
                        CurrentShop = Shops.Odessa;
                        shopString = "WAGGON Одесса";
                        break;
                    }
                case Shops.Outlet:
                    {
                        CurrentShop = Shops.Outlet;
                        shopString = "WAGGON Outlet";
                        break;
                    }
                }
            this.Text = "База клиентов       v2.0.0.0      " + shopString + "       ©D.Noskov 2016-2017";
        }

        /// <summary>
        /// Сохранение параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlAdminSave_Click(object sender, EventArgs e)
        {
            mtbPassword.Visible = true;
            mtbPassword.Focus();
        }

        /// <summary>
        /// Ввод пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (mtbPassword.Text.Trim() == "09061987")
                {
                    Provider.Provider.WriteSettingsToRegistry(CurrentShop, mlClientsDBPath.Text, mlServerDBPath.Text);
                    MetroMessageBox.Show(this, "Настройки успешно сохранены!", "Сохранение настроек", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbPassword.Text = "";
                    mtbPassword.Visible = false;
                    mlSettings_Click(null, null);
                }
                else
                {
                    MetroMessageBox.Show(this, "Тут тебе делать нечего!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    mtbPassword.Text = "";
                    mtbPassword.Visible = false;
                    mlSettings_Click(null, null);
                }
            }
        }

        /// <summary>
        /// Нажатие Евро-флага
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxFlagEU_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = true;
            pbxFlagEU.Visible = false;
            pbxFlagUkraine.Visible = true;
            maskedTextBox2.Focus();
        }

        /// <summary>
        /// Нажатия Укр-флага
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxFlagUkraine_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = false;
            pbxFlagEU.Visible = true;
            pbxFlagUkraine.Visible = false;
            maskedTextBox1.Focus();
        }

        /// <summary>
        /// Ввод номера телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (maskedTextBox1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() == "380663073856")
                {
                    mlFileGenerate.Visible = mlUpdateServData.Visible = true;
                    btnDownloadFromServ.Enabled = btnSendData.Enabled = true;

                    lblStatus.Text = "Режим Администратора";
                    lblStatusRuning.Text = "Выполняется...";

                    return;
                }

                lblStatus.Text = "Поиск клиента";
                lblStatusRuning.Text = "Выполняется...";

                mlFileGenerate.Visible = mlUpdateServData.Visible = false;

                string phone = string.Empty;

                if (pbxFlagUkraine.Visible)
                {
                    phone = maskedTextBox2.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                }
                else
                {
                    phone = maskedTextBox1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                }

                if (phone != "38" && phone != "")
                {
                    if (!accessDB.FindClientByPhone(phone, CurrentShop, out CurrentClient))
                    {
                        panInfo.Visible = pnlSales.Visible = false;

                        DialogResult dr = MetroMessageBox.Show(this,"Такого клиента не существует в базе данных.\nЖелаете добавить?", "База клиентов", MessageBoxButtons.YesNo);
                        maskedTextBox1.Clear();
                        maskedTextBox2.Clear();
                        //maskedTextBox1.Focus();
                        lblClientName.Text = "";
                        lblBirthDate.Text = "";
                        lblDiscount.Text = "%";
                        picbxViber.Visible = false;
                        picbxWhatsApp.Visible = false;
                        pnlSales.Visible = false;
                        panInfo.Visible = false;
                        lblTotal.Text = "0";
                        txbxSum.Visible = false;

                        if (dr == DialogResult.Yes)
                        {
                            AddClient(phone);
                        }
                        return;
                    }

                    panInfo.Visible = true;
                    txbxSum.Visible = true;
                    pbxSell.Visible = true;
                    chbxVozvrat.Visible = true;
                    //label3.Visible = true;
                    txbxSum.Focus();
                    pnlSales.Visible = true;
                    lblClientName.Text = CurrentClient.ClientName;
                    lblBirthDate.Text = CurrentClient.BirthDate.ToShortDateString();
                    lblDiscount.Text = string.Format(CurrentClient.Discount.ToString() + "%");
                    lblTotal.Text = CurrentClient.Total.ToString();

                    if (CurrentClient.Kiev > 0)
                    {
                        lblKiev.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblKiev.ForeColor = Color.Black;
                    }
                    lblKiev.Text = CurrentClient.Kiev.ToString();

                    if (CurrentClient.Outlet > 0)
                    {
                        lblOutlet.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblOutlet.ForeColor = Color.Black;
                    }
                    lblOutlet.Text = CurrentClient.Outlet.ToString();

                    if (CurrentClient.Karavan > 0)
                    {
                        lblKaravan.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblKaravan.ForeColor = Color.Black;
                    }
                    lblKaravan.Text = CurrentClient.Karavan.ToString();

                    if (CurrentClient.Dafi > 0)
                    {
                        lblDafi.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblDafi.ForeColor = Color.Black;
                    }
                    lblDafi.Text = CurrentClient.Dafi.ToString();

                    if (CurrentClient.FourG > 0)
                    {
                        lblFourG.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblFourG.ForeColor = Color.Black;
                    }
                    lblFourG.Text = CurrentClient.FourG.ToString();

                    if (CurrentClient.Odessa > 0)
                    {
                        lblOdessa.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblOdessa.ForeColor = Color.Black;
                    }
                    lblOdessa.Text = CurrentClient.Odessa.ToString();

                    if (CurrentClient.Bars > 0)
                    {
                        lblBars.ForeColor = Color.MediumBlue;
                    }
                    else
                    {
                        lblBars.ForeColor = Color.Black;
                    }
                    lblBars.Text = CurrentClient.Bars.ToString();

                    if (CurrentClient.Viber)
                    {
                        picbxViber.Visible = true;
                    }
                    else
                    {
                        picbxViber.Visible = false;
                    }

                    if (CurrentClient.WhatsApp)
                    {
                        picbxWhatsApp.Visible = true;
                    }
                    else
                    {
                        picbxWhatsApp.Visible = false;
                    }

                    clients.Clear();
                    clients.Add(CurrentClient);
                    dgvClients.DataSource = null;
                    dgvClients.DataSource = clients;

                    lblStatusRuning.Text = "Выполнено";
                }
            }
        }

        /// <summary>
        /// Изменение личных данных клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void изменитьДанныеКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((lblClientName.Text == string.Empty && maskedTextBox1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "38")
                || (lblClientName.Text != string.Empty && maskedTextBox1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() != "38"))
            {
                lblStatus.Text = "Изменение данных клиента";
                lblStatusRuning.Text = "Выполняется...";

                string oldNum = CurrentClient.PhoneNumber;

                EditClient editClient = new EditClient(CurrentClient);

                if (editClient.ShowDialog() == DialogResult.OK)
                {
                    if (accessDB.EditClient(editClient.client, CurrentShop, oldNum))
                    {
                        MetroMessageBox.Show(this, "Клиент " + CurrentClient.ClientName + " успешно изменен", "Изменение клиента",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        tstrlblExistingClients.Text = string.Format("       Существующих клиентов: " + SelectExistingClientsNumber());
                        lblStatusRuning.Text = "Выполнено";
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Изменение клиента " + CurrentClient.ClientName + " не удалось", "Изменение клиента",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatusRuning.Text = "Обнаружена ошибка!";
                    }
                }
            }
        }
    }
}
