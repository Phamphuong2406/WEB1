using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web1.Data;
using Web1.DTO;
using Web1.Service;

namespace Web1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PartnerManagementController : Controller
    {
        private IPartnerService _partnerService;
        private readonly IUploadFileService _fileService;
        public PartnerManagementController(IPartnerService partnerService, IUploadFileService fileService)
        {
            _partnerService = partnerService;
            _fileService = fileService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var data = _partnerService.GetAllPartner();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewPartner([FromForm]PartnerDTO model)
        {
            try
            {

                if (model.LogoFile != null)
                {
                    if (model.LogoFile.Length > 1 * 1024 * 1024)
                    {
                        throw new InvalidOperationException("Dung lượng ảnh không được vượt quá 1 mb");
                    }

                }
                string image = await _fileService.SaveFile(model.LogoFile, "Images", new string[] { ".jpg", ".jpeg", ".png" });
                _partnerService.createPartner(model,image);
                return Ok(new {message="Thêm mới đối tác thành công"});
;            }
            catch (Exception ex)
            {
                return BadRequest(new {message = "Đã xảy ra lỗi" + ex.Message});
                throw;
            }
        }
        [HttpGet]
        public IActionResult GetPostById(int id)
        {
            try
            {
                var result = _partnerService.GetPartnerById(id);
               return Json(result);

            }
            catch (Exception ex)
            {
                return Json(new { message = "Đã xảy ra lỗi" + ex.Message });
            }

        }
        [HttpPost]
        public async  Task<IActionResult> UpdatePartner([FromForm]PartnerDTO model)
        {
            try
            {
                if (model.LogoFile != null)
                {
                    if (model.LogoFile.Length > 1 * 1024 * 1024)
                    {
                        throw new InvalidOperationException("Dung lượng ảnh không được vượt quá 1 mb");
                    }
                    var partner = _partnerService.GetPartnerById(model.Id);
                    if(partner != null && partner.Name != null)
                    {
                        _fileService.DeleteFile(partner.Logo, "Images");
                    }
                   string image = await _fileService.SaveFile(model.LogoFile, "Images", new string[] { ".jpg", ".jpeg", ".png" });
                    _partnerService.updatePartner(model,image);
                
                }
                else
                {
                    _partnerService.updatePartner(model, null);
                   
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
           
        }
        [HttpPost]
        public IActionResult DeletePartner(int id)
        {
            try
            {
                _partnerService.deletePartner(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
