using eShop_V1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShop_V1.Data.Services
{
    public interface IMarketServices
    {
        Task<IEnumerable<Market>> GetAllAsync(); //بترجع كل ال markets 
        Task< Market > GetByIdAsync(int id);
        Task AddAsync(Market market); // add data to database
        Task<Market> UpdateAsync(int id, Market newMarket);
        void Delete(int id);
    }
}
