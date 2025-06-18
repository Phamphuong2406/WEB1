using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class FooterViewComponent :ViewComponent
    {
        private IFooterService _footerService;
        public FooterViewComponent(IFooterService footerService)
        {
            _footerService = footerService;
        }
        public IViewComponentResult Invoke()
        {
            var data = _footerService.GetSampleFooter();
            return View(data);
        }
    }
}
