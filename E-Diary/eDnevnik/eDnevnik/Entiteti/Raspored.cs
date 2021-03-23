using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class Raspored
    {
        public virtual int Id { get; protected set; }
        public virtual Odeljenje Id_Odeljenja { get; set; }
        public virtual Predmet Id_Predmeta { get; set; }
        public virtual string Dan { get; set; }
        public virtual int Cas { get; set; }

        public Raspored()
        {

        }
    }
}
