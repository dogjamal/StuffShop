using Microsoft.AspNetCore.Mvc;
using StuffShop.Models;
using System.Diagnostics;
using Microsoft.Extensions.Caching.Memory;
using StuffShop.Services.Stuffs.Models;

namespace StuffShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache cache;


        public HomeController(ILogger<HomeController> logger, IMemoryCache cache)
        {
            _logger = logger;
            this.cache = cache;
        }

        public IActionResult Index()
        {
            const string LatestStuffsCacheKey = "LatestStuffsCacheKey";

            var latestSneakers = this.cache.Get<List<LatestStuffServiceModel>>(LatestStuffsCacheKey);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}