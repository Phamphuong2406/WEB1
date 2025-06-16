using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web1.Models;
using Web1.Service;
using Web1.ViewModel;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IFooterService _footerService;
        private readonly IPartnersService _partnersService;
        public HomeController(ILogger<HomeController> logger, IFooterService footerService, IPartnersService partnersService)
        {
            _logger = logger;
            _footerService = footerService;
            _partnersService = partnersService;
        }

        public IActionResult Index()
        {
            var vm = new HomeViewModel
            {
                Footer = _footerService.GetSampleFooter(),
                generalDesription = _partnersService.GetPartners()
            };
            return View(vm);
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
