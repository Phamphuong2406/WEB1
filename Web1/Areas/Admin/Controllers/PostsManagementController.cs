using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Web1.Data;
using Web1.DTO;
using Web1.Service;
using Web1.ViewModel;

namespace Web1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PostsManagementController : Controller
    {
        private readonly IPostService _postService;
        private readonly IUploadFileService _fileService;
        private readonly ISettingService _settingService;
        public PostsManagementController(AppDbContext context, IPostService postService, IUploadFileService fileService, ISettingService settingService)
        {
            _postService = postService;
            _fileService = fileService;
            _settingService = settingService;
        }
        public IActionResult Index(string temp ="", int currentPage = 1,DateTime? validDate = null, DateTime? postingStartDate = null, DateTime? postingEndDate = null)
        {
            temp =string.IsNullOrEmpty(temp)?"": temp.ToLower();
            int pageSize = 2;
           
            try
            {
                var data = _postService.GetListPost(temp,validDate, postingStartDate, postingEndDate);

                int totalRecord = data.Count();
                int totalPage = (int)Math.Ceiling(totalRecord / (double)pageSize);
                //current=1, skip(1-1=0), take=5
                //currentPage = 2, skip(2-1)*5 = 5

                var pagedData = data.Skip((currentPage - 1) * pageSize).Take(pageSize);

                var model = new PostPagingViewModel
                {
                    Posts = pagedData,
                    CurrentPage = currentPage,
                    TotalPage = totalPage,
                    Temp = temp,
                    ValidDate = validDate,
                    PostingStartDate = postingStartDate,
                    PostingEndDate = postingEndDate
                };


                return View(model);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Lỗi " + ex.Message });
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
        [HttpGet]
        public IActionResult CreateNewPost()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewPost([FromForm] IntroductoryPostDTO postDTO)
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
                string image = await _fileService.SaveFile(postDTO.ImageFile, "Images", new string[] { ".jpg", ".jpeg", ".png" });
                _postService.CreatePost(postDTO, userId, image);
                return Ok(new { message = "Thêm mới thành công bài viết" });


            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(new { message = "Đã xảy ra lỗi " + ex.Message });
            }

        }
        [HttpPost]
        public IActionResult DeletePost(int id)
        {

            var result = _postService.DeletePost(id);
            var imgdelete = _postService.GetPostbyPostId(id);
            if (imgdelete != null)
            {
                _fileService.DeleteFile(imgdelete.Image, "Images");
            }
            if (result == "Bài viết đã được xóa thành công")
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost]
        public IActionResult SetPostLimit(int limit)
        {
            try
            {
                _settingService.UpdateNumberOfPostsToShow(limit);
                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return BadRequest(new { message = "Đã xảy ra lỗi " + ex.Message });
            }

        }
        [HttpGet]
        public IActionResult UpdatePost(int Id)
        {
            var post = _postService.GetPostbyPostId(Id);
            return View(post);
        }
        [HttpPost]
        public async Task<ActionResult> UpdatePost(IntroductoryPostDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.Length > 1 * 1024 * 1024)
                    {
                        throw new InvalidOperationException("Dung lượng ảnh không được vượt quá 1 mb");
                    }
                    var imgdelete = _postService.GetPostbyPostId(model.Id);
                    if (imgdelete != null) {
                        _fileService.DeleteFile(imgdelete.Image, "Images");
                    }

                    string image = await _fileService.SaveFile(model.ImageFile, "Images", new string[] { ".jpg", ".jpeg", ".png" });
                    _postService.UpdatePost(model, image);
                    return RedirectToAction("Index");
                }
                else
                {
                    _postService.UpdatePost(model, null);
                    return RedirectToAction("Index");
                }


            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                throw;
            }
        }

    }
}
