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
    public partial class Abituent : Form
    {
        public Abituent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Abiturient". При необходимости она может быть перемещена или удалена.
            this.abiturientTableAdapter.Fill(this.pRKODataSet.Abiturient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            abiturientTableAdapter.Update(pRKODataSet.Abiturient);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            abiturientTableAdapter.Update(pRKODataSet.Abiturient);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAbiturient f10 = new AddAbiturient();
            f10.ShowDialog();
        }
    }
}
