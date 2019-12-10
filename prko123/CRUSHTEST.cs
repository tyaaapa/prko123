using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prko123
{
    public partial class CRUSHTEST : Form
    {
        public CRUSHTEST()
        {
            InitializeComponent();
        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection aConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:/BD/PRKO.mdb");
            aConn.Open();
            OleDbCommand bComm = new OleDbCommand();
            bComm.Connection = aConn;
            bComm.CommandText = "INSERT INTO Cities (ID, City) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
            bComm.ExecuteNonQuery();
            MessageBox.Show("В таблицу добавлена запись");
            aConn.Close();
        }

    }
}
