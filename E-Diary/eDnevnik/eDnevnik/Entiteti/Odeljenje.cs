using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class Odeljenje
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Smer { get; set; }

        public virtual IList<Ucenik> Ucenici { get; set; }
        public virtual IList<JeRazredni> RazredneStaresine { get; set; }
        public virtual IList<Predstavlja> Predstavnici { get; set; }
        public virtual IList<Raspored> RasporedCasova { get; set; }
        public virtual IList<DrziCas> PredajuPredmete { get; set; }

        public Odeljenje()
        {
            Ucenici = new List<Ucenik>();
            RazredneStaresine = new List<JeRazredni>();
            Predstavnici = new List<Predstavlja>();
            RasporedCasova = new List<Raspored>();
            PredajuPredmete = new List<DrziCas>();
        }
    }
}
