using eShop_V1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop_V1.Data.Services
{
    public class MarketServices : IMarketServices
    {

        private readonly AppDbContext _context;
        public MarketServices(AppDbContext context)
        {
            _context= context;
        }
        public async Task AddAsync(Market market)
        {
            await _context.AddAsync(market);
           await _context.SaveChangesAsync(); 
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Market>>  GetAllAsync()
        {
            var result =await _context.Markets.ToListAsync();
            return result;
        }

        public async Task<Market> GetByIdAsync(int id)
        {
            var result = await _context.Markets.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }
       

        public async Task<Market> UpdateAsync(int id, Market newMarket)
        {
            _context.Markets.Update(newMarket); 
            await _context.SaveChangesAsync();  
            return newMarket;   
        }
    }
}
