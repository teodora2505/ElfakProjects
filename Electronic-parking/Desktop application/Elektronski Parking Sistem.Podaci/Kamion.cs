using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Kamion:Vozilo
    {
        public Kamion(string reg,DateTime pocetak, DateTime kraj,int usluga)
        {
            TipVozila = "kamion";
            RegTab = reg;
            DalijeInvalidsko = false;
            PocetakParkiranja = pocetak;
            KrajParkiranja = kraj;
            TimeSpan span = KrajParkiranja.Subtract(PocetakParkiranja);
            TrajanjeParkiranja = (span.Seconds) / 360;//1h=10sec,12h=2min,24h=4min,nedeljuDana=28min, mesecDana=120min
            UslugaParkingServisa = usluga;
        }

        public Kamion()
        {

        }
    }
}
