using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class DrziCasMapiranja:ClassMap<DrziCas>
    {
        public DrziCasMapiranja()
        {
            Table("DRZI_CAS");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();//mapiranje prim kljuca;

            References(x => x.Id_Nastavnika).Column("ID_NASTAVNIKA").LazyLoad();
            References(x => x.Id_Predmeta).Column("ID_PREDMETA").LazyLoad();
            References(x => x.Id_Odeljenja).Column("ID_ODELJENJA").LazyLoad();
        }
    }
}
