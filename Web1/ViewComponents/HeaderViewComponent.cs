using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        private IHeaderService _headervice;
        public HeaderViewComponent(IHeaderService headervice)
        {
            _headervice = headervice;
        }
        public IViewComponentResult Invoke()
        {
            var data = _headervice.GetHeader();
            return View(data);
        }
    }
}
