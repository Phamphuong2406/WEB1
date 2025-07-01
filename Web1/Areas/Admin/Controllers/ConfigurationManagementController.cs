using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Web1.DTO;
using Web1.Service;

namespace Web1.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ConfigurationManagementController : Controller
    {
        private readonly ISettingService _settingService;
        public ConfigurationManagementController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = _settingService.GetAllConfiguration();
            return View(data);
        }
        [HttpGet]
        public IActionResult GetBySettingId(int id) {
            try
            {
                var setting = _settingService.GetSettingById(id);
                return Json(setting);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                throw;
            }
        }
        [HttpPost]
        public IActionResult CreateSetting(SettingDTO model)
        {
            try
            {
                _settingService.AddnewSetting(model);
                // return Ok(new {message="Thêm mới tính năng thành công"});
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Đã xảy ra lỗi " + ex.Message });
                throw;
            }
        }
       
        [HttpPost]
        public IActionResult UpdateSetting(SettingDTO model)
        {
            try
            {
                _settingService.UpdateDisplaySetting(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex.Message);
                throw;
            }
            
        }
        [HttpPost]
        public IActionResult DeleteSetting(int id)
        {
            try
            {
                _settingService.DeleteDisplaySetting(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
