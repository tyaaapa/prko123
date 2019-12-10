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
    public partial class AddAbiturient : Form
    {
        public AddAbiturient()
        {
            InitializeComponent();
        }

        private void AddAbiturient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Doctypes". При необходимости она может быть перемещена или удалена.
            this.doctypesTableAdapter.Fill(this.pRKODataSet.Doctypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Institutions". При необходимости она может быть перемещена или удалена.
            this.institutionsTableAdapter.Fill(this.pRKODataSet.Institutions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Speciallities". При необходимости она может быть перемещена или удалена.
            this.speciallitiesTableAdapter.Fill(this.pRKODataSet.Speciallities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.pRKODataSet.Faculties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Foreign_language". При необходимости она может быть перемещена или удалена.
            this.foreign_languageTableAdapter.Fill(this.pRKODataSet.Foreign_language);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Streets". При необходимости она может быть перемещена или удалена.
            this.streetsTableAdapter.Fill(this.pRKODataSet.Streets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.pRKODataSet.Cities);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pRKODataSet.Nationalities". При необходимости она может быть перемещена или удалена.
            this.nationalitiesTableAdapter.Fill(this.pRKODataSet.Nationalities);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
