using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using Web1.Data;
using Web1.Models;
using Web1.Service;
using Web1.ViewModel;

namespace Web1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        public HomeController(ILogger<HomeController> logger, AppDbContext context )
        {
           _context = context;
        }

        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult LogIn()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.users.FirstOrDefault(u =>
                            u.Email == model.Email && u.Password == model.Password);

                if (user != null)
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Role, user.Role ?? "User")
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return Ok();

                }

                ViewBag.Error = "Email hoặc mật khẩu không đúng!";
            }

            return BadRequest();
        }

        [HttpPost]
        public IActionResult SubscribeEmail([FromBody] SubscribeViewModel model)
        {
            if (!ModelState.IsValid)
            {
      
                return BadRequest(new {message=" Email không đúng định dạng"});
            }
            try
            {
                var exist = _context.subscribers.Any(x => x.Email == model.Email);
                if (exist)
                {
                    return BadRequest(new {message= "Email đã được đăng ký trước đó" });
                }
                _context.subscribers.Add(new Subscriber
                {
                    Email = model.Email,
                    TimeSent = DateTime.Now,
                    Status = "enable"
                });
                _context.SaveChanges();
                return Ok(new { message = "Cảm ơn bạn đã đăng ký" });
            }
            catch (Exception)
            {
                return BadRequest(new { message = "Email không hợp lẹ hoặc có lỗi xảy ra" });
                throw;
            }
           
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
