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
namespace ип.Reg_Vhod
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            Pict_open_eye.Visible = false;
        }

        private async void Btn_Create_Click(object sender, EventArgs e)
        {
            await Task.Run(async() =>
            {
                var login = textBox_login.Text;
                var password = textBox_password.Text;


                if (checkuser())
                {
                    return;
                }

                string query = $"insert into Watch (UserLogin, UserPassword) values('{login}', '{password}')";
                SqlCommand command = new SqlCommand(query, Database.GetConn());

                Database.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                   

                    await Task.Run(() => {
                        this.Invoke((MethodInvoker)delegate {
                            MessageBox.Show("Аккаунт успешно создан!!!!!!!", "Успех!");
                            Log_in log_In = new Log_in();
                            this.Hide();
                            log_In.ShowDialog();
                            this.Close();
                        });
                    });

                }
                else
                {
                    MessageBox.Show("Аккаунт не создан!", "Ошибка!");
                }
                Database.CloseConnection();
           

            });
        }
        private Boolean checkuser()
        {
            string loginUser = textBox_login.Text;

            var passwordUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from Watch where UserLogin = '{loginUser}'";

            SqlCommand command = new SqlCommand(query, Database.GetConn());


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка!");
                return true;
            }
            else
            {
                return false;

            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in login = new Log_in();
            login.ShowDialog();
        }

        private void Pict_close_eye_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            Pict_open_eye.Visible = true;
            Pict_close_eye.Visible = false;
        }

        private void Pict_open_eye_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            Pict_open_eye.Visible = false;
            Pict_close_eye.Visible = true;
        }
    }
}
