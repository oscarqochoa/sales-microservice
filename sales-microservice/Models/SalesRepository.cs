using MongoDB.Driver;
using sales_microservice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sales_microservice.Models
{
    public class SalesRepository : ISalesRepository
    {
        private MongoDBContext db = new MongoDBContext();

        public async Task<Sale> GetSale(string id)
        {
            FilterDefinition<Sale> filter = Builders<Sale>.Filter.Eq("Id", id);
            return await db.Sales.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<List<Sale>> GetSales()
        {
            return await db.Sales.Find(_ => true).ToListAsync();
        }
        public async Task Register(Sale sale)
        {
            try
            {
                await db.Sales.InsertOneAsync(sale);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task Update(Sale sale)
        {
            try
            {
                await db.Sales.ReplaceOneAsync(filter: g => g.Id == sale.Id, replacement: sale);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                FilterDefinition<Sale> filter = Builders<Sale>.Filter.Eq("Id", id);
                await db.Sales.DeleteOneAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
