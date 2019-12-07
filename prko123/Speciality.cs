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
    public partial class Speciality : Form
    {
        public Speciality()
        {
            InitializeComponent();
        }

        private void Speciality_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Speciallities". При необходимости она может быть перемещена или удалена.
            this.speciallitiesTableAdapter.Fill(this.pRKODataSet.Speciallities);

        }
    }
}
