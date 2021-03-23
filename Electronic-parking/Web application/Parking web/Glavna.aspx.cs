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
    public partial class Glavna : System.Web.UI.Page
    {        

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ucitajCene();
            this.ucitajPopuste();
            this.SlobodnaMesta();
            Session["Korisnik"] = "";
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

        public void ucitajPopuste()
        {
         
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cene WHERE snizenje=1",con);
            cmd.CommandType = System.Data.CommandType.Text;

            string temp = "";
            string bus = "";
            string track = "";
           
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        if (reader.GetString(0) == "1hautomobil")
                        {
                            temp += "Jednočasovna";
                            temp += " "+reader.GetInt32(1);
                            temp += " "+reader.GetInt32(3);
                            temp += "%";
                            temp += "<br/>";
                            temp += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "12hautomobil")
                        {
                            temp += "Poludnevna";
                            temp += " "+reader.GetInt32(1);
                            temp += " "+reader.GetInt32(3);
                            temp += "%";
                            temp += "<br/>";
                            temp += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "24hautomobil")
                        {
                            temp += "Dnevna";
                            temp += " " + reader.GetInt32(1);
                            temp += " " + reader.GetInt32(3);
                            temp += "%";
                            temp += "<br/>";
                            temp += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "168hautomobil")
                        {
                            temp += "Nedeljna";
                            temp += " " + reader.GetInt32(1);
                            temp += " " + reader.GetInt32(3);
                            temp += "%";
                            temp += "<br/>";
                            temp += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "720hautomobil")
                        {
                            temp += "Mesečna";
                            temp += " " + reader.GetInt32(1);
                            temp += " " + reader.GetInt32(3);
                            temp += "%";
                            temp += "<br/>";
                            temp += "<br/>";
                        }
                        else
                             if (reader.GetString(0) == "1hautobus")
                        {
                            bus += "Jednočasovna";
                            bus += " " + reader.GetInt32(1);
                            bus += " " + reader.GetInt32(3);
                            bus += "%";
                            bus += "<br/>";
                            bus += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "12hautobus")
                        {
                            bus += "Poludnevna";
                            bus += " " + reader.GetInt32(1);
                            bus += " " + reader.GetInt32(3);
                            bus += "%";
                            bus += "<br/>";
                            bus += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "24hautobus")
                        {
                            bus += "Dnevna";
                            bus += " " + reader.GetInt32(1);
                            bus += " " + reader.GetInt32(3);
                            bus += "%";
                            bus += "<br/>";
                            bus += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "168hautobus")
                        {
                            bus += "Nedeljna";
                            bus += " " + reader.GetInt32(1);
                            bus += " " + reader.GetInt32(3);
                            bus += "%";
                            bus += "<br/>";
                            bus += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "720hautobus")
                        {
                            bus += "Mesečna";
                            bus += " " + reader.GetInt32(1);
                            bus += " " + reader.GetInt32(3);
                            bus += "%";
                            bus += "<br/>";
                            bus += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "1hkamion")
                        {
                            track += "Jednočasovna";
                            track += " " + reader.GetInt32(1);
                            track += " " + reader.GetInt32(3);
                            track += "%";
                            track += "<br/>";
                            track += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "12hkamion")
                        {
                            track += "Poludnevna";
                            track += " " + reader.GetInt32(1);
                            track += " " + reader.GetInt32(3);
                            track += "%";
                            track += "<br/>";
                            track += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "24hkamion")
                        {
                            track += "Dnevna";
                            track += " " + reader.GetInt32(1);
                            track += " " + reader.GetInt32(3);
                            track += "%";
                            track += "<br/>";
                            track += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "168hkamion")
                        {
                            track += "Nedeljna";
                            track += " " + reader.GetInt32(1);
                            track += " " + reader.GetInt32(3);
                            track += "%";
                            track += "<br/>";
                            track += "<br/>";
                        }
                        else
                        if (reader.GetString(0) == "720hkamion")
                        {
                            track += "Mesečna";
                            track += " " + reader.GetInt32(1);
                            track += " " + reader.GetInt32(3);
                            track += "%";
                            track += "<br/>";
                            track += "<br/>";

                        }
                    }
                }

                Label1.InnerHtml = "<br/>"+ temp;
                LabelBus.InnerHtml = "<br/>"+ bus;
                LabelTruck.InnerHtml = "<br/>"+track;

                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska" + e);
            }

         
          }

        public void SlobodnaMesta()
        {

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection con = new MySqlConnection(MySQLConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM parking", con);
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                int g1a = 0;
                int g1ia = 0;
                int g1k = 0;
                int g1b = 0;
                int g2a = 0;
                int g2ia = 0;
                int g2b = 0;
                int g2k = 0;
                int g3a = 0, g3ia = 0, g3b = 0, g3k = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        /////G1
                        if (reader.GetInt32(0) == 1 && reader.GetString(2) == "automobil" && reader.GetInt32(3) == 0)
                        {
                            g1a++;
                        }

                        Td1.InnerHtml = (20 - g1a).ToString();

                        if (reader.GetInt32(0) == 1 && reader.GetString(2) == "automobil" && reader.GetInt32(3) == 1)
                        {
                            g1ia++;
                        }
                        Td2.InnerHtml = (4 - g1ia).ToString();

                        if (reader.GetInt32(0) == 1 && reader.GetString(2) == "autobus")
                        {
                            g1b++;
                        }                    

                        if (reader.GetInt32(0) == 1 && reader.GetString(2) == "kamion")
                        {
                            g1k++;
                        }
                        Td3.InnerHtml = (8 - g1b-g1k).ToString();
                        Td4.InnerHtml = (8 - g1k-g1b).ToString();
                        ////G2

                        if (reader.GetInt32(0) == 2 && reader.GetString(2) == "automobil" && reader.GetInt32(3) == 0)
                        {
                            g2a++;
                        }

                        Td5.InnerHtml = (20 - g2a).ToString();

                        if (reader.GetInt32(0) == 2 && reader.GetString(2) == "automobil" && reader.GetInt32(3) == 1)
                        {
                            g2ia++;
                        }
                        Td6.InnerHtml = (4 - g2ia).ToString();

                        if (reader.GetInt32(0) == 2 && reader.GetString(2) == "autobus")
                        {
                            g2b++;
                        }
                        
                        if (reader.GetInt32(0) == 2 && reader.GetString(2) == "kamion")
                        {
                            g2k++;
                        }
                        Td7.InnerHtml = (8 - g2b-g2k).ToString();
                        Td8.InnerHtml = (8 - g2k-g2b).ToString();
                        ////G3

                        if (reader.GetInt32(0) == 3 && reader.GetString(2) == "automobil" && reader.GetInt32(3) == 0)
                        {
                            g3a++;
                        }

                        Td9.InnerHtml = (20 - g3a).ToString();

                        if (reader.GetInt32(0) == 3 && reader.GetString(2) == "automobil" && reader.GetInt32(3) == 1)
                        {
                            g3ia++;
                        }
                        Td10.InnerHtml = (4 - g3ia).ToString();

                        if (reader.GetInt32(0) == 3 && reader.GetString(2) == "autobus")
                        {
                            g3b++;
                        }                        

                        if (reader.GetInt32(0) == 3 && reader.GetString(2) == "kamion")
                        {
                            g3k++;
                        }
                        Td11.InnerHtml = (8 - g3b-g3k).ToString();
                        Td12.InnerHtml = (8 - g3k-g3b).ToString();

                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska" + e);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
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

        protected void btnRezervisi_Click(object sender, EventArgs e)
        {
            Response.Redirect("Logovanje.aspx");
        }
    }
}