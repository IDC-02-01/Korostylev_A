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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_bd_KorostylevDataSet.Nakladnaya". При необходимости она может быть перемещена или удалена.
            this.NakladnayaTableAdapter.Fill(this._bd_KorostylevDataSet.Nakladnaya);

            this.reportViewer1.RefreshReport();
        }
    }
}
