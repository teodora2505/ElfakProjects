using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Korisnik
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public string admin { get; set; }
    }
}
