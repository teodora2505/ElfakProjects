using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class Funkcija
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual string Tip { get; set; }

        public virtual Roditelj VrsiFunkciju { get; set; }

        public Funkcija()
        {

        }
    }
}
