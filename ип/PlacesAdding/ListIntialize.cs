using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ип.Connect;

namespace ип.PlacesAdding
{
    public class ListIntialize
    {
        static public List<Place> place(Form form)
        {
            List<Place> places = PlacesInformation.Store();

            try
            {
                string query = "Select Lots_Now.*, Car_colors.Color, Type_Ts.TypeTs from Lots_Now, Car_colors, Type_Ts where Lots_Now.Цвет = Цвет and Цвет = Car_colors.id and Type_Ts.id = Lots_Now.Тип_ТС";

                using (SqlConnection connection = Database.GetConn())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows == false)
                        {
                            MessageBox.Show("Все места свободные", "Предупреждение");
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                string currentPlaceNumber = reader["Номер_места"].ToString().Replace(" ", "");

                                Place currentPlace = places.FirstOrDefault(p => p.PlaceNumber == currentPlaceNumber);

                                if (currentPlace != null)
                                {
                                    currentPlace.StatusIsTaken = true;
                                    currentPlace.Fio = reader["ФИО"].ToString();
                                    currentPlace.CarsBrand = reader["Марка_Автомобиля"].ToString();
                                    currentPlace.CarsColor = reader["Color"].ToString();
                                    currentPlace.CarsNumber = reader["Номер"].ToString();
                                    currentPlace.TypeOfTs = reader["TypeTs"].ToString();
                                    currentPlace.CarsDate = reader["Дата_начала_бронирования"].ToString();
                                    currentPlace.CarsDateEnd = reader["Дата_конца_бронирования"].ToString();
                                }
                            }
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                form.Close();
            }
            finally
            {
                Database.CloseConnection();
            }
             
            return places;
        }
    }
}
