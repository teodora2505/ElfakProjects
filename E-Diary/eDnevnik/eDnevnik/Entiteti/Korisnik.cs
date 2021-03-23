using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eDnevnik.Entiteti;

namespace eDnevnik.Entiteti
{
    public class Korisnik
    {
        public virtual int Id { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual char Pol { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual int FAdministrator { get; set; }
        public virtual int FRoditelj { get; set; }
        public virtual int FNastavnik { get; set; }
        public virtual int FUcenik { get; set; }

        public virtual IList<BrojTelefona> Brojevi { get; set; }

        public Korisnik()
        {
            Brojevi = new List<BrojTelefona>();
        }

    }

    public class Administrator : Korisnik
    {
        public Administrator()
        {
        }
    }

    public class Nastavnik : Korisnik
    {
        public virtual string SSSpreme { get; set; }
        public virtual IList<JeRazredni> MojaOdeljenja { get; set; }
        public virtual IList<Predmet> PredajemPredmete { get; set; }

        public virtual IList<DrziCas> DrziCasove { get; set; }

        public Nastavnik()
        {
            MojaOdeljenja = new List<JeRazredni>();
            PredajemPredmete = new List<Predmet>();
            DrziCasove = new List<DrziCas>();
        }

    }

    public class Roditelj : Korisnik
    {
        public virtual IList<Ucenik> Deca { get; set; }
        public virtual IList<Predstavlja> PredstavljaoOdeljenja { get; set; }

        public virtual IList<Funkcija> FunkcijeKojeJeVrsio { get; set; }

        public Roditelj()
        {
            Deca = new List<Ucenik>();
            PredstavljaoOdeljenja = new List<Predstavlja>();
            FunkcijeKojeJeVrsio = new List<Funkcija>();
        }
    }

    public class Ucenik : Korisnik
    {
        public virtual int BrOpravdanih { get; set; }
        public virtual int BrNeopravdanih { get; set; }
        public virtual int OcenaVladanje { get; set; }

        public virtual Odeljenje PripadaOdeljenju { get; set; }
        public virtual IList<Roditelj> Roditelji { get; set; }
        public virtual IList<NastavnikRoditelj> NastavnikRoditelji { get; set; }

        public virtual IList<ImaOcenu> Ocene { get; set; }

        public Ucenik()
        {
            Roditelji = new List<Roditelj>();
            NastavnikRoditelji = new List<NastavnikRoditelj>();
            Ocene = new List<ImaOcenu>();
        }
    }

    public class NastavnikRoditelj : Korisnik
    {
        public virtual string SSSpreme { get; set; }
        public virtual IList<Ucenik> Deca { get; set; }
        public virtual IList<JeRazredni> MojaOdeljenja { get; set; }
        public virtual IList<Predmet> PredajemPredmete { get; set; }
        public virtual IList<Predstavlja> PredstavljaoOdeljenja { get; set; }
        public virtual IList<Funkcija> FunkcijeKojeJeVrsio { get; set; }
        public virtual IList<DrziCas> DrziCasove { get; set; }

        public NastavnikRoditelj()
        {
            Deca = new List<Ucenik>();
            MojaOdeljenja = new List<JeRazredni>();
            PredajemPredmete = new List<Predmet>();
            PredstavljaoOdeljenja = new List<Predstavlja>();
            FunkcijeKojeJeVrsio = new List<Funkcija>();
            DrziCasove = new List<DrziCas>();
        }
    }

}
