using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web1.DTO;
using Web1.Service;

namespace Web1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PartnerManagementController : Controller
    {
        private IPartnerService _partnerService;
        public PartnerManagementController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var data = _partnerService.GetAllPartner();
            return View(data);
        }
        [HttpPost]
        public IActionResult CreateNewPartner([FromForm]PartnerDTO model)
        {
            try
            {
                _partnerService.createPartner(model);
                return Ok(new {message="Thêm mới đối tác thành công"});
;            }
            catch (Exception ex)
            {
                return BadRequest(new {message = "Đã xảy ra lỗi" + ex.Message});
                throw;
            }
        }
    }
}
