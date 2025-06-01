namespace BLAGODAT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            textBoxNameSearch = new TextBox();
            label1 = new Label();
            comboBoxSort = new ComboBox();
            panelMaterials = new System.Windows.Forms.Panel();
            closebttn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(73, 140, 81);
            button1.Location = new Point(580, 24);
            button1.Name = "button1";
            button1.Size = new Size(131, 37);
            button1.TabIndex = 9;
            button1.Text = "Создать отчёт";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxNameSearch
            // 
            textBoxNameSearch.BorderStyle = BorderStyle.None;
            textBoxNameSearch.Location = new Point(145, 37);
            textBoxNameSearch.Name = "textBoxNameSearch";
            textBoxNameSearch.PlaceholderText = "Поиск по коду заказа";
            textBoxNameSearch.Size = new Size(135, 17);
            textBoxNameSearch.TabIndex = 8;
            textBoxNameSearch.TextChanged += textBoxNameSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 7;
            label1.Text = "Сортировка по коду заказа";
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            comboBoxSort.Location = new Point(405, 31);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 25);
            comboBoxSort.TabIndex = 6;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // panelMaterials
            // 
            panelMaterials.AutoScroll = true;
            panelMaterials.BackColor = Color.FromArgb(118, 227, 131);
            panelMaterials.Location = new Point(14, 87);
            panelMaterials.Name = "panelMaterials";
            panelMaterials.Size = new Size(697, 411);
            panelMaterials.TabIndex = 5;
            panelMaterials.Paint += panelMaterials_Paint;
            // 
            // closebttn
            // 
            closebttn.BackColor = Color.FromArgb(73, 140, 81);
            closebttn.Location = new Point(14, 19);
            closebttn.Name = "closebttn";
            closebttn.Size = new Size(37, 37);
            closebttn.TabIndex = 10;
            closebttn.Text = "X";
            closebttn.UseVisualStyleBackColor = false;
            closebttn.Click += closebttn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 510);
            Controls.Add(closebttn);
            Controls.Add(button1);
            Controls.Add(textBoxNameSearch);
            Controls.Add(label1);
            Controls.Add(comboBoxSort);
            Controls.Add(panelMaterials);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Заказы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxNameSearch;
        private Label label1;
        private ComboBox comboBoxSort;
        private System.Windows.Forms.Panel panelMaterials;
        private Button closebttn;
    }
}