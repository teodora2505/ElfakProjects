using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.Windows.Forms;
using eDnevnik.Entiteti;
using System.Globalization;

namespace eDnevnik
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitavanjeKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                //Ucitavaju se podaci o korisniku za zadatim brojem
                Korisnik k = s.Load<Korisnik>(101);

                MessageBox.Show("Ime: "+k.Ime+Environment.NewLine+
                    "Prezime: "+ k.Prezime+ Environment.NewLine+
                    "Datum rodjenja: "+k.DatumRodjenja.ToString("dd/MMM/yyyy") +Environment.NewLine+
                    "JMBG: "+k.JMBG+Environment.NewLine+
                    "Pol: "+k.Pol+Environment.NewLine);

                //za 3. fazu prikazati i specificne podatk, na osnovu ispitanog tipa korisnika 
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = new Korisnik();

                k.Ime = "Milica";
                k.Prezime = "Miloradovic";
                k.DatumRodjenja = DateTime.ParseExact("25-05-1997","dd-MM-yyyy",CultureInfo.InvariantCulture);
                k.JMBG = "2505997747010";
                k.Pol = 'Z';
                k.Username = "milica997";
                k.Password = "miloradovic997";
                k.FAdministrator = 1;
                k.FNastavnik = 0;
                k.FRoditelj = 0;
                k.FUcenik = 0;

                s.SaveOrUpdate(k);

                s.Flush();
                MessageBox.Show("Dodat je korisnik: "+k.Ime+" "+k.Prezime+".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //many-to-one
        private void btnUcenikOdeljenje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o uceniku za zadatim brojem
                Ucenik u = s.Load<Ucenik>(101);

                MessageBox.Show(u.Ime+ " "+ u.Prezime+" je u odeljenju "+u.PripadaOdeljenju.Naziv+", smer: "+u.PripadaOdeljenju.Smer.ToLower()+".");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //one-to-many
        private void btnOdeljenjeUcenik_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o odeljenju sa zadatim brojem
                Odeljenje o = s.Load<Odeljenje>(1);

                String prikaz = "U odeljenju "+o.Naziv +" su učenici:"+Environment.NewLine;
                foreach (Ucenik u in o.Ucenici)
                {
                    prikaz += u.Ime + " " + u.Prezime + Environment.NewLine;
                }

                MessageBox.Show(prikaz);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitavanjeOdeljenja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(8);

                MessageBox.Show("Odeljenje " + o.Naziv + " je " + o.Smer.ToLower() + " smer.");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeOdeljenja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = new Odeljenje()
                {
                    Naziv = "I3",
                    Smer = "INFORMATICKI"

                };

                s.SaveOrUpdate(o);

                s.Flush();
                MessageBox.Show("Odeljenje je dodato!");
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnRoditeljUcenik_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String prikaz1 = "";

                Roditelj r1 = s.Load<Roditelj>(33);

                prikaz1 = r1.Ime+" "+r1.Prezime+" je roditelj deci:"+Environment.NewLine;
                foreach (Ucenik u1 in r1.Deca)
                {
                    prikaz1 += u1.Ime + " " + u1.Prezime+Environment.NewLine;
                }
                prikaz1 += Environment.NewLine;
    
                Ucenik u2 = s.Load<Ucenik>(109);

                prikaz1 += u2.Ime + " " + u2.Prezime + " je dete roditelja:" + Environment.NewLine;

                foreach (Roditelj r2 in u2.Roditelji)
                {
                    prikaz1 += r2.Ime + " " + r2.Prezime + Environment.NewLine;
                }
                MessageBox.Show(prikaz1);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //hasManyToMany bez dodatnih atributa
        private void btnJeRoditelj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(105);
                Roditelj r = s.Load<Roditelj>(28);

                u.Roditelji.Add(r);
                s.Save(u);

                r.Deca.Add(u);
                s.Save(r);

                s.Flush();
                MessageBox.Show("Roditelju " + r.Ime + " " + r.Prezime + " je dodato dete " + u.Ime +" "+u.Prezime+ ".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
       
        private void btnUcitajRazrednog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                string prikaz = "";

                Nastavnik n = s.Load<Nastavnik>(48);

                prikaz += "Nastavnica " + n.Ime + " " + n.Prezime + " je bila razredna odeljenjima:" + Environment.NewLine;

                foreach (JeRazredni i in n.MojaOdeljenja)
                {
                    prikaz += "     Odeljenje: " + i.Id_Odeljenja.Naziv + ", od: " + i.DatumOd.ToShortDateString() + Environment.NewLine;
                }


                Odeljenje o = s.Load<Odeljenje>(8);

                prikaz += Environment.NewLine + "Odeljenju " + o.Naziv + " su bile razredne staresine:" + Environment.NewLine;

                foreach (JeRazredni i in o.RazredneStaresine)
                {
                    prikaz += "    " + i.Id_Nastavnika.Ime + " " + i.Id_Nastavnika.Prezime + Environment.NewLine;
                }
                MessageBox.Show(prikaz);
                s.Close();

                /*
                JeRazredni jr = new JeRazredni();

                jr = s.Load<JeRazredni>(1);


                MessageBox.Show(jr.Id_Nastavnika.Ime+" "+jr.Id_Nastavnika.Prezime+" je razredni starešina odeljenju "+jr.Id_Odeljenja.Naziv+".");
                s.Close();*/
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //hasManyToMany sa dodatnim atributima
        private void btnJeRazredni_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Nastavnik n = s.Load<Nastavnik>(46);
                Odeljenje o = s.Load<Odeljenje>(7);

                JeRazredni jr = new JeRazredni();
                jr.Id_Odeljenja = o;
                jr.Id_Nastavnika = n;
                jr.DatumOd = DateTime.Now;

                s.SaveOrUpdate(jr);

                s.Flush();
                MessageBox.Show("Odeljenju " + o.Naziv + " je dodat razredni staresina " + n.Ime + " " + n.Prezime + ".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(6);


                MessageBox.Show("Učitan je predmet " + p.Naziv + ", opis predmeta: " + p.Opis + ". Broj časova predmeta je " + p.BrojCasova + ", tip predmeta: " + p.TipPredmeta.ToLower() + ".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = new Predmet();
                p.Naziv = "Fizicko";
                p.Opis = "sportsko obrazovanje";
                p.BrojCasova = 3;
                p.TipPredmeta = "OBAVEZNI";
                p.BlokNastava = "NE";
                p.SpecijalanKabinet = "NE";

                s.SaveOrUpdate(p);

                s.Flush();
                MessageBox.Show("Dodat je novi predmet " + p.Naziv+ ", opis predmeta: " + p.Opis + ", broj časova " + p.BrojCasova +", tip predmeta: " +p.TipPredmeta.ToLower()+".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnNastavnikPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                String prikaz1 = "";

                Nastavnik n = s.Load<Nastavnik>(44);

                prikaz1 = "Nastavnik "+n.Ime + " " + n.Prezime + " predaje predmete:" + Environment.NewLine;

                foreach (Predmet p in n.PredajemPredmete)
                {
                    prikaz1 += p.Naziv + ", opis: " + p.Opis + Environment.NewLine;
                }
                prikaz1 += Environment.NewLine;

                Predmet p2 = s.Load<Predmet>(3);

                prikaz1 += "Predmet "+p2.Naziv + " predaju nastavnici :" + Environment.NewLine;

                foreach (Nastavnik n2 in p2.DrzeNastavnici)
                {
                    prikaz1 += n2.Ime + " " + n2.Prezime + Environment.NewLine;
                }
                MessageBox.Show(prikaz1);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjePredaje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nastavnik n = s.Load<Nastavnik>(49);
                Predmet p = s.Load<Predmet>(7);

                n.PredajemPredmete.Add(p);
                s.Save(n);

                p.DrzeNastavnici.Add(n);
                s.Save(p);

                s.Flush();
                MessageBox.Show("Nastavnik " + n.Ime +" "+n.Prezime + " od sada predaje i predmet " + p.Naziv + ".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcenikPredmet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                string prikaz = "";

                Ucenik u = s.Load<Ucenik>(101);

                prikaz += "Ucenik " + u.Ime + " " + u.Prezime + " ima ocene:"+Environment.NewLine;

                foreach(ImaOcenu i in u.Ocene)
                {
                    prikaz += "     Predmet: " + i.Id_Predmeta.Naziv +", tip ocene: "+i.TipOcene.ToLower()+ ", ocena: " + i.Opis.ToLower() + Environment.NewLine;
                }


                Ucenik u2 = s.Load<Ucenik>(103);

                prikaz += Environment.NewLine+"Ucenik " + u2.Ime + " " + u2.Prezime + " ima ocene:" + Environment.NewLine;

                foreach (ImaOcenu i in u2.Ocene)
                {
                    prikaz += "     Predmet: " + i.Id_Predmeta.Naziv + ", tip ocene: " + i.TipOcene.ToLower() + ", ocena: " + i.Vrednost + Environment.NewLine;
                }
                MessageBox.Show(prikaz);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeImaOcenu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik u = s.Load<Ucenik>(116);
                Predmet p = s.Load<Predmet>(7);

                ImaOcenu jo = new ImaOcenu();
                jo.Id_Ucenika = u;
                jo.Id_Predmeta = p;
                jo.TipOcene = "BROJCANA";
                jo.Vrednost = 5;
                jo.Opis = null;

                s.SaveOrUpdate(jo);

                s.Flush();
                MessageBox.Show("Uceniku "+u.Ime+" "+u.Prezime+" je dodata ocena "+jo.Vrednost+" iz " + p.Naziv + ".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajPredstavnika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                string prikaz = "";

                Roditelj r = s.Load<Roditelj>(33);

                prikaz += "Roditelj " + r.Ime + " " + r.Prezime + " je predstavljao odeljenja:" + Environment.NewLine;

                foreach (Predstavlja p in r.PredstavljaoOdeljenja)
                {
                    prikaz += "     Odeljenje: " + p.Id_Odeljenja.Naziv + ", od: " + p.DatumOd.ToShortDateString() + Environment.NewLine;
                }


                Odeljenje o = s.Load<Odeljenje>(7);

                prikaz += Environment.NewLine + "Odeljenje " + o.Naziv + " su predstavljali:" + Environment.NewLine;

                foreach (Predstavlja p in o.Predstavnici)
                {
                    prikaz += "     " + p.Id_Roditelja.Ime + " " + p.Id_Roditelja.Prezime + Environment.NewLine;
                }
                MessageBox.Show(prikaz);
                s.Close();

                /*Predstavlja pr = new Predstavlja();

                pr = s.Load<Predstavlja>(9);
                MessageBox.Show(pr.Id_Roditelja.Ime + " " + pr.Id_Roditelja.Prezime + " je predstavljao odeljenje " + pr.Id_Odeljenja.Naziv + ".");
                s.Close();*/
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnPredstavlja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Roditelj r = s.Load<Roditelj>(33);
                Odeljenje o = s.Load<Odeljenje>(8);

                Predstavlja pr = new Predstavlja();
                pr.Id_Odeljenja = o;
                pr.Id_Roditelja = r;
                pr.DatumOd = DateTime.Now;

                s.SaveOrUpdate(pr);

                s.Flush();
                MessageBox.Show("Novi predstavnik odeljenja " + o.Naziv + " je " + r.Ime + " " + r.Prezime + ".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajRaspored_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                string prikaz = "";

                Predmet p = s.Load<Predmet>(4);

                prikaz += "Predmet " + p.Naziv + " se drži po rasporedu: " + Environment.NewLine;

                foreach (Raspored r in p.SeDrzePoRasporedu)
                {
                    prikaz += "     Odeljenje: " + r.Id_Odeljenja.Naziv +" "+r.Dan.ToLower() +" "+ r.Cas +". cas."+ Environment.NewLine;
                }


                Odeljenje o = s.Load<Odeljenje>(7);

                prikaz += Environment.NewLine + "Odeljenje " + o.Naziv + " ima raspored časova:" + Environment.NewLine;

                foreach (Raspored r in o.RasporedCasova)
                {
                    prikaz += "     " + r.Id_Predmeta.Naziv + " "+ r.Dan.ToLower()+" "+r.Cas+". cas." + Environment.NewLine;
                }
                MessageBox.Show(prikaz);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnRaspored_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(5);
                Odeljenje o = s.Load<Odeljenje>(8);

                Raspored rs = new Raspored();
                rs.Id_Odeljenja = o;
                rs.Id_Predmeta = p;
                rs.Dan = "CETVRTAK";
                rs.Cas = 3;

                s.SaveOrUpdate(rs);

                s.Flush();
                MessageBox.Show("U odeljenju " + o.Naziv + " se od sada drži " + p.Naziv + " u terminu " + rs.Dan.ToLower() + " "+rs.Cas+". cas.");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnBrojTelefona_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(33);

                string prikaz = "Korisnik " + k.Ime + " " + k.Prezime + " ima brojeve telefona:" + Environment.NewLine;
                foreach (BrojTelefona br in k.Brojevi)
                    prikaz += "   " + br.BrojTelefonaKorisnika + Environment.NewLine;
                MessageBox.Show(prikaz);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnGodina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Load<Predmet>(4);

                string prikaz = "Predmet " + p.Naziv + " se drži na ";
                foreach (Godina g in p.NaGodini)
                    prikaz += g.NaGodini + ". ";
                MessageBox.Show(prikaz + "godini.");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnFunkcija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Roditelj r = s.Load<Roditelj>(33);
                string prikaz = "Roditelj " + r.Ime + " " + r.Prezime + " je vršio funkciju: " + Environment.NewLine;
                foreach (Funkcija f in r.FunkcijeKojeJeVrsio)
                    prikaz += "   " + f.Tip.ToLower()+ " od "+f.DatumOd.ToShortDateString()+ " do "+f.DatumDo.ToShortDateString() + Environment.NewLine;
                MessageBox.Show(prikaz);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDrziCas_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje o = s.Load<Odeljenje>(1);

                string prikaz = "U odeljenju " + o.Naziv + " profesori drže predmete:"+ Environment.NewLine;
                foreach (DrziCas dr in o.PredajuPredmete)
                    prikaz += "   " + dr.Id_Nastavnika.Ime+ " "+dr.Id_Nastavnika.Prezime +" "+dr.Id_Predmeta.Naziv+ Environment.NewLine;
                MessageBox.Show(prikaz);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnKreiranjeUcenika_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Ucenik k = new Ucenik();
                Odeljenje o = s.Load<Odeljenje>(1); 

                k.Ime = "Novak";
                k.Prezime = "Novakovic";
                k.DatumRodjenja = DateTime.Parse("10-01-1999");
                k.JMBG = "1001999742015";
                k.Pol = 'M';
                k.Username = "novak999";
                k.Password = "novakovic999";
                k.FAdministrator = 0;
                k.FNastavnik = 0;
                k.FRoditelj = 0;
                k.FUcenik = 1;
                k.PripadaOdeljenju = o;
                k.BrOpravdanih = 7;
                k.BrNeopravdanih = 2;
                k.OcenaVladanje = 5;

                o.Ucenici.Add(k);

                s.SaveOrUpdate(k);

                s.Flush();
                MessageBox.Show("Dodat je učenik: "+k.Ime+" "+k.Prezime+".");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //pribavljanje korisnika preko upita QueryOver
        private void btnInheritance_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Korisnik> korisnici = s.QueryOver<Korisnik>()
                                                .Where(k => k.Id == 102)
                                                .List<Korisnik>();

                Ucenik u = (Ucenik)korisnici[0];

                MessageBox.Show("Učitan korisnik je učenik!");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //pribavljanje korisnika i kastovanje u odredjenu podklasu
        private void btnTPC_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Korisnik> neznani = s.QueryOver<Korisnik>()
                    .List<Korisnik>();

                foreach (Korisnik k in neznani)
                {
                    if (k.GetType() == typeof(NastavnikRoditelj))
                    {
                        NastavnikRoditelj nasrod = (NastavnikRoditelj)k;
                        MessageBox.Show("Učitan korisnik je nastavnik i roditelj!");
                    }
                    else if (k.GetType() == typeof(Nastavnik))
                    {
                        Nastavnik nas = (Nastavnik)k;
                        MessageBox.Show("Učitan korisnik je nastavnik!");
                    }
                    else if (k.GetType() == typeof(Roditelj))
                    {
                        Roditelj rod = (Roditelj)k;
                        MessageBox.Show("Učitan korisnik je roditelj!");
                    }
                    else if (k.GetType() == typeof(Ucenik))
                    {
                        Ucenik uce = (Ucenik)k;
                        MessageBox.Show("Učitan korisnik je učenik!");
                    }
                    else
                    {
                        Administrator adm = (Administrator)k;
                        MessageBox.Show("Učitan korisnik je administrator!");
                    }

                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        // pribavljanje odredjenog predmeta i prikaz min br ucenika ako ako postoji, koristi se GET kad nije sigurno da li postoji
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Godina g = s.Get<Godina>(21);

                if (g != null)
                {
                    MessageBox.Show("Minimalni broj učenika koji je potreban da bi se držala nastava iz predmeta "+g.PredmeT.Naziv+" je: "+g.PredmeT.MinBrojUcenika+".");
                }
                else
                {
                    MessageBox.Show("Traženi predmet ne postoji na godini.");
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        // REFRESH sluzi za ponovno pribavljanje podatka iz baze
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet p = s.Get<Predmet>(5);

                s.Refresh(p);
                MessageBox.Show("Traženi predmet je: " + p.Naziv);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        // QUERY upit sa pridodatim where uslovom
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Odeljenja koja nemaju info pult
                IQuery q = s.CreateQuery("from Predmet as p where p.TipPredmeta = 'IZBORNI'");

                IList<Predmet> pred = q.List<Predmet>();

                string prikaz = "Izborni predmeti su:"+Environment.NewLine;
                foreach (Predmet pr in pred)
                {
                    prikaz +="   "+pr.Naziv+Environment.NewLine;
                }

                MessageBox.Show(prikaz);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}