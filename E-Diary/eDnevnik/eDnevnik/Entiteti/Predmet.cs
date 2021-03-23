using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDnevnik.Entiteti
{
    public class Predmet
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Opis { get; set; }
        public virtual int BrojCasova { get; set; }
        public virtual string TipPredmeta { get; set; }
        public virtual int MinBrojUcenika { get; set; }
        public virtual string BlokNastava { get; set; }
        public virtual string SpecijalanKabinet { get; set; }

        public virtual IList<Nastavnik> DrzeNastavnici { get; set; }
        public virtual IList<NastavnikRoditelj> DrzeNastavniciRoditelji { get; set; }

        public virtual IList<ImaOcenu> OceneUcenika { get; set; }
        public virtual IList<Raspored> SeDrzePoRasporedu { get; set; }

        public virtual IList<Godina> NaGodini { get; set; }
        public virtual IList<DrziCas> SeDrzeU { get; set; }

        public Predmet()
        {
            DrzeNastavnici = new List<Nastavnik>();
            DrzeNastavniciRoditelji = new List<NastavnikRoditelj>();
            OceneUcenika = new List<ImaOcenu>();
            SeDrzePoRasporedu = new List<Raspored>();
            NaGodini = new List<Godina>();
            SeDrzeU = new List<DrziCas>();
        }

    }
}
