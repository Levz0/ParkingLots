using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ип.Connect
{

    static class Database
    {
        static public  string connectionString = $"Data Source=192.168.1.243;Initial Catalog" +
            $"=Parking_Lot;Integrated Security=True";

        static public SqlConnection conn = new SqlConnection(connectionString);

        static public void OpenConnection()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии соединения: {ex.Message}");
                
            }
        }

        static public void CloseConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(($"Ошибка при закрытии соединения: {ex.Message}"));
                // Логирование исключения, если необходимо
            }
        }

        static public SqlConnection GetConn()
        {
            return conn;
        }
    }

}
