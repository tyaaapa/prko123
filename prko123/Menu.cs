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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void абитуриентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abituent f1 = new Abituent();
            f1.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void национальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nationality f4 = new Nationality();
            f4.ShowDialog();
        }

        private void улицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Street f3 = new Street();
            f3.ShowDialog();
        }

        private void городToolStripMenuItem_Click(object sender, EventArgs e)
        {
            City f2 = new City();
            f2.ShowDialog();
        }

        private void иностранныйЯзыкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Language f5 = new Language();
            f5.ShowDialog();
        }

        private void типДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctype f6 = new Doctype();
            f6.ShowDialog();
        }

        private void родителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parents f7 = new Parents();
            f7.ShowDialog();
        }

        private void учебныеЗаведенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Institution f8 = new Institution();
            f8.ShowDialog();
        }

        private void факультетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty f9 = new Faculty();
            f9.ShowDialog();
        }
    }
}
