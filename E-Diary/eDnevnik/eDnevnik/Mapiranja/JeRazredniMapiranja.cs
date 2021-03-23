using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class JeRazredniMapiranja:ClassMap<JeRazredni>
    {
        public JeRazredniMapiranja()
        {
            Table("JE_RAZREDNI");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Id_Odeljenja).Cascade.SaveUpdate().Column("ID_ODELJENJA");
            References(x => x.Id_Nastavnika).Cascade.SaveUpdate().Column("ID_NASTAVNIKA");

            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");

        }
    }
}
