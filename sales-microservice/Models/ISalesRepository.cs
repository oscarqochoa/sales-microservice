using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sales_microservice.Models
{
    public interface ISalesRepository
    {
        Task Register(Sale sale);
        Task Update(Sale sale);
        Task Delete(string id);
        Task<Sale> GetSale(string id);
        Task<List<Sale>> GetSales();
    }
}
