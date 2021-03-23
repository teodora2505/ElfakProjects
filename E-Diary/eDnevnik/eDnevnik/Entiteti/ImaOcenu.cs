using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class ImaOcenu
    {
        public virtual int Id { get; protected set; }
        public virtual Ucenik Id_Ucenika { get; set; }
        public virtual Predmet Id_Predmeta { get; set; }
        public virtual string TipOcene { get; set; }
        public virtual int Vrednost { get; set; }
        public virtual string Opis { get; set; }

        public ImaOcenu()
        {

        }
    }
}
