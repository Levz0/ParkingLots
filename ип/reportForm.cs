using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace ип
{
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();
        }

        private void reportForm_Load(object sender, EventArgs e)
        {
            try
            {


                string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database31.accdb";
                OleDbConnection dbConnection = new OleDbConnection(connectionString);

                dbConnection.Open();
                string query = $"SELECT * FROM report";
                OleDbCommand dbcommand = new OleDbCommand(query, dbConnection);
                OleDbDataReader dbReader = dbcommand.ExecuteReader();
                if (dbReader.HasRows == false)
                {
                    MessageBox.Show("Данных нет!!", "Ошибка!");

                }
                else
                {
                    while (dbReader.Read())
                    {
                        Dgv.Rows.Add(dbReader["ID"],dbReader["Номер_Места"], dbReader["ФИО"], dbReader["Марка_автомобиля"], dbReader["Цвет"], dbReader["Номер"], dbReader["Тип_ТС"], dbReader["Дата_начала_бронирования"], dbReader["Дата_конца_бронирования"]);
                    }
                }
                dbReader.Close();
                dbConnection.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!! База данных не исправна!", "Извещение");
                this.Close();
            }
            
        }

       
    }
}
