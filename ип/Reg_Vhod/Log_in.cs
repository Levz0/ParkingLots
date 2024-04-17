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

namespace ип.Reg_Vhod
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

        private async void Btn_Enter_Click(object sender, EventArgs e)
        {
            
            await Task.Run(async () => {
                if (textBoxlog.Text == "" || textBoxpass.Text == "")
                {
                    MessageBox.Show("Вы не ввели логин или пароль!", "Ошибка!");
                }
                else
                {

                    var loginUser = textBoxlog.Text;
                    var passUser = textBoxpass.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    string querystring = $"select id, UserLogin, UserPassword from Watch where UserLogin = {loginUser} and UserPassword = {passUser}";

                    SqlCommand command = new SqlCommand(querystring, Database.GetConn());
                    Database.OpenConnection();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Database.CloseConnection();

                        await Task.Run(() => {
                            this.Invoke((MethodInvoker)delegate {
                                MainForm mainForm = new MainForm();
                                this.Hide();
                                mainForm.ShowDialog();
                                this.Close();
                            });
                        });


                    }
                    else
                    {
                        Database.CloseConnection();
                        MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                        

                }
            });
            
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
