using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;



namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 main = new Form2();
                main.Show();
            }
            catch
            {
                MessageBox.Show("Выполнено");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 main = new Form4();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 main = new Form6();
            main.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 main = new Form8();
            main.Show();
        }
    }
}
