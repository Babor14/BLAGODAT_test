namespace BLAGODAT
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            Логин = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(30, 63);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(264, 24);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(264, 24);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(73, 140, 81);
            btnLogin.Location = new Point(30, 176);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 26);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Логин
            // 
            Логин.AutoSize = true;
            Логин.Location = new Point(33, 43);
            Логин.Name = "Логин";
            Логин.Size = new Size(49, 17);
            Логин.TabIndex = 3;
            Логин.Text = "Логин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 100);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 4;
            label1.Text = "Пароль:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 240);
            Controls.Add(label1);
            Controls.Add(Логин);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Font = new Font("Comic Sans MS", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label Логин;
        private Label label1;
    }
}