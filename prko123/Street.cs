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
    public partial class Street : Form
    {
        public Street()
        {
            InitializeComponent();
        }

        private void Street_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Streets". При необходимости она может быть перемещена или удалена.
            this.streetsTableAdapter.Fill(this.pRKODataSet.Streets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            streetsTableAdapter.Update(pRKODataSet.Streets);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            streetsTableAdapter.Update(pRKODataSet.Streets);
        }
    }
}
