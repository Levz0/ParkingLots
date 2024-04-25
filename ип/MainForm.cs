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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        
        private void lbl_parking_Click(object sender, EventArgs e)
        {
            parkingForm parkingForm = new parkingForm();
            parkingForm.Show();
            
            
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lb_report_Click(object sender, EventArgs e)
        {
            reportForm reportform = new reportForm();
            reportform.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
