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
    public partial class Doctype : Form
    {
        public Doctype()
        {
            InitializeComponent();
        }

        private void Doctype_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Doctypes". При необходимости она может быть перемещена или удалена.
            this.doctypesTableAdapter.Fill(this.pRKODataSet.Doctypes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doctypesTableAdapter.Update(pRKODataSet.Doctypes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            doctypesTableAdapter.Update(pRKODataSet.Doctypes);
        }
    }
}
