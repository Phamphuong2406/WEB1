using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class PartnersViewComponent: ViewComponent
    {
        private readonly IPartnersService _partnersService;
        public PartnersViewComponent(IPartnersService partnersService)
        {
            _partnersService = partnersService;
        }
        public IViewComponentResult Invoke()
        {
            var data = _partnersService.GetPartners();
            return View(data);
        }
       
    }
}
