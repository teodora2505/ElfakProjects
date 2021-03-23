using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronski_Parking_Sistem.Podaci
{
    public class Menadzer:Object
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

        public Menadzer(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
    }
}
