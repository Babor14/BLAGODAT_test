using System;
using System.Linq;
using System.Windows.Forms;
using BLAGODAT.Model; // Подключаем пространство имен модели

namespace BLAGODAT
{
    public partial class LoginForm : Form
    {
        private GorcompContext db = new GorcompContext(); // Контекст БД

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            // Ищем клиента в базе
            var user = db.ClientsImports.FirstOrDefault(c => c.EMail == login && c.Password == password);

            if (user != null)
            {
                MessageBox.Show("Авторизация успешна!");

                // Переход в основную форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Скрываем форму входа
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
