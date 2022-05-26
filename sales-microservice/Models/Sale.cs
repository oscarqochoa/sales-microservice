using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sales_microservice.Models
{
    public class Sale
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string ClientId { get; set; }
        public string Amount { get; set; }
        public bool status { get; set; }
        public DateTime created_at { get; set; }
    
    
    }
}
