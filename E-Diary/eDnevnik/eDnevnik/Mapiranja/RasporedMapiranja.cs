using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class RasporedMapiranja:ClassMap<Raspored>
    {
        public RasporedMapiranja()
        {
                Table("RASPORED");

                //mapiranje primarnog kljuca
                Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

                References(x => x.Id_Odeljenja).Cascade.SaveUpdate().Column("ID_ODELJENJA");
                References(x => x.Id_Predmeta).Cascade.SaveUpdate().Column("ID_PREDMETA");

                Map(x => x.Dan).Column("DAN");
                Map(x => x.Cas).Column("CAS");
      
        }
    }
}
