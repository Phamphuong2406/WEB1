using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class TestYoneViewComponent : ViewComponent
    {
        private ITestYoneService _testYoneService;
        public TestYoneViewComponent(ITestYoneService testYoneService)
        {
            _testYoneService = testYoneService;
        }
        public IViewComponentResult Invoke() {
            var data = _testYoneService.GetTestYone();
            return View(data);
        }
    }
}
