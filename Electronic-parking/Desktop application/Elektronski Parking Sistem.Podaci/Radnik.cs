using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Radnik:Object
    {
        private string username;
        private string password;


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Radnik(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
    }
}
