using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ип.PlacesAdding
{
    public class LabelsInitialize
    {
       

        static public void Initialize(List<Place> places, Form form)
        {
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    places[i].Label = new Label();
                    places[i].Label.BackColor = System.Drawing.Color.Transparent;
                    places[i].Label.Cursor = System.Windows.Forms.Cursors.Hand;
                    places[i].Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    places[i].Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    places[i].Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                    places[i].Label.Name = $"PP_A{i + 1}";
                    places[i].Label.Text = places[i].PlaceNumber;
                    places[i].Label.Tag = i + 1;
                    places[i].Label.Size = new System.Drawing.Size(61, 39);
                    places[i].Label.TabIndex = i + 1;
                    places[i].Label.AutoSize = true;
                    form.Controls.Add(places[i].Label);


                    places[i].PictureBox = new PictureBox();

                    if (places[i].StatusIsTaken == true)
                    {
                        string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                        switch (places[i].TypeOfTs)
                        {
                            case "мотоТС":
                                places[i].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{parkingForm.TranslateColorToEnglish(places[i].CarsColor)}_moto.jpg"));
                                break;

                            case "легковоеТС":
                                places[i].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{parkingForm.TranslateColorToEnglish(places[i].CarsColor)}_car.jpg"));
                                break;

                            case "грузовоеТС":
                                places[i].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{parkingForm.TranslateColorToEnglish(places[i].CarsColor)}_truck.jpg"));
                                break;

                            case "Тс_с_прицепом":
                                places[i].PictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "cars_pack", $"{parkingForm.TranslateColorToEnglish(places[i].CarsColor)}_car_trailer.jpg"));
                                break;
                        }
                    }

                }

                places[0].Label.Location = new System.Drawing.Point(25, 194);
                places[1].Label.Location = new System.Drawing.Point(155, 194);
                places[2].Label.Location = new System.Drawing.Point(277, 194);
                places[3].Label.Location = new System.Drawing.Point(395, 194);
                places[4].Label.Location = new System.Drawing.Point(516, 194);
                places[5].Label.Location = new System.Drawing.Point(637, 194);
                places[6].Label.Location = new System.Drawing.Point(757, 194);
                places[7].Label.Location = new System.Drawing.Point(881, 194);
                places[8].Label.Location = new System.Drawing.Point(992, 194);
                places[9].Label.Location = new System.Drawing.Point(1102, 194);

                places[10].Label.Location = new System.Drawing.Point(25, 476);
                places[11].Label.Location = new System.Drawing.Point(155 - 10, 476);
                places[12].Label.Location = new System.Drawing.Point(277 - 10, 476);
                places[13].Label.Location = new System.Drawing.Point(395 - 10, 476);
                places[14].Label.Location = new System.Drawing.Point(516 - 10, 476);
                places[15].Label.Location = new System.Drawing.Point(637 - 10, 476);
                places[16].Label.Location = new System.Drawing.Point(757 - 10, 476);
                places[17].Label.Location = new System.Drawing.Point(881 - 10, 476);
                places[18].Label.Location = new System.Drawing.Point(992 - 10, 476);
                places[19].Label.Location = new System.Drawing.Point(1102, 476);




                for (int i = 0; i < Math.Min(places.Count, 20); i++)
                {
                    Control slotControl = form.Controls.Find($"Slot_{i + 1}", true).FirstOrDefault();
                    if (slotControl is PictureBox pictureBox)
                    {
                        pictureBox.Image = places[i].PictureBox.Image;
                    }
                }



            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка!");
                form.Close();
            }
        }
    }
}
