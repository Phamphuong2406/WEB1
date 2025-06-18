using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class MenuViewComponent : ViewComponent 
    {
        private IMenuService _menuService;
        public MenuViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }
        public IViewComponentResult Invoke()
        {
            var data = _menuService.GetMenu();
            return View(data);
        }
    }
}
