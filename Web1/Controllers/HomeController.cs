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
        private IIntroduceService _introduceService;
        private IServiceFeatureService _serviceFeatureService;
        private IBlock6Service _block6Service;
        private IHeaderService _headervice;
        private IMenuService _menuService;
        private IBlock3Service _block3Service;
        public HomeController(ILogger<HomeController> logger, IFooterService footerService, IPartnersService partnersService, IIntroduceService introduceService, IServiceFeatureService serviceFeatureService, IBlock6Service block6Service, IHeaderService headerService, IMenuService menuService, IBlock3Service block3Service)
        {
            _logger = logger;
            _footerService = footerService;
            _partnersService = partnersService;
            _introduceService = introduceService;
            _serviceFeatureService = serviceFeatureService;
            _block6Service = block6Service;
            _headervice = headerService;
            _menuService = menuService;
            _block3Service = block3Service;
        }

        public IActionResult Index()
        {
            var vm = new HomeViewModel
            {
                Footer = _footerService.GetSampleFooter(),
                generalDesription = _partnersService.GetPartners(),
                introduces = _introduceService.GetIntroduce(),
                generalserviceFeatures = _serviceFeatureService.getServiceFeature(),
                block6 = _block6Service.GetBlock6(),
                header = _headervice.GetHeader(),
                menu = _menuService.GetMenu(),
                block3s = _block3Service.GetBlock3()
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
