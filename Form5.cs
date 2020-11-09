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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tovarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._bd_KorostylevDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this._bd_KorostylevDataSet.Tovar);

        }
    }
}
