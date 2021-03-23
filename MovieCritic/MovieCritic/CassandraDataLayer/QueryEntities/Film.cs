using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Film
    {
        public string sifra { get; set; }
        public string naziv { get; set; }
        public string reziser { get; set; }
        public string glumci { get; set; }
        public string zanr { get; set; }
        public string godina { get; set; }

    }

    public class OmiljeniFilm:Film
    {
        public Korisnik korisnik { get; set; }
    }
}
