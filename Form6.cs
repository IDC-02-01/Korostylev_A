using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this._bd_KorostylevDataSet.DataTable3);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form7 main = new Form7();
            main.Show();
        }
    }
}
