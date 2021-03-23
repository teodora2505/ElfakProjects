using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class ParkingMesto
    {
        private int broj;
        private Vozilo vozilo;
        private int brGaraze;

        public ParkingMesto(int br, Vozilo v)
        {
            Broj = br;
            Vozilo = v;
        }

        public ParkingMesto(int br)
        {
            Broj = br;
            vozilo = new Vozilo();
        }

        public ParkingMesto()
        {
            vozilo = new Vozilo();
        }

        public bool dalijeInvalidsko()
        {
            bool pom;
            switch(this.Broj)
            {
                case 21: pom = true; break;
                case 22: pom = true; break;
                case 23: pom = true; break;
                case 24: pom = true; break;
                default: pom = false; break;
            }
            return pom;
        }

        public int Broj { get => broj; set => broj = value; }
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
        public int BrGaraze { get => brGaraze; set => brGaraze = value; }
    }
}
