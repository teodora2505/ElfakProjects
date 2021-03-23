using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Garaza
    {
        private int brParkingMesta = 32;
        private int brSlobodnihMesta = 32;
        private string ime;
        private int redniBrGaraze;
        private List<ParkingMesto> listaParkingMesta;

        public Garaza(string ime, int redniBr)
        {
            Ime = ime;
            RedniBrGaraze = redniBr;
            listaParkingMesta = new List<ParkingMesto>();
            for(int i=1;i<=32;i++)
            {
                listaParkingMesta.Add(new ParkingMesto(i));
            }
        }

        public int BrParkingMesta { get => brParkingMesta; set => brParkingMesta = value; }
        public int BrSlobodnihMesta { get => brSlobodnihMesta; set => brSlobodnihMesta = value; }
        public string Ime { get => ime; set => ime = value; }
        public List<ParkingMesto> ListaParkingMesta { get => listaParkingMesta; set => listaParkingMesta = value; }
        public int RedniBrGaraze { get => redniBrGaraze; set => redniBrGaraze = value; }
    }
}
