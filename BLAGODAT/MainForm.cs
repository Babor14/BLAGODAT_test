using BLAGODAT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLAGODAT
{
    public partial class MainForm : Form
    {
        private List<OrderImport> list;
        private GorcompContext db;

        public MainForm()
        {
            InitializeComponent();

            db = new GorcompContext();
            list = db.OrderImports.ToList();

            UpdateForm();
        }

        public void UpdateForm()
        {

            panelMaterials.Controls.Clear();
            list = db.OrderImports.ToList();
            int x = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Panel pc = new Panel(list[i], this);
                pc.Top = x;
                panelMaterials.Controls.Add(pc);
                x += pc.Height;
            }
        }

        public void UpdateForm(List<OrderImport> sortingList)
        {
            panelMaterials.Controls.Clear();
            int x = 0;
            for (int i = 0; i < sortingList.Count; i++)
            {
                Panel pc = new Panel(sortingList[i], this);
                pc.Top = x;
                panelMaterials.Controls.Add(pc);
                x += pc.Height;
            }
        }
        private void textBoxNameSearch_TextChanged(object sender, EventArgs e)
        {
            panelMaterials.Controls.Clear();

            list = db.OrderImports.Where(i => i.КодЗаказа.Contains(textBoxNameSearch.Text)).ToList();
            int Y = 0;
            for (int i = 0; i < list.Count; i++)
            {
                Panel pc = new Panel(list[i], this);
                pc.Top = Y;
                panelMaterials.Controls.Add(pc);
                Y += pc.Height + 10;
            }
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortForm();
        }
        public void SortForm()
        {
            panelMaterials.Controls.Clear();

            list = db.OrderImports.ToList();

            if (comboBoxSort.SelectedIndex == 0)
            {
                list = list.OrderBy(i => i.КодЗаказа).ToList();
            }
            else
            {
                list = list.OrderByDescending(i => i.КодЗаказа).ToList();
            }

            int Y = 0;
            foreach (var item in list)
            {
                Panel pc = new Panel(item, this);
                pc.Top = Y;
                panelMaterials.Controls.Add(pc);
                Y += pc.Height + 10;
            }
        }

        private void panelMaterials_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportForm repform = new ReportForm(this);
            MessageBox.Show("выберите тип отчёта");
            repform.Show();
            this.Hide();
        }

        private void closebttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}