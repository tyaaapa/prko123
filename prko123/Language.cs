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
    public partial class Language : Form
    {
        public Language()
        {
            InitializeComponent();
        }

        private void Language_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Foreign_language". При необходимости она может быть перемещена или удалена.
            this.foreign_languageTableAdapter.Fill(this.pRKODataSet.Foreign_language);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreign_languageTableAdapter.Update(pRKODataSet.Foreign_language);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            foreign_languageTableAdapter.Update(pRKODataSet.Foreign_language);
        }
    }
}
