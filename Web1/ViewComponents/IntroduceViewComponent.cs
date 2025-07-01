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
        public IViewComponentResult Invoke(string temp, DateTime? validDate)
        {
            int limit = _settingService.GetNumberOfPostsToShow();
            var data = _postService.GetListPost(temp,validDate)

                .OrderBy(x => x.DisplayOrder)
                .Take(limit);
            return View(data);
        }
    }
}
