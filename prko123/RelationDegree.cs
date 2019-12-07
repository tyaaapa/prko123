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
    public partial class RelationDegree : Form
    {
        public RelationDegree()
        {
            InitializeComponent();
        }

        private void RelationDegree_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Relation_degree". При необходимости она может быть перемещена или удалена.
            this.relation_degreeTableAdapter.Fill(this.pRKODataSet.Relation_degree);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            relation_degreeTableAdapter.Update(pRKODataSet.Relation_degree);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            relation_degreeTableAdapter.Update(pRKODataSet.Relation_degree);
        }
    }
}
