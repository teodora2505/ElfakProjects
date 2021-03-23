using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDnevnik.Entiteti;
using FluentNHibernate.Mapping;

namespace eDnevnik.Mapiranja
{
    class KorisnikMapiranja:ClassMap<Korisnik>
    {
        public KorisnikMapiranja()
        {
            //Mapiranje tabele
            Table("KORISNIK");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("").Formula("CASE " +
                "WHEN (FADMINISTRATOR = 0 AND FRODITELJ = 1 AND FNASTAVNIK = 0 AND FUCENIK = 0) THEN 'Roditelj' " +
                "WHEN (FADMINISTRATOR = 0 AND FRODITELJ = 0 AND FNASTAVNIK = 1 AND FUCENIK = 0) THEN 'Nastavnik' " +
                "WHEN (FADMINISTRATOR = 0 AND FRODITELJ = 0 AND FNASTAVNIK = 0 AND FUCENIK = 1) THEN 'Ucenik' " +
                "WHEN (FADMINISTRATOR = 0 AND FRODITELJ = 1 AND FNASTAVNIK = 1 AND FUCENIK = 0) THEN 'NastavnikRoditelj' ELSE 'Administrator'" +
                "END");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Pol, "POL");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Username, "USERNAME");
            Map(x => x.Password, "PASSWORD");
            Map(x => x.FAdministrator, "FADMINISTRATOR");
            Map(x => x.FRoditelj, "FRODITELJ");
            Map(x => x.FNastavnik, "FNASTAVNIK");
            Map(x => x.FUcenik, "FUCENIK");

            //visevrednosni brojevi telefona
            HasMany(x => x.Brojevi).Table("BROJ_TELEFONA").KeyColumn("ID_KORISNIKA").LazyLoad().Cascade.All().Inverse();

        }
    }


    public class AdministratorMapiranja : SubclassMap<Administrator>
    {
        public AdministratorMapiranja()
        {
            DiscriminatorValue("Administrator");
        }
    }

    public class NastavnikMapiranja : SubclassMap<Nastavnik>
    {
        public NastavnikMapiranja()
        {
            DiscriminatorValue("Nastavnik");
            Map(x => x.SSSpreme, "STEPEN_STRUCNE_SPREME");

            //razredni-odeljenje
            HasMany(x => x.MojaOdeljenja).Table("JE_RAZREDNI").KeyColumn("ID_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();

            //nastavnik-predaje-predmet
            HasManyToMany(x => x.PredajemPredmete)
             .Table("PREDAJE")
             .ParentKeyColumn("ID_NASTAVNIKA")
             .ChildKeyColumn("ID_PREDMETA")
             .Cascade.All();

            // za ternarnu drzi cas
            HasMany(x => x.DrziCasove).Table("DRZI_CAS").KeyColumn("ID_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();
        }

    }

    public class RoditeljMapiranja : SubclassMap<Roditelj>
    {
        public RoditeljMapiranja()
        {
            DiscriminatorValue("Roditelj");

            //predstavnik-odeljenje
            HasMany(x => x.PredstavljaoOdeljenja).Table("PREDSTAVLJA").KeyColumn("ID_RODITELJA").LazyLoad().Cascade.All().Inverse();

            //funkcija roditelja
            HasMany(x => x.FunkcijeKojeJeVrsio).Table("FUNKCIJA").KeyColumn("ID_RODITELJA").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Deca)
               .Table("JE_RODITELJ")
               .ParentKeyColumn("ID_RODITELJA")
               .ChildKeyColumn("ID_UCENIKA")
               .Cascade.All();
        }
    }

    public class UcenikMapiranja : SubclassMap<Ucenik>
    {
        public UcenikMapiranja()
        {
            DiscriminatorValue("Ucenik");
            Map(x => x.BrOpravdanih, "BR_OPRAVDANIH");
            Map(x => x.BrNeopravdanih, "BR_NEOPRAVDANIH");
            Map(x => x.OcenaVladanje, "OCENA_IZ_VLADANJA");

            //mapiranje veze 1:N Odeljenje-Ucenik
            References(x => x.PripadaOdeljenju).Column("ID_ODELJENJA").LazyLoad();

            //roditelj-ucenik
            HasManyToMany(x => x.Roditelji)
               .Table("JE_RODITELJ")
               .ParentKeyColumn("ID_UCENIKA")
               .ChildKeyColumn("ID_RODITELJA")
               .Inverse()
               .Cascade.All();

            HasManyToMany(x => x.NastavnikRoditelji)
               .Table("JE_RODITELJ")
               .ParentKeyColumn("ID_UCENIKA")
               .ChildKeyColumn("ID_RODITELJA")
               .Inverse()
               .Cascade.All();

            // mapiranje manyTomany + dodatne kolone
            HasMany(x => x.Ocene).Table("IMA_OCENU").KeyColumn("ID_UCENIKA").LazyLoad().Cascade.All().Inverse();

        }
    }

    public class NastavnikRoditeljMapiranja : SubclassMap<NastavnikRoditelj>
    {
        public NastavnikRoditeljMapiranja()
        {
            DiscriminatorValue("NastavnikRoditelj");
            Map(x => x.SSSpreme, "STEPEN_STRUCNE_SPREME");

            HasManyToMany(x => x.Deca)
               .Table("JE_RODITELJ")
               .ParentKeyColumn("ID_RODITELJA")
               .ChildKeyColumn("ID_UCENIKA")
               .Cascade.All();

            //razredni-odeljenje
            HasMany(x => x.MojaOdeljenja).Table("JE_RAZREDNI").KeyColumn("ID_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();

            //predstavnik-odeljenje
            HasMany(x => x.PredstavljaoOdeljenja).Table("PREDSTAVLJA").KeyColumn("ID_RODITELJA").LazyLoad().Cascade.All().Inverse();

            //funkcija roditelja
            HasMany(x => x.FunkcijeKojeJeVrsio).Table("FUNKCIJA").KeyColumn("ID_RODITELJA").LazyLoad().Cascade.All().Inverse();

            //nastavnik-predaje-predmet
            HasManyToMany(x => x.PredajemPredmete)
             .Table("PREDAJE")
             .ParentKeyColumn("ID_NASTAVNIKA")
             .ChildKeyColumn("ID_PREDMETA")
             .Cascade.All();

            // za ternarnu drzi cas
            HasMany(x => x.DrziCasove).Table("DRZI_CAS").KeyColumn("ID_NASTAVNIKA").LazyLoad().Cascade.All().Inverse();
        }
    }

    
}


