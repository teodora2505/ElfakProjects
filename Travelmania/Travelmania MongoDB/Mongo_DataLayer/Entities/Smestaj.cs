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
    public class Smestaj
    {
        public ObjectId _id { get; set; }
        public string NazivHotela { get; set; }
        public int BrojZvezdica { get; set; }
        public int BrojJednokrevetnih { get; set; }
        public int BrojDvokrevetnih { get; set; }
        public int BrojTrokrevetnih{ get; set; }
        public int BrojCetvorokrevetnih { get; set; }
    }
}
