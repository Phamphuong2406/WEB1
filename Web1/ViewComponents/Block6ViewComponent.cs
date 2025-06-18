using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class Block6ViewComponent :ViewComponent
    {
        private IBlock6Service _block6Service;
        public Block6ViewComponent(IBlock6Service block6Service)
        {
            _block6Service = block6Service;
        }
        public IViewComponentResult Invoke()
        {
            var data = _block6Service.GetBlock6();
            return View(data);
        }
    }
}
