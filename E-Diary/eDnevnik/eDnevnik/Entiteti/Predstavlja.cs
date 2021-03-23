using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class Predstavlja
    {
        public virtual int Id { get; protected set; }
        public virtual Odeljenje Id_Odeljenja { get; set; }
        public virtual Roditelj Id_Roditelja { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }

        public Predstavlja()
        {

        }
    }
}
