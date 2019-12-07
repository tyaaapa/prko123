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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.pRKODataSet.Faculties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            facultiesTableAdapter.Update(pRKODataSet.Faculties);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            facultiesTableAdapter.Update(pRKODataSet.Faculties);
        }
    }
}
