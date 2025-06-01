namespace BLAGODAT
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            comboReportType = new ComboBox();
            btnCreateReport = new Button();
            dataGridViewReport = new DataGridView();
            backvttn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // comboReportType
            // 
            comboReportType.FormattingEnabled = true;
            comboReportType.Items.AddRange(new object[] { "Услуги", "Заказы по услугам", "Общие заказы" });
            comboReportType.Location = new Point(422, 18);
            comboReportType.Name = "comboReportType";
            comboReportType.Size = new Size(137, 25);
            comboReportType.TabIndex = 2;
            // 
            // btnCreateReport
            // 
            btnCreateReport.BackColor = Color.FromArgb(73, 140, 81);
            btnCreateReport.Location = new Point(577, 14);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(131, 37);
            btnCreateReport.TabIndex = 3;
            btnCreateReport.Text = "Создать отчёт";
            btnCreateReport.UseVisualStyleBackColor = false;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.BackgroundColor = Color.FromArgb(118, 227, 131);
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(22, 63);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new Size(739, 433);
            dataGridViewReport.TabIndex = 4;
            // 
            // backvttn
            // 
            backvttn.BackColor = Color.FromArgb(73, 140, 81);
            backvttn.Location = new Point(22, 18);
            backvttn.Name = "backvttn";
            backvttn.Size = new Size(131, 37);
            backvttn.TabIndex = 5;
            backvttn.Text = "Назад";
            backvttn.UseVisualStyleBackColor = false;
            backvttn.Click += backvttn_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(backvttn);
            Controls.Add(dataGridViewReport);
            Controls.Add(btnCreateReport);
            Controls.Add(comboReportType);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportForm";
            Text = "Создание отчёта";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboReportType;
        private Button btnCreateReport;
        private DataGridView dataGridViewReport;
        private Button backvttn;
    }
}