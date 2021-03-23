using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using eDnevnik.Entiteti;

namespace eDnevnik.Mapiranja
{
    class OdeljenjeMapiranja:ClassMap<Odeljenje>
    {
        public OdeljenjeMapiranja()
        {
            //Mapiranje tabele
            Table("ODELJENJE");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Smer, "SMER");

            //mapiranje veze 1:N Odeljenje-Ucenik
            HasMany(x => x.Ucenici).KeyColumn("ID_ODELJENJA").LazyLoad().Cascade.All().Inverse();

            // mapiranje manyTomany + dodatne kolone
            HasMany(x => x.RazredneStaresine).Table("JE_RAZREDNI").KeyColumn("ID_ODELJENJA").LazyLoad().Cascade.All().Inverse();

            // mapiranje manyTomany + dodatne kolone
            HasMany(x => x.Predstavnici).Table("PREDSTAVLJA").KeyColumn("ID_ODELJENJA").LazyLoad().Cascade.All().Inverse();

            // mapiranje manyTomany + dodatne kolone
            HasMany(x => x.RasporedCasova).Table("RASPORED").KeyColumn("ID_ODELJENJA").LazyLoad().Cascade.All().Inverse();

            // za ternarnu drzi cas
            HasMany(x => x.PredajuPredmete).Table("DRZI_CAS").KeyColumn("ID_ODELJENJA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
