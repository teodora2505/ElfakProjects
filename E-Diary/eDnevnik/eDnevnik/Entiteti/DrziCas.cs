using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;

namespace eDnevnik.Entiteti
{
    public class DrziCas
    {
        public virtual int Id { get; set; }
        public virtual Nastavnik Id_Nastavnika { get; set; }
        public virtual Predmet Id_Predmeta { get; set; }
        public virtual Odeljenje Id_Odeljenja { get; set; }

        public DrziCas()
        {   
        }
    }
}
