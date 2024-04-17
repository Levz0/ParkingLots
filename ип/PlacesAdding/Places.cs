using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ип.PlacesAdding
{

    public static class PlacesInformation
    {
        private static List<Place> PlaceList = new List<Place>();

        public static void AddPlace(
            string placeNumber, string typeOfTs, string fio, string carsBrand,
            string carsColor, string carsNumber, bool statusIsTaken,
            string carsDate, string carsDateEnd)
        {
            PlaceList.Add(new Place(
                placeNumber: placeNumber, typeOfTs: typeOfTs, fio: fio,
                carsBrand: carsBrand, carsColor: carsColor, carsNumber: carsNumber,
                statusIsTaken: statusIsTaken, carsDate: carsDate, carsDateEnd: carsDateEnd
            ));
        }

        public static void PlacesProcessing()
        {
            for (int i = 0; i < 20; i++)
            {
                AddPlace(

                    placeNumber: $"A{i + 1}",
                    typeOfTs: null,
                    fio: null,
                    carsBrand: null,
                    carsColor: null,
                    carsNumber: null,
                    statusIsTaken: false,
                    carsDate: null,
                    carsDateEnd: null
                );
            }
        }

        public static List<Place> Store()
        {
            return PlaceList;
        }
    }



    public class Place
    {
        public Place(string placeNumber, string typeOfTs, string fio, string carsBrand, string carsColor,
                string carsNumber, bool statusIsTaken, string carsDate, string carsDateEnd)
        {
            PlaceNumber = placeNumber;
            TypeOfTs = typeOfTs;
            Fio = fio;
            CarsBrand = carsBrand;
            CarsColor = carsColor;
            CarsNumber = carsNumber;
            StatusIsTaken = statusIsTaken;
            CarsDate = carsDate;
            CarsDateEnd = carsDateEnd;

            
            }

        // Переменные

        public string PlaceNumber { get; set; }
        public string TypeOfTs { get; set; }
        public string Fio { get; set; }
        public string CarsBrand { get; set; }
        public string CarsColor { get; set; }
        public string CarsNumber { get; set; }
        public bool StatusIsTaken { get; set; }
        public string CarsDate { get; set; }
        public string CarsDateEnd { get; set; }
        
        // Элементы Controls

        public Label Label { get; set; }
        public PictureBox PictureBox { get; set; }
    }
}
