using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class Block3ViewComponent: ViewComponent
    {
        private IBlock3Service _block3Service;
        public Block3ViewComponent(IBlock3Service block3Service)
        {
            _block3Service = block3Service;
        }
        public IViewComponentResult Invoke() {
            var data = _block3Service.GetBlock3();
            return View(data);
        }
    }
}
