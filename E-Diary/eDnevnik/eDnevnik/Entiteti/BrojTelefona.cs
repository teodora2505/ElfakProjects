using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.Entiteti
{
    public class BrojTelefona
    {
        public virtual int Id { get; set; }
        public virtual string BrojTelefonaKorisnika { get; set; }

        public virtual Korisnik PripadaKorisniku { get; set; }

        public BrojTelefona()
        {

        }
    }
}
