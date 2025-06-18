using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class IntroduceViewComponent : ViewComponent
    {
        private IIntroduceService _introduceService;
        public IntroduceViewComponent(IIntroduceService introduceService)
        {
            _introduceService = introduceService;
        }
        public IViewComponentResult Invoke()
        {
            var data = _introduceService.GetIntroduce();
            return View(data);
        }
    }
}
