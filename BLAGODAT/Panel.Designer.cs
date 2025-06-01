namespace BLAGODAT
{
    partial class Panel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label_zakaz_code = new Label();
            label_date_create = new Label();
            label_time_create = new Label();
            label_status = new Label();
            label_time_procat = new Label();
            label1 = new Label();
            label2 = new Label();
            Дата = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label_barcode = new Label();
            SuspendLayout();
            // 
            // label_zakaz_code
            // 
            label_zakaz_code.AutoSize = true;
            label_zakaz_code.Location = new Point(109, 20);
            label_zakaz_code.Name = "label_zakaz_code";
            label_zakaz_code.Size = new Size(39, 17);
            label_zakaz_code.TabIndex = 0;
            label_zakaz_code.Text = "label1";
            // 
            // label_date_create
            // 
            label_date_create.AutoSize = true;
            label_date_create.Location = new Point(214, 61);
            label_date_create.Name = "label_date_create";
            label_date_create.Size = new Size(41, 17);
            label_date_create.TabIndex = 1;
            label_date_create.Text = "label2";
            label_date_create.Click += label_date_create_Click;
            // 
            // label_time_create
            // 
            label_time_create.AutoSize = true;
            label_time_create.Location = new Point(126, 96);
            label_time_create.Name = "label_time_create";
            label_time_create.Size = new Size(41, 17);
            label_time_create.TabIndex = 2;
            label_time_create.Text = "label3";
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(574, 20);
            label_status.Name = "label_status";
            label_status.Size = new Size(41, 17);
            label_status.TabIndex = 4;
            label_status.Text = "label4";
            // 
            // label_time_procat
            // 
            label_time_procat.AutoSize = true;
            label_time_procat.Location = new Point(586, 102);
            label_time_procat.Name = "label_time_procat";
            label_time_procat.Size = new Size(41, 17);
            label_time_procat.TabIndex = 5;
            label_time_procat.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(638, 2);
            label1.Name = "label1";
            label1.Size = new Size(15, 17);
            label1.TabIndex = 8;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 22);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 9;
            label2.Text = "Код заказа -";
            // 
            // Дата
            // 
            Дата.AutoSize = true;
            Дата.Location = new Point(20, 61);
            Дата.Name = "Дата";
            Дата.Size = new Size(189, 17);
            Дата.TabIndex = 10;
            Дата.Text = "Дата создания/Дата закрытия -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 96);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 11;
            label3.Text = "Время создания -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 20);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 12;
            label4.Text = "Статус -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 102);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 13;
            label5.Text = "Время проката - ";
            // 
            // label_barcode
            // 
            label_barcode.AutoSize = true;
            label_barcode.Font = new Font("Microsoft Sans Serif", 9F);
            label_barcode.Location = new Point(574, 61);
            label_barcode.Name = "label_barcode";
            label_barcode.Size = new Size(41, 15);
            label_barcode.TabIndex = 14;
            label_barcode.Text = "label6";
            // 
            // Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 227, 131);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label_barcode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Дата);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_time_procat);
            Controls.Add(label_status);
            Controls.Add(label_time_create);
            Controls.Add(label_date_create);
            Controls.Add(label_zakaz_code);
            Font = new Font("Comic Sans MS", 9F);
            ForeColor = SystemColors.ControlText;
            Name = "Panel";
            Size = new Size(654, 138);
            Load += Panel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_zakaz_code;
        private Label label_date_create;
        private Label label_time_create;
        private Label label_status;
        private Label label_time_procat;
        private Label label1;
        private Label label2;
        private Label Дата;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label_barcode;
    }
}
