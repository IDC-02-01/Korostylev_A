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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void postavshikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postavshikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._bd_KorostylevDataSet);

        }

        private void postavshikBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.postavshikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._bd_KorostylevDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this._bd_KorostylevDataSet.Postavshik);

        }
    }
}
