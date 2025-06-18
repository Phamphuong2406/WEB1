using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class ServiceFeatureViewComponent : ViewComponent
    {
        private IServiceFeatureService _serviceFeatureService;
        public ServiceFeatureViewComponent(IServiceFeatureService serviceFeatureService)
        {
            _serviceFeatureService = serviceFeatureService;
        }
        public IViewComponentResult Invoke()
        {
            var data = _serviceFeatureService.getServiceFeature();
            return View(data);
        }
    }
}
