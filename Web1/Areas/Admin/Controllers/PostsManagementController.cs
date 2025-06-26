using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using Web1.Data;
using Web1.DTO;
using Web1.Service;

namespace Web1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PostsManagementController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUploadFileService _fileService;
        public PostsManagementController(AppDbContext context, IPostService postService, IUploadFileService fileService)
        {
            _postService = postService;
            _fileService = fileService;
        }
        public IActionResult Index()
        {
            try
            {
                var data = _postService.GetListPost();
                return View(data);
            }
            catch (Exception ex)
            {
                return BadRequest(new {message = "Lỗi " + ex.Message});
            }
           
        }
        public int? CurrentUser()
        {

            var claim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (claim != null && int.TryParse(claim, out int userId))
            {
                return userId;
            }
            return null;
        }
        [HttpPost]
        public IActionResult CreateNewPost([FromForm] IntroductoryPostDTO postDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
          
            int userId = CurrentUser() ?? -1;
            if (userId == -1)
            {
                return Unauthorized();
            }
            try
            {
                if (postDTO.ImageFile != null)
                {
                    if (postDTO.ImageFile.Length > 1 * 1024 * 1024)
                    {
                        throw new InvalidOperationException("Dung lượng ảnh không được vượt quá 1 mb");
                    }
                   
                }
                string image = _fileService.SaveFile(postDTO.ImageFile, "Images", new string[] { ".jpg", ".jpeg", ".png" });
                _postService.CreatePost(postDTO, userId, image);
                return Ok(new { message = "Thêm mới thành công bài viết" });


            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(new {message = "Đã xảy ra lỗi " + ex.Message});
            }
           
        }
        [HttpPost]
        public IActionResult actionResult(int id) {

            return Ok();
        
        
        }
    }
}
