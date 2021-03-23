using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Parking_web
{
    public partial class Logovanje : System.Web.UI.Page
    {
        public string korisnickoIme = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM korisnici";
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string user = korisnickoLog.Value.ToString();
                        string pass = lozinkaLog.Value.ToString();
                        if (user == myReader.GetString(2) && pass == myReader.GetString(3))
                        {
                            korisnickoIme = user;
                            Session["Korisnik"] = korisnickoIme;
                            Response.Redirect("Rezervacije.aspx");
                        }
                    }
                }
                databaseConnection.Close();

                Response.Write("<script language=javascript>alert('Greška prilikom logovanja! Unesite validne podatke.')</script>");


                //string script = "<script type = 'text/javascript'>alert('Greška prilikom logovanja. Proverite unete podatke!');</script>";
                //ClientScript.RegisterClientScriptBlock(this.GetType(),"alert",script);

                //za pogresno logovanje
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:logovanje_korisnika" + ex);
            }
        }

 
        protected void Registracija_Click(object sender, EventArgs e)
        {
          
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection("datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO");
            try
            {
                if (!string.IsNullOrEmpty(first_name.Value.ToString()) && !string.IsNullOrEmpty(last_name.Value.ToString()) && !string.IsNullOrEmpty(email.Value.ToString()) && !string.IsNullOrEmpty(korisnickoReg.Value.ToString()) && !string.IsNullOrEmpty(lozinkaReg.Value.ToString()))
                {
                    con.Open();
                    string imeprez = first_name.Value.ToString() + " " + last_name.Value.ToString();
                    string emailReg = email.Value.ToString();
                    string korisnickoR = korisnickoReg.Value.ToString();
                    string lozinkaR = lozinkaReg.Value.ToString();

                    cmd = new MySqlCommand("INSERT INTO korisnici(ImePrezime, Email, KorisnickoIme, Lozinka) VALUES (?ImePrezime, ?Email, ?KorisnickoIme, ?Lozinka)", con);
                    cmd.Parameters.AddWithValue("?ImePrezime", imeprez);
                    cmd.Parameters.AddWithValue("?Email", emailReg);
                    cmd.Parameters.AddWithValue("?KorisnickoIme", korisnickoR);
                    cmd.Parameters.AddWithValue("?Lozinka", lozinkaR);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    Response.Redirect("Glavna.aspx", false);
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Greška pri registrovanju! Unesite validne podatke.')</script>");
                }
                   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:logovanje_korisnika" + ex);
            }

           
        }

       
    }
}