
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Web1.DTO;
using Web1.Repository;

namespace Web1.Service
{
    public interface IPostService
    {
        void CreatePost(IntroductoryPostDTO postDTO, int userIed, string image);
        List<IntroductoryPostDTO> GetListPost(string temp, DateTime? validDate, DateTime? postingStartDate = null, DateTime? postingEndDate = null);
        string DeletePost(int idPost);
        IntroductoryPostDTO GetPostbyPostId(int idPost);
        void UpdatePost(IntroductoryPostDTO model, string? imageUpdate);
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
        public IntroductoryPostDTO GetPostbyPostId(int idPost)
        {
            try
            {
                return _postRepo.getPostbyId(idPost);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi khi hiển thị bài viết");
                throw new ApplicationException("Có lỗi xảy ra khi hiển thị bài viết");
            }
        }
        public List<IntroductoryPostDTO> GetListPost(string temp, DateTime? validDate, DateTime? postingStartDate = null, DateTime? postingEndDate = null)
        {
            try
            {
               return _postRepo.getListPost(temp,validDate, postingStartDate, postingEndDate);

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
        public string DeletePost(int idPost)
        {
          
               var result = _postRepo.deletePost(idPost);
                if (result ==1 )
                {
                    return "Bài viết đã được xóa thành công";

                }
                return "Không thể xóa bài viết vui lòng thử lại";
        }
        public void UpdatePost(IntroductoryPostDTO model, string? imageUpdate)
        {
            try
            {
                _postRepo.UpdatePost(model, imageUpdate);
            }
            catch (Exception )
            {

                throw;
            }
        }

    }
}
