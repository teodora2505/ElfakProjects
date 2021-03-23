using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            //Mapiranje tabele
            Table("PREDMET");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Opis, "OPIS");
            Map(x => x.BrojCasova, "BR_CASOVA");
            Map(x => x.TipPredmeta, "TIP_PREDMETA");
            Map(x => x.MinBrojUcenika, "MIN_BR_UCENIKA");
            Map(x => x.BlokNastava, "BLOK_NASTAVA");
            Map(x => x.SpecijalanKabinet, "SPEC_KABINET");

            //nastavnik-predaje-predmet
            HasManyToMany(x => x.DrzeNastavnici)
             .Table("PREDAJE")
             .ParentKeyColumn("ID_PREDMETA")
             .ChildKeyColumn("ID_NASTAVNIKA")
             .Inverse()
             .Cascade.All();

            HasManyToMany(x => x.DrzeNastavniciRoditelji)
             .Table("PREDAJE")
             .ParentKeyColumn("ID_PREDMETA")
             .ChildKeyColumn("ID_NASTAVNIKA")
             .Inverse()
             .Cascade.All();

            // mapiranje manyTomany + dodatne kolone
            HasMany(x => x.OceneUcenika).Table("IMA_OCENU").KeyColumn("ID_PREDMETA").LazyLoad().Cascade.All().Inverse();

            // mapiranje manyTomany + dodatne kolone
            HasMany(x => x.SeDrzePoRasporedu).Table("RASPORED").KeyColumn("ID_PREDMETA").LazyLoad().Cascade.All().Inverse();

            // za ternarnu drzi cas
            HasMany(x => x.SeDrzeU).Table("DRZI_CAS").KeyColumn("ID_PREDMETA").LazyLoad().Cascade.All().Inverse();

            // visevrednosni godina 
            HasMany(x => x.NaGodini).Table("GODINA").KeyColumn("ID_PREDMETA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
