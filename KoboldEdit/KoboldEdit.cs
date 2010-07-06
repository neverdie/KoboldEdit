using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;




namespace KoboldEdit
{
    public partial class KoboldEdit : Form
    {
        public KoboldEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MysqlConnect.ConnectDB();
          
        }

        private void базаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectDB form = new ConnectDB();
            form.ShowDialog(this);
        }

        private void скриптыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptsOpen form = new ScriptsOpen();
            form.ShowDialog(this);
        }

        private void dBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBC form = new DBC();
            form.ShowDialog(this);
        }

        private void оСебеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Myhost = Properties.Settings.Default["host"].ToString();
            String Myport = Properties.Settings.Default["port"].ToString();
            String Myuser = Properties.Settings.Default["user"].ToString();
            String Mypass = Properties.Settings.Default["pass"].ToString() ;



            MessageBox.Show(Myhost+";"+Myport);
          
            

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void общиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
