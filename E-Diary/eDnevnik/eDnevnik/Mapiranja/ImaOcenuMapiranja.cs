using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class ImaOcenuMapiranja :ClassMap<ImaOcenu>
    {
        public ImaOcenuMapiranja()
        {
            Table("IMA_OCENU");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Id_Ucenika).Cascade.SaveUpdate().Column("ID_UCENIKA");
            References(x => x.Id_Predmeta).Cascade.SaveUpdate().Column("ID_PREDMETA");

            Map(x => x.TipOcene).Column("TIP_OCENE");
            Map(x => x.Vrednost).Column("VREDNOST");
            Map(x => x.Opis).Column("OPIS");


        }
    }
}
