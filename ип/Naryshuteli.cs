using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ип.Connect;

namespace ип
{
        public partial class Naryshuteli : Form
        {
      
            private SqlConnection connection;

            public Naryshuteli()
            {
                InitializeComponent();
           

        }

        private void Naryshuteli_Load(object sender, EventArgs e)
            {
                LoadData();
            }

        private void LoadData()
            {
                try
                {
                    connection = new SqlConnection(Database.connectionString);
                    connection.Open();

                    string query = @"
                         SELECT  TypeOfLastViolation as Тип_последнего_нарушения, DateOfLastViolation as Дата_последнего_нарушения,
                         Concat(Trim(MiddleName), ' ', Trim(FirstName), ' ' , Trim(Patronymic)) as ФИО_нарушителя,
                         Car as Марка_машины, NumberOfCar as Номер_машины


                         FROM dbo.Intruders, Users

                         where Users.id = Intruders.id";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    BindingSource bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = dataTable;
                    bindingNavigator1.BindingSource = bindingSource1;

                dataGridView1.Columns["Тип_последнего_нарушения"].HeaderText = "Тип последнего нарушения";
                    dataGridView1.Columns["Дата_последнего_нарушения"].HeaderText = "Дата последнего нарушения";
                    dataGridView1.Columns["ФИО_нарушителя"].HeaderText = "ФИО нарушителя";
                    dataGridView1.Columns["Марка_машины"].HeaderText = "Марка машины";
                    dataGridView1.Columns["Номер_машины"].HeaderText = "Номер машины";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

       
    }
    }



