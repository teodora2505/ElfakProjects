using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class Godina
    {
        public virtual int Id { get; set; }
        public virtual int NaGodini { get; set; }

        public virtual Predmet PredmeT { get;  set; }

        public Godina()
        {

        }
    }
}
