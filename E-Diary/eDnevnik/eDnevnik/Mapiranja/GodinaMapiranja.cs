using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class GodinaMapiranja:ClassMap<Godina>
    {
        public GodinaMapiranja()
        {
            Table("GODINA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();//mapiranje prim kljuca;

            //mapiranje ostalih stvari
            Map(x => x.NaGodini, "GODINA");

            References(x => x.PredmeT).Column("ID_PREDMETA").LazyLoad();
        }

    }
}
