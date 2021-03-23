using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//Elektronski Parking Sistem.Podaci mora biti Class of Library, inace greska:"program does not contain a static main method" :D

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Baza
    {
        public string provera_zaposlenog(string user, string pass)
        {
            string query = "SELECT * FROM zaposleni";
           

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
                        if(user==myReader.GetString(0) && pass==myReader.GetString(1))
                        {
                            string pozicija = myReader.GetString(2);
                            databaseConnection.Close();
                            return pozicija; //vraca "menadzer" ili "radnik"
                        }
                    }
                }

                databaseConnection.Close();
                return null;//za pogresno logovanje
                


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog"+e);
                return null;
            }
        }

        public bool provera_username(string user)
        {
            string query = "SELECT * FROM zaposleni";


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
                        if (user == myReader.GetString(0) )
                        {
                            return false;
                        }
                    }
                }

                databaseConnection.Close();
                return true;


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog" + e);
                return false;
            }
        }

        public List<ParkingMesto> parkiranaVozila()
        {
            string query = "SELECT * FROM parking";

            List<ParkingMesto> lista = new List<ParkingMesto>();
            ParkingMesto p;

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
                        p = new ParkingMesto();

                        p.BrGaraze = myReader.GetInt32(0);
                        p.Broj = myReader.GetInt32(1);
                        p.Vozilo.TipVozila = myReader.GetString(2);

                        if(myReader.GetInt32(3)==1)
                            p.Vozilo.DalijeInvalidsko = true;
                        else
                            p.Vozilo.DalijeInvalidsko = false;

                        p.Vozilo.RegTab = myReader.GetString(4);
                        p.Vozilo.PocetakParkiranja = myReader.GetDateTime(5);
                        p.Vozilo.KrajParkiranja = myReader.GetDateTime(6);
                        p.Vozilo.UslugaParkingServisa = myReader.GetInt32(7);
                        p.Vozilo.Racun = myReader.GetInt32(8);

                        lista.Add(p);
                        
                    }
                }

                databaseConnection.Close();
                if (lista.Count>0)
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

        public List<ParkingMesto> istorijaParkiranja()
        {
            string query = "SELECT * FROM parkingistorija";

            List<ParkingMesto> lista = new List<ParkingMesto>();
            ParkingMesto p;

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
                        p = new ParkingMesto();

                        p.BrGaraze = myReader.GetInt32(0);
                        p.Broj = myReader.GetInt32(1);
                        p.Vozilo.TipVozila = myReader.GetString(2);

                        if (myReader.GetInt32(3) == 1)
                            p.Vozilo.DalijeInvalidsko = true;
                        else
                            p.Vozilo.DalijeInvalidsko = false;

                        p.Vozilo.RegTab = myReader.GetString(4);
                        p.Vozilo.PocetakParkiranja = myReader.GetDateTime(5);
                        p.Vozilo.KrajParkiranja = myReader.GetDateTime(6);
                        p.Vozilo.UslugaParkingServisa = myReader.GetInt32(7);
                        p.Vozilo.Racun = myReader.GetInt32(8);

                        lista.Add(p);

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

        public bool dodajRadnika(string user, string pass,string pozicija)
        {
            if(this.provera_zaposlenog(user,pass)==null && this.provera_username(user)==true)
            {
                try
                {
                    
                    string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                    string Query = "insert into zaposleni(username,password,pozicija) values('" + user + "','" + pass + "','" + pozicija + "');";
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
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool obrisiRadnika(string user,string pass)
        {
            if (this.provera_zaposlenog(user, pass) != null)
            {
                try
                {

                    string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                    string Query = "delete from zaposleni where username='" + user + "' AND password='" +pass+ "';";
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
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool izmeniRadnika(string user, string pass, string userNovi, string passNovi, string pozicija)
        {
            if(this.provera_zaposlenog(user,pass)!=null)
            {
                try
                {
                    string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                    string Query = "update zaposleni set username='" + userNovi + "',password='" + passNovi+ "',pozicija='"+pozicija+"' where username='" + user + "' AND password='" + pass + "';";
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
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool dodajVozilo(int garaza, int parkingMesto, string tipVozila, int invalid, string registracija, string pocetak, string kraj, int usluga, int racun)
        {
                try
                {

                    string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                
                    string Query = "insert into parking(BrGaraze,ParkingMesto,TipVozila,Invalid,RegTab,PocetakParkiranja,KrajParkiranja,Usluga,racun) "
                    +"values('" + garaza + "','" + parkingMesto + "','" + tipVozila + "','" + invalid + "','" +registracija + "','" +pocetak + "','" 
                    +kraj + "','" +usluga+ "','" +racun+ "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    //zatim arhiviramo dodavanje u istoriju
                    this.dodajVoziloIstorija(garaza, parkingMesto, tipVozila, invalid, registracija, pocetak, kraj, usluga, racun);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
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
                
            }
        }

        public bool izmeniVozilo(int starag, int starom,int garaza, int parkingMesto, string tipVozila, int invalid, string registracija, string pocetak, string kraj, int usluga, int racun)
        {

            try
            {
                string bla = "";

                if (invalid == 70 || invalid == 71)
                {
                    bla = "ne menjaj vozio u istoriji";
                    invalid -= 70;
                }

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
                //izvrsimo izmenu i u istoriji, jer se podrazumeva da je izmena zbog pogresno unetih informacija,izmena same usluge ako se predomisli

                if(bla!= "ne menjaj vozio u istoriji")
                    this.izmeniVoziloIstorija(starag,starom,garaza, parkingMesto, tipVozila, invalid, registracija, pocetak, kraj, usluga, racun);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public void izmeniVoziloIstorija(int starag, int starom, int garaza, int parkingMesto, string tipVozila, int invalid, string registracija, string pocetak, string kraj, int usluga, int racun)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "update parkingistorija set BrGaraze='" + garaza + "',ParkingMesto='" + parkingMesto + "',TipVozila='" + tipVozila + "',Invalid='" + invalid + "',RegTab='" + registracija + "',PocetakParkiranja='" + pocetak + "',KrajParkiranja='" + kraj + "',usluga='" + usluga + "',racun='" + racun + "'where BrGaraze='" + starag + "' AND ParkingMesto='" + starom + "';";
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
                
            }
        }

        public bool ukloniVoziloLokacija(int garaza,int parkingMesto)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                string Query = "delete from parking where BrGaraze='" + garaza + "' AND ParkingMesto='" + parkingMesto + "';";
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
                return false;
            }
        }

        public bool ukloniVoziloReg(string registracija)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                string Query = "delete from parking where RegTab='" + registracija + "';";
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
                return false;
            }
        }

        public int automobil1h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "1hautomobil")
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

        public int automobil12h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "12hautomobil")
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

        public int automobil24h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "24hautomobil")
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

        public int automobil168h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "168hautomobil")
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

        public int automobil720h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "720hautomobil")
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

        public int autobus1h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "1hautobus")
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

        public int autobus12h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "12hautobus")
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

        public int autobus24h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "24hautobus")
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

        public int autobus168h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "168hautobus")
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

        public int autobus720h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "720hautobus")
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

        public int kamion1h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "1hkamion")
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

        public int kamion12h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "12hkamion")
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

        public int kamion24h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "24hkamion")
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

        public int kamion168h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "168hkamion")
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

        public int kamion720h()
        {
            int cena = 0;
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == "720hkamion")
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

        public bool dodajAktivnost(string aktivnost)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "insert into istorijaaktivnosti(broj,aktivnost) "
                + "values('" + 0 + "','" + aktivnost  + "');";
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
                return false;
            }
        }

        public List<string> ucitajAktivnost()
        {
            string query = "SELECT * FROM istorijaaktivnosti order by broj";
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<string> lista = new List<string>(); 

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {

                        lista.Add(myReader.GetString(1));
                        
                    }
                }

                databaseConnection.Close();
                return lista;


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog" + e);
                return null;
            }
        }

        public int brojAktivnosti()
        {
            string query = "SELECT * FROM istorijaaktivnosti order by broj";
            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            int broj = 0;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        broj++;
                    }
                }

                databaseConnection.Close();
                return broj;


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog" + e);
                return 0;
            }
        }

        public bool obrisiAktivnostiSaPocetka(int broj)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "DELETE FROM istorijaaktivnosti ORDER BY broj ASC limit " + broj + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MyCommand2.ExecuteNonQuery();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool obrisiAktivnostiSaKraja(int broj)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "DELETE FROM istorijaaktivnosti ORDER BY broj DESC limit " + broj + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MyCommand2.ExecuteNonQuery();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool obrisiParkingIstoriju(int brojRedova)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "DELETE FROM parkingistorija ORDER BY PocetakParkiranja ASC limit " + brojRedova + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                MyCommand2.ExecuteNonQuery();
                MyConn2.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool izmeniUslugu(string usluga, int cena, int snizenje, int popust)
        {
            try
            {
                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                string Query = "update cene set cena='" + cena + "',snizenje='" + snizenje + "',popust='" + popust + "' where usluga='" + usluga + "';";
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
                return false;
            }
        }

        public List<int> vratiPodatkeUsluge(string usluga)
        {
            string query = "SELECT * FROM cene";

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
                        if (myReader.GetString(0) == usluga)
                        {
                            lista.Add(myReader.GetInt32(1));//cena usluge
                            lista.Add(myReader.GetInt32(2));//snizenje 
                            lista.Add(myReader.GetInt32(3));//popust

                        }
                    }
                }

                databaseConnection.Close();
                return lista;


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog" + e);
                return null;
            }
        }

        public List<int> CeneSniznjaPopusti()
        {
            string query = "SELECT * FROM cene";

            string MySQLConnectionString = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            List<int> lista = new List<int>();
            for(int i=0;i<45;i++)
            {
                lista.Add(0);
            }

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        if (myReader.GetString(0) == "1hautomobil")
                        {
                            lista[0]=(myReader.GetInt32(1));//cena usluge
                            lista[1]=(myReader.GetInt32(2));//snizenje 
                            lista[2]=(myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "12hautomobil")
                        {
                            lista[3] = (myReader.GetInt32(1));//cena usluge
                            lista[4] = (myReader.GetInt32(2));//snizenje 
                            lista[5] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "24hautomobil")
                        {
                            lista[6] = (myReader.GetInt32(1));//cena usluge
                            lista[7] = (myReader.GetInt32(2));//snizenje 
                            lista[8] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "168hautomobil")
                        {
                            lista[9] = (myReader.GetInt32(1));//cena usluge
                            lista[10] = (myReader.GetInt32(2));//snizenje 
                            lista[11] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "720hautomobil")
                        {
                            lista[12] = (myReader.GetInt32(1));//cena usluge
                            lista[13] = (myReader.GetInt32(2));//snizenje 
                            lista[14] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "1hautobus")
                        {
                            lista[15] = (myReader.GetInt32(1));//cena usluge
                            lista[16] = (myReader.GetInt32(2));//snizenje 
                            lista[17] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "12hautobus")
                        {
                            lista[18] = (myReader.GetInt32(1));//cena usluge
                            lista[19] = (myReader.GetInt32(2));//snizenje 
                            lista[20] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "24hautobus")
                        {
                            lista[21] = (myReader.GetInt32(1));//cena usluge
                            lista[22] = (myReader.GetInt32(2));//snizenje 
                            lista[23] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "168hautobus")
                        {
                            lista[24] = (myReader.GetInt32(1));//cena usluge
                            lista[25] = (myReader.GetInt32(2));//snizenje 
                            lista[26] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "720hautobus")
                        {
                            lista[27] = (myReader.GetInt32(1));//cena usluge
                            lista[28] = (myReader.GetInt32(2));//snizenje 
                            lista[29] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "1hkamion")
                        {
                            lista[30] = (myReader.GetInt32(1));//cena usluge
                            lista[31] = (myReader.GetInt32(2));//snizenje 
                            lista[32] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "12hkamion")
                        {
                            lista[33] = (myReader.GetInt32(1));//cena usluge
                            lista[34] = (myReader.GetInt32(2));//snizenje 
                            lista[35] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "24hkamion")
                        {
                            lista[36] = (myReader.GetInt32(1));//cena usluge
                            lista[37] = (myReader.GetInt32(2));//snizenje 
                            lista[38] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "168hkamion")
                        {
                            lista[39] = (myReader.GetInt32(1));//cena usluge
                            lista[40] = (myReader.GetInt32(2));//snizenje 
                            lista[41] = (myReader.GetInt32(3));//popust
                        }
                        else if (myReader.GetString(0) == "720hkamion")
                        {
                            lista[42] = (myReader.GetInt32(1));//cena usluge
                            lista[43] = (myReader.GetInt32(2));//snizenje 
                            lista[44] = (myReader.GetInt32(3));//popust
                        }
                    }
                }

                databaseConnection.Close();
                return lista;


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:provera_zaposlenog" + e);
                return null;
            }
        }

        public bool dodajRezervaciju(string tip, int garaza, int mesto, string registracija, string termin, int usluga)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";

                string Query = "insert into rezervacije(id,gar,mesto,tip,reg,termin,usluga) "
                + "values('" + 0 + "','" + garaza + "','" + mesto + "','" + tip + "','" + registracija + "','" + termin + "','"
                + usluga + "');";
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
                return false;
            }
        }

        public List<ParkingMesto> vratiRezervacije()
        {
            string query = "SELECT * FROM rezervacije";

            List<ParkingMesto> lista = new List<ParkingMesto>();
            ParkingMesto p;

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
                        p = new ParkingMesto();

                        p.BrGaraze = myReader.GetInt32(1);
                        p.Broj = myReader.GetInt32(2);
                        string tipVozila = myReader.GetString(3);
                        if(tipVozila=="automobil")
                        {
                            p.Vozilo.TipVozila = "automobil";
                            p.Vozilo.DalijeInvalidsko = false;
                        }
                        else if(tipVozila=="automobil sa invaliditetom")
                        {
                            p.Vozilo.TipVozila = "automobil";
                            p.Vozilo.DalijeInvalidsko = true;
                        }
                        else if(tipVozila=="autobus")
                        {
                            p.Vozilo.TipVozila = "autobus";
                            p.Vozilo.DalijeInvalidsko = false;
                        }
                        else if(tipVozila=="kamion")
                        {
                            p.Vozilo.TipVozila = "kamion";
                            p.Vozilo.DalijeInvalidsko = false;
                        }

                        p.Vozilo.RegTab = myReader.GetString(4);
                        p.Vozilo.PocetakParkiranja = myReader.GetDateTime(5);
                        p.Vozilo.UslugaParkingServisa = myReader.GetInt32(6);

                        lista.Add(p);

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

        public bool obrisiRezervaciju(string registracija, int usluga, string tipVozila, int garaza, int mesto)
        {
            try
            {

                string MyConnection2 = "datasource=remotemysql.com;port=3306;username=SMpnx9HHZO;password=KxuxSIqgCJ;database=SMpnx9HHZO";
                string Query = "delete from rezervacije where reg='" + registracija + "' AND usluga=" + usluga + " AND tip = '" + tipVozila + "' AND gar = " + garaza + " AND mesto = " + mesto + "; ";
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
                return false;
            }
        }  
    }

    
}
