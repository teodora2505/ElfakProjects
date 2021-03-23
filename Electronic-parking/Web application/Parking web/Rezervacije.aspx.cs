using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Parking_web
{
    public partial class Rezervacije : System.Web.UI.Page
    {
        public string ulogovaniKorisnik;

        protected void Page_Load(object sender, EventArgs e)
        {
            ulogovaniKorisnik = Session["Korisnik"].ToString();
            vratiUlogovanogKorisnika(ulogovaniKorisnik);
            this.ucitajCene();
            krajLabela.InnerHtml = "";
        }

        protected void Button1_Click(object sender, EventArgs e)  //produzenje
        {
            Produzenje();          
        }

        public void Produzenje()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection("datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO");
            List<string> lista = this.CitajReg();
            bool fleg = false;
            foreach (string registracija in lista)
            {
                if ( Request["tablice"] == registracija)
                {
                    fleg = true;
                    break;
                }
            }
            try
            {
                con.Open();
                if (fleg == true && UslugaOp.SelectedIndex > -1)
                {
                    int usluga1 = 0;
                    if (UslugaOp.Items[UslugaOp.SelectedIndex].Text == "Jednočasovna")
                    {
                        usluga1 = 1;
                    }
                    else if (UslugaOp.Items[UslugaOp.SelectedIndex].Text == "Poludnevna")
                    {
                        usluga1 = 12;
                    }
                    else if (UslugaOp.Items[UslugaOp.SelectedIndex].Text == "Dnevna")
                    {
                        usluga1 = 24;
                    }
                    else if (UslugaOp.Items[UslugaOp.SelectedIndex].Text == "Nedeljna")
                    {
                        usluga1 = 168;
                    }
                    else if (UslugaOp.Items[UslugaOp.SelectedIndex].Text == "Mesečna")
                    {
                        usluga1 = 720;
                    }

                    List<Object> lista1 = new List<Object>();
                    lista1 = vratiVoziloInfo(Request["tablice"]);
                    int garaza = (int)lista1[0];
                    int mesto = (int)lista1[1];
                    string tip = (string)lista1[2];
                    int invalid = (int)lista1[3];
                    string reg = (string)lista1[4];
                    DateTime poc = (DateTime)lista1[5];
                    DateTime kraj = (DateTime)lista1[6];
                    int usluga = (int)lista1[7];
                    int racun = (int)lista1[8];

                    DateTime kraj1 = kraj;
                    kraj = kraj.AddHours(usluga1);
                    usluga = usluga1;
                    int cenaUsluge = vratiCenuUsluge(usluga, tip);
                    racun += cenaUsluge;

                    izmeniVozilo(garaza, mesto, garaza, mesto, tip, invalid, reg, poc.ToString("yyyy-MM-dd H:mm:ss"), kraj.ToString("yyyy-MM-dd H:mm:ss"), usluga, racun);
                    dodajVoziloIstorija(garaza, mesto, tip, invalid, reg, kraj1.ToString("yyyy-MM-dd H:mm:ss"), kraj.ToString("yyyy-MM-dd H:mm:ss"), usluga, cenaUsluge);
                    Response.Write("<script language=javascript>alert('Uspešno produženje usluge parkiranja!')</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Nije moguće produženje parkiranja. Proverite unete podatke!')</script>");
                }
                
                con.Close();
                tablice.Value = "";
                UslugaOp.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska" + e);
            }
        }

        public List<string> CitajReg()
        {
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM parking", con);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> lista = new List<string>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(4));
                    }
                }
                con.Close();
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska" + e);
                return null;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)  //email
        {
            try
            {
                string to = "milan.janjic998@gmail.com";
                string from = email.Value.ToString(); //From address  
                string pass = password.Value.ToString();
                MailMessage message = new MailMessage(from, to);

                string mailbody = message1.Value.ToString();
                message.Subject = subject.Value.ToString();
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential(from, pass);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                email.Value = "";
                password.Value = "";
                name.Value = "";
                message1.Value = "";
                subject.Value = "";
            
                client.Send(message);
            }

            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('E-mail nije uspešno poslat! Pokušajte ponovo!')</script>");
                Console.WriteLine("Greska" + ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)  //rezervacije
        {
            MySqlCommand cmd = new MySqlCommand();
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);

            string tablica;
            string tipVozila;
            int usluga=0;
            int garaza;
            int mesto;
            DateTime datumVreme = new DateTime();

            List<DateTime?> datumiZavrsetka = new List<DateTime?>();            

            try
            {
                garaza = garazaR.SelectedIndex;
                DateTime datum = DateTime.Parse(datumR.Value.ToString());
                TimeSpan vreme = TimeSpan.Parse(vremeR.Value.ToString());
                datumVreme = datum + vreme;

                switch (uslugaR.SelectedIndex)
                {
                    case 1: usluga = 1; break;
                    case 2: usluga = 12; break;
                    case 3: usluga = 24; break;
                    case 4: usluga = 168; break;
                    case 5: usluga = 720; break;
                }

                datumiZavrsetka = vratiKrajTrenutnoParkiranihVozila(garaza);
                bool pronadjenoMesto = false;
                int i = 0;
                while (pronadjenoMesto == false)
                {
                    if (datumiZavrsetka[i] != null)
                    {
                        if (datumiZavrsetka[i] < datumVreme)
                            pronadjenoMesto = true;
                        else
                            pronadjenoMesto = false;
                    }
                    else
                        pronadjenoMesto = true;

                    if (pronadjenoMesto == true)
                    {
                        List<DateTime> list1 = new List<DateTime>(32);
                        List<int> list2 = new List<int>();

                        list1 = vratiPocetakRezervacije(garaza, i + 1); //pocetke parkiranja svake rezervacije za to mesto
                        list2 = vratiUslugaRezervacije(garaza,i+1); //usluge svake rezervacije
                        if (list1!=null)
                        {
                            for (int j = 0; j < list1.Count; j++)
                            {
                                DateTime zavrsetakParkiranjaRezervacije = list1[j].AddHours(list2[j]);
                                if (datumVreme > zavrsetakParkiranjaRezervacije && datumVreme.AddHours(usluga) < list1[j])
                                {

                                }
                                else
                                    pronadjenoMesto = false;
                            }
                        }
                    }
                        i++;
                }

                mesto = i;
                if (pronadjenoMesto == true)
                {
                    if (tipVozilaR.SelectedIndex > -1 && uslugaR.SelectedIndex > -1 && garazaR.SelectedIndex > -1)
                    {
                        tipVozila = tipVozilaR.Items[tipVozilaR.SelectedIndex].Text.ToLower();
                        tablica = tabliceR.Value.ToString();

                        con.Open();

                        cmd = new MySqlCommand("INSERT INTO rezervacije(id,gar,mesto,tip,reg,termin,usluga) VALUES (null,?garaza,?mesto,?tipVozila,?tablica,?datumVreme,?usluga)", con);
                        cmd.Parameters.AddWithValue("?garaza", garaza);
                        cmd.Parameters.AddWithValue("?mesto", mesto);
                        cmd.Parameters.AddWithValue("?tipVozila", tipVozila);
                        cmd.Parameters.AddWithValue("?tablica", tablica);
                        cmd.Parameters.AddWithValue("?datumVreme", datumVreme);
                        cmd.Parameters.AddWithValue("?usluga", usluga);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        Response.Write("<script language=javascript>alert('Rezervacija je uspešno izvršena!')</script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('Nije moguće izvršiti rezervaciju!')</script>");
                    }
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Nije moguće izvršiti rezervaciju!')</script>");
                    //ovde ide obavestenje o nemogucem izvrsenju rezervacije
                }
                garazaR.SelectedIndex = -1;
                tipVozilaR.SelectedIndex = -1;
                tabliceR.Value = "";    
                uslugaR.SelectedIndex = -1;
                datumR.Value = "";
                vremeR.Value = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('Nije moguće izvršiti rezervaciju. Unesite potrebne podatke!')</script>");
                garazaR.SelectedIndex = -1;
                tipVozilaR.SelectedIndex = -1;
                tabliceR.Value = "";
                uslugaR.SelectedIndex = -1;
                datumR.Value = "";
                vremeR.Value = "";
                Console.WriteLine("Greska" + ex);
            }
        }

        public List<DateTime?> vratiKrajTrenutnoParkiranihVozila(int garaza)
        {
            string query = "SELECT * FROM parking WHERE BrGaraze=" + garaza + ";";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<DateTime?> lista = new List<DateTime?>(32);
            DateTime? KrajParkiranja = null;
            for (int i = 0; i < 32; i++)
            {
                lista.Add(null);
            }

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        int pmesto = myReader.GetInt32(1);
                        KrajParkiranja = myReader.GetDateTime(6);
                        lista[pmesto - 1] = KrajParkiranja;
                    }
                }

                databaseConnection.Close();
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:parkiranaVozila" + e);
                return null;
            }
        }

        public List<DateTime> vratiPocetakRezervacije(int garaza, int mesto)
        {
            string query = "SELECT * FROM rezervacije WHERE gar=" + garaza + " AND mesto = " + mesto + ";";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<DateTime> lista = new List<DateTime>();

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        lista.Add(myReader.GetDateTime(5));
                    }
                }

                databaseConnection.Close();
                if (lista.Count > 0)
                    return lista;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:parkiranaVozila" + e);
                return null;
            }
        }

        public List<int> vratiUslugaRezervacije(int garaza, int mesto)
        {
            string query = "SELECT * FROM rezervacije WHERE gar=" + garaza + " AND mesto = " + mesto + ";";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<int> lista = new List<int>();

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        lista.Add(myReader.GetInt32(6));
                    }
                }

                databaseConnection.Close();
                if (lista.Count > 0)
                    return lista;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:parkiranaVozila" + e);
                return null;
            }
        }

        public bool izmeniVozilo(int starag, int starom, int garaza, int parkingMesto, string tipVozila, int invalid, string registracija, string pocetak, string kraj, int usluga, int racun)
        {
            try
            {
                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "update parking set BrGaraze='" + garaza + "',ParkingMesto='" + parkingMesto + "',TipVozila='" + tipVozila + "',Invalid='" + invalid + "',RegTab='" + registracija + "',PocetakParkiranja='" + pocetak + "',KrajParkiranja='" + kraj + "',usluga='" + usluga + "',racun='" + racun + "'where BrGaraze='" + starag + "' AND ParkingMesto='" + starom + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
               
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:nepostojeciKorisnik" + ex);
                return false;
            }

        }

        public List<Object> vratiVoziloInfo(string registracija)
        {
            string query = "SELECT * FROM parking ";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<Object> lista = new List<Object>();

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        if (myReader.GetString(4) == registracija)
                        {
                            int garaza = myReader.GetInt32(0);
                            lista.Add((Object)garaza);
                            int mesto = myReader.GetInt32(1);
                            lista.Add((Object)mesto);
                            string tip = myReader.GetString(2);
                            lista.Add((Object)tip);
                            int invalid = myReader.GetInt32(3);
                            lista.Add((Object)invalid);
                            string reg = myReader.GetString(4);
                            lista.Add((Object)reg);
                            DateTime poc = myReader.GetDateTime(5);
                            lista.Add((Object)poc);
                            DateTime kraj = myReader.GetDateTime(6);
                            lista.Add((Object)kraj);
                            int usluga = myReader.GetInt32(7);
                            lista.Add((Object)usluga);
                            int racun = myReader.GetInt32(8);
                            lista.Add((Object)racun);
                        }
                    }
                }
                databaseConnection.Close();
                if (lista.Count > 0)
                    return lista;
                else
                    return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:parkiranaVozila" + e);
                return null;
            }
        }

        public int vratiCenuUsluge(int usluga, string tip)
        {
            string nazivUsluge = usluga + "h" + tip;
            string query = "SELECT * FROM cene ";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            int cena = 0;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        if(myReader.GetString(0)==nazivUsluge)
                            cena = myReader.GetInt32(1);
                    }
                }

                databaseConnection.Close();
                return cena;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog" + e);
                return 0;
            }
        }

        public void ucitajCene()
        {
            string query = "SELECT * FROM cene";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<string> usluga = new List<string>();
            List<int> cena = new List<int>();

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        usluga.Add(myReader.GetString(0));
                        cena.Add(myReader.GetInt32(1));
                    }
                }
                databaseConnection.Close();

                if (cena.Count > 0)
                {
                    auto1h.InnerHtml = cena[0].ToString();
                    auto12h.InnerHtml = cena[1].ToString();
                    auto24h.InnerHtml = cena[2].ToString();
                    auto168h.InnerHtml = cena[3].ToString();
                    auto720h.InnerHtml = cena[4].ToString();
                    autobus1h.InnerHtml = cena[5].ToString();
                    autobus12h.InnerHtml = cena[6].ToString();
                    autobus24h.InnerHtml = cena[7].ToString();
                    autobus168h.InnerHtml = cena[8].ToString();
                    autobus720h.InnerHtml = cena[9].ToString();
                    kamion1h.InnerHtml = cena[10].ToString();
                    kamion12h.InnerHtml = cena[11].ToString();
                    kamion24h.InnerHtml = cena[12].ToString();
                    kamion168h.InnerHtml = cena[13].ToString();
                    kamion720h.InnerHtml = cena[14].ToString();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:parkiranaVozila" + e);
            }
        }

        public void dodajVoziloIstorija(int garaza, int parkingMesto, string tipVozila, int invalid, string registracija, string pocetak, string kraj, int usluga, int racun)
        {
            try
            {
                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "insert into parkingistorija(BrGaraze,ParkingMesto,TipVozila,Invalid,RegTab,PocetakParkiranja,KrajParkiranja,Usluga,racun) "
                + "values('" + garaza + "','" + parkingMesto + "','" + tipVozila + "','" + invalid + "','" + registracija + "','" + pocetak + "','"
                + kraj + "','" + usluga + "','" + racun + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:nepostojeciKorisnik" + ex);
            }
        }

        public void vratiUlogovanogKorisnika(string ulKorisnik)
        {
            //string query = "SELECT * FROM korisnici WHERE KorisnickoIme=" + ulKorisnik + ";";
            string query = "SELECT * FROM korisnici ";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            string imePrez = "";

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        if(myReader.GetString(2)==ulKorisnik)
                            imePrez = myReader.GetString(0);
                    }
                }
                databaseConnection.Close();
                korisnikImePrez.InnerHtml ="Korisnik: "+ imePrez;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:nepostojeciKorisnik" + e);             
            }
        }

        protected void btnKrajParkiranja_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM parking", con);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();              
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(4).ToLower() == regKraj.Value.ToString().ToLower())
                            krajLabela.InnerHtml = "Kraj parkiranja: "+reader.GetDateTime(6).ToString();
                    }
                }
                con.Close();

                if (krajLabela.InnerHtml == "")
                {
                    krajLabela.InnerHtml = "Izabrano vozilo nije trenutno parkirano.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska" + ex);             
            }
        }
    }
}