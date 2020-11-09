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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void magazBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.magazBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._bd_KorostylevDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this._bd_KorostylevDataSet.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.Magaz". При необходимости она может быть перемещена или удалена.
            this.magazTableAdapter.Fill(this._bd_KorostylevDataSet.Magaz);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form3 main = new Form3();
           main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this._bd_KorostylevDataSet.DataTable1);
        }
    }
}
