using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ип.Connect;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ип
{
    public partial class DataChangeForm : Form
    {
        public DataChangeForm()
        {
            InitializeComponent();
            Dtp_picker.Format = DateTimePickerFormat.Time;
            Dtp_picker_end.Format = DateTimePickerFormat.Time;
            
            
        }

        private void check(object sender, EventArgs e)
        {
            bool IsFilled = !string.IsNullOrEmpty(Txt_fio.Text) &&
                !string.IsNullOrEmpty(Txt_number.Text) &&
                !string.IsNullOrEmpty(Cmb_changing_color.Text) &&
                !string.IsNullOrEmpty(Txt_cars_type.Text) &&
                !string.IsNullOrEmpty(Cmb_typeofts.Text) &&  Dtp_picker.Value < Dtp_picker_end.Value;

            Btn_Add.Enabled = IsFilled;
        }

        
    

        private void Txt_fio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) return;
            else
                e.Handled = true;
           
                
        }

        public void DataChangeForm_Load(object sender, EventArgs e)
        {
            string query = $"Select  id, Color from Car_colors";
            string query1 = $"Select * from Type_Ts";

            using (SqlConnection con = Database.GetConn())
            {

                con.ConnectionString = Database.connectionString;
               
                
                Database.OpenConnection();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);          
                Cmb_changing_color.DisplayMember = "Color";
                Cmb_changing_color.ValueMember = "id";
                Cmb_changing_color.DataSource = table;


                SqlCommand cmd1 = new SqlCommand(query1, Database.GetConn());
                cmd1.CommandType = CommandType.Text;
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                adapter1.Fill(table1);
                Cmb_typeofts.DisplayMember = "TypeTs";
                Cmb_typeofts.ValueMember = "id";
                Cmb_typeofts.DataSource = table1;

            }



            Cmb_changing_color.TextChanged += (s, a) => { check(sender, e); };
            Txt_cars_type.TextChanged += (s, a) => { check(sender, e); };
            Cmb_typeofts.SelectedIndexChanged += (s, a) => { check(sender, e); };

            Dtp_picker.Value.AddHours(0.2);
            Dtp_picker_end.Value.AddHours(0.5);
            this.Dtp_picker_end.ValueChanged += new System.EventHandler(this.Dtp_picker_end_ValueChanged);
            this.Dtp_picker.ValueChanged += new System.EventHandler(this.Dtp_picker_ValueChanged);
            Btn_Add.Enabled = false;

            
       


        }

        private void date_check(object sender, EventArgs e)
        {
            if (Dtp_picker.Value >= Dtp_picker_end.Value)
            {
                MessageBox.Show("Дата начала бронирования должна быть раньше даты конца бронирования!!!");
                Btn_Add.Enabled = false;
            }
            else
                check(sender, e);

        }

        private void Dtp_picker_end_ValueChanged(object sender, EventArgs e)
        {
            date_check(sender,e);  
           

        }

        private void Dtp_picker_ValueChanged(object sender, EventArgs e)
        {
            date_check(sender, e);
        }

        private void Txt_cars_type_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Char.IsLetter(e.KeyChar) && (e.KeyChar >= 'A' && e.KeyChar <= 'z')) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsDigit(e.KeyChar))return;          
            else
                e.Handled = true;


        }

        private void Txt_fio_TextChanged(object sender, EventArgs e)
        {
            check(sender, e);
        }

        private void Txt_cars_type_TextChanged(object sender, EventArgs e)
        {
            check(sender, e);
        }

        private void Txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

        }


    
        
    }
} 
