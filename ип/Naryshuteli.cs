using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ип
{
    public partial class Naryshuteli : Form
    {
        public Naryshuteli()
        {
            InitializeComponent();
        }

        private void Naryshuteli_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parking_LotDataSet.Intruders". При необходимости она может быть перемещена или удалена.
            this.intrudersTableAdapter.Fill(this.parking_LotDataSet.Intruders);

        }
    }
}
