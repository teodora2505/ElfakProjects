using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MongoDB.Bson;
using MongoDB.Driver;
using Mongo_DataLayer.Entities;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization;

namespace Mongo_DataLayer
{
    public static class MongoProvider
    {

        #region Korisnici

        public static Korisnik dodajKorisnika(Korisnik korisnik)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");
            collection.Insert(korisnik);
            return korisnik;

        }

        public static Korisnik vratiKorisnika(string email, string password)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");

            var query = from korisnik in collection.AsQueryable<Korisnik>()
                         where korisnik.Email == email && korisnik.Password==password
                         select korisnik;

            return (Korisnik)query.FirstOrDefault();
        }

        public static Korisnik vratiKorisnika(string email)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");

            var query = from korisnik in collection.AsQueryable<Korisnik>()
                        where korisnik.Email == email
                        select korisnik;

            return (Korisnik)query.FirstOrDefault();
        }

        public static List<Korisnik> vratiSveKorisnike()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");

            var query = from korisnik in collection.AsQueryable<Korisnik>()
                        select korisnik;

            return query.ToList();
        }

        public static void azurirajKorisnika(string stariMail, Korisnik novi)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");

            var query = Query.EQ("_id", ObjectId.Parse(vratiKorisnika(stariMail)._id.ToString()));
            var update1 = MongoDB.Driver.Builders.Update.Set("Ime", BsonValue.Create(novi.Ime)); collection.Update(query, update1);
            var update2 = MongoDB.Driver.Builders.Update.Set("Prezime", BsonValue.Create(novi.Prezime)); collection.Update(query, update2);   
            var update4 = MongoDB.Driver.Builders.Update.Set("Password", BsonValue.Create(novi.Password)); collection.Update(query, update4);
            var update5 = MongoDB.Driver.Builders.Update.Set("Admin", BsonValue.Create(novi.Admin)); collection.Update(query, update5);
            var update3 = MongoDB.Driver.Builders.Update.Set("Email", BsonValue.Create(novi.Email)); collection.Update(query, update3);
        }

        public static void obrisiKorisnika(string email)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");

            var query = Query.EQ("Email", email);

            collection.Remove(query);
        }

        public static Korisnik vratiKorisnika(ObjectId id)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Korisnik>("Korisnici");

            var query = from korisnik in collection.AsQueryable<Korisnik>()
                        where korisnik._id == id
                        select korisnik;

            return (Korisnik)query.FirstOrDefault();
        }

        #endregion

        #region Ponude i Smestaj

        public static Ponuda dodajPonudu(Ponuda ponuda)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Ponuda>("Ponude");
            collection.Insert(ponuda);
            return ponuda;
        }

        public static Ponuda vratiPonudu(string destinacija, string nazivHotela, string datumPolaska)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Ponuda>("Ponude");

            var query = from ponuda in collection.AsQueryable<Ponuda>()
                        where ponuda.Destinacija==destinacija && ponuda.Hotel.NazivHotela==nazivHotela && ponuda.DatumPolaska==datumPolaska
                        select ponuda;

            return (Ponuda)query.FirstOrDefault();
        }

        public static List<Ponuda> vratiSvePonude()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Ponuda>("Ponude");

            var query = from ponuda in collection.AsQueryable<Ponuda>()
                        select ponuda;

            return query.ToList();
        }

        public static void obrisiPonudu(string destinacija, string datumPolaska, string kategorija)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Ponuda>("Ponude");

            var query = Query.And(
                            Query.EQ("Destinacija", destinacija),
                            Query.EQ("DatumPolaska", datumPolaska),
                            Query.EQ("Kategorija", kategorija)
                            );

            collection.Remove(query);
        }

        public static void azurirajPonudu(Ponuda staraPonuda, Ponuda novaPonuda)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Ponuda>("Ponude");

            var query = Query.EQ("_id", ObjectId.Parse(staraPonuda._id.ToString()));                          

            var update1 = MongoDB.Driver.Builders.Update.Set("Destinacija", BsonValue.Create(novaPonuda.Destinacija)); collection.Update(query, update1);
            var update2 = MongoDB.Driver.Builders.Update.Set("Prevoz", BsonValue.Create(novaPonuda.Prevoz)); collection.Update(query, update2);
            var update3 = MongoDB.Driver.Builders.Update.Set("Kategorija", BsonValue.Create(novaPonuda.Kategorija)); collection.Update(query, update3);
            var update4 = MongoDB.Driver.Builders.Update.Set("BrojDana", BsonValue.Create(novaPonuda.BrojDana)); collection.Update(query, update4);
            var update5 = MongoDB.Driver.Builders.Update.Set("BrojNoci", BsonValue.Create(novaPonuda.BrojNoci)); collection.Update(query, update5);
            var update6 = MongoDB.Driver.Builders.Update.Set("DatumPolaska", BsonValue.Create(novaPonuda.DatumPolaska)); collection.Update(query, update6);
            var update7 = MongoDB.Driver.Builders.Update.Set("CenaPoOsobi", BsonValue.Create(novaPonuda.CenaPoOsobi)); collection.Update(query, update7);
            var update8 = MongoDB.Driver.Builders.Update.Set("TipPonude", BsonValue.Create(novaPonuda.TipPonude)); collection.Update(query, update8);
            var update9 = MongoDB.Driver.Builders.Update.Set("Slike", BsonValue.Create(novaPonuda.Slike)); collection.Update(query, update9);

            var ponuda = vratiPonudu(novaPonuda.Destinacija, staraPonuda.Hotel.NazivHotela, novaPonuda.DatumPolaska);
            ponuda.Hotel = novaPonuda.Hotel;
            collection.Save(ponuda);
        }

        public static Ponuda vratiPonudu(ObjectId id)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Ponuda>("Ponude");

            var query = from ponuda in collection.AsQueryable<Ponuda>()
                        where ponuda._id == id
                        select ponuda;

            return (Ponuda)query.FirstOrDefault();
        }

        public static List<Ponuda> pretraziPonude(string destinacija, string prevoz, string kategorija, int minBrojDana, int maxBrojDana, int minCena, int maxCena, string tipPonude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var ponudeCollection = db.GetCollection("Ponude");

            var query = Query.And(
                            Query.GTE("CenaPoOsobi", minCena),
                            Query.LTE("CenaPoOsobi", maxCena),
                            Query.GTE("BrojDana", minBrojDana),
                            Query.LTE("BrojDana", maxBrojDana)
                            );

            if (destinacija != null)
                query = Query.And(query, Query.EQ("Destinacija", destinacija));

            if (kategorija != null)
                query = Query.And(query, Query.EQ("Kategorija", kategorija));

            if (prevoz != null)
                query = Query.And(query, Query.EQ("Prevoz", prevoz));

            if (tipPonude != null)
                query = Query.And(query, Query.EQ("TipPonude", tipPonude));

            MongoCursor<BsonDocument> lista= ponudeCollection.Find(query);
            List<Ponuda> listaPonuda = new List<Ponuda>();

            foreach( BsonDocument doc in lista)
            {
                Ponuda p = new Ponuda();
                p = BsonSerializer.Deserialize<Ponuda>(doc);
                listaPonuda.Add(p);
            }

            return listaPonuda;
        }

        #endregion

        #region OmiljnePonudeKorisnika

        public static Omiljeno dodajOmiljenuPonudu(Omiljeno omiljenaPonuda)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Omiljeno>("Omiljeno");

            collection.Insert(omiljenaPonuda);
            return omiljenaPonuda;
        }

        public static void obrisiOmiljenuPonudu(Omiljeno omiljenaPonuda)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collectionOmiljeno = db.GetCollection<Omiljeno>("Omiljeno");

            var query = Query.EQ("_id", omiljenaPonuda._id);

            collectionOmiljeno.Remove(query);      
        }

        public static Omiljeno vratiOmiljenuPonudu(ObjectId id_Korisnika, ObjectId id_Ponude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Omiljeno>("Omiljeno");
            var query = from omiljeno in collection.AsQueryable<Omiljeno>()
                        where omiljeno.Korisnik.Id == id_Korisnika && omiljeno.Ponuda.Id == id_Ponude
                        select omiljeno;

            return query.FirstOrDefault();
        }

        public static List<Omiljeno> vratiSveOmiljenePonude()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Omiljeno>("Omiljeno");

            var query = from omiljeno in collection.AsQueryable<Omiljeno>()
                        select omiljeno;

            return query.ToList();
        }

        public static List<Ponuda> vratiSveKorisnikoveOmiljenePonude(ObjectId id_Korisnika)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Omiljeno>("Omiljeno");
            var query = from omiljeno in collection.AsQueryable<Omiljeno>()
                        where omiljeno.Korisnik.Id == id_Korisnika
                        select omiljeno;

            List<Ponuda> listaPonuda = new List<Ponuda>();

            foreach(Omiljeno o in (List<Omiljeno>)query.ToList())
            {

                Ponuda p = db.FetchDBRefAs<Ponuda>(o.Ponuda);
                listaPonuda.Add(p);
            }

            return listaPonuda;
        }

        public static List<Omiljeno> vratiSveOmiljenePonudeZaPonudu(ObjectId id_Ponude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Omiljeno>("Omiljeno");
            var query = from omiljeno in collection.AsQueryable<Omiljeno>()
                        where omiljeno.Ponuda.Id == id_Ponude
                        select omiljeno;


            return (List<Omiljeno>)query.ToList();

        }

        public static List<Omiljeno> vratiSveOmiljenePonudeZaKorisnika(ObjectId id_Korisnika)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Omiljeno>("Omiljeno");
            var query = from omiljeno in collection.AsQueryable<Omiljeno>()
                        where omiljeno.Korisnik.Id == id_Korisnika
                        select omiljeno;

            return (List<Omiljeno>)query.ToList();
   
        }

        #endregion

        #region Recnezije

        public static Recenzija dodajRecenziju(Recenzija recenzija)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");

            collection.Insert(recenzija);
            return recenzija;
        }

        public static void azurirajRecenziju(string novaRecenzija, Recenzija r)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");

            var query = Query.EQ("_id", ObjectId.Parse(r._id.ToString()));
            var update1 = MongoDB.Driver.Builders.Update.Set("TekstRecenzije", BsonValue.Create(novaRecenzija));
            collection.Update(query, update1);

        }

        public static Recenzija obrisiRecenziju(Recenzija recenzija)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collectionRecenzije = db.GetCollection<Recenzija>("Recenzije");

            var query = Query.EQ("_id", recenzija._id);

            collectionRecenzije.Remove(query);
            return recenzija;
        }

        public static Korisnik vratiAutoraRecenzije(ObjectId idRecenzije)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");

            var query = from recenzija in collection.AsQueryable<Recenzija>()
                        where recenzija._id == idRecenzije
                        select recenzija;


            Recenzija r = (Recenzija)query.FirstOrDefault();
            Korisnik korisnik = db.FetchDBRefAs<Korisnik>(r.Korisnik);
            return korisnik;
        }

        public static Ponuda vratiPonuduRecenzije(ObjectId idRecenzije)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");

            var query = from recenzija in collection.AsQueryable<Recenzija>()
                        where recenzija._id == idRecenzije
                        select recenzija;


            Recenzija r = (Recenzija)query.FirstOrDefault();
            Ponuda ponuda = db.FetchDBRefAs<Ponuda>(r.Ponuda);
            return ponuda;
        }

        public static Recenzija vratiRecenziju(ObjectId id_Korisnika, ObjectId id_Ponude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");
            var query = from recenzija in collection.AsQueryable<Recenzija>()
                        where recenzija.Korisnik.Id == id_Korisnika && recenzija.Ponuda.Id == id_Ponude
                        select recenzija;

            return query.FirstOrDefault();
        }

        public static List<Recenzija> vratiSveRecenzije()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");

            var query = from recenzije in collection.AsQueryable<Recenzija>()
                        orderby recenzije.Datum descending
                        select recenzije;

            return query.ToList();
        }

        public static List<Recenzija> vratiSveRecenzijeZaPonudu(ObjectId id_Ponude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");
            var query = from recenzije in collection.AsQueryable<Recenzija>()
                        where recenzije.Ponuda.Id == id_Ponude
                        orderby recenzije.Datum descending
                        select recenzije;

            return query.ToList();
        }

        public static List<Recenzija> vratiSveRecenzijeZaKorisnika(ObjectId id_Korisnik)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Recenzija>("Recenzije");
            var query = from recenzije in collection.AsQueryable<Recenzija>()
                        where recenzije.Korisnik.Id == id_Korisnik
                        orderby recenzije.Datum descending
                        select recenzije;

            return query.ToList();
        }

        #endregion

        #region Rezervacije

        public static Rezervacija dodajRezervaciju(Rezervacija rezervacija)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");

            collection.Insert(rezervacija);
            return rezervacija;
        }

        public static void azurirajRezervaciju(string novaSoba, Rezervacija r)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");

            var query = Query.EQ("_id", ObjectId.Parse(r._id.ToString()));
            var update1 = MongoDB.Driver.Builders.Update.Set("Soba", BsonValue.Create(novaSoba)); 
            collection.Update(query, update1);
       
        }

        public static Rezervacija obrisiRezervaciju(Rezervacija rezervacija)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collectionRecenzije = db.GetCollection<Rezervacija>("Rezervacije");

            var query = Query.EQ("_id", rezervacija._id);

            collectionRecenzije.Remove(query);
            return rezervacija;
        }

        public static Korisnik vratiKorisnikaRezervacije(ObjectId idRezervacije)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");

            var query = from rezervacija in collection.AsQueryable<Rezervacija>()
                        where rezervacija._id == idRezervacije
                        select rezervacija;


            Rezervacija r = (Rezervacija)query.FirstOrDefault();
            Korisnik korisnik = db.FetchDBRefAs<Korisnik>(r.Korisnik);
            return korisnik;
        }

        public static Ponuda vratiRezervisanuPonudu(ObjectId idRezervacije)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");

            var query = from rezervacija in collection.AsQueryable<Rezervacija>()
                        where rezervacija._id == idRezervacije
                        select rezervacija;


            Rezervacija r = (Rezervacija)query.FirstOrDefault();
            Ponuda ponuda = db.FetchDBRefAs<Ponuda>(r.Ponuda);
            return ponuda;
        }

        public static Rezervacija vratiRezervaciju(ObjectId id_Korisnika, ObjectId id_Ponude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");
            var query = from rezervacija in collection.AsQueryable<Rezervacija>()
                        where rezervacija.Korisnik.Id == id_Korisnika && rezervacija.Ponuda.Id == id_Ponude
                        select rezervacija;

            return query.FirstOrDefault();
        }

        public static List<Rezervacija> vratiSveRezervacije()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");

            var query = from rezervacija in collection.AsQueryable<Rezervacija>()
                        orderby rezervacija.DatumRezervisanja descending
                        select rezervacija;

            return query.ToList();
        }

        public static List<Rezervacija> vratiSveRezervacijeZaPonudu(ObjectId id_Ponude)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");
            var query = from rezervacija in collection.AsQueryable<Rezervacija>()
                        where rezervacija.Ponuda.Id == id_Ponude
                        orderby rezervacija.DatumRezervisanja descending
                        select rezervacija;

            return query.ToList();
        }

        public static List<Rezervacija> vratiSveRezervacijeZaKorisnika(ObjectId id_Korisnika)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var db = server.GetDatabase("travelmania");

            var collection = db.GetCollection<Rezervacija>("Rezervacije");
            var query = from rezervacija in collection.AsQueryable<Rezervacija>()
                        where rezervacija.Korisnik.Id == id_Korisnika
                        orderby rezervacija.DatumRezervisanja descending
                        select rezervacija;

            return query.ToList();
        }

        #endregion
    }

}
