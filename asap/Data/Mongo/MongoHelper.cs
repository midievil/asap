using MongoDB.Driver;
using MongoDB.Driver.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mongo
{
    public class MongoHelper<T> where T : class
    {
        public IMongoCollection<T> Collection { get; private set; }

        public MongoHelper()
        {
            
            var connectionString = ConfigurationManager.ConnectionStrings["MongoDB"];
            var client = new MongoClient(connectionString.ConnectionString);
            var db = client.GetDatabase("asap");

            Collection = db.GetCollection<T>(typeof(T).Name.ToLower());
        }
    }
}
