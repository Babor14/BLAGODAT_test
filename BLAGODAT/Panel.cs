using BLAGODAT.Model;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLAGODAT
{
    public partial class Panel : UserControl
    {
        private OrderImport order;
        private BlagodateContext db;
        private MainForm form;
        private PrivateFontCollection barcode = new PrivateFontCollection();

        public Panel(OrderImport _order, MainForm _form)
        {
            InitializeComponent();

            order = _order;
            form = _form;

            label_zakaz_code.Text = order.КодЗаказа;
            label_date_create.Text = order.ДатаСоздания + " / " + (string.IsNullOrEmpty(order.ДатаЗакрытия) ? "ещё не сдан" : order.ДатаЗакрытия);
            label_time_create.Text = order.ВремяЗаказа;
            label_status.Text = order.Статус;
            label_time_procat.Text = order.ВремяПроката;
            label_barcode.Text = order.КодЗаказа;


            LoadBarcodeFont();
        }
        public void LoadBarcodeFont()
        {
            string fontFile = Path.Combine(Application.StartupPath, "resources", "fonts", "Free3Of9Regular.ttf");
            if (!File.Exists(fontFile))
                throw new FileNotFoundException("Шрифт не найден по пути", fontFile);

            barcode.AddFontFile(fontFile);

            label_barcode.Font = new Font(barcode.Families[0], 48f);
            label_barcode.Text = "*" + order.КодЗаказа + "*";
            label_barcode.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить элемент {order.КодЗаказа}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    db = new BlagodateContext();
                    db.Remove(order);
                    db.SaveChanges();
                    form.UpdateForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Невозможно удалить элемент {ex.Message}");
                }
            }
        }

        private void label_date_create_Click(object sender, EventArgs e)
        {

        }


    }


    }
