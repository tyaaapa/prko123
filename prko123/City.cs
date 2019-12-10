using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prko123
{
    public partial class City : Form
    {
        public City()
        {
            InitializeComponent();
        }

        private void City_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.pRKODataSet.Cities);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            citiesTableAdapter.Update(pRKODataSet.Cities);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            citiesTableAdapter.Update(pRKODataSet.Cities);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CRUSHTEST ct = new CRUSHTEST();
            ct.ShowDialog();
        }
    }
}
