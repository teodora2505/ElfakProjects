using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region Korisnici
        public static void dodajKorisnika(Korisnik k)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("insert into \"Korisnik\" (\"username\", \"password\",ime, prezime, mail, admin)  values ('" + k.username + "', '" + k.password + "', '" + k.ime + "', '" + k.prezime + "', '" + k.mail + "', '" + k.admin + "');");
        }

        public static bool daLiPostojiUsernamePassword(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row korisnikData = session.Execute("select * from \"Korisnik\" where \"username\"='" + username + "' and \"password\"='" + password + "'").FirstOrDefault();

            if (korisnikData!=null)
                return true;
            else
                return false;
        }

        public static bool daLiJeKorisnikAdministrator(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row korisnikData = session.Execute("select * from \"Korisnik\" where \"username\"='" + username + "' and \"password\"='" + password + "'").FirstOrDefault();

            if (korisnikData != null)
            {
                if (korisnikData["admin"].ToString() == "da")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static Korisnik GetKorisnik(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            Row korisnikData = session.Execute("select * from \"Korisnik\" where \"username\"='" + username + "' and \"password\"='" + password + "'").FirstOrDefault();

            if (korisnikData != null)
            {
                korisnik.username = korisnikData["username"] != null ? korisnikData["username"].ToString() : string.Empty;
                korisnik.password = korisnikData["password"] != null ? korisnikData["password"].ToString() : string.Empty;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                korisnik.mail = korisnikData["mail"] != null ? korisnikData["mail"].ToString() : string.Empty;
                korisnik.admin = korisnikData["admin"] != null ? korisnikData["admin"].ToString() : string.Empty;
            }

            return korisnik;
        }

        public static void DeleteKorisnik(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            Korisnik korisnik = new Korisnik();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("delete from \"Korisnik\" where \"username\" = '" + username + "' and \"password\"='" + password + "'");

        }

        public static void UpdateKorisnik(Korisnik k, string username, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            if (k.username == username && k.password == password) //ne menjamo primary key
            {
                RowSet korisnikData = session.Execute("update \"Korisnik\" set " +
               "', ime='" + k.ime +
               "', prezime='" + k.prezime +
               "', mail='" + k.mail +
               "', admin='" + k.admin +
               "' where \"username\" = '" + username + "' and \"password\"='" + password + "'");
            }
            else //menjamo i primary key
            {
                DeleteKorisnik(username, password);
                dodajKorisnika(k);
            }

        }

        public static List<Korisnik> GetKorisnici()
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;

            var korisniciData = session.Execute("select * from \"Korisnik\"");

            foreach (var korisnikData in korisniciData)
            {
                Korisnik k = new Korisnik();
                k.username = korisnikData["username"] != null ? korisnikData["username"].ToString() : string.Empty;
                k.password = korisnikData["password"] != null ? korisnikData["password"].ToString() : string.Empty;
                k.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                k.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                k.mail = korisnikData["mail"] != null ? korisnikData["mail"].ToString() : string.Empty;
                k.admin = korisnikData["admin"] != null ? korisnikData["admin"].ToString() : string.Empty;
                korisnici.Add(k);
            }

            return korisnici;
        }

        #endregion

        #region Filmovi
        public static void dodajFilm(Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet filmData1 = session.Execute("insert into \"Film\" (\"zanr\", \"sifra\",naziv, godina)  values ('" + f.zanr + "', '" + f.sifra + "', '" + f.naziv + "', '" + f.godina + "');");
            RowSet filmData2 = session.Execute("insert into \"ReziserGlumci\" (\"sifra\",reziser, glumci)  values ('" + f.sifra + "', '" + f.reziser + "', '" + f.glumci + "');");
        }

        public static Film GetFilm(string sifra)
        {
            ISession session = SessionManager.GetSession();

            Film film = new Film();

            if (session == null)
                return null;

            Row filmData2 = session.Execute("select * from \"ReziserGlumci\" where \"sifra\"='" + sifra + "'").FirstOrDefault();

            if (filmData2 != null)
            {
                film.sifra = filmData2["sifra"] != null ? filmData2["sifra"].ToString() : string.Empty;
                film.reziser = filmData2["reziser"] != null ? filmData2["reziser"].ToString() : string.Empty;
                film.glumci = filmData2["glumci"] != null ? filmData2["glumci"].ToString() : string.Empty;
            }

            return film;
        }

        public static List<Film> GetFilmovi()
        {
            ISession session = SessionManager.GetSession();
            List<Film> filmovi = new List<Film>();

            if (session == null)
                return null;

            var filmoviData1 = session.Execute("select * from \"Film\"");


            foreach (Row filmData1 in filmoviData1)
            {
                Film film = new Film();
                film.zanr = filmData1["zanr"] != null ? filmData1["zanr"].ToString() : string.Empty;
                film.sifra = filmData1["sifra"] != null ? filmData1["sifra"].ToString() : string.Empty;
                film.naziv = filmData1["naziv"] != null ? filmData1["naziv"].ToString() : string.Empty;
                film.godina = filmData1["godina"] != null ? filmData1["godina"].ToString() : string.Empty;
                film.reziser = GetFilm(film.sifra).reziser;
                film.glumci = GetFilm(film.sifra).glumci;
                filmovi.Add(film);
            }

            return filmovi;

        }

        public static void DeleteFilmReziserGlumci(string sifra)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet filmData = session.Execute("delete from \"ReziserGlumci\" where \"sifra\" = '" + sifra + "';");

        }

        public static void UpdateFilmReziserGlumci(string staraSifra, Film noviFilm)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            if (staraSifra == noviFilm.sifra) //ne menjamo primary key
            {
                RowSet korisnikData = session.Execute("update \"ReziserGlumci\" set " +
               "reziser='" + noviFilm.reziser +
               "', glumci='" + noviFilm.glumci +
               "' where \"sifra\" = '" + staraSifra + "'");
            }
            else //menjamo i primary key
            {
                DeleteFilmReziserGlumci(staraSifra);
                RowSet filmData2 = session.Execute("insert into \"ReziserGlumci\" (\"sifra\",reziser, glumci)  values ('" + noviFilm.sifra + "', '" + noviFilm.reziser + "', '" + noviFilm.glumci + "');");
            }

        }

        public static void DeleteFilm(string zanr, string naziv, string godina)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet filmData = session.Execute("delete from \"Film\" where \"zanr\" = '" + zanr + "' and godina='" + godina + "'" + " and naziv='" + naziv + "';");

        }

        public static void UpdateFilm(Film stari, Film novi)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            DeleteFilm(stari.zanr, stari.naziv, stari.godina);
            RowSet filmData1 = session.Execute("insert into \"Film\" (\"zanr\", \"sifra\",naziv, godina)  values ('" + novi.zanr + "', '" + novi.sifra + "', '" + novi.naziv + "', '" + novi.godina + "');");

        }

        public static List<Film> GetZanr(string zanr)
        {
            ISession session = SessionManager.GetSession();
            List<Film> filmovi = new List<Film>();

            if (session == null)
                return null;

            var filmoviData1 = session.Execute("select * from \"Film\" where \"zanr\"='" + zanr + "'");


            foreach (Row filmData1 in filmoviData1)
            {
                Film film = new Film();
                film.zanr = filmData1["zanr"] != null ? filmData1["zanr"].ToString() : string.Empty;
                film.sifra = filmData1["sifra"] != null ? filmData1["sifra"].ToString() : string.Empty;
                film.naziv = filmData1["naziv"] != null ? filmData1["naziv"].ToString() : string.Empty;
                film.godina = filmData1["godina"] != null ? filmData1["godina"].ToString() : string.Empty;
                film.reziser = GetFilm(film.sifra).reziser;
                film.glumci = GetFilm(film.sifra).glumci;
                filmovi.Add(film);
            }

            return filmovi;

        }

        #endregion

        #region Ocene

        public static bool daLiJeFilmOcenjen(string sifraFilma)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row ocenaData = session.Execute("select * from \"Ocene\" where \"sifraFilma\"='" + sifraFilma + "'").FirstOrDefault();

            if (ocenaData != null)
                return true;
            else
                return false;
        }

        public static Ocena GetOcena(string sifraFilma)
        {
            ISession session = SessionManager.GetSession();

            Ocena ocenaFilma = new Ocena();

            if (session == null)
                return null;

            var oceneFilmaData = session.Execute("select * from \"Ocene\" where \"sifraFilma\"='" + sifraFilma + "'");

            int brojOcena = 0;

            foreach (Row ocenaData in oceneFilmaData)
            {
                brojOcena++;
                ocenaFilma.sifraFilma = ocenaData["sifraFilma"] != null ? ocenaData["sifraFilma"].ToString() : string.Empty;
                ocenaFilma.ocena += ocenaData["ocena"] != null ? (int)ocenaData["ocena"] : 0;
            }

            ocenaFilma.ocena /= brojOcena;

            return ocenaFilma;
        }

        public static List<Ocena> GetSveOcene()
        {
            ISession session = SessionManager.GetSession();

            List<Ocena> ocene = new List<Ocena>();

            if (session == null)
                return null;

            var oceneFilmaData = session.Execute("select * from \"Ocene\"");

            foreach (Row ocenaData in oceneFilmaData)
            {
                Ocena ocenaFilma = new Ocena();

                ocenaFilma.sifraFilma = ocenaData["sifraFilma"] != null ? ocenaData["sifraFilma"].ToString() : string.Empty;
                ocenaFilma.username = ocenaData["username"] != null ? ocenaData["username"].ToString() : string.Empty;
                ocenaFilma.password = ocenaData["password"] != null ? ocenaData["password"].ToString() : string.Empty;
                ocenaFilma.ocena = ocenaData["ocena"] != null ? (int)ocenaData["ocena"] : 0;

                ocene.Add(ocenaFilma);
            }


            return ocene;
        }

        public static bool daLiJeKorisnikVecOcenioFilm(string sifraFilma,string username, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row ocenaData = session.Execute("select * from \"Ocene\" where \"sifraFilma\"='" + sifraFilma + "' and \"username\"='"+username+"' and \"password\"='"+password+"'").FirstOrDefault();

            if (ocenaData != null)
                return true;
            else
                return false;
        }

        public static Ocena getKorisnikovaOcena(string sifraFilma, string username, string password)
        {
            ISession session = SessionManager.GetSession();
            Ocena ocena = new Ocena();

            if (session == null)
                return null;

            Row ocenaData = session.Execute("select * from \"Ocene\" where \"sifraFilma\"='" + sifraFilma + "' and \"username\"='" + username + "' and \"password\"='" + password + "'").FirstOrDefault();

            if (ocenaData != null)
            {
                ocena.sifraFilma = ocenaData["sifraFilma"].ToString();
                ocena.username = ocenaData["username"].ToString();
                ocena.password = ocenaData["password"].ToString();
                ocena.ocena = (int)ocenaData["ocena"];
            }

            return ocena;
        }

        public static void dodajOcenu(Ocena o)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ocenaData = session.Execute("insert into \"Ocene\" (\"sifraFilma\", \"username\",\"password\", ocena)  values ('" + o.sifraFilma + "', '" + o.username + "', '" + o.password + "', " + Convert.ToInt32(o.ocena) + ");");
        }

        public static void UpdateOcena(Ocena staraOcena, int novaOcena)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ocenaData = session.Execute("update \"Ocene\" set " +
           " ocena=" + novaOcena +
           " where \"sifraFilma\" = '" + staraOcena.sifraFilma + "' and \"username\"='" + staraOcena.username + "' and \"password\"='" + staraOcena.password + "'");

        }

        public static void DeleteOcena(Ocena o)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet ocenaData = session.Execute("delete from \"Ocene\" where \"sifraFilma\" = '" + o.sifraFilma + "' and \"username\"='" + o.username + "' and \"password\"='"+o.password+"'");

        }

        #endregion

        #region Preporuke
        public static int GetBrojPreporuka(string sifraFilma)
        {
            ISession session = SessionManager.GetSession();

            Preporuka preporukaFilma = new Preporuka();

            if (session == null)
                return 0;

            var preporukeData = session.Execute("select * from \"Preporuke\" where \"sifraFilma\"='" + sifraFilma + "'");

            int broj_preporuka = 0;

            foreach (Row preporukaData in preporukeData)
            {
                preporukaFilma.sifraFilma = preporukaData["sifraFilma"] != null ? preporukaData["sifraFilma"].ToString() : string.Empty;
                if(preporukaData["preporuka"]!=null)
                {
                    if (preporukaData["preporuka"].ToString() == "da")
                        broj_preporuka++;
                }
            }

            return broj_preporuka;
        }

        public static int GetBrojNePreporuka(string sifraFilma)
        {
            ISession session = SessionManager.GetSession();

            Preporuka preporukaFilma = new Preporuka();

            if (session == null)
                return 0;

            var preporukeData = session.Execute("select * from \"Preporuke\" where \"sifraFilma\"='" + sifraFilma + "'");

            int broj_nepreporuka = 0;

            foreach (Row preporukaData in preporukeData)
            {
                preporukaFilma.sifraFilma = preporukaData["sifraFilma"] != null ? preporukaData["sifraFilma"].ToString() : string.Empty;
                if (preporukaData["preporuka"] != null)
                {
                    if (preporukaData["preporuka"].ToString() == "ne")
                        broj_nepreporuka++;
                }
            }

            return broj_nepreporuka;
        }

        public static Preporuka getKorisnikovaPreporuka(string sifraFilma, string username, string password)
        {
            ISession session = SessionManager.GetSession();
            Preporuka preporuka = new Preporuka();

            if (session == null)
                return null;

            Row preporukaData = session.Execute("select * from \"Preporuke\" where \"sifraFilma\"='" + sifraFilma + "' and \"username\"='" + username + "' and \"password\"='" + password + "'").FirstOrDefault();

            if (preporukaData != null)
            {
                preporuka.sifraFilma = preporukaData["sifraFilma"].ToString();
                preporuka.username = preporukaData["username"].ToString();
                preporuka.password = preporukaData["password"].ToString();
                preporuka.preporuka = preporukaData["preporuka"].ToString();
            }

            return preporuka;
        }

        public static bool daLiJeKorisnikVecPreporucioFilm(string sifraFilma, string username, string password)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row preporukaData = session.Execute("select * from \"Preporuke\" where \"sifraFilma\"='" + sifraFilma + "' and \"username\"='" + username + "' and \"password\"='" + password + "'").FirstOrDefault();

            if (preporukaData != null)
                return true;
            else
                return false;
        }

        public static List<Preporuka> getSvePreporuke()
        {
            ISession session = SessionManager.GetSession();
            List<Preporuka> preporuke = new List<Preporuka>();

            if (session == null)
                return null;

            var preporukeData = session.Execute("select * from \"Preporuke\"");

            foreach (var preporukaData in preporukeData)
            {
                Preporuka p = new Preporuka();
                p.sifraFilma = preporukaData["sifraFilma"] != null ? preporukaData["sifraFilma"].ToString() : string.Empty;
                p.username = preporukaData["username"] != null ? preporukaData["username"].ToString() : string.Empty;
                p.password = preporukaData["password"] != null ? preporukaData["password"].ToString() : string.Empty;
                p.preporuka = preporukaData["preporuka"] != null ? preporukaData["preporuka"].ToString() : string.Empty;
                preporuke.Add(p);
            }

            return preporuke;
        }
        public static void dodajPreporuku(Preporuka p)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet preporukaData = session.Execute("insert into \"Preporuke\" (\"sifraFilma\", \"username\",\"password\", preporuka)  values ('" + p.sifraFilma + "', '" + p.username + "', '" + p.password + "','" + p.preporuka + "');");
        }

        public static void UpdatePreporuka(Preporuka staraPreporuka, string novaPreporuka)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

                RowSet preporukaData = session.Execute("update \"Preporuke\" set " +
               " preporuka='" + novaPreporuka +
               "' where \"sifraFilma\" = '" + staraPreporuka.sifraFilma + "' and \"username\"='" + staraPreporuka.username + "' and \"password\"='"+staraPreporuka.password+"'");

        }

        public static void DeletePreporuka(Preporuka p)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet preporukaData = session.Execute("delete from \"Preporuke\" where \"sifraFilma\" = '" + p.sifraFilma + "' and \"username\"='" + p.username + "' and \"password\"='" + p.password + "'");

        }

        #endregion

        #region OmiljeniFilmovi
        public static List<Film> GetKorisnikoviOmiljeniFilmovi(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            List<Film> filmovi = new List<Film>();

            if (session == null)
                return null;

            var filmoviData1 = session.Execute("select * from \"OmiljeniFilmovi\" where \"username\"='" + username + "' and \"password\"='" + password + "'");


            foreach (Row filmData1 in filmoviData1)
            {
                Film film = new Film();
                film.naziv = filmData1["naziv"] != null ? filmData1["naziv"].ToString() : string.Empty;
                film.godina = filmData1["godina"] != null ? filmData1["godina"].ToString() : string.Empty;
                film.zanr = filmData1["zanr"] != null ? filmData1["zanr"].ToString() : string.Empty;
                film.sifra = filmData1["sifraFilma"] != null ? filmData1["sifraFilma"].ToString() : string.Empty;
                film.reziser = GetFilm(film.sifra).reziser;
                film.glumci = GetFilm(film.sifra).glumci;
                filmovi.Add(film);
            }

            return filmovi;

        }

        public static List<OmiljeniFilm> GetSviOmiljeniFilmovi()
        {
            ISession session = SessionManager.GetSession();

            List<OmiljeniFilm> filmovi = new List<OmiljeniFilm>();

            if (session == null)
                return null;

            var filmoviData1 = session.Execute("select * from \"OmiljeniFilmovi\"");


            foreach (Row filmData1 in filmoviData1)
            {
                OmiljeniFilm film = new OmiljeniFilm();
                film.korisnik = new Korisnik();
                film.korisnik.username = filmData1["username"] != null ? filmData1["username"].ToString() : string.Empty;
                film.korisnik.password = filmData1["password"] != null ? filmData1["password"].ToString() : string.Empty;
                film.naziv = filmData1["naziv"] != null ? filmData1["naziv"].ToString() : string.Empty;
                film.godina = filmData1["godina"] != null ? filmData1["godina"].ToString() : string.Empty;
                film.zanr = filmData1["zanr"] != null ? filmData1["zanr"].ToString() : string.Empty;
                film.sifra = filmData1["sifraFilma"] != null ? filmData1["sifraFilma"].ToString() : string.Empty;
                film.reziser = GetFilm(film.sifra).reziser;
                film.glumci = GetFilm(film.sifra).glumci;
                filmovi.Add(film);
            }

            return filmovi;
        }
        public static bool daLiJeToKorisnikovOmiljeniFilm(Korisnik k, Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row filmData = session.Execute("select * from \"OmiljeniFilmovi\" where \"username\"='" + k.username + "' and \"password\"='" + k.password + "' and naziv='" + f.naziv + "' and godina='" + f.godina + "' and zanr='" + f.zanr + "'").FirstOrDefault();

            if (filmData != null)
                return true;
            else
                return false;
        }

        public static void dodajOmiljeniFilm(Korisnik k, Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet omiljenjiData = session.Execute("insert into \"OmiljeniFilmovi\" (\"username\", \"password\", naziv, godina, zanr, \"sifraFilma\")  values ('" + k.username + "', '" + k.password + "', '" + f.naziv + "','" + f.godina + "'" + ",'" + f.zanr + "','" + f.sifra + "')");
        }

        public static void deleteOmiljeniFilm(Korisnik k, Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet omiljeniData = session.Execute("delete from \"OmiljeniFilmovi\" where \"username\" = '" + k.username + "' and \"password\"='" + k.password + "'" + " and naziv='" + f.naziv + "' and godina='" + f.godina + "' and zanr='" + f.zanr + "'");

        }

        #endregion

        #region OdgledaniFilmovi
        public static List<Film> GetKorisnikoviOdgledaniFilmovi(string username, string password)
        {
            ISession session = SessionManager.GetSession();

            List<Film> filmovi = new List<Film>();

            if (session == null)
                return null;

            var filmoviData1 = session.Execute("select * from \"OdgledaniFilmovi\" where \"username\"='" + username + "' and \"password\"='" + password + "'");

            foreach (Row filmData1 in filmoviData1)
            {
                Film film = new Film();
                film.naziv = filmData1["naziv"] != null ? filmData1["naziv"].ToString() : string.Empty;
                film.godina = filmData1["godina"] != null ? filmData1["godina"].ToString() : string.Empty;
                film.zanr = filmData1["zanr"] != null ? filmData1["zanr"].ToString() : string.Empty;
                film.sifra = filmData1["sifraFilma"] != null ? filmData1["sifraFilma"].ToString() : string.Empty;
                film.reziser = GetFilm(film.sifra).reziser;
                film.glumci = GetFilm(film.sifra).glumci;
                filmovi.Add(film);
            }

            return filmovi;

        }

        public static List<OmiljeniFilm> GetSviOdgledaniFilmovi()
        {
            ISession session = SessionManager.GetSession();

            List<OmiljeniFilm> filmovi = new List<OmiljeniFilm>();

            if (session == null)
                return null;

            var filmoviData1 = session.Execute("select * from \"OdgledaniFilmovi\"");


            foreach (Row filmData1 in filmoviData1)
            {
                OmiljeniFilm film = new OmiljeniFilm();
                film.korisnik = new Korisnik();
                film.korisnik.username = filmData1["username"] != null ? filmData1["username"].ToString() : string.Empty;
                film.korisnik.password = filmData1["password"] != null ? filmData1["password"].ToString() : string.Empty;
                film.naziv = filmData1["naziv"] != null ? filmData1["naziv"].ToString() : string.Empty;
                film.godina = filmData1["godina"] != null ? filmData1["godina"].ToString() : string.Empty;
                film.zanr = filmData1["zanr"] != null ? filmData1["zanr"].ToString() : string.Empty;
                film.sifra = filmData1["sifraFilma"] != null ? filmData1["sifraFilma"].ToString() : string.Empty;
                film.reziser = GetFilm(film.sifra).reziser;
                film.glumci = GetFilm(film.sifra).glumci;
                filmovi.Add(film);
            }

            return filmovi;
        }
        public static bool daLiJeKorisnikOdgledaoFilm(Korisnik k, Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return false;

            Row filmData = session.Execute("select * from \"OdgledaniFilmovi\" where \"username\"='" + k.username + "' and \"password\"='" + k.password + "' and naziv='" + f.naziv + "' and godina='" + f.godina + "' and zanr='" + f.zanr + "'").FirstOrDefault();

            if (filmData != null)
                return true;
            else
                return false;
        }

        public static void dodajOdgledaniFilm(Korisnik k, Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet odgledaniData = session.Execute("insert into \"OdgledaniFilmovi\" (\"username\", \"password\", naziv, godina, zanr, \"sifraFilma\")  values ('" + k.username + "', '" + k.password + "', '" + f.naziv + "','" + f.godina + "'" + ",'" + f.zanr + "','" + f.sifra + "')");
        }

        public static void deleteOdgledaniFilm(Korisnik k, Film f)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet odgledaniData = session.Execute("delete from \"OdgledaniFilmovi\" where \"username\" = '" + k.username + "' and \"password\"='" + k.password + "'" + " and naziv='" + f.naziv + "' and godina='" + f.godina + "' and zanr='" + f.zanr + "'");

        }

        #endregion

        #region Recenzije
        public static List<Recenzija> GetRecenzijeFilma(string sifraFilma)
        {
            ISession session = SessionManager.GetSession();
            List<Recenzija> recenzije = new List<Recenzija>();

            if (session == null)
                return null;

            var recenzijeData = session.Execute("select * from \"Recenzije\" where \"sifraFilma\"='"+ sifraFilma + "'");

            foreach (var recenzijaData in recenzijeData)
            {
                Recenzija r = new Recenzija();
                r.sifraFilma = recenzijaData["sifraFilma"] != null ? recenzijaData["sifraFilma"].ToString() : string.Empty;
                r.username = recenzijaData["username"] != null ? recenzijaData["username"].ToString() : string.Empty;
                r.recenzija = recenzijaData["recenzija"] != null ? recenzijaData["recenzija"].ToString() : string.Empty;
                r.datum = (LocalDate)recenzijaData["datum"];

                recenzije.Add(r);
            }
            
            return recenzije;
        }

        public static void dodajRecenziju(Recenzija r, string datum)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet recenzijaData = session.Execute("insert into \"Recenzije\" (\"sifraFilma\", \"username\", recenzija, datum)  values ('" + r.sifraFilma + "', '" + r.username + "', '" + r.recenzija + "','" + datum + "')");
        }

        public static void UpdateRecenziju(Recenzija stara, string datumStari, Recenzija nova, string datumNovi)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            if (stara.sifraFilma==nova.sifraFilma && stara.datum==nova.datum && stara.recenzija==nova.recenzija) //ne menjamo primary key
            {
                RowSet recenzData = session.Execute("update \"Recenzije\" set " +
               " username='" + nova.username +
               "' where \"sifraFilma\" = '" + stara.sifraFilma + "' and datum='" + datumStari + "' and recenzija='"+stara.recenzija+"'");
            }
            else //menjamo i primary key
            {
                deleteRecenziju(stara, datumStari);
                dodajRecenziju(nova,datumNovi);
            }

        }

        public static void deleteRecenziju(Recenzija r, string datum)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet recenzijaData = session.Execute("delete from \"Recenzije\" where \"sifraFilma\" = '" + r.sifraFilma + "' and datum='" + datum + "'" + " and recenzija='" + r.recenzija + "'");

        }

        public static int brojRecenzijaFilma(string sifraFilma)
        {
            ISession session = SessionManager.GetSession();
            List<Recenzija> recenzije = new List<Recenzija>();

            if (session == null)
                return -1;   

            var recenzijeData = session.Execute("select * from \"Recenzije\" where \"sifraFilma\"='" + sifraFilma + "'");

            int br = 0;
            foreach (var recenzijaData in recenzijeData)
                br++;
           
            return br;
        }

        public static List<Recenzija> GetSveRecenzije()
        {
            ISession session = SessionManager.GetSession();
            List<Recenzija> recenzije = new List<Recenzija>();

            if (session == null)
                return null;

            var recenzijeData = session.Execute("select * from \"Recenzije\"");

            foreach (var recenzijaData in recenzijeData)
            {
                Recenzija r = new Recenzija();
                r.sifraFilma = recenzijaData["sifraFilma"] != null ? recenzijaData["sifraFilma"].ToString() : string.Empty;
                r.username = recenzijaData["username"] != null ? recenzijaData["username"].ToString() : string.Empty;
                r.recenzija = recenzijaData["recenzija"] != null ? recenzijaData["recenzija"].ToString() : string.Empty;
                r.datum = (LocalDate)recenzijaData["datum"];

                recenzije.Add(r);
            }

            return recenzije;
        }

        #endregion
    }


}
