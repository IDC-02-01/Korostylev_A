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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void magazBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.magazBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this._bd_KorostylevDataSet);
            }
            catch
            {
                MessageBox.Show("Выполнено");
            }
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.Magaz". При необходимости она может быть перемещена или удалена.
            this.magazTableAdapter.Fill(this._bd_KorostylevDataSet.Magaz);

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
