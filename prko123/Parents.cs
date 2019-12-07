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
    public partial class Parents : Form
    {
        public Parents()
        {
            InitializeComponent();
        }

        private void Parents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.pRKODataSet.Parents);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentsTableAdapter.Update(pRKODataSet.Parents);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            parentsTableAdapter.Update(pRKODataSet.Parents);
        }
    }
}
