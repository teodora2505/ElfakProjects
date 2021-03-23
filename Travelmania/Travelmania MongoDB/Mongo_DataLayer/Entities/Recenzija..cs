using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo_DataLayer.Entities
{
    public class Recenzija
    {
        public ObjectId _id { get; set; }
        public MongoDBRef Korisnik { get; set; }
        public MongoDBRef Ponuda { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Datum { get; set; }
        public String TekstRecenzije { get; set; }
    }
}
