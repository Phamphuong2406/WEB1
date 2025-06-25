using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PostsManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateNewPost()
        {
            return View();
        }
    }
}
