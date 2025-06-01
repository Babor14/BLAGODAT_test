using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BLAGODAT.Model;
using Microsoft.EntityFrameworkCore;

namespace BLAGODAT
{
    
    public partial class ReportForm : Form
    {
        private Form prevForm;
        public ReportForm(Form MainFOrm)
        {
            InitializeComponent();


            comboReportType.Items.Add("Услуги");
            comboReportType.Items.Add("Заказы по услугам");
            comboReportType.Items.Add("Общие заказы");
            comboReportType.SelectedIndex = 0;
            this.prevForm = MainFOrm;
        }


        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            DataTable reportData = null;
            string reportType = comboReportType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Выберите тип отчёта.");
                return;
            }

            switch (reportType)
            {
                case "Услуги":
                    reportData = GetServicesCount();
                    break;
                case "Заказы по услугам":
                    reportData = GetOrdersCountByService();
                    break;
                case "Общие заказы":
                    reportData = GetOrdersCountOverall();
                    break;
                default:
                    MessageBox.Show("Выбран неизвестный тип отчёта.");
                    return;
            }


            dataGridViewReport.DataSource = reportData;
        }


        private DataTable GetServicesCount()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата", typeof(string));
            dt.Columns.Add("Количество оказанных услуг", typeof(int));

            using (var context = new GorcompContext())
            {
                var query = context.OrderImports
                    .AsEnumerable()
                    .GroupBy(o => o.ДатаСоздания)
                    .Select(g => new
                    {
                        Дата = g.Key,
                        Количество = g.Sum(o => o.КодУслугиs.Count)
                    })
                    .OrderBy(x => x.Дата)
                    .ToList();

                foreach (var item in query)
                {
                    dt.Rows.Add(item.Дата, item.Количество);
                }
            }
            return dt;
        }

        private DataTable GetOrdersCountByService()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата", typeof(string));
            dt.Columns.Add("Наименование услуги", typeof(string));
            dt.Columns.Add("Количество заказов", typeof(int));

            using (var context = new GorcompContext())
            {
                var orders = context.OrderImports
                    .Include(o => o.КодУслугиs)
                    .AsEnumerable()
                    .SelectMany(o =>
                    {
                        string date = o.ДатаСоздания;
                        return o.КодУслугиs.Select(s => new { Дата = date, НаименованиеУслуги = s.НаименованиеУслуги });
                    })
                    .GroupBy(x => new { x.Дата, x.НаименованиеУслуги })
                    .Select(g => new
                    {
                        g.Key.Дата,
                        g.Key.НаименованиеУслуги,
                        Количество = g.Count()
                    })
                    .OrderBy(x => x.Дата)
                    .ThenBy(x => x.НаименованиеУслуги)
                    .ToList();

                foreach (var item in orders)
                {
                    dt.Rows.Add(item.Дата, item.НаименованиеУслуги, item.Количество);
                }
            }
            return dt;
        }

        private DataTable GetOrdersCountOverall()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Дата", typeof(string));
            dt.Columns.Add("Количество заказов", typeof(int));

            using (var context = new GorcompContext())
            {
                var query = context.OrderImports
                    .AsEnumerable()
                    .GroupBy(o => o.ДатаСоздания)
                    .Select(g => new
                    {
                        Дата = g.Key,
                        Количество = g.Count()
                    })
                    .OrderBy(x => x.Дата)
                    .ToList();

                foreach (var item in query)
                {
                    dt.Rows.Add(item.Дата, item.Количество);
                }
            }
            return dt;
        }

        private void bttnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backvttn_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Close();
        }
    }
}
