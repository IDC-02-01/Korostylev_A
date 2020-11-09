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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.DataTable2". При необходимости она может быть перемещена или удалена.
            this.dataTable2TableAdapter.Fill(this._bd_KorostylevDataSet.DataTable2);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form5 main = new Form5();
            main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable2TableAdapter.Fill(this._bd_KorostylevDataSet.DataTable2);
        }
    }
}
