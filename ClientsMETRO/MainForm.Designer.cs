namespace ClientsMETRO
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpAppearence = new MetroFramework.Controls.MetroTabPage();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.mtbPassword = new MetroFramework.Controls.MetroTextBox();
            this.cmbxShops = new MetroFramework.Controls.MetroComboBox();
            this.mlSearchServerDB = new MetroFramework.Controls.MetroLink();
            this.mlSearchClientsDB = new MetroFramework.Controls.MetroLink();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mlServerDBPath = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mlClientsDBPath = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlAdminSave = new MetroFramework.Controls.MetroLink();
            this.mtpUtils = new System.Windows.Forms.TabPage();
            this.mlFileGenerate = new MetroFramework.Controls.MetroLink();
            this.mlUpdateServData = new MetroFramework.Controls.MetroLink();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlSettings = new MetroFramework.Controls.MetroLink();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatusRuning = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrlblClientsNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrlblClientsForDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrlblNewClients = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrlblExistingClients = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msmStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.panInfo = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.lblBars = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.lblOdessa = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lblFourG = new MetroFramework.Controls.MetroLabel();
            this.lblDafi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblKaravan = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblOutlet = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblKiev = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.picbxWhatsApp = new MetroFramework.Controls.MetroLink();
            this.picbxViber = new MetroFramework.Controls.MetroLink();
            this.lblClientName = new System.Windows.Forms.Label();
            this.cnmstrUpdateClient = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.изменитьДанныеКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSales = new MetroFramework.Controls.MetroPanel();
            this.pbxSell = new MetroFramework.Controls.MetroLink();
            this.chbxVozvrat = new MetroFramework.Controls.MetroCheckBox();
            this.txbxSum = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnSendData = new MetroFramework.Controls.MetroTile();
            this.btnDownloadFromServ = new MetroFramework.Controls.MetroTile();
            this.btnAdmin = new MetroFramework.Controls.MetroTile();
            this.pbxFlagEU = new MetroFramework.Controls.MetroLink();
            this.pbxFlagUkraine = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpAppearence.SuspendLayout();
            this.mtpConnection.SuspendLayout();
            this.mtpUtils.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmStyle)).BeginInit();
            this.panInfo.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.cnmstrUpdateClient.SuspendLayout();
            this.pnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.mtcSettings);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.mlSettings);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1085, 50);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(505, 893);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // mtcSettings
            // 
            this.mtcSettings.Controls.Add(this.mtpAppearence);
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Controls.Add(this.mtpUtils);
            this.mtcSettings.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.mtcSettings.Location = new System.Drawing.Point(12, 73);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 2;
            this.mtcSettings.Size = new System.Drawing.Size(538, 443);
            this.mtcSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mtcSettings.TabIndex = 4;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpAppearence
            // 
            this.mtpAppearence.Controls.Add(this.mrbDark);
            this.mtpAppearence.Controls.Add(this.mrbLight);
            this.mtpAppearence.Controls.Add(this.metroLabel2);
            this.mtpAppearence.Controls.Add(this.metroLabel1);
            this.mtpAppearence.Controls.Add(this.flowLayoutPanel1);
            this.mtpAppearence.HorizontalScrollbarBarColor = true;
            this.mtpAppearence.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpAppearence.HorizontalScrollbarSize = 10;
            this.mtpAppearence.Location = new System.Drawing.Point(4, 39);
            this.mtpAppearence.Name = "mtpAppearence";
            this.mtpAppearence.Size = new System.Drawing.Size(530, 400);
            this.mtpAppearence.TabIndex = 1;
            this.mtpAppearence.Text = "&Внешний вид";
            this.mtpAppearence.VerticalScrollbarBarColor = true;
            this.mtpAppearence.VerticalScrollbarHighlightOnWheel = false;
            this.mtpAppearence.VerticalScrollbarSize = 10;
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDark.Location = new System.Drawing.Point(3, 48);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(77, 20);
            this.mrbDark.TabIndex = 4;
            this.mrbDark.Text = "&Темная";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbDark_CheckedChanged);
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbLight.Location = new System.Drawing.Point(112, 48);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(80, 20);
            this.mrbLight.TabIndex = 4;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "&Светлая";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(3, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(163, 26);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "&Стиль";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(163, 32);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "&Тема";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 300);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // mtpConnection
            // 
            this.mtpConnection.Controls.Add(this.mtbPassword);
            this.mtpConnection.Controls.Add(this.cmbxShops);
            this.mtpConnection.Controls.Add(this.mlSearchServerDB);
            this.mtpConnection.Controls.Add(this.mlSearchClientsDB);
            this.mtpConnection.Controls.Add(this.metroLabel7);
            this.mtpConnection.Controls.Add(this.mlServerDBPath);
            this.mtpConnection.Controls.Add(this.metroLabel5);
            this.mtpConnection.Controls.Add(this.mlClientsDBPath);
            this.mtpConnection.Controls.Add(this.metroLabel3);
            this.mtpConnection.Controls.Add(this.mlAdminSave);
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 39);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(530, 400);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&Соединение";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // mtbPassword
            // 
            // 
            // 
            // 
            this.mtbPassword.CustomButton.Image = null;
            this.mtbPassword.CustomButton.Location = new System.Drawing.Point(140, 2);
            this.mtbPassword.CustomButton.Name = "";
            this.mtbPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPassword.CustomButton.TabIndex = 1;
            this.mtbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPassword.CustomButton.UseSelectable = true;
            this.mtbPassword.CustomButton.Visible = false;
            this.mtbPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtbPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mtbPassword.Lines = new string[0];
            this.mtbPassword.Location = new System.Drawing.Point(155, 268);
            this.mtbPassword.MaxLength = 32767;
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '*';
            this.mtbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPassword.SelectedText = "";
            this.mtbPassword.SelectionLength = 0;
            this.mtbPassword.SelectionStart = 0;
            this.mtbPassword.ShortcutsEnabled = true;
            this.mtbPassword.Size = new System.Drawing.Size(176, 38);
            this.mtbPassword.TabIndex = 5;
            this.mtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPassword.UseSelectable = true;
            this.mtbPassword.Visible = false;
            this.mtbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbPassword_KeyDown);
            // 
            // cmbxShops
            // 
            this.cmbxShops.DisplayMember = "Shops";
            this.cmbxShops.FormattingEnabled = true;
            this.cmbxShops.ItemHeight = 24;
            this.cmbxShops.Location = new System.Drawing.Point(21, 216);
            this.cmbxShops.Name = "cmbxShops";
            this.cmbxShops.Size = new System.Drawing.Size(199, 30);
            this.cmbxShops.TabIndex = 4;
            this.cmbxShops.UseSelectable = true;
            this.cmbxShops.SelectedIndexChanged += new System.EventHandler(this.cmbxShops_SelectedIndexChanged);
            // 
            // mlSearchServerDB
            // 
            this.mlSearchServerDB.AutoSize = true;
            this.mlSearchServerDB.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mlSearchServerDB.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mlSearchServerDB.Location = new System.Drawing.Point(278, 92);
            this.mlSearchServerDB.Name = "mlSearchServerDB";
            this.mlSearchServerDB.Size = new System.Drawing.Size(103, 27);
            this.mlSearchServerDB.TabIndex = 3;
            this.mlSearchServerDB.Text = "Обзор";
            this.mlSearchServerDB.UseSelectable = true;
            this.mlSearchServerDB.Click += new System.EventHandler(this.mlSearchServerDB_Click);
            // 
            // mlSearchClientsDB
            // 
            this.mlSearchClientsDB.AutoSize = true;
            this.mlSearchClientsDB.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mlSearchClientsDB.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mlSearchClientsDB.Location = new System.Drawing.Point(278, 23);
            this.mlSearchClientsDB.Name = "mlSearchClientsDB";
            this.mlSearchClientsDB.Size = new System.Drawing.Size(103, 27);
            this.mlSearchClientsDB.TabIndex = 3;
            this.mlSearchClientsDB.Text = "Обзор";
            this.mlSearchClientsDB.UseSelectable = true;
            this.mlSearchClientsDB.Click += new System.EventHandler(this.mlSearchClientsDB_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(21, 176);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(276, 30);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Текущий магазин";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlServerDBPath
            // 
            this.mlServerDBPath.Location = new System.Drawing.Point(21, 132);
            this.mlServerDBPath.Name = "mlServerDBPath";
            this.mlServerDBPath.Size = new System.Drawing.Size(403, 27);
            this.mlServerDBPath.TabIndex = 2;
            this.mlServerDBPath.Text = "База данных сервера:";
            this.mlServerDBPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(21, 95);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(263, 24);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "База данных сервера:";
            // 
            // mlClientsDBPath
            // 
            this.mlClientsDBPath.Location = new System.Drawing.Point(22, 50);
            this.mlClientsDBPath.Name = "mlClientsDBPath";
            this.mlClientsDBPath.Size = new System.Drawing.Size(402, 32);
            this.mlClientsDBPath.TabIndex = 2;
            this.mlClientsDBPath.Text = "База данных клиента:";
            this.mlClientsDBPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(21, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(225, 27);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "База данных клиента:";
            // 
            // mlAdminSave
            // 
            this.mlAdminSave.Image = global::ClientsMETRO.Properties.Resources.save;
            this.mlAdminSave.ImageSize = 40;
            this.mlAdminSave.Location = new System.Drawing.Point(292, 209);
            this.mlAdminSave.Name = "mlAdminSave";
            this.mlAdminSave.Size = new System.Drawing.Size(39, 43);
            this.mlAdminSave.TabIndex = 6;
            this.mlAdminSave.UseSelectable = true;
            this.mlAdminSave.Click += new System.EventHandler(this.mlAdminSave_Click);
            // 
            // mtpUtils
            // 
            this.mtpUtils.BackColor = System.Drawing.Color.Transparent;
            this.mtpUtils.Controls.Add(this.mlFileGenerate);
            this.mtpUtils.Controls.Add(this.mlUpdateServData);
            this.mtpUtils.Location = new System.Drawing.Point(4, 34);
            this.mtpUtils.Name = "mtpUtils";
            this.mtpUtils.Size = new System.Drawing.Size(530, 405);
            this.mtpUtils.TabIndex = 2;
            this.mtpUtils.Text = "Инструменты";
            // 
            // mlFileGenerate
            // 
            this.mlFileGenerate.Image = global::ClientsMETRO.Properties.Resources._211;
            this.mlFileGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlFileGenerate.ImageSize = 32;
            this.mlFileGenerate.Location = new System.Drawing.Point(14, 85);
            this.mlFileGenerate.Name = "mlFileGenerate";
            this.mlFileGenerate.Size = new System.Drawing.Size(253, 44);
            this.mlFileGenerate.TabIndex = 1;
            this.mlFileGenerate.Text = "Генерация файла-рассылки";
            this.mlFileGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlFileGenerate.UseSelectable = true;
            this.mlFileGenerate.Visible = false;
            this.mlFileGenerate.Click += new System.EventHandler(this.создатьФайлДляРассылкиToolStripMenuItem_Click);
            // 
            // mlUpdateServData
            // 
            this.mlUpdateServData.Image = global::ClientsMETRO.Properties.Resources.imagen_sync_for_icloud_0big;
            this.mlUpdateServData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlUpdateServData.ImageSize = 32;
            this.mlUpdateServData.Location = new System.Drawing.Point(14, 24);
            this.mlUpdateServData.Name = "mlUpdateServData";
            this.mlUpdateServData.Size = new System.Drawing.Size(253, 40);
            this.mlUpdateServData.TabIndex = 0;
            this.mlUpdateServData.Text = "&Обновить серверные данные";
            this.mlUpdateServData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlUpdateServData.UseSelectable = true;
            this.mlUpdateServData.Visible = false;
            this.mlUpdateServData.Click += new System.EventHandler(this.обновитьСерверныеДанныеToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 893);
            this.panel1.TabIndex = 3;
            // 
            // mlSettings
            // 
            this.mlSettings.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlSettings.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.mlSettings.Image = global::ClientsMETRO.Properties.Resources.back;
            this.mlSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlSettings.ImageSize = 32;
            this.mlSettings.Location = new System.Drawing.Point(12, 3);
            this.mlSettings.Name = "mlSettings";
            this.mlSettings.Size = new System.Drawing.Size(207, 64);
            this.mlSettings.TabIndex = 2;
            this.mlSettings.Text = "&Settings";
            this.mlSettings.UseSelectable = true;
            this.mlSettings.Click += new System.EventHandler(this.mlSettings_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "Clients";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(149, 20);
            this.lblStatus.Text = "Работа программы";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 19);
            this.toolStripProgressBar1.Step = 3;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblStatusRuning
            // 
            this.lblStatusRuning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusRuning.ForeColor = System.Drawing.Color.Lime;
            this.lblStatusRuning.Name = "lblStatusRuning";
            this.lblStatusRuning.Size = new System.Drawing.Size(123, 20);
            this.lblStatusRuning.Text = "Выполняется...";
            // 
            // tstrlblClientsNumber
            // 
            this.tstrlblClientsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tstrlblClientsNumber.ForeColor = System.Drawing.Color.Lime;
            this.tstrlblClientsNumber.Name = "tstrlblClientsNumber";
            this.tstrlblClientsNumber.Size = new System.Drawing.Size(307, 20);
            this.tstrlblClientsNumber.Text = "В базе зарегистрировано 8500 человек";
            // 
            // tstrlblClientsForDate
            // 
            this.tstrlblClientsForDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tstrlblClientsForDate.ForeColor = System.Drawing.Color.Lime;
            this.tstrlblClientsForDate.Name = "tstrlblClientsForDate";
            this.tstrlblClientsForDate.Size = new System.Drawing.Size(200, 20);
            this.tstrlblClientsForDate.Text = "Заполнение клиентов за ";
            // 
            // tstrlblNewClients
            // 
            this.tstrlblNewClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tstrlblNewClients.ForeColor = System.Drawing.Color.Lime;
            this.tstrlblNewClients.Name = "tstrlblNewClients";
            this.tstrlblNewClients.Size = new System.Drawing.Size(128, 20);
            this.tstrlblNewClients.Text = "Новых клиентов";
            // 
            // tstrlblExistingClients
            // 
            this.tstrlblExistingClients.AutoSize = false;
            this.tstrlblExistingClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tstrlblExistingClients.ForeColor = System.Drawing.Color.Lime;
            this.tstrlblExistingClients.Name = "tstrlblExistingClients";
            this.tstrlblExistingClients.Size = new System.Drawing.Size(197, 20);
            this.tstrlblExistingClients.Text = "Существующих клиентов:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripProgressBar1,
            this.lblStatusRuning,
            this.tstrlblClientsNumber,
            this.tstrlblClientsForDate,
            this.tstrlblNewClients,
            this.tstrlblExistingClients});
            this.statusStrip1.Location = new System.Drawing.Point(20, 946);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1559, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msmStyle
            // 
            this.msmStyle.Owner = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 100);
            this.maskedTextBox1.Mask = "38(999)000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(496, 60);
            this.maskedTextBox1.TabIndex = 89;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.White;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(140, 100);
            this.maskedTextBox2.Mask = "00(999)000-00-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(496, 60);
            this.maskedTextBox2.TabIndex = 90;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.Visible = false;
            this.maskedTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // panInfo
            // 
            this.panInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panInfo.AutoSize = true;
            this.panInfo.Controls.Add(this.metroPanel2);
            this.panInfo.Controls.Add(this.lblBirthDate);
            this.panInfo.Controls.Add(this.picbxWhatsApp);
            this.panInfo.Controls.Add(this.picbxViber);
            this.panInfo.Controls.Add(this.lblClientName);
            this.panInfo.HorizontalScrollbarBarColor = true;
            this.panInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.panInfo.HorizontalScrollbarSize = 10;
            this.panInfo.Location = new System.Drawing.Point(5, 173);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(845, 525);
            this.panInfo.TabIndex = 93;
            this.panInfo.VerticalScrollbarBarColor = true;
            this.panInfo.VerticalScrollbarHighlightOnWheel = false;
            this.panInfo.VerticalScrollbarSize = 10;
            this.panInfo.Visible = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoSize = true;
            this.metroPanel2.Controls.Add(this.metroTabControl1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(16, 189);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(809, 310);
            this.metroPanel2.TabIndex = 88;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.Location = new System.Drawing.Point(19, 14);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(787, 284);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblDiscount);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.lblTotal);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 15;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 34);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(779, 246);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Информация";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscount.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Lime;
            this.lblDiscount.Location = new System.Drawing.Point(308, 91);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(165, 80);
            this.lblDiscount.TabIndex = 86;
            this.lblDiscount.Text = "%";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(0, 112);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(230, 44);
            this.metroLabel6.TabIndex = 85;
            this.metroLabel6.Text = "Дисконт клиента";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(506, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 73);
            this.label5.TabIndex = 84;
            this.label5.Text = "грн.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(-4, 34);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(262, 35);
            this.metroLabel4.TabIndex = 83;
            this.metroLabel4.Text = "Общая сумма покупок";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTotal.Location = new System.Drawing.Point(312, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(161, 59);
            this.lblTotal.TabIndex = 82;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel5);
            this.metroTabPage2.Controls.Add(this.metroPanel4);
            this.metroTabPage2.Controls.Add(this.metroPanel3);
            this.metroTabPage2.HorizontalScrollbarBarColor = false;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 15;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(779, 241);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "По магазинам";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.lblBars);
            this.metroPanel5.Controls.Add(this.metroLabel19);
            this.metroPanel5.Controls.Add(this.lblOdessa);
            this.metroPanel5.Controls.Add(this.metroLabel21);
            this.metroPanel5.Controls.Add(this.metroLabel22);
            this.metroPanel5.HorizontalScrollbar = true;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(513, 17);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(263, 222);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // lblBars
            // 
            this.lblBars.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBars.Location = new System.Drawing.Point(152, 115);
            this.lblBars.Name = "lblBars";
            this.lblBars.Size = new System.Drawing.Size(108, 33);
            this.lblBars.TabIndex = 3;
            this.lblBars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel19
            // 
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(19, 111);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(105, 37);
            this.metroLabel19.TabIndex = 3;
            this.metroLabel19.Text = "Барс";
            this.metroLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOdessa
            // 
            this.lblOdessa.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOdessa.Location = new System.Drawing.Point(152, 64);
            this.lblOdessa.Name = "lblOdessa";
            this.lblOdessa.Size = new System.Drawing.Size(108, 34);
            this.lblOdessa.TabIndex = 3;
            this.lblOdessa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel21
            // 
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(19, 59);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(105, 30);
            this.metroLabel21.TabIndex = 3;
            this.metroLabel21.Text = "Одесса";
            this.metroLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel22
            // 
            this.metroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.Location = new System.Drawing.Point(70, 9);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(136, 45);
            this.metroLabel22.TabIndex = 2;
            this.metroLabel22.Text = "ОДЕССА";
            this.metroLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.lblFourG);
            this.metroPanel4.Controls.Add(this.lblDafi);
            this.metroPanel4.Controls.Add(this.metroLabel23);
            this.metroPanel4.Controls.Add(this.metroLabel14);
            this.metroPanel4.Controls.Add(this.lblKaravan);
            this.metroPanel4.Controls.Add(this.metroLabel17);
            this.metroPanel4.Controls.Add(this.metroLabel16);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(225, 17);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(263, 222);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // lblFourG
            // 
            this.lblFourG.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFourG.Location = new System.Drawing.Point(158, 160);
            this.lblFourG.Name = "lblFourG";
            this.lblFourG.Size = new System.Drawing.Size(102, 31);
            this.lblFourG.TabIndex = 3;
            this.lblFourG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDafi
            // 
            this.lblDafi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDafi.Location = new System.Drawing.Point(158, 115);
            this.lblDafi.Name = "lblDafi";
            this.lblDafi.Size = new System.Drawing.Size(102, 33);
            this.lblDafi.TabIndex = 3;
            this.lblDafi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel23
            // 
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel23.Location = new System.Drawing.Point(17, 160);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(94, 41);
            this.metroLabel23.TabIndex = 3;
            this.metroLabel23.Text = "4G";
            this.metroLabel23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(17, 113);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(94, 37);
            this.metroLabel14.TabIndex = 3;
            this.metroLabel14.Text = "Дафи";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKaravan
            // 
            this.lblKaravan.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKaravan.Location = new System.Drawing.Point(157, 59);
            this.lblKaravan.Name = "lblKaravan";
            this.lblKaravan.Size = new System.Drawing.Size(102, 34);
            this.lblKaravan.TabIndex = 3;
            this.lblKaravan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel17
            // 
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(59, 9);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(136, 45);
            this.metroLabel17.TabIndex = 2;
            this.metroLabel17.Text = "ДНЕПР";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(17, 59);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(135, 30);
            this.metroLabel16.TabIndex = 3;
            this.metroLabel16.Text = "Караван";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.lblOutlet);
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.lblKiev);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 17);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(200, 222);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblOutlet
            // 
            this.lblOutlet.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOutlet.Location = new System.Drawing.Point(98, 111);
            this.lblOutlet.Name = "lblOutlet";
            this.lblOutlet.Size = new System.Drawing.Size(99, 33);
            this.lblOutlet.TabIndex = 3;
            this.lblOutlet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(14, 109);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(90, 35);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Outlet";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKiev
            // 
            this.lblKiev.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKiev.Location = new System.Drawing.Point(98, 59);
            this.lblKiev.Name = "lblKiev";
            this.lblKiev.Size = new System.Drawing.Size(99, 34);
            this.lblKiev.TabIndex = 3;
            this.lblKiev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(14, 54);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 39);
            this.metroLabel9.TabIndex = 3;
            this.metroLabel9.Text = "Океан";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(29, 9);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(136, 45);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "КИЕВ";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.Black;
            this.lblBirthDate.Location = new System.Drawing.Point(298, 129);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(0, 55);
            this.lblBirthDate.TabIndex = 86;
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbxWhatsApp
            // 
            this.picbxWhatsApp.Image = global::ClientsMETRO.Properties.Resources.whatsapp_hide_last_seen_stt_2_l_140x140;
            this.picbxWhatsApp.ImageSize = 60;
            this.picbxWhatsApp.Location = new System.Drawing.Point(739, 25);
            this.picbxWhatsApp.Name = "picbxWhatsApp";
            this.picbxWhatsApp.Size = new System.Drawing.Size(83, 67);
            this.picbxWhatsApp.TabIndex = 83;
            this.picbxWhatsApp.UseSelectable = true;
            this.picbxWhatsApp.Visible = false;
            // 
            // picbxViber
            // 
            this.picbxViber.Image = global::ClientsMETRO.Properties.Resources.viber;
            this.picbxViber.ImageSize = 60;
            this.picbxViber.Location = new System.Drawing.Point(18, 25);
            this.picbxViber.Name = "picbxViber";
            this.picbxViber.Size = new System.Drawing.Size(83, 67);
            this.picbxViber.TabIndex = 82;
            this.picbxViber.UseSelectable = true;
            this.picbxViber.Visible = false;
            // 
            // lblClientName
            // 
            this.lblClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientName.ContextMenuStrip = this.cnmstrUpdateClient;
            this.lblClientName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblClientName.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientName.ForeColor = System.Drawing.Color.Red;
            this.lblClientName.Location = new System.Drawing.Point(128, 13);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(596, 112);
            this.lblClientName.TabIndex = 81;
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cnmstrUpdateClient
            // 
            this.cnmstrUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cnmstrUpdateClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cnmstrUpdateClient.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnmstrUpdateClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьДанныеКлиентаToolStripMenuItem});
            this.cnmstrUpdateClient.Name = "cnmstrUpdateClient";
            this.cnmstrUpdateClient.Size = new System.Drawing.Size(270, 30);
            // 
            // изменитьДанныеКлиентаToolStripMenuItem
            // 
            this.изменитьДанныеКлиентаToolStripMenuItem.Image = global::ClientsMETRO.Properties.Resources.screen9_item_img_6;
            this.изменитьДанныеКлиентаToolStripMenuItem.Name = "изменитьДанныеКлиентаToolStripMenuItem";
            this.изменитьДанныеКлиентаToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.изменитьДанныеКлиентаToolStripMenuItem.Text = "Изменить данные клиента";
            this.изменитьДанныеКлиентаToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеКлиентаToolStripMenuItem_Click);
            // 
            // pnlSales
            // 
            this.pnlSales.Controls.Add(this.pbxSell);
            this.pnlSales.Controls.Add(this.chbxVozvrat);
            this.pnlSales.Controls.Add(this.txbxSum);
            this.pnlSales.HorizontalScrollbarBarColor = true;
            this.pnlSales.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSales.HorizontalScrollbarSize = 10;
            this.pnlSales.Location = new System.Drawing.Point(856, 173);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(301, 293);
            this.pnlSales.TabIndex = 94;
            this.pnlSales.VerticalScrollbarBarColor = true;
            this.pnlSales.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSales.VerticalScrollbarSize = 10;
            this.pnlSales.Visible = false;
            // 
            // pbxSell
            // 
            this.pbxSell.Image = global::ClientsMETRO.Properties.Resources.E_commerce_Labcomputers;
            this.pbxSell.ImageSize = 86;
            this.pbxSell.Location = new System.Drawing.Point(82, 174);
            this.pbxSell.Name = "pbxSell";
            this.pbxSell.Size = new System.Drawing.Size(125, 100);
            this.pbxSell.TabIndex = 81;
            this.pbxSell.UseSelectable = true;
            this.pbxSell.Click += new System.EventHandler(this.pbxSell_DoubleClick);
            // 
            // chbxVozvrat
            // 
            this.chbxVozvrat.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chbxVozvrat.Location = new System.Drawing.Point(98, 134);
            this.chbxVozvrat.Name = "chbxVozvrat";
            this.chbxVozvrat.Size = new System.Drawing.Size(90, 25);
            this.chbxVozvrat.TabIndex = 80;
            this.chbxVozvrat.Text = "Возврат";
            this.chbxVozvrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxVozvrat.UseSelectable = true;
            // 
            // txbxSum
            // 
            this.txbxSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbxSum.Font = new System.Drawing.Font("Comic Sans MS", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbxSum.ForeColor = System.Drawing.Color.MediumBlue;
            this.txbxSum.Location = new System.Drawing.Point(13, 13);
            this.txbxSum.Name = "txbxSum";
            this.txbxSum.Size = new System.Drawing.Size(271, 100);
            this.txbxSum.TabIndex = 79;
            this.txbxSum.Text = "0";
            this.txbxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvClients.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClients.Location = new System.Drawing.Point(5, 726);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClients.Size = new System.Drawing.Size(845, 131);
            this.dgvClients.TabIndex = 95;
            this.dgvClients.TabStop = false;
            this.dgvClients.Visible = false;
            // 
            // btnSendData
            // 
            this.btnSendData.ActiveControl = null;
            this.btnSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendData.Enabled = false;
            this.btnSendData.Location = new System.Drawing.Point(1413, 50);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(96, 96);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.TileImage = global::ClientsMETRO.Properties.Resources.SendData;
            this.btnSendData.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendData.UseSelectable = true;
            this.btnSendData.UseTileImage = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnDownloadFromServ
            // 
            this.btnDownloadFromServ.ActiveControl = null;
            this.btnDownloadFromServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadFromServ.Location = new System.Drawing.Point(1311, 50);
            this.btnDownloadFromServ.Name = "btnDownloadFromServ";
            this.btnDownloadFromServ.Size = new System.Drawing.Size(96, 96);
            this.btnDownloadFromServ.TabIndex = 0;
            this.btnDownloadFromServ.TileImage = global::ClientsMETRO.Properties.Resources.GetData2;
            this.btnDownloadFromServ.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDownloadFromServ.UseSelectable = true;
            this.btnDownloadFromServ.UseTileImage = true;
            this.btnDownloadFromServ.Click += new System.EventHandler(this.btnDownloadFromServ_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.ActiveControl = null;
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.Location = new System.Drawing.Point(1311, 152);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(198, 96);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.TileImage = global::ClientsMETRO.Properties.Resources.Settings;
            this.btnAdmin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdmin.UseSelectable = true;
            this.btnAdmin.UseTileImage = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pbxFlagEU
            // 
            this.pbxFlagEU.Image = global::ClientsMETRO.Properties.Resources.European_union_icon;
            this.pbxFlagEU.ImageSize = 60;
            this.pbxFlagEU.Location = new System.Drawing.Point(643, 93);
            this.pbxFlagEU.Name = "pbxFlagEU";
            this.pbxFlagEU.Size = new System.Drawing.Size(83, 67);
            this.pbxFlagEU.TabIndex = 91;
            this.pbxFlagEU.UseSelectable = true;
            this.pbxFlagEU.Click += new System.EventHandler(this.pbxFlagEU_Click);
            // 
            // pbxFlagUkraine
            // 
            this.pbxFlagUkraine.Image = global::ClientsMETRO.Properties.Resources.ukraine_flag_7682;
            this.pbxFlagUkraine.ImageSize = 60;
            this.pbxFlagUkraine.Location = new System.Drawing.Point(643, 93);
            this.pbxFlagUkraine.Name = "pbxFlagUkraine";
            this.pbxFlagUkraine.Size = new System.Drawing.Size(83, 67);
            this.pbxFlagUkraine.TabIndex = 92;
            this.pbxFlagUkraine.UseSelectable = true;
            this.pbxFlagUkraine.Visible = false;
            this.pbxFlagUkraine.Click += new System.EventHandler(this.pbxFlagUkraine_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1589, 991);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pnlSales);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.btnDownloadFromServ);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pbxFlagEU);
            this.Controls.Add(this.pbxFlagUkraine);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 10, 20);
            this.Resizable = false;
            this.Text = "Clients";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpAppearence.ResumeLayout(false);
            this.mtpAppearence.PerformLayout();
            this.mtpConnection.ResumeLayout(false);
            this.mtpConnection.PerformLayout();
            this.mtpUtils.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmStyle)).EndInit();
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.cnmstrUpdateClient.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlSettings;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpAppearence;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroLink mlAdminSave;
        private MetroFramework.Controls.MetroTextBox mtbPassword;
        private MetroFramework.Controls.MetroComboBox cmbxShops;
        private MetroFramework.Controls.MetroLink mlSearchServerDB;
        private MetroFramework.Controls.MetroLink mlSearchClientsDB;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel mlServerDBPath;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel mlClientsDBPath;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnDownloadFromServ;
        private MetroFramework.Controls.MetroTile btnAdmin;
        private MetroFramework.Controls.MetroTile btnSendData;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusRuning;
        private System.Windows.Forms.ToolStripStatusLabel tstrlblClientsNumber;
        private System.Windows.Forms.ToolStripStatusLabel tstrlblClientsForDate;
        private System.Windows.Forms.ToolStripStatusLabel tstrlblNewClients;
        private System.Windows.Forms.ToolStripStatusLabel tstrlblExistingClients;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Components.MetroStyleManager msmStyle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private MetroFramework.Controls.MetroLink pbxFlagEU;
        private MetroFramework.Controls.MetroLink pbxFlagUkraine;
        private MetroFramework.Controls.MetroPanel panInfo;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label lblDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label lblTotal;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel lblBars;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel lblOdessa;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel lblFourG;
        private MetroFramework.Controls.MetroLabel lblDafi;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel lblKaravan;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel lblOutlet;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lblKiev;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Label lblBirthDate;
        private MetroFramework.Controls.MetroLink picbxWhatsApp;
        private MetroFramework.Controls.MetroLink picbxViber;
        private System.Windows.Forms.Label lblClientName;
        private MetroFramework.Controls.MetroPanel pnlSales;
        private MetroFramework.Controls.MetroLink pbxSell;
        private MetroFramework.Controls.MetroCheckBox chbxVozvrat;
        private System.Windows.Forms.TextBox txbxSum;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеКлиентаToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu cnmstrUpdateClient;
        private System.Windows.Forms.TabPage mtpUtils;
        private MetroFramework.Controls.MetroLink mlUpdateServData;
        private MetroFramework.Controls.MetroLink mlFileGenerate;
    }
}

