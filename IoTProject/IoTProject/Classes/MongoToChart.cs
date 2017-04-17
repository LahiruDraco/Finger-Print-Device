using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Classes
{
    public class MongoToChart
    {
        public static Dictionary<string, int> list = new Dictionary<string, int>();
        MongoClient client;
        

        public MongoToChart()
        {
            Initialize();
        }

        public async void Initialize()
        {
            client = new MongoClient();
            var database = client.GetDatabase("fingerprint");
            var collection = database.GetCollection<BsonDocument>("Batch");

            var resultList = await collection.Find(new BsonDocument()).ToListAsync();

            foreach (var item in resultList)
            {
                List<string> students = JsonConvert.DeserializeObject<List<string>>(item.ToString());
                list.Add(item[1].ToString(), students.Count);
            }

            //for (int i = 0; i < resultList.Count; i++)
            //{
            //    for (int j = 1; j < resultList.Count-1; j++)
            //    {
            //        if (resultList[i].ToString()==resultList[j])
            //        {
                        
            //        }
            //    }
            //}
        }
    }
}
