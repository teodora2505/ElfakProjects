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
    public class Ponuda
    {
        public ObjectId _id{ get; set; }
        public string Destinacija { get; set; }
        public string Prevoz { get; set; }
        public string Kategorija { get; set; }
        public int BrojDana { get; set; }
        public int BrojNoci { get; set; }
        public string DatumPolaska { get; set; }
        public Smestaj Hotel { get; set; }
        public int CenaPoOsobi { get; set; }
        public string TipPonude { get; set; }
        public List<string> Slike { get; set; }
    }
}
