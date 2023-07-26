using eShop_V1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eShop_V1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducts = await _context.Products.Include(n => n.Market). OrderBy(n =>n.Name).ToListAsync();
            return View(allProducts);
        }
    }
}
