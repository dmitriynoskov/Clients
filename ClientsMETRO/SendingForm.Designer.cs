namespace ClientsMETRO
{
    partial class SendingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpckrFilterDate = new MetroFramework.Controls.MetroDateTime();
            this.btnFormingReport = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // dtpckrFilterDate
            // 
            this.dtpckrFilterDate.Location = new System.Drawing.Point(23, 111);
            this.dtpckrFilterDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtpckrFilterDate.Name = "dtpckrFilterDate";
            this.dtpckrFilterDate.Size = new System.Drawing.Size(215, 30);
            this.dtpckrFilterDate.TabIndex = 0;
            // 
            // btnFormingReport
            // 
            this.btnFormingReport.ActiveControl = null;
            this.btnFormingReport.Location = new System.Drawing.Point(299, 84);
            this.btnFormingReport.Name = "btnFormingReport";
            this.btnFormingReport.Size = new System.Drawing.Size(135, 91);
            this.btnFormingReport.TabIndex = 1;
            this.btnFormingReport.Text = "Сформировать\r\nотчет";
            this.btnFormingReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormingReport.UseSelectable = true;
            this.btnFormingReport.Click += new System.EventHandler(this.btnFormingReport_Click);
            // 
            // SendingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(479, 231);
            this.Controls.Add(this.btnFormingReport);
            this.Controls.Add(this.dtpckrFilterDate);
            this.Name = "SendingForm";
            this.Resizable = false;
            this.Text = "Генерация файла-рассылки";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dtpckrFilterDate;
        private MetroFramework.Controls.MetroTile btnFormingReport;
    }
}