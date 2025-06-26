using Web1.Data;
using Web1.DTO;
using Web1.Helpers;

namespace Web1.Repository
{
    public interface IIntroductoryPostRepo
    {
        void AddNewPost(IntroductoryPostDTO model, int userId,string img);
        List<IntroductoryPostDTO> getListPost();
        
    }
    public class IntroductoryPostRepo : IIntroductoryPostRepo
    {
        private readonly AppDbContext _context;

        public IntroductoryPostRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddNewPost(IntroductoryPostDTO model, int userId,string img)
        {
            _context.posts.Add(new IntroductoryPost
            {
                title = model.title,
                description = model.description,
                Content = model.Content,
                Image = img,
                Posteddate = DateTime.Now,
                ExpireAt = model.ExpireAt,
                PosterId = userId,
                DisplayOrder = 1,
                Url = Generate.GenerateSlug(model.title)

            });
            _context.SaveChanges();
        }
        public List<IntroductoryPostDTO> getListPost()
        {
            return _context.posts.Select(x => new IntroductoryPostDTO
            {
                title = x.title,
                description = x.description,
                Content = x.Content,
                Image = x.Image,
                Posteddate = x.Posteddate,
                ExpireAt = x.ExpireAt,
                Id = x.Id,
                Url = x.Url,
                PosterId = x.PosterId,
                DisplayOrder = x.DisplayOrder,
            }).ToList();
        }
    }
}
