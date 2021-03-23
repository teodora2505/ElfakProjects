using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class FunkcijaMapiranja:ClassMap<Funkcija>
    {
        public FunkcijaMapiranja()
        {
            Table("FUNKCIJA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();//mapiranje prim kljuca;

            //mapiranje ostalih stvari
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
            Map(x => x.Tip, "TIP");

            References(x => x.VrsiFunkciju).Column("ID_RODITELJA").LazyLoad();
        }

    }
}
