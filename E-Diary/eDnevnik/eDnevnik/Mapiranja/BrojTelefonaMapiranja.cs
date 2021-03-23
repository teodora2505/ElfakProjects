using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class BrojTelefonaMapiranja:ClassMap<BrojTelefona>
    {
        public BrojTelefonaMapiranja()
        {
            Table("BROJ_TELEFONA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();//mapiranje prim kljuca;

            //mapiranje ostalih stvari
            Map(x => x.BrojTelefonaKorisnika, "BR_TELEFONA");

            References(x => x.PripadaKorisniku).Column("ID_KORISNIKA").LazyLoad();
        }
    }
}
