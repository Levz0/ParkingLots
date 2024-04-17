using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using ип.Connect;
using ип.PlacesAdding;
namespace ип
{

    public partial class parkingForm : Form
    {
        static public int selfindex;

        public parkingForm()
        {
            InitializeComponent();
        }

        static public string TranslateColorToEnglish(string color)
        {
            switch (color)
            {
                case "синий": return "Blue";
                case "красный": return "Red";
                case "голубой": return "Lightblue";
                case "зеленый": return "Green";
                case "фиолетовый": return "Purple";
                case "розовый": return "Pink";
                case "желтый": return "Yellow";
                case "серый": return "Gray";
                case "черный": return "Black";
                case "белый": return "White";
                case "бежевый": return "Beige";
                case "коричневый": return "Brown";
                case "бордовый": return "Burgundy";
                case "салатовый": return "Lightgreen";
                case "оранжевый": return "Orange";
                default: return color;
            }
        }

        public void parkingForm_Load(object sender, EventArgs e)
        {

            PlacesInformation.PlacesProcessing();

            List<Place> places = ListIntialize.place(this);

            LabelsInitialize.Initialize(places, this);


            for (int i = 0; i < Math.Min(places.Count, 20); i++)
            {
                int index = i;
                places[i].Label.Click += (s, a) =>
                {
                    cleaning(sender, e);
                    selfindex = (int)places[index].Label.Tag - 1;
                    actwithplaces(sender, e);
                };
            }

        }

        private void selecteditem(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();
            

            ChooseSpot.Visible = false;
            CARSBRAND_lbl.Visible = CARSCOLOR_lbl.Visible = CARSNUMBER_lbl.Visible = FIO_lbl.Visible = DATE_lbl.Visible =
              TYPEOFTS_lbl.Visible = Btn_Change_Data.Visible = Btn_Back.Visible = true;



            for (int i = 0; i < places.Count; i++)
            {
                places[i].Label.BackColor = Color.Transparent;
            }

        }

        public void cleaning(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();
            for (int i = 0; i < places.Count; i++)
            {
                places[i].Label.BackColor = Color.Transparent;
            }

            //Лейблы состояний

            FIO_field.Text = "";
            TYPEOFTS_field.Text = "";
            CARSBRAND_field.Text = "";
            CARSCOLOR_field.Text = "";
            CARSNUMBER_field.Text = "";
            DATE_field.Text = "";

            //Лейблы результатов
            CARSBRAND_lbl.Visible = CARSCOLOR_lbl.Visible = CARSNUMBER_lbl.Visible = FIO_lbl.Visible = DATE_lbl.Visible =
              TYPEOFTS_lbl.Visible = Btn_Change_Data.Visible = Btn_Back.Visible = false;


        }

        public void Labels_fill(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();
            FIO_field.Text = places[selfindex].Fio;
            TYPEOFTS_field.Text = places[selfindex].TypeOfTs;
            CARSBRAND_field.Text = places[selfindex].CarsBrand;
            CARSCOLOR_field.Text = places[selfindex].CarsColor;
            CARSNUMBER_field.Text = places[selfindex].CarsNumber;
            DATE_field.Text = places[selfindex].CarsDate;

        }


        public void emptyplaceclick(object sender, EventArgs e)
        {
            ChooseSpot.Visible = false;

            Btn_add_car.Visible = true;

        }

        public void actwithplaces(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();
            if (places[selfindex].StatusIsTaken is true)
            {
                Btn_add_car.Visible = false;
                selecteditem(sender, e);
                Labels_fill(sender, e);
            }
            else
                emptyplaceclick(sender, e);
            places[selfindex].Label.BackColor = Color.Red;
        }

        private async void Btn_Back_Click(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();
            //Очистка лейблов

            await Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    ChooseSpot.Visible = true;
                    Btn_Back.Visible = Btn_Change_Data.Visible = Btn_add_car.Visible = false;


                    //Поля результатов

                    FIO_field.Text = "";
                    CARSBRAND_field.Text = "";
                    CARSBRAND_field.Text = "";
                    CARSCOLOR_field.Text = "";
                    CARSNUMBER_field.Text = "";
                    DATE_field.Text = "";
                    TYPEOFTS_field.Text = "";

                    //Лейблы результатов

                    FIO_lbl.Visible = false;
                    TYPEOFTS_lbl.Visible = false;
                    CARSBRAND_lbl.Visible = false;
                    CARSCOLOR_lbl.Visible = false;
                    CARSNUMBER_lbl.Visible = false;
                    DATE_lbl.Visible = false;

                    for (int i = 0; i < places.Count; i++)
                    {
                        places[i].Label.BackColor = Color.Transparent;
                    }

                });


                


            });

            

        }

        public void Btn_Change_Data_Click(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();
            DataChangeForm datachangeForm = new DataChangeForm();
            datachangeForm.Txt_fio.Text = places[selfindex].Fio;
            datachangeForm.Txt_cars_type.Text = places[selfindex].CarsBrand;
            datachangeForm.Cmb_changing_color.SelectedItem = places[selfindex].CarsColor;
            datachangeForm.Txt_number.Text = places[selfindex].CarsNumber;
            datachangeForm.Dtp_picker.Text = places[selfindex].CarsDate;
            datachangeForm.Dtp_picker_end.Text = places[selfindex].CarsDateEnd;

            switch (places[selfindex].TypeOfTs)
            {
                case "легковоеТС":
                    datachangeForm.Cmb_typeofts.SelectedIndex = 0; break;
                case "грузовоеТС":
                    datachangeForm.Cmb_typeofts.SelectedIndex = 1; break;
                case "мотоцикл":
                    datachangeForm.Cmb_typeofts.SelectedIndex = 2; break;
                case "ТС с прицепом":
                    datachangeForm.Cmb_typeofts.SelectedIndex = 3; break;
            }



            string connectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source= Database31.accdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            datachangeForm.Btn_MakeFree.Enabled = true;
            datachangeForm.Btn_Add.Text = "Изменить";
            datachangeForm.Dtp_picker.Enabled = false;
            if (datachangeForm.ShowDialog() == DialogResult.OK)
            {
                FIO_field.Text = places[selfindex].Fio = datachangeForm.Txt_fio.Text;
                CARSBRAND_field.Text = places[selfindex].CarsBrand = datachangeForm.Txt_cars_type.Text;
                places[selfindex].CarsColor = datachangeForm.Cmb_changing_color.SelectedItem.ToString();
                CARSCOLOR_field.Text = places[selfindex].CarsColor;
                CARSNUMBER_field.Text = places[selfindex].CarsNumber = datachangeForm.Txt_number.Text;
                CARSBRAND_field.Text = places[selfindex].TypeOfTs = datachangeForm.Cmb_typeofts.SelectedItem.ToString();
                places[selfindex].CarsBrand = datachangeForm.Dtp_picker.Value.ToString();
                DATE_field.Text = datachangeForm.Dtp_picker.Value.ToString();

                dbConnection.Open();

                string query = $"update bd set ФИО='" + datachangeForm.Txt_fio.Text + "' ,Цвет ='" + datachangeForm.Cmb_changing_color.SelectedItem.ToString() + "' ,Марка_Автомобиля='" + datachangeForm.Txt_cars_type.Text +
                   "' ,Номер='" + datachangeForm.Txt_number.Text + "' ,Тип_ТС='" + datachangeForm.Cmb_typeofts.SelectedItem.ToString() + "' ,Дата_начала_бронирования='" + datachangeForm.Dtp_picker.Value.ToString() + "', Дата_конца_бронирования='" + datachangeForm.Dtp_picker_end.Value.ToString() + "' where ID=" + (selfindex);


                parkfill(sender, e);
                OleDbCommand dbcommand = new OleDbCommand(query, dbConnection);

                if (dbcommand.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Ошибка выполнения!");
                }
                else
                    MessageBox.Show("Данные были успешно сохранены!");

                dbConnection.Close();
              
            }
            else if (datachangeForm.DialogResult == DialogResult.No)
            {
                dbConnection.Open();



                string query = $"Update bd SET ФИО='{""} ',Марка_Автомобиля='{""} ',Цвет='{""} ',Номер='{""} ',Тип_ТС='{""} ',Дата_начала_бронирования='{"01.01.2023"} ',Статус='0 'where ID={selfindex}";


                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);




                if (dbCommand.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Не удалось удалить данные!");
                }
                else
                {
                    MessageBox.Show("Данные удалены!");
                    FIO_field.Text = places[selfindex].Fio = "";
                    CARSBRAND_field.Text = places[selfindex].CarsBrand = "";
                    places[selfindex].PictureBox.Image = null;
                    CARSCOLOR_field.Text = places[selfindex].CarsColor = "";
                    CARSNUMBER_field.Text = places[selfindex].CarsNumber = "";
                    places[selfindex].StatusIsTaken = false;
                    Btn_add_car.Visible = false;
                    TYPEOFTS_field.Text = "";
                    DATE_field.Text = "";
                }

                Btn_Back_Click(sender, e);
            }


        }

        public void Btn_add_car_Click(object sender, EventArgs e)
        {
            List<Place> places = PlacesInformation.Store();

            using (DataChangeForm datachangeForm = new DataChangeForm())
            {
                datachangeForm.Btn_Add.Text = "Добавить";
                datachangeForm.Btn_MakeFree.Enabled = false;

                if (datachangeForm.ShowDialog() == DialogResult.OK)
                {
                    FIO_field.Text = places[selfindex].Fio = datachangeForm.Txt_fio.Text;

                    CARSBRAND_field.Text = places[selfindex].CarsBrand = datachangeForm.Txt_cars_type.Text;

                    DataRowView selectedColors = datachangeForm.Cmb_changing_color.SelectedItem as DataRowView;

                    CARSCOLOR_field.Text = places[selfindex].CarsColor = selectedColors["Color"].ToString();

                    CARSNUMBER_field.Text = places[selfindex].CarsNumber = datachangeForm.Txt_number.Text;

                    DataRowView selectedType = datachangeForm.Cmb_typeofts.SelectedItem as DataRowView;

                    TYPEOFTS_field.Text = places[selfindex].TypeOfTs = selectedType["TypeTs"].ToString();

                     DATE_field.Text = places[selfindex].CarsDate = datachangeForm.Dtp_picker.Value.ToString();

                    places[selfindex].CarsDateEnd = datachangeForm.Dtp_picker_end.Value.ToString();

                    

                    string query = "INSERT INTO Lots_Now (Номер_места, ФИО, Марка_Автомобиля, Цвет, Номер, Тип_ТС, Дата_начала_бронирования, Дата_конца_бронирования)" +
                                   " VALUES (@placenumber, @fio, @cars_type, @changing_color, @number, @TypeOfTs, @start_date, @end_date)";

                    using (SqlConnection connection = Database.GetConn())
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.ConnectionString = Database.connectionString;
                        command.Parameters.Add("@placenumber", SqlDbType.VarChar).Value = places[selfindex].PlaceNumber;
                        command.Parameters.Add("@fio", SqlDbType.VarChar).Value = datachangeForm.Txt_fio.Text;
                        command.Parameters.Add("@cars_type", SqlDbType.VarChar).Value = datachangeForm.Txt_cars_type.Text;
                        command.Parameters.Add("@changing_color", SqlDbType.Int).Value = datachangeForm.Cmb_changing_color.SelectedValue;
                        command.Parameters.Add("@number", SqlDbType.VarChar).Value = datachangeForm.Txt_number.Text;
                        command.Parameters.Add("@TypeOfTs", SqlDbType.Int).Value = datachangeForm.Cmb_typeofts.SelectedValue;
                        command.Parameters.Add("@start_date", SqlDbType.DateTime).Value = datachangeForm.Dtp_picker.Value;
                        command.Parameters.Add("@end_date", SqlDbType.DateTime).Value = datachangeForm.Dtp_picker.Value;

                        Btn_Back_Click(sender, e);
                        try
                        {
                            if (Database.GetConn().State != ConnectionState.Open)
                                Database.OpenConnection();

                            if (command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Запись добавлена успешно!");
                                parkfill(sender, e);    
                                selecteditem(sender, e);
                                Labels_fill(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Ошибка добавления записи!");
                                
                            }


                            places[selfindex].StatusIsTaken = true;
                            Btn_add_car.Visible = false;
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Произошла ошибка: {ex.Message}");
                            // Логирование исключения, если необходимо
                        }
                        finally
                        {
                            Database.CloseConnection();
                        }
                    }
                 
                }
            }
           
        }


        public void parkfill(object sender, EventArgs e)

        {
            List<Place> places = PlacesInformation.Store();

           
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            switch (places[selfindex].TypeOfTs)
            {
                case "мотоцикл":
                    places[selfindex].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{TranslateColorToEnglish(places[selfindex].CarsColor)}_moto.jpg"));
                    break;
                case "легковоеТС":
                    places[selfindex].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{TranslateColorToEnglish(places[selfindex].CarsColor)}_car.jpg"));
       
                    break;
                case "грузовоеТС":
                    places[selfindex].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{TranslateColorToEnglish(places[selfindex].CarsColor)}_truck.jpg"));
                    break;
                case "Тc_с_прицепом":
                    places[selfindex].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{TranslateColorToEnglish(places[selfindex].CarsColor)}_car_trailer.jpg"));
                    break;
            }


            for (int i = 0; i < Math.Min(places.Count, 20); i++)
            {
                Control slotControl = this.Controls.Find($"Slot_{i + 1}", true).FirstOrDefault();
                if (slotControl is PictureBox pictureBox)
                {
                    pictureBox.Image = places[i].PictureBox.Image;
                }
            }

        }

   
    }



       



       
        


       





    
}
         