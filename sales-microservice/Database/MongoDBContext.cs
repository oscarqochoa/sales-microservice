using MongoDB.Driver;
using sales_microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sales_microservice.Database
{
    public class MongoDBContext
    {
        private const string Database = "technical_test";
        private const string SalesCollection = "Sales";
        private readonly IMongoDatabase _mongoDb;

        public MongoDBContext()
        {
            var client = new MongoClient("mongodb+srv://microserviceserver:T9YdkYa8tkVKwwuk@cluster0.rqdwn.mongodb.net/?retryWrites=true&w=majority");
            _mongoDb = client.GetDatabase(Database);
        }

        public IMongoCollection<Sale> Sales
        {
            get
            {
                return _mongoDb.GetCollection<Sale>(SalesCollection);
            }
        }
    }
}
