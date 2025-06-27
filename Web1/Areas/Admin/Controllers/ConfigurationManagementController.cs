using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Web1.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ConfigurationManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
    }
}
