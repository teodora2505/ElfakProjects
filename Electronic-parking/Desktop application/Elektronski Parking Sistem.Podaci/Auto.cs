using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Auto:Vozilo
    {
        

       

        public Auto(string reg, bool invalid, DateTime pocetak, DateTime kraj,int usluga)
        {
            TipVozila = "automobil";
            RegTab = reg;
            DalijeInvalidsko = invalid;
            PocetakParkiranja = pocetak;
            KrajParkiranja = kraj;
            TimeSpan span = KrajParkiranja.Subtract(PocetakParkiranja);
            TrajanjeParkiranja = (span.Seconds) / 360;//1h=10sec,12h=2min,24h=4min,nedeljuDana=28min, mesecDana=120min
            UslugaParkingServisa = usluga;
        }
        
        public Auto()
        {

        }
        
       
        
    }
}
