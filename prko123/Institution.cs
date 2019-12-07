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
    public partial class Institution : Form
    {
        public Institution()
        {
            InitializeComponent();
        }

        private void Institution_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Institutions". При необходимости она может быть перемещена или удалена.
            this.institutionsTableAdapter.Fill(this.pRKODataSet.Institutions);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            institutionsTableAdapter.Update(pRKODataSet.Institutions);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            institutionsTableAdapter.Update(pRKODataSet.Institutions);
        }
    }
}
