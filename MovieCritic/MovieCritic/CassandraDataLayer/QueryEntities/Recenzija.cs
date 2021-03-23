using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;

namespace CassandraDataLayer.QueryEntities
{
    public class Recenzija
    {
        public string sifraFilma { get; set; }
        public string username { get; set; }
        public LocalDate datum{ get; set; }
        public string recenzija { get; set; }
    }
}
