using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using eDnevnik.Entiteti;
using System.Globalization;

namespace eDnevnik
{
    public class DTOManager
    {
        public static KorisnikPregled GetKorisnikPregled(string korisnicko_ime, string sifra)
        {
            KorisnikPregled korisnik = new KorisnikPregled();
            korisnik = null;

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Korisnik> korisnici = from k in s.Query<Korisnik>()
                                                  select k;

                foreach (Korisnik k in korisnici)
                {
                    if (k.Username == korisnicko_ime && k.Password == sifra)
                        korisnik = new KorisnikPregled(k.Id, k.Ime, k.Prezime, k.Username, k.Password, k.FAdministrator, k.FUcenik, k.FNastavnik, k.FRoditelj);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return korisnik;
        }

        public static KorisnikExtended GetKorisnikPregledInfos(int KorisnikId)
        {
            KorisnikExtended k = new KorisnikExtended();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(KorisnikId);

                if (korisnik.FUcenik == 1)
                {
                    Ucenik ucenik = s.Load<Ucenik>(KorisnikId);
                    Odeljenje o = s.Load<Odeljenje>(ucenik.PripadaOdeljenju.Id);

                    k.KorisnikId = ucenik.Id;
                    k.Ime = ucenik.Ime;
                    k.Prezime = ucenik.Prezime;
                    k.DatumRodjenja = DateTime.Parse(ucenik.DatumRodjenja.ToShortDateString());
                    k.JMBG = ucenik.JMBG;
                    k.Pol = ucenik.Pol;
                    k.KorisnickoIme = ucenik.Username;
                    k.Sifra = ucenik.Password;
                    k.FAdministrator = ucenik.FAdministrator;
                    k.FNastavnik = ucenik.FNastavnik;
                    k.FRoditelj = ucenik.FRoditelj;
                    k.FUcenik = ucenik.FUcenik;
                    k.OdeljenjeId = o.Id;
                    k.Opravdani = ucenik.BrOpravdanih;
                    k.Neopravdani = ucenik.BrNeopravdanih;
                    k.OcenaVladanje = ucenik.OcenaVladanje;

                }
                else if (korisnik.FNastavnik == 1)
                {
                    Nastavnik nastavnik = s.Load<Nastavnik>(KorisnikId);

                    k.KorisnikId = nastavnik.Id;
                    k.Ime = nastavnik.Ime;
                    k.Prezime = nastavnik.Prezime;
                    k.DatumRodjenja = DateTime.Parse(nastavnik.DatumRodjenja.ToShortDateString());
                    k.JMBG = nastavnik.JMBG;
                    k.Pol = nastavnik.Pol;
                    k.KorisnickoIme = nastavnik.Username;
                    k.Sifra = nastavnik.Password;
                    k.FAdministrator = nastavnik.FAdministrator;
                    k.FNastavnik = nastavnik.FNastavnik;
                    k.FRoditelj = nastavnik.FRoditelj;
                    k.FUcenik = nastavnik.FUcenik;
                    k.StrucnaSprema = nastavnik.SSSpreme;
                }
                else
                {
                    k.KorisnikId = korisnik.Id;
                    k.Ime = korisnik.Ime;
                    k.Prezime = korisnik.Prezime;
                    k.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    k.JMBG = korisnik.JMBG;
                    k.Pol = korisnik.Pol;
                    k.KorisnickoIme = korisnik.Username;
                    k.Sifra = korisnik.Password;
                    k.FAdministrator = korisnik.FAdministrator;
                    k.FNastavnik = korisnik.FNastavnik;
                    k.FRoditelj = korisnik.FRoditelj;
                    k.FUcenik = korisnik.FUcenik;
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return k;
        }

        public static OdeljenjeBasic GetOdeljenje(int OdeljenjeId)
        {
            OdeljenjeBasic odeljenje = new OdeljenjeBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(OdeljenjeId);

                odeljenje = new OdeljenjeBasic(o.Id, o.Naziv, o.Smer);

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odeljenje;
        }

        public static OdeljenjeBasic GetOdeljenjeNaziv(string nazivOdeljenja)
        {
            OdeljenjeBasic odelj = new OdeljenjeBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Odeljenje> odeljenja = from k in s.Query<Odeljenje>()
                                                   select k;

                foreach (Odeljenje k in odeljenja)
                {
                    if (k.Naziv == nazivOdeljenja)
                        odelj = new OdeljenjeBasic(k.Id, k.Naziv, k.Smer);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return odelj;
        }

        public static List<PredmetBasic> GetPredmetiInfos(int NastavnikId)
        {
            List<PredmetBasic> NastavnikoviPredmeti = new List<PredmetBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Nastavnik n = s.Load<Nastavnik>(NastavnikId);

                foreach (Predmet p in n.PredajemPredmete)
                {

                    NastavnikoviPredmeti.Add(new PredmetBasic(p.Id, p.Naziv, p.Opis, p.BrojCasova, p.TipPredmeta, p.MinBrojUcenika, p.BlokNastava, p.SpecijalanKabinet));
                }

                s.Close();
            }
            catch (Exception e) { }

            return NastavnikoviPredmeti;
        }

        public static List<KorisnikExtended> GetKorisnici()
        {
            List<KorisnikExtended> listaKorisnika = new List<KorisnikExtended>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Korisnik> korisnici = from k in s.Query<Korisnik>()
                                                  select k;

                foreach (Korisnik p in korisnici)
                {
                    KorisnikExtended kk = new KorisnikExtended(p.Id, p.Ime, p.Prezime, p.DatumRodjenja, "", "", p.FAdministrator, p.FUcenik, p.FNastavnik, p.FRoditelj, "", -1, -1, -1, -1);
                    kk.Pol = p.Pol;
                    kk.JMBG = p.JMBG;
                    listaKorisnika.Add(kk);
                }

                s.Close();
            }
            catch (Exception e) { }

            return listaKorisnika;
        }

        public static List<OdeljenjeBasic> GetOdeljenjeInfos(int NastavnikId)
        {
            List<OdeljenjeBasic> NastavnikovaOdeljena = new List<OdeljenjeBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                Nastavnik n = s.Load<Nastavnik>(NastavnikId);
                foreach (DrziCas drziCas in n.DrziCasove)
                {
                    Odeljenje o = s.Load<Odeljenje>(drziCas.Id_Odeljenja.Id);
                    NastavnikovaOdeljena.Add(new OdeljenjeBasic(o.Id, o.Naziv, o.Smer));
                }

                s.Close();
            }
            catch (Exception e) { }

            return NastavnikovaOdeljena;
        }

        public static List<PredmetBasic> GetNastavnikOdeljenjuDrziPredmet(int NastavnikId, int OdeljenjeId)
        {
            List<PredmetBasic> predmeti = new List<PredmetBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DrziCas> drziCas = from p in s.Query<DrziCas>()
                                               where (p.Id_Nastavnika.Id == NastavnikId && p.Id_Odeljenja.Id == OdeljenjeId)
                                               select p;

                foreach (DrziCas d in drziCas)
                {
                    predmeti.Add(new PredmetBasic(d.Id_Predmeta.Id, d.Id_Predmeta.Naziv, d.Id_Predmeta.Opis, d.Id_Predmeta.BrojCasova,
                                                  d.Id_Predmeta.TipPredmeta, d.Id_Predmeta.MinBrojUcenika, d.Id_Predmeta.BlokNastava, d.Id_Predmeta.SpecijalanKabinet));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predmeti;
        }

        public static List<PredmetBasic> GetOdeljenskiPredmeti(int OdeljenjeId)
        {
            List<PredmetBasic> predmeti = new List<PredmetBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DrziCas> drziCas = from p in s.Query<DrziCas>()
                                               where (p.Id_Odeljenja.Id == OdeljenjeId)
                                               select p;

                foreach (DrziCas d in drziCas)
                {
                    predmeti.Add(new PredmetBasic(d.Id_Predmeta.Id, d.Id_Predmeta.Naziv, d.Id_Predmeta.Opis, d.Id_Predmeta.BrojCasova,
                                                  d.Id_Predmeta.TipPredmeta, d.Id_Predmeta.MinBrojUcenika, d.Id_Predmeta.BlokNastava, d.Id_Predmeta.SpecijalanKabinet));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predmeti;
        }

        public static List<ImaOcenuPregled> GetOcenaPredmetInfo(int UcenikId, int PredmetId)
        {
            List<ImaOcenuPregled> imaOcenu = new List<ImaOcenuPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ImaOcenu> imaO = from i in s.Query<ImaOcenu>()
                                             where (i.Id_Ucenika.Id == UcenikId && i.Id_Predmeta.Id == PredmetId)
                                             select i;

                foreach (ImaOcenu i in imaO)
                {
                    imaOcenu.Add(new ImaOcenuPregled(i.Id, i.Id_Ucenika.Id, i.Id_Predmeta.Id, i.TipOcene, i.Vrednost, i.Opis));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return imaOcenu;
        }

        public static List<ImaOcenuPregled> GetUcenikoveOcene(int UcenikId)
        {
            List<ImaOcenuPregled> imaOcenu = new List<ImaOcenuPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ImaOcenu> imaO = from i in s.Query<ImaOcenu>()
                                             where (i.Id_Ucenika.Id == UcenikId)
                                             select i;

                foreach (ImaOcenu i in imaO)
                {
                    imaOcenu.Add(new ImaOcenuPregled(i.Id, i.Id_Ucenika.Id, i.Id_Predmeta.Id, i.TipOcene, i.Vrednost, i.Opis));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return imaOcenu;
        }

        public static List<UcenikBasics> GetUceniciOdeljenja(int OdeljenjeId)
        {
            List<UcenikBasics> ucenici = new List<UcenikBasics>();

            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje od = s.Load<Odeljenje>(OdeljenjeId);

                /*
                IEnumerable<Ucenik> listaUcenika = from u in s.Query<Ucenik>()
                                               where (u.PripadaOdeljenju.Id==OdeljenjeId)
                                               select u;
                                               */
                foreach (Ucenik u in od.Ucenici)
                {
                    ucenici.Add(new UcenikBasics(u.Id, u.Ime, u.Prezime, u.PripadaOdeljenju.Id, u.BrOpravdanih, u.BrNeopravdanih));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ucenici;
        }

        public static List<RasporedPregled> GetRasporedOdeljenjaInfos(int OdeljenjeId)
        {
            List<RasporedPregled> rasporedCasova = new List<RasporedPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Raspored> raspored = from u in s.Query<Raspored>()
                                                 where (u.Id_Odeljenja.Id == OdeljenjeId)
                                                 select u;

                foreach (Raspored r in raspored)
                {
                    rasporedCasova.Add(new RasporedPregled(r.Id, r.Id_Odeljenja.Id, r.Id_Predmeta.Id, r.Dan, r.Cas));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return rasporedCasova;
        }

        public static void SaveRaspored(RasporedPregled raspored)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(raspored.PredmetId);
                Odeljenje o = s.Load<Odeljenje>(raspored.OdeljenjeId);

                Raspored rs = new Raspored();
                rs.Id_Odeljenja = o;
                rs.Id_Predmeta = p;
                rs.Dan = raspored.Dan;
                rs.Cas = raspored.Cas;

                s.SaveOrUpdate(rs);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void SaveImaOcenu(int UcenikId, int PredmetId, string tipOcene, string ocena)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                ImaOcenu imaocenu = new ImaOcenu();


                Ucenik u = s.Load<Ucenik>(UcenikId);
                Predmet p = s.Load<Predmet>(PredmetId);



                imaocenu.Id_Ucenika = u;
                imaocenu.Id_Predmeta = p;
                imaocenu.TipOcene = tipOcene;
                if (tipOcene == "BROJCANA")
                {
                    imaocenu.Vrednost = Convert.ToInt32(ocena);
                    imaocenu.Opis = null;
                }
                else if (tipOcene == "OPISNA")
                {
                    imaocenu.Opis = ocena;
                }

                s.SaveOrUpdate(imaocenu);

                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void UpdateImaOcenu(int ImaOcenuId, string tipOcene, string ocena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ImaOcenu ima = s.Load<ImaOcenu>(ImaOcenuId);
                if (tipOcene == "BROJCANA")
                    ima.Vrednost = Convert.ToInt32(ocena);
                else if (tipOcene == "OPISNA")
                    ima.Opis = ocena;

                s.Update(ima);
                s.Flush();
                s.Close();


            }
            catch (Exception e) { }
        }

        public static void UpdateUcenikPovecajNeopravdane(int ucenikId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(ucenikId);
                u.BrNeopravdanih = u.BrNeopravdanih + 1;

                s.Update(u);
                s.Flush();
                s.Close();


            }
            catch (Exception e) { }
        }

        public static void UpdateUcenikSmanjiNeopravdane(int ucenikId, int broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(ucenikId);
                u.BrNeopravdanih = u.BrNeopravdanih - broj;

                s.Update(u);
                s.Flush();
                s.Close();


            }
            catch (Exception e) { }
        }

        public static void UpdateUcenikPovecajOpravdane(int ucenikId, int broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(ucenikId);
                u.BrOpravdanih = u.BrOpravdanih + broj;

                s.Update(u);
                s.Flush();
                s.Close();


            }
            catch (Exception e) { }
        }

        public static void brisiImaOcenu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ImaOcenu io = s.Load<ImaOcenu>(id);
                s.Delete(io);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { }
        }

        public static UcenikBasics GetUcenikInfos(int UcenikId)
        {
            UcenikBasics ucenik = new UcenikBasics();
            try
            {
                ISession s = DataLayer.GetSession();
                Ucenik ucenik1 = s.Load<Ucenik>(UcenikId);
                ucenik.UcenikId = ucenik1.Id;
                ucenik.Ime = ucenik1.Ime;
                ucenik.Prezime = ucenik1.Prezime;
                ucenik.OdeljenjeId = ucenik1.PripadaOdeljenju.Id;
                ucenik.BrOpravdanih = ucenik1.BrOpravdanih;
                ucenik.BrNeopravdanih = ucenik1.BrNeopravdanih;
                ucenik.OcenaVladanje = ucenik1.OcenaVladanje;

                s.Close();

            }
            catch (Exception e)
            {

            }
            return ucenik;
        }

        public static PredmetBasic GetPredmetBasicInfo(int PredmetId)
        {
            PredmetBasic pred = new PredmetBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet predmet = s.Load<Predmet>(PredmetId);
                pred.PredmetId = predmet.Id;
                pred.Naziv = predmet.Naziv;
                pred.Opis = predmet.Opis;
                pred.BrojCasvoa = predmet.BrojCasova;
                pred.TipPredmeta = predmet.TipPredmeta;
                pred.MinBrUcenika = predmet.MinBrojUcenika;
                pred.BlokNastava = predmet.BlokNastava;
                pred.SpecijalniKabinet = predmet.SpecijalanKabinet;

                s.Close();

            }
            catch (Exception e)
            {

            }
            return pred;
        }

        public static List<UcenikBasics> GetRoditeljevaDecaInfos(int RoditeljId)
        {
            List<UcenikBasics> roditeljevaDeca = new List<UcenikBasics>();

            try
            {
                ISession s = DataLayer.GetSession();

                Roditelj roditelj = s.Load<Roditelj>(RoditeljId);

                foreach (Ucenik ucenik in roditelj.Deca)
                {
                    UcenikBasics u = new UcenikBasics(ucenik.Id, ucenik.Ime, ucenik.Prezime, ucenik.PripadaOdeljenju.Id, ucenik.BrOpravdanih, ucenik.BrNeopravdanih);
                    roditeljevaDeca.Add(u);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return roditeljevaDeca;
        }

        public static FunkcijaPregled GetFunkcijaInfos(int RoditeljId)
        {
            FunkcijaPregled funkcija = new FunkcijaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Funkcija> fje = from k in s.Query<Funkcija>()
                                            select k;

                foreach (Funkcija f in fje)
                {
                    if (f.VrsiFunkciju.Id == RoditeljId)
                    {
                        funkcija.RoditeljId = f.VrsiFunkciju.Id;
                        funkcija.TipFunkcije = f.Tip;
                        funkcija.DatumDo = f.DatumDo;
                        funkcija.DatumOd = f.DatumOd;
                        funkcija.FunkcijaId = f.Id;
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return funkcija;
        }

        public static PredstavljaPregled GetPredstavljaInfos(int RoditeljId)
        {
            PredstavljaPregled predstavlja = new PredstavljaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavlja> pred = from k in s.Query<Predstavlja>()
                                                select k;

                foreach (Predstavlja p in pred)
                {
                    if (p.Id_Roditelja.Id == RoditeljId)
                    {
                        predstavlja.PredstavljaId = p.Id;
                        predstavlja.RoditeljId = p.Id_Roditelja.Id;
                        predstavlja.OdeljenjeId = p.Id_Odeljenja.Id;
                        predstavlja.DatumDo = p.DatumDo;
                        predstavlja.DatumOd = p.DatumOd;
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return predstavlja;
        }

        public static bool DaLiJeRazredni(int id)
        {
            bool fleg = false;

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<JeRazredni> jeRazredni = from k in s.Query<JeRazredni>()
                                                     select k;

                foreach (JeRazredni jr in jeRazredni)
                {
                    if (jr.Id_Nastavnika.Id == id && jr.DatumDo == null)
                    {
                        fleg = true;
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return fleg;
        }

        public static OdeljenjeBasic OdeljenjeRazrednogStaresineInfos(int RazredniID)
        {
            OdeljenjeBasic mojeOdeljenje = new OdeljenjeBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<JeRazredni> jeRazredni = from k in s.Query<JeRazredni>()
                                                     select k;


                foreach (JeRazredni jr in jeRazredni)
                {
                    if (jr.Id_Nastavnika.Id == RazredniID && jr.DatumDo == null)
                    {
                        mojeOdeljenje = DTOManager.GetOdeljenje(jr.Id_Odeljenja.Id);
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return mojeOdeljenje;
        }

        public static void SaveUcenik(KorisnikExtended korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik k = new Ucenik();

                Odeljenje odeljenje = s.Load<Odeljenje>(korisnik.OdeljenjeId);
                k.Ime = korisnik.Ime;
                k.Prezime = korisnik.Prezime;
                k.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                k.JMBG = korisnik.JMBG;
                k.Pol = korisnik.Pol;
                k.Username = korisnik.KorisnickoIme;
                k.Password = korisnik.Sifra;
                k.FAdministrator = korisnik.FAdministrator;
                k.FNastavnik = korisnik.FNastavnik;
                k.FRoditelj = korisnik.FRoditelj;
                k.FUcenik = korisnik.FUcenik;
                k.PripadaOdeljenju = odeljenje;
                k.BrOpravdanih = korisnik.Opravdani;
                k.BrNeopravdanih = korisnik.Neopravdani;
                k.OcenaVladanje = korisnik.OcenaVladanje;

                odeljenje.Ucenici.Add(k);

                s.SaveOrUpdate(k);

                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }



        public static void UpdateUcenik(int UcenikId, KorisnikExtended korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik k = s.Load<Ucenik>(UcenikId);

                k.Ime = korisnik.Ime;
                k.Prezime = korisnik.Prezime;
                k.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                k.JMBG = korisnik.JMBG;
                k.Pol = korisnik.Pol;
                k.Username = korisnik.KorisnickoIme;
                k.Password = korisnik.Sifra;
                k.FAdministrator = korisnik.FAdministrator;
                k.FNastavnik = korisnik.FNastavnik;
                k.FRoditelj = korisnik.FRoditelj;
                k.FUcenik = korisnik.FUcenik;
                k.BrOpravdanih = korisnik.Opravdani;
                k.BrNeopravdanih = korisnik.Neopravdani;
                k.OcenaVladanje = korisnik.OcenaVladanje;
                s.Update(k);
                s.Flush();
                s.Close();


            }
            catch (Exception e) { }
        }

        public static void brisiUcenika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ucenik io = s.Load<Ucenik>(id);

                s.Delete(io);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { }
        }

        public static PredmetBasic GetPredmetNaziv(string nazivPredmeta)
        {
            PredmetBasic pred = new PredmetBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> predmeti = from k in s.Query<Predmet>()
                                                select k;

                foreach (Predmet k in predmeti)
                {
                    if (k.Naziv == nazivPredmeta)
                        pred = new PredmetBasic(k.Id, k.Naziv, k.Opis, k.BrojCasova, k.TipPredmeta, k.MinBrojUcenika, k.BlokNastava, k.SpecijalanKabinet);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return pred;
        }

        public static RasporedPregled GetRasporedDanCasOdeljenje(int cas, string dan, int OdeljenjeId)
        {
            RasporedPregled ras = new RasporedPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Raspored> rasporedi = from k in s.Query<Raspored>()
                                                  where (k.Cas == cas && k.Dan == dan && k.Id_Odeljenja.Id == OdeljenjeId)
                                                  select k;

                foreach (Raspored k in rasporedi)
                {
                    if (k.Cas == cas && k.Dan == dan && k.Id_Odeljenja.Id == OdeljenjeId)
                        ras = new RasporedPregled(k.Id, k.Id_Odeljenja.Id, k.Id_Predmeta.Id, k.Dan, k.Cas);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ras;
        }

        public static void brisiRaspored(int RasporedId)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Raspored io = s.Load<Raspored>(RasporedId);

                s.Delete(io);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { }
        }

        public static void UpdateRaspored(int RasporedId, RasporedPregled raspored)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Raspored k = s.Load<Raspored>(RasporedId);
                Odeljenje o = s.Load<Odeljenje>(raspored.OdeljenjeId);
                Predmet p = s.Load<Predmet>(raspored.PredmetId);

                k.Dan = raspored.Dan;
                k.Id_Odeljenja = o;
                k.Id_Predmeta = p;
                k.Cas = raspored.Cas;


                s.Update(k);
                s.Flush();
                s.Close();

            }
            catch (Exception e) { }
        }

        public static void SaveKorisnik(KorisnikExtended korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (korisnik.FUcenik == 1)
                {
                    Ucenik u = new Ucenik();
                    Odeljenje o = s.Load<Odeljenje>(korisnik.OdeljenjeId);

                    u.Ime = korisnik.Ime;
                    u.Prezime = korisnik.Prezime;
                    u.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    u.JMBG = korisnik.JMBG;
                    u.Pol = korisnik.Pol;
                    u.Username = korisnik.KorisnickoIme;
                    u.Password = korisnik.Sifra;
                    u.FAdministrator = korisnik.FAdministrator;
                    u.FNastavnik = korisnik.FNastavnik;
                    u.FRoditelj = korisnik.FRoditelj;
                    u.FUcenik = korisnik.FUcenik;
                    u.PripadaOdeljenju = o;
                    u.BrOpravdanih = korisnik.Opravdani;
                    u.BrNeopravdanih = korisnik.Neopravdani;
                    u.OcenaVladanje = korisnik.OcenaVladanje;

                    o.Ucenici.Add(u);

                    s.SaveOrUpdate(u);

                    s.Flush();
                    s.Close();
                }
                else if (korisnik.FNastavnik == 1)
                {
                    Nastavnik n = new Nastavnik();

                    n.Ime = korisnik.Ime;
                    n.Prezime = korisnik.Prezime;
                    n.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    n.JMBG = korisnik.JMBG;
                    n.Pol = korisnik.Pol;
                    n.Username = korisnik.KorisnickoIme;
                    n.Password = korisnik.Sifra;
                    n.FAdministrator = korisnik.FAdministrator;
                    n.FNastavnik = korisnik.FNastavnik;
                    n.FRoditelj = korisnik.FRoditelj;
                    n.FUcenik = korisnik.FUcenik;
                    n.SSSpreme = korisnik.StrucnaSprema;

                    s.SaveOrUpdate(n);

                    s.Flush();
                    s.Close();

                }
                else
                {
                    Korisnik k = new Korisnik();
                    k.Ime = korisnik.Ime;
                    k.Prezime = korisnik.Prezime;
                    k.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    k.JMBG = korisnik.JMBG;
                    k.Pol = korisnik.Pol;
                    k.Username = korisnik.KorisnickoIme;
                    k.Password = korisnik.Sifra;
                    k.FAdministrator = korisnik.FAdministrator;
                    k.FNastavnik = korisnik.FNastavnik;
                    k.FRoditelj = korisnik.FRoditelj;
                    k.FUcenik = korisnik.FUcenik;

                    s.SaveOrUpdate(k);

                    s.Flush();
                    s.Close();
                }

            }
            catch (Exception ec)
            {

            }
        }


        public static void UpdateKorisnik(int KorisnikId, KorisnikExtended korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (korisnik.FUcenik == 1)
                {
                    Ucenik u = s.Load<Ucenik>(KorisnikId);
                    Odeljenje o = s.Load<Odeljenje>(korisnik.OdeljenjeId);

                    u.Ime = korisnik.Ime;
                    u.Prezime = korisnik.Prezime;
                    u.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    u.JMBG = korisnik.JMBG;
                    u.Pol = korisnik.Pol;
                    u.Username = korisnik.KorisnickoIme;
                    u.Password = korisnik.Sifra;
                    u.FAdministrator = korisnik.FAdministrator;
                    u.FNastavnik = korisnik.FNastavnik;
                    u.FRoditelj = korisnik.FRoditelj;
                    u.FUcenik = korisnik.FUcenik;
                    u.PripadaOdeljenju = o;
                    u.BrOpravdanih = korisnik.Opravdani;
                    u.BrNeopravdanih = korisnik.Neopravdani;
                    u.OcenaVladanje = korisnik.OcenaVladanje;

                    o.Ucenici.Add(u);

                    s.Update(u);

                    s.Flush();
                    s.Close();
                }
                else if (korisnik.FNastavnik == 1)
                {
                    Nastavnik n = s.Load<Nastavnik>(KorisnikId);

                    n.Ime = korisnik.Ime;
                    n.Prezime = korisnik.Prezime;
                    n.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    n.JMBG = korisnik.JMBG;
                    n.Pol = korisnik.Pol;
                    n.Username = korisnik.KorisnickoIme;
                    n.Password = korisnik.Sifra;
                    n.FAdministrator = korisnik.FAdministrator;
                    n.FNastavnik = korisnik.FNastavnik;
                    n.FRoditelj = korisnik.FRoditelj;
                    n.FUcenik = korisnik.FUcenik;
                    n.SSSpreme = korisnik.StrucnaSprema;

                    s.Update(n);

                    s.Flush();
                    s.Close();

                }
                else
                {
                    Korisnik k = s.Load<Korisnik>(KorisnikId);

                    k.Ime = korisnik.Ime;
                    k.Prezime = korisnik.Prezime;
                    k.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja.ToShortDateString());
                    k.JMBG = korisnik.JMBG;
                    k.Pol = korisnik.Pol;
                    k.Username = korisnik.KorisnickoIme;
                    k.Password = korisnik.Sifra;
                    k.FAdministrator = korisnik.FAdministrator;
                    k.FNastavnik = korisnik.FNastavnik;
                    k.FRoditelj = korisnik.FRoditelj;
                    k.FUcenik = korisnik.FUcenik;

                    s.Update(k);

                    s.Flush();
                    s.Close();
                }

            }
            catch (Exception ec)
            {

            }
        }

        public static void DeleteKorisnik(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Korisnik io = s.Load<Korisnik>(id);
                s.Delete(io);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { }
        }


        public static List<OdeljenjeBasic> GetSvaOdeljenja()
        {
            List<OdeljenjeBasic> lista = new List<OdeljenjeBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Odeljenje> odeljenja = from k in s.Query<Odeljenje>()
                                                   select k;

                foreach (Odeljenje k in odeljenja)
                {
                    lista.Add(new OdeljenjeBasic(k.Id, k.Naziv, k.Smer));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }


        public static void UpdateUcenikovoOdeljenje(int UcenikId, int OdeljenjeId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(UcenikId);
                Odeljenje o = s.Load<Odeljenje>(OdeljenjeId);

                u.PripadaOdeljenju = o;
                o.Ucenici.Add(u);


                s.Update(u);

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public static void SaveOdeljenje(OdeljenjeBasic odeljenje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = new Odeljenje();
                o.Naziv = odeljenje.Naziv;
                o.Smer = odeljenje.Smer.ToUpper();

                s.SaveOrUpdate(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void UpdateOdeljenje(int idOdeljenje, OdeljenjeBasic odeljenje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(idOdeljenje);
                o.Naziv = odeljenje.Naziv;
                o.Smer = odeljenje.Smer.ToUpper();

                s.Update(o);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void DeleteOdeljenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Odeljenje io = s.Load<Odeljenje>(id);
                s.Delete(io);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { }
        }

        public static List<KorisnikExtended> getRoditelji()
        {
            List<KorisnikExtended> lista = new List<KorisnikExtended>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Roditelj> roditelji = from k in s.Query<Roditelj>()
                                                  select k;

                foreach (Roditelj jr in roditelji)
                {
                    KorisnikExtended kp = DTOManager.GetKorisnikPregledInfos(jr.Id);
                    lista.Add(kp);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static List<UcenikBasics> getUcenici()
        {
            List<UcenikBasics> lista = new List<UcenikBasics>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Ucenik> ucenici = from k in s.Query<Ucenik>()
                                              select k;

                foreach (Ucenik uc in ucenici)
                {
                    UcenikBasics u = new UcenikBasics();
                    u.UcenikId = uc.Id;
                    u.Ime = uc.Ime;
                    u.Prezime = uc.Prezime;
                    lista.Add(u);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return lista;
        }

        public static void saveJeRoditelj(int idRoditelja, int idUcenika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(idUcenika);
                Roditelj r = s.Load<Roditelj>(idRoditelja);

                u.Roditelji.Add(r);
                s.SaveOrUpdate(u);

                r.Deca.Add(u);
                s.SaveOrUpdate(r);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void deleteJeRoditelj(int idRoditelja, int idUcenika)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ucenik uc = s.Load<Ucenik>(idUcenika);
                Roditelj ro = s.Load<Roditelj>(idRoditelja);

                ro.Deca.Remove(uc);
                s.Update(ro);
                s.Flush();
                uc.Roditelji.Remove(ro);
                s.Update(uc);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static List<jeRazredniPregled> GetRazredneStaresine()
        {
            List<jeRazredniPregled> lista = new List<jeRazredniPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<JeRazredni> jeRazredni = from k in s.Query<JeRazredni>()
                                                     select k;

                foreach (JeRazredni jr in jeRazredni)
                {
                    lista.Add(new jeRazredniPregled(jr.Id, jr.Id_Nastavnika.Id, jr.Id_Odeljenja.Id, jr.DatumOd, jr.DatumDo));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static jeRazredniPregled GetJeRazredniPregled(int jeRazredniId)
        {
            jeRazredniPregled jrPregled = new jeRazredniPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<JeRazredni> jeRazredni = from k in s.Query<JeRazredni>()
                                                     select k;

                foreach (JeRazredni jr in jeRazredni)
                {
                    if (jr.Id == jeRazredniId)
                    {
                        jrPregled.jeRazredniId = jeRazredniId;
                        jrPregled.NastavnikId = jr.Id_Nastavnika.Id;
                        jrPregled.OdeljenjeId = jr.Id_Odeljenja.Id;
                        jr.DatumDo = jr.DatumDo;
                        jr.DatumOd = jr.DatumOd;
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return jrPregled;
        }

        public static List<KorisnikExtended> GetNastavniciNisuRazredni()
        {
            List<KorisnikExtended> lista = new List<KorisnikExtended>();

            foreach (KorisnikExtended k in DTOManager.GetKorisnici())
            {
                if (k.FNastavnik == 1 && DTOManager.DaLiJeRazredni(k.KorisnikId) == false)
                {
                    lista.Add(k);
                }
            }

            return lista;
        }

        public static List<OdeljenjeBasic> GetOdeljenjaBezRazrednogStaresine()
        {
            List<OdeljenjeBasic> lista = new List<OdeljenjeBasic>();

            foreach (OdeljenjeBasic odeljenje in DTOManager.GetSvaOdeljenja())
            {
                bool flag = true;

                foreach (jeRazredniPregled jr in DTOManager.GetRazredneStaresine())
                {
                    if (jr.datumDo == null && jr.OdeljenjeId == odeljenje.OdeljenjeId)
                    {
                        flag = false;
                    }

                }

                if (flag == true)
                    lista.Add(odeljenje);
            }

            return lista;
        }

        public static void SaveJeRazredni(int nastavnikId, int odeljenjeId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastavnik n = s.Load<Nastavnik>(nastavnikId);
                Odeljenje o = s.Load<Odeljenje>(odeljenjeId);

                JeRazredni jr = new JeRazredni();
                jr.Id_Odeljenja = o;
                jr.Id_Nastavnika = n;
                jr.DatumOd = DateTime.Now;

                s.SaveOrUpdate(jr);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void deleteJeRazredi(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                JeRazredni jr = s.Load<JeRazredni>(id);
                jr.DatumDo = DateTime.Now;

                s.Update(jr);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static void UpdateJeRazredi(int id, DateTime pocetak, DateTime? kraj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                JeRazredni jr = s.Load<JeRazredni>(id);
                jr.DatumOd = pocetak;
                jr.DatumDo = kraj;

                s.Update(jr);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static KorisnikExtended GetKorisnikImePrezime(string ImePrezime)
        {
            KorisnikExtended k = new KorisnikExtended();

            foreach (KorisnikExtended kor in DTOManager.GetKorisnici())
            {
                if (kor.Ime + " " + kor.Prezime == ImePrezime)
                    k = kor;
            }

            return k;
        }

        public static List<PredmetBasic> GetSviPredmeti()
        {
            List<PredmetBasic> predmetiiiii = new List<PredmetBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> predmeti = from k in s.Query<Predmet>()
                                                select k;

                foreach (Predmet p in predmeti)
                {
                    predmetiiiii.Add(new PredmetBasic(p.Id, p.Naziv, p.Opis, p.BrojCasova, p.TipPredmeta, p.MinBrojUcenika, p.BlokNastava, p.SpecijalanKabinet));
                }

                s.Close();
            }
            catch (Exception e) { }

            return predmetiiiii;
        }

        public static void SavePredmet(PredmetBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = new Predmet();
                p.Naziv = predmet.Naziv;
                p.Opis = predmet.Opis;
                p.BrojCasova = predmet.BrojCasvoa;
                p.TipPredmeta = predmet.TipPredmeta;
                p.BlokNastava = predmet.BlokNastava;
                p.SpecijalanKabinet = predmet.SpecijalniKabinet;
                p.MinBrojUcenika = predmet.MinBrUcenika;

                s.SaveOrUpdate(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void UpdatePredmet(int id, PredmetBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(id);
                p.Naziv = predmet.Naziv;
                p.Opis = predmet.Opis;
                p.BrojCasova = predmet.BrojCasvoa;
                p.TipPredmeta = predmet.TipPredmeta;
                p.BlokNastava = predmet.BlokNastava;
                p.SpecijalanKabinet = predmet.SpecijalniKabinet;
                p.MinBrojUcenika = predmet.MinBrUcenika;

                s.Update(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void DeletePredmet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(id);
                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<KorisnikExtended> GetPredavaciPredmeta(int PredmetId)
        {
            List<KorisnikExtended> predavaci = new List<KorisnikExtended>();
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet p = s.Load<Predmet>(PredmetId);


                foreach (Nastavnik nas in p.DrzeNastavnici)
                {
                    KorisnikExtended k = new KorisnikExtended();
                    k.KorisnikId = nas.Id;
                    k.Ime = nas.Ime;
                    k.Prezime = nas.Prezime;
                    predavaci.Add(k);
                }

                s.Close();
            }
            catch (Exception e) { }

            return predavaci;
        }

        public static List<KorisnikExtended> GetNastavniciNePredajuPredmet(int PredmetId)
        {
            List<KorisnikExtended> nePredavaci = new List<KorisnikExtended>();
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet p = s.Load<Predmet>(PredmetId);

                foreach (KorisnikExtended k in DTOManager.GetKorisnici())
                {
                    if (k.FNastavnik == 1)
                    {
                        bool flag = false;

                        foreach (Nastavnik n in p.DrzeNastavnici)
                        {
                            if (n.Ime + n.Prezime == k.Ime + k.Prezime)
                                flag = true;
                        }

                        if (flag == false)
                            nePredavaci.Add(k);
                    }
                }


                s.Close();
            }
            catch (Exception e) { }

            return nePredavaci;
        }

        public static void savePredaje(int idPredmeta, int idNastavnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet predmet = s.Load<Predmet>(idPredmeta);
                Nastavnik nastavnik = s.Load<Nastavnik>(idNastavnika);

                predmet.DrzeNastavnici.Add(nastavnik);
                s.SaveOrUpdate(predmet);

                nastavnik.PredajemPredmete.Add(predmet);
                s.SaveOrUpdate(nastavnik);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void deletePredaje(int idPredmeta, int idNastavnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet predmet = s.Load<Predmet>(idPredmeta);
                Nastavnik nastavnik = s.Load<Nastavnik>(idNastavnika);

                nastavnik.PredajemPredmete.Remove(predmet);
                s.Update(nastavnik);
                s.Flush();
                predmet.DrzeNastavnici.Remove(nastavnik);
                s.Update(predmet);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static List<PredstavljaPregled> GetOdeljenskiPredstavnici()
        {

            List<PredstavljaPregled> lista = new List<PredstavljaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predstavlja> pred = from k in s.Query<Predstavlja>()
                                                select k;

                foreach (Predstavlja p in pred)
                {
                    PredstavljaPregled predstavlja = new PredstavljaPregled();
                    predstavlja.PredstavljaId = p.Id;
                    predstavlja.RoditeljId = p.Id_Roditelja.Id;
                    predstavlja.OdeljenjeId = p.Id_Odeljenja.Id;
                    predstavlja.DatumDo = p.DatumDo;
                    predstavlja.DatumOd = p.DatumOd;
                    lista.Add(predstavlja);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static List<OdeljenjeBasic> GetOdeljenjaBezPredstavnika()
        {
            List<OdeljenjeBasic> lista = new List<OdeljenjeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (OdeljenjeBasic odeljenje in DTOManager.GetSvaOdeljenja())
                {
                    bool flag = false;

                    foreach (PredstavljaPregled pred in DTOManager.GetOdeljenskiPredstavnici())
                    {
                        if (pred.OdeljenjeId == odeljenje.OdeljenjeId && pred.DatumDo == null)
                        {
                            flag = true;
                        }
                    }

                    if (flag == false)
                        lista.Add(odeljenje);
                }


                s.Close();
            }
            catch (Exception e) { }

            return lista;
        }


        public static void SavePredstavlja(int roditeljId, int odeljenjeId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Roditelj n = s.Load<Roditelj>(roditeljId);
                Odeljenje o = s.Load<Odeljenje>(odeljenjeId);

                Predstavlja jr = new Predstavlja();
                jr.Id_Odeljenja = o;
                jr.Id_Roditelja = n;
                jr.DatumOd = DateTime.Now;

                s.SaveOrUpdate(jr);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void deletePredstavlja(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predstavlja jr = s.Load<Predstavlja>(id);
                jr.DatumDo = DateTime.Now;

                s.Update(jr);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static void UpdatePredstavlja(int id, DateTime pocetak, DateTime? kraj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predstavlja jr = s.Load<Predstavlja>(id);
                jr.DatumOd = pocetak;
                jr.DatumDo = kraj;

                s.Update(jr);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static void SaveFunkcija(int roditeljId, string tipFunkcije)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Roditelj n = s.Load<Roditelj>(roditeljId);

                Funkcija jr = new Funkcija();
                jr.VrsiFunkciju = n;
                jr.Tip = tipFunkcije;
                jr.DatumOd = DateTime.Now;

                s.SaveOrUpdate(jr);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void deleteFunkcija(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Funkcija jr = s.Load<Funkcija>(id);
                jr.DatumDo = DateTime.Now;

                s.Update(jr);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static void UpdateFunkcija(int id, DateTime pocetak, DateTime? kraj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Funkcija jr = s.Load<Funkcija>(id);
                jr.DatumOd = pocetak;

                if (kraj != null)
                    jr.DatumDo = (DateTime)kraj;

                s.Update(jr);
                s.Flush();

                s.Close();
            }
            catch (Exception e) { }
        }

        public static List<FunkcijaPregled> GetSveFunkcije()
        {

            List<FunkcijaPregled> lista = new List<FunkcijaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Funkcija> pred = from k in s.Query<Funkcija>()
                                             select k;

                foreach (Funkcija p in pred)
                {
                    FunkcijaPregled FJA = new FunkcijaPregled();
                    FJA.FunkcijaId = p.Id;
                    FJA.RoditeljId = p.VrsiFunkciju.Id;
                    FJA.TipFunkcije = p.Tip;
                    FJA.DatumDo = p.DatumDo;
                    FJA.DatumOd = p.DatumOd;
                    lista.Add(FJA);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }


        public static List<KorisnikExtended> GetRoditeljiBezFunkcije()
        {
            List<KorisnikExtended> lista = new List<KorisnikExtended>();
            try
            {
                ISession s = DataLayer.GetSession();

                foreach (KorisnikExtended k in DTOManager.GetKorisnici())
                {
                    if (k.FRoditelj == 1)
                    {
                        bool flag = true;
                        Roditelj rod = s.Load<Roditelj>(k.KorisnikId);

                        foreach (Funkcija fun in rod.FunkcijeKojeJeVrsio)
                        {
                            if (fun.DatumDo == DateTime.MinValue)
                                flag = false;
                        }

                        if (flag == true)
                            lista.Add(k);
                    }
                }
            }
            catch (Exception e) { }

            return lista;
        }

        public static List<GodinaPregled> GetNaGodini()
        {

            List<GodinaPregled> lista = new List<GodinaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Godina> godine = from k in s.Query<Godina>()
                                             select k;

                foreach (Godina g in godine)
                {
                    GodinaPregled godinaP = new GodinaPregled(g.Id, g.PredmeT.Id, g.NaGodini);
                    lista.Add(godinaP);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static GodinaPregled GetNaGodiniInfos(int godina, int predmetId)
        {

            GodinaPregled godinaP = new GodinaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Godina> godine = from k in s.Query<Godina>()
                                             where (k.NaGodini==godina && k.PredmeT.Id==predmetId)
                                             select k;

                foreach (Godina g in godine)
                {
                    godinaP = new GodinaPregled(g.Id, g.PredmeT.Id, g.NaGodini);
                    
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return godinaP;
        }

        public static List<PredmetBasic> GetPredmetiNaGodini(int godina)
        {
            List<PredmetBasic> lista = new List<PredmetBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Godina> godine = from k in s.Query<Godina>()
                                             where k.NaGodini==godina
                                             select k;

                foreach (Godina g in godine)
                {
                    PredmetBasic pred = DTOManager.GetPredmetBasicInfo(g.PredmeT.Id);
                    lista.Add(pred);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static List<PredmetBasic> GetPredmetiKojiNisuNaGodini(int godina)
        {
            List<PredmetBasic> lista = new List<PredmetBasic>();

            List<PredmetBasic> predmetiNaGodini = DTOManager.GetPredmetiNaGodini(godina);

            List<PredmetBasic> sviPredmeti = DTOManager.GetSviPredmeti();

            foreach(PredmetBasic p in sviPredmeti)
            {
                bool flag = true;

                foreach(PredmetBasic pp in predmetiNaGodini)
                {
                    if (p.PredmetId == pp.PredmetId)
                        flag = false;
                }

                if (flag == true)
                    lista.Add(p);
            }

            return lista;
        }

        public static void SaveNaGodini(int godina, int predmetId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(predmetId);

                Godina god = new Godina();
                god.NaGodini = godina;
                god.PredmeT = p;

                s.SaveOrUpdate(god);
                s.Flush();
                s.Close();

                p.NaGodini.Add(god);
                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static void deleteNaGodini( int godina, int idPredmeta)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet predmet = s.Load<Predmet>(idPredmeta);
                Godina god = s.Load<Godina>(DTOManager.GetNaGodiniInfos(godina, idPredmeta).GodinaId);

                predmet.NaGodini.Remove(god);
                s.Update(predmet);
                s.Flush();

                s.Delete(god);
                s.Flush();
                s.Close();

            }
            catch (Exception e) { }
        }

        public static List<BrojTelefonaPregled> GetBrojTelefonaKorisnika(int KorisnikId)
        {

            List<BrojTelefonaPregled> lista = new List<BrojTelefonaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<BrojTelefona> brojevi = from k in s.Query<BrojTelefona>()
                                                    where k.PripadaKorisniku.Id==KorisnikId
                                             select k;

                foreach (BrojTelefona b in brojevi)
                {
                    BrojTelefonaPregled br = new BrojTelefonaPregled(b.Id, b.PripadaKorisniku.Id, b.BrojTelefonaKorisnika);
                    lista.Add(br);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static void SaveBrojTelefona(int korisnikId, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(korisnikId);

                BrojTelefona br = new BrojTelefona();
                br.PripadaKorisniku = k;
                br.BrojTelefonaKorisnika = broj;

                s.SaveOrUpdate(br);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }

        public static void UpdateBrojTelefona(int id, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojTelefona br = s.Load<BrojTelefona>(id);
                Korisnik k = s.Load<Korisnik>(br.PripadaKorisniku.Id);

                k.Brojevi.Remove(br);
                s.Update(br);
                s.Flush();
                br.BrojTelefonaKorisnika = broj;
                s.Update(br);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }
        
        public static void deleteBrojTelefona(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                BrojTelefona br = s.Load<BrojTelefona>(id);
                Korisnik k = s.Load<Korisnik>(br.PripadaKorisniku.Id);

                k.Brojevi.Remove(br);
                s.Update(k);
                s.Flush();

                s.Delete(br);
                s.Flush();
                s.Close();

            }
            catch (Exception e) { }
        }

        public static List<DrziCasPregled> GetDrziCas()
        {
            List<DrziCasPregled> lista = new List<DrziCasPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DrziCas> drziCas = from p in s.Query<DrziCas>()
                                               select p;

                foreach (DrziCas d in drziCas)
                {
                    lista.Add(new DrziCasPregled(d.Id,d.Id_Nastavnika.Id,d.Id_Predmeta.Id,d.Id_Odeljenja.Id));
                }

                s.Close(); 

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return lista;
        }

        public static List<PredmetBasic> GetNastavnikoviPredmetiKojeNeDrziOdeljenju(int nastavnikId, int odeljenjeId)
        {
            List<PredmetBasic> lista = new List<PredmetBasic>();

            List<PredmetBasic> lista1 = DTOManager.GetNastavnikOdeljenjuDrziPredmet(nastavnikId, odeljenjeId);

            List<PredmetBasic> lista2 = DTOManager.GetPredmetiInfos(nastavnikId);

            foreach(PredmetBasic p in lista2)
            {
                bool flag = true;

                foreach(PredmetBasic pp in lista1)
                {
                    if (p.PredmetId == pp.PredmetId)
                        flag = false;
                }

                if (flag == true)
                    lista.Add(p);
            }

            return lista;
        }

        public static void SaveDrziCas(int nastavnikId, int OdeljenjeId, int PredmetId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastavnik nas = s.Load<Nastavnik>(nastavnikId);
                Odeljenje odelj = s.Load<Odeljenje>(OdeljenjeId);
                Predmet pred = s.Load<Predmet>(PredmetId);

                DrziCas drzi = new DrziCas();
                drzi.Id_Nastavnika = nas;
                drzi.Id_Odeljenja = odelj;
                drzi.Id_Predmeta = pred;

                nas.DrziCasove.Add(drzi);
                s.SaveOrUpdate(nas);
                s.Flush();
                pred.SeDrzeU.Add(drzi);
                s.SaveOrUpdate(pred);
                s.Flush();
                odelj.PredajuPredmete.Add(drzi);
                s.SaveOrUpdate(odelj);
                s.Flush();


                s.SaveOrUpdate(drzi);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {

            }
        }


        public static void deleteDrziCas(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                DrziCas drzi = s.Load<DrziCas>(id);
                Nastavnik nas = s.Load<Nastavnik>(drzi.Id_Nastavnika.Id);
                Odeljenje odelj = s.Load<Odeljenje>(drzi.Id_Odeljenja.Id);
                Predmet pred = s.Load<Predmet>(drzi.Id_Predmeta.Id);

                nas.DrziCasove.Remove(drzi);
                s.Update(nas);
                s.Flush();
                odelj.PredajuPredmete.Remove(drzi);
                s.Update(odelj);
                s.Flush();
                pred.SeDrzeU.Remove(drzi);
                s.Update(pred);
                s.Flush();
                s.Delete(drzi);
                s.Flush();
                s.Close();

            }
            catch (Exception e) { }
        }
    }


}
