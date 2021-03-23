using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik
{
    public class KorisnikPregled
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public int FAdministrator { get; set; }
        public int FUcenik { get; set; }
        public int FNastavnik { get; set; }
        public int FRoditelj { get; set; }

        public KorisnikPregled(int KorisnikId, string Ime, string Prezime, string KorisnickoIme, string Sifra, int FAdministrator, int FUcenik, int FNastavnik, int FRoditelj)
        {
            this.KorisnikId = KorisnikId;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.KorisnickoIme = KorisnickoIme;
            this.Sifra = Sifra;
            this.FAdministrator = FAdministrator;
            this.FUcenik = FUcenik;
            this.FNastavnik = FNastavnik;
            this.FRoditelj = FRoditelj;
        }

        public KorisnikPregled()
        {

        }
    }

    public class PredmetBasic
    {
        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int BrojCasvoa { get; set; }
        public string TipPredmeta { get; set; }
        public int MinBrUcenika { get; set; }
        public string BlokNastava { get; set; }
        public string SpecijalniKabinet { get; set; }

        public PredmetBasic()
        {

        }

        public PredmetBasic(int PredmetId, string Naziv, string Opis, int BrojCasvoa, string TipPredmeta, int MinBrUcenika, string BlokNastava, string SpecijalniKabinet)
        {
            this.PredmetId = PredmetId;
            this.Naziv = Naziv;
            this.Opis = Opis;
            this.BrojCasvoa = BrojCasvoa;
            this.TipPredmeta = TipPredmeta;
            this.MinBrUcenika = MinBrUcenika;
            this.BlokNastava = BlokNastava;
            this.SpecijalniKabinet = SpecijalniKabinet;
        }

    }

    public class OdeljenjeBasic
    {
        public int OdeljenjeId { get; set; }
        public string Naziv { get; set; }
        public string Smer { get; set; }

        public OdeljenjeBasic()
        {

        }

        public OdeljenjeBasic(int OdeljenjeId, string Naziv, string Smer)
        {
            this.OdeljenjeId = OdeljenjeId;
            this.Naziv = Naziv;
            this.Smer = Smer;
        }
    }

    public class DrziCasPregled
    {
        public int DrziCasid { get; set; }
        public int NastavnikId { get; set; }
        public int PredmetId { get; set; }
        public int OdeljenjeId { get; set; }

        public DrziCasPregled()
        {

        }

        public DrziCasPregled(int DrziCasId, int NastavnikId, int PredmetId, int OdeljenjeId)
        {
            this.DrziCasid = DrziCasId;
            this.NastavnikId = NastavnikId;
            this.PredmetId = PredmetId;
            this.OdeljenjeId = OdeljenjeId;
        }

    }

    public class UcenikBasics
    {
        public int UcenikId;
        public string Ime;
        public string Prezime;
        public int OdeljenjeId;
        public int BrOpravdanih;
        public int BrNeopravdanih;
        public int OcenaVladanje;

        public UcenikBasics()
        {

        }

        public UcenikBasics(int UcenikId, string Ime, string Prezime, int OdeljenjeId, int BrOpravdanih, int BrNeopravdanih)
        {
            this.UcenikId = UcenikId;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.OdeljenjeId = OdeljenjeId;
            this.BrNeopravdanih = BrNeopravdanih;
            this.BrOpravdanih = BrOpravdanih;
        }

    }

    public class ImaOcenuPregled
    {
        public int ImaOcenuId;
        public int UcenikId;
        public int PredmetId;
        public string TipOcene;
        public int Vrednost;
        public string Opis;

        public ImaOcenuPregled()
        {

        }

        public ImaOcenuPregled(int ImaOcenuId, int UcenikId, int PredmetId, string TipOcene, int Vrednost, string Opis)
        {
            this.ImaOcenuId = ImaOcenuId;
            this.UcenikId = UcenikId;
            this.PredmetId = PredmetId;
            this.TipOcene = TipOcene;
            this.Vrednost = Vrednost;
            this.Opis = Opis;
        }
    }

    public class jeRoditeljPregled
    {
        public int jeRoditeljId;
        public int RoditeljId;
        public int UcenikId;

        public jeRoditeljPregled()
        {

        }

        public jeRoditeljPregled(int jeRoditeljId, int RoditeljId, int UcenikId)
        {
            this.jeRoditeljId = jeRoditeljId;
            this.RoditeljId = RoditeljId;
            this.UcenikId = UcenikId;
        }
    }

    public class jeRazredniPregled
    {
        public int jeRazredniId;
        public int NastavnikId;
        public int OdeljenjeId;
        public DateTime datumOd;
        public DateTime? datumDo;

        public jeRazredniPregled()
        {

        }

        public jeRazredniPregled(int jeRazredniId, int NastavnikId, int OdeljenjeId, DateTime datumOd, DateTime? datumDo)
        {
            this.jeRazredniId = jeRazredniId;
            this.NastavnikId = NastavnikId;
            this.OdeljenjeId = OdeljenjeId;
            this.datumDo = datumDo;
            this.datumOd = datumOd;
        }
    }

    public class RasporedPregled
    {
        public int RasporedId;
        public int OdeljenjeId;
        public int PredmetId;
        public string Dan;
        public int Cas;

        public RasporedPregled()
        {

        }

        public RasporedPregled(int RasporedId, int OdeljenjeId, int PredmetId, string Dan, int Cas)
        {
            this.RasporedId = RasporedId;
            this.OdeljenjeId = OdeljenjeId;
            this.PredmetId = PredmetId;
            this.Dan = Dan;
            this.Cas = Cas;
        }
    }

    public class FunkcijaPregled
    {
        public int FunkcijaId;
        public int RoditeljId;
        public DateTime DatumOd;
        public DateTime? DatumDo;
        public string TipFunkcije;

        public FunkcijaPregled()
        {

        }

        public FunkcijaPregled(int FunkcijaId, int RoditeljId, DateTime DatumOd, DateTime? DatumDo, string TipFunkcije)
        {
            this.FunkcijaId = FunkcijaId;
            this.RoditeljId = RoditeljId;
            this.DatumOd = DatumOd;
            this.DatumDo = DatumDo;
            this.TipFunkcije = TipFunkcije;
        }
    }

    public class PredstavljaPregled
    {
        public int PredstavljaId;
        public int OdeljenjeId;
        public int RoditeljId;
        public DateTime DatumOd;
        public DateTime? DatumDo;

        public PredstavljaPregled()
        {

        }

        public PredstavljaPregled(int PredstavljaId, int OdeljenjeId, int RoditeljId, DateTime DatumOd, DateTime? DatumDo)
        {
            this.PredstavljaId = PredstavljaId;
            this.OdeljenjeId = OdeljenjeId;
            this.RoditeljId = RoditeljId;
            this.DatumOd = DatumOd;
            this.DatumDo = DatumDo;
        }

    }

    public class GodinaPregled
    {
        public int GodinaId;
        public int PredmetId;
        public int godina;

        public GodinaPregled()
        {

        }

        public GodinaPregled(int godinaId, int predmetId, int godina)
        {
            this.GodinaId = godinaId;
            this.PredmetId = predmetId;
            this.godina = godina;
        }
    }

    public class BrojTelefonaPregled
    {
        public int Id;
        public int KorisnikId;
        public string broj;

        public BrojTelefonaPregled()
        {

        }

        public BrojTelefonaPregled(int Id, int KorisnikId,string broj)
        {
            this.Id = Id;
            this.KorisnikId = KorisnikId;
            this.broj = broj;
        }
    }

    public class KorisnikExtended
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public char Pol { get; set; }
        public string JMBG { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public int FAdministrator { get; set; }
        public int FUcenik { get; set; }
        public int FNastavnik { get; set; }
        public int FRoditelj { get; set; }
        public string StrucnaSprema { get; set; }
        public int OdeljenjeId { get; set; }
        public int Opravdani { get; set; }
        public int Neopravdani { get; set; }
        public int OcenaVladanje { get; set; }

        public KorisnikExtended(int KorisnikId, string Ime, string Prezime, DateTime DatumRodjenja, string KorisnickoIme, string Sifra, int FAdministrator,
            int FUcenik, int FNastavnik, int FRoditelj,string StrucnaSprema, int OdeljenjeId, int Opravdani, int Neopravdani, int OcenaVladanje)
        {
            this.KorisnikId = KorisnikId;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.DatumRodjenja = DatumRodjenja;
            this.KorisnickoIme = KorisnickoIme;
            this.Sifra = Sifra;
            this.FAdministrator = FAdministrator;
            this.FUcenik = FUcenik;
            this.FNastavnik = FNastavnik;
            this.FRoditelj = FRoditelj;
            this.StrucnaSprema = StrucnaSprema;
            this.OdeljenjeId = OdeljenjeId;
            this.Opravdani = Opravdani;
            this.Neopravdani = Neopravdani;
            this.OcenaVladanje = OcenaVladanje;
        }

        public KorisnikExtended()
        {

        }
    }


}





