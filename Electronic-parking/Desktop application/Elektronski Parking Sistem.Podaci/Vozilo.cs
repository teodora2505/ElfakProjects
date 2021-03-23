using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Vozilo
    {
        private string regTab;
        private string tipVozila;//automobil,autobus,kamion
        private bool dalijeInvalidsko;//false-nije, true-jeste
        private DateTime pocetakParkiranja;
        private DateTime krajParkiranja;
        private int trajanjeParkiranja;//1h=10sec,12h=2min,24h=4min,nedeljuDana=28min, mesecDana=120min
        private int uslugaParkingServisa;//1,12,24,168,720
        private int racun;

        public string RegTab { get => regTab; set => regTab = value; }
        public string TipVozila { get => tipVozila; set => tipVozila = value; }
        public DateTime PocetakParkiranja { get => pocetakParkiranja; set => pocetakParkiranja = value; }
        public DateTime KrajParkiranja { get => krajParkiranja; set => krajParkiranja = value; }
        public int TrajanjeParkiranja { get => trajanjeParkiranja; set => trajanjeParkiranja = value; }
        public bool DalijeInvalidsko { get => dalijeInvalidsko; set => dalijeInvalidsko = value; }
        public int UslugaParkingServisa { get => uslugaParkingServisa; set => uslugaParkingServisa = value; }
        public int Racun { get => racun; set => racun = value; }

        public void produziParkiranje(int brojSati)//1H,12H,24H,168H,720H
        {
            KrajParkiranja = KrajParkiranja.AddHours(brojSati);

            switch (brojSati)
            {
                case 1: TrajanjeParkiranja += 10;
                    if(this.TipVozila=="automobil")
                    {
                        this.Racun += 50;
                    }
                    else if (this.TipVozila == "autobus")
                    {
                        this.Racun += 100;
                    }
                    else if (this.TipVozila == "kamion")
                    {
                        this.Racun += 120;
                    }
                    break;

                case 12: TrajanjeParkiranja += 120;
                    if (this.TipVozila == "automobil")
                    {
                        this.Racun += 200;
                    }
                    else if (this.TipVozila == "autobus")
                    {
                        this.Racun += 300;
                    }
                    else if (this.TipVozila == "kamion")
                    {
                        this.Racun += 350;
                    }
                    break;

                case 24: TrajanjeParkiranja += 240;
                    if (this.TipVozila == "automobil")
                    {
                        this.Racun += 350;
                    }
                    else if (this.TipVozila == "autobus")
                    {
                        this.Racun += 500;
                    }
                    else if (this.TipVozila == "kamion")
                    {
                        this.Racun += 550;
                    }
                    break;

                case 168: TrajanjeParkiranja += 1680;
                    if (this.TipVozila == "automobil")
                    {
                        this.Racun += 700;
                    }
                    else if (this.TipVozila == "autobus")
                    {
                        this.Racun += 1000;
                    }
                    else if (this.TipVozila == "kamion")
                    {
                        this.Racun += 1100;
                    }
                    break;

                case 720: TrajanjeParkiranja += 7200;
                    if (this.TipVozila == "automobil")
                    {
                        this.Racun += 1400;
                    }
                    else if (this.TipVozila == "autobus")
                    {
                        this.Racun += 1800;
                    }
                    else if (this.TipVozila == "kamion")
                    {
                        this.Racun += 1900;
                    }
                    break;
            }
        }
    }
}
