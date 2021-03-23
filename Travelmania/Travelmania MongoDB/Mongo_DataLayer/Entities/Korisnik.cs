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
    public class Korisnik
    {
        public ObjectId _id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Admin { get; set; }
    }
}
