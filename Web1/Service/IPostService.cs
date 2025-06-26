
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Web1.DTO;
using Web1.Repository;

namespace Web1.Service
{
    public interface IPostService
    {
        void CreatePost(IntroductoryPostDTO postDTO, int userIed, string image);
        List<IntroductoryPostDTO> GetListPost();
    }
    public class PostService : IPostService
    {
        private readonly ILogger<UserService> _logger;
        private IIntroductoryPostRepo _postRepo;
        public PostService(IIntroductoryPostRepo postRepo, ILogger<UserService> logger)
        {
            _postRepo = postRepo;
            _logger = logger;
        }
        public List<IntroductoryPostDTO> GetListPost()
        {
            try
            {
               return _postRepo.getListPost();

            }
            catch (Exception)
            {

                throw new ApplicationException("Có lỗi xảy ra khi gọi danh sách bài viết");
            }
        }
        public void CreatePost(IntroductoryPostDTO postDTO, int userId, string image)
        {
            try
            {
                _postRepo.AddNewPost(postDTO, userId, image);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi khi thêm bài viết");
                throw new ApplicationException("Không thể thêm bài viết, vui lòng thử lại.");//Ném lỗi lên tầng trên để xử lý
            }
           
        }
    }
}
