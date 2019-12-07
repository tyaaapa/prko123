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
    public partial class Nationality : Form
    {
        public Nationality()
        {
            InitializeComponent();
        }

        private void Nationality_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Nationalities". При необходимости она может быть перемещена или удалена.
            this.nationalitiesTableAdapter.Fill(this.pRKODataSet.Nationalities);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nationalitiesTableAdapter.Update(pRKODataSet.Nationalities);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            nationalitiesTableAdapter.Update(pRKODataSet.Nationalities);
        }
    }
}
