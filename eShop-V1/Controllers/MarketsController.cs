using eShop_V1.Data;
using eShop_V1.Data.Services;
using eShop_V1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eShop_V1.Controllers
{
    public class MarketsController : Controller
    {
        private readonly IMarketServices _service;
        public MarketsController(IMarketServices service)
        {
            _service= service;  
        }

        public async Task<IActionResult> Index()
        {
            var allMarkets =await _service.GetAllAsync();
            return View(allMarkets);    
        }

        //Create a new market

        public IActionResult Create()
        {
            return View();
        }

        

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Market market)
        {
            if (!ModelState.IsValid)
            {
                return View(market);
            }
            await _service.AddAsync (market);
            return RedirectToAction(nameof(Index));
        }

        //Get previous market to see details

        public async Task<IActionResult> Details(int id)
        {
            var marketDetails =await _service.GetByIdAsync(id);
            if (marketDetails == null)
                return View("NotFound");
            return View(marketDetails);
        }

        //Create a new market

        public async Task<IActionResult> Edit(int id)
        {
            var marketDetails = await _service.GetByIdAsync(id);
            if (marketDetails == null)
                return View("NotFound");
            return View(marketDetails);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id,Logo,Name,Description")] Market market)
        {
            if (!ModelState.IsValid)
            {
                return View(market);
            }
            await _service.UpdateAsync(id,market);
            return RedirectToAction(nameof(Index));
        }

    }
}
