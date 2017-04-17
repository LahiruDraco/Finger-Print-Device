using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Classes
{
    public class MongoDatabase
    {
        MongoClient client;


        public MongoDatabase()
        {
            client = new MongoClient();
        }

        public object GetData(string collectionName)
        {
            var database = client.GetDatabase("fingerprint");
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var result = collection.Find(new BsonDocument()).ToListAsync();

            return result;
        }

        public void GetData(string collectionName,string filterValue)
        {
            var database = client.GetDatabase("fingerprint");
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", filterValue);
            var result = collection.Find(filter).ToListAsync();
        }
    }
}
