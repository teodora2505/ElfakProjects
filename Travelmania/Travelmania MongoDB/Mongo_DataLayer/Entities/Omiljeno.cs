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
    public class Omiljeno
    {
        public ObjectId _id { get; set; }
        public MongoDBRef Korisnik { get; set; }
        public MongoDBRef Ponuda { get; set; }
    }
}
