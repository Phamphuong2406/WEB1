using Microsoft.AspNetCore.Mvc;
using Web1.Repository;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class IntroduceViewComponent : ViewComponent
    {
     
        private IPostService _postService;
        private ISettingService _settingService;
        public IntroduceViewComponent(IPostService postService, ISettingService settingService)
        {
            _postService = postService;
            _settingService = settingService;
        }
        public IViewComponentResult Invoke()
        {
            int limit = _settingService.GetNumberOfPostsToShow();
            var data = _postService.GetListPost()
                .Take(limit)
                .OrderBy(x =>x.DisplayOrder);
            return View(data);
        }
    }
}
