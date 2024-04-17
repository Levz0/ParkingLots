using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ип.Connect;

namespace ип.Vhod
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
          
            textBoxpass.UseSystemPasswordChar = true;
            Pict_open_eye.Visible = false;
            textBoxlog.MaxLength = 50;
            textBoxpass.MaxLength = 50;

        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            if (textBoxlog.Text == "" ||  textBoxpass.Text == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль!", "Ошибка!");
            }
            else
            {

            var loginUser = textBoxlog.Text;
            var passUser = textBoxpass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}'and password_user ='{passUser}'";

            SqlCommand command = new SqlCommand(querystring,  Database.GetConn());
                Database.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Show();

            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            }



        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up sign = new Sign_up();
            sign.ShowDialog();
        }

        private void Pict_close_eye_Click(object sender, EventArgs e)
        {
            textBoxpass.UseSystemPasswordChar = false;
            Pict_open_eye.Visible = true;
            Pict_close_eye.Visible = false;
        }

        private void Pict_open_eye_Click(object sender, EventArgs e)
        {
            textBoxpass.UseSystemPasswordChar = true;
            Pict_open_eye.Visible = false;
            Pict_close_eye.Visible = true;
        }
    }
}
