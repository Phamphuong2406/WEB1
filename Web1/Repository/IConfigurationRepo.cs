using Web1.Data;

namespace Web1.Repository
{
    public interface IConfigurationRepo
    {
        int getNumberOfDisplays();
        void EditNumberOfDisplays(int limit);
    }
    public class ConfigurationRepo: IConfigurationRepo
    {
        private readonly AppDbContext _context;
        public ConfigurationRepo(AppDbContext context)
        {
            _context = context;

        }
        public int getNumberOfDisplays()
        {
            var setting = _context.settings.FirstOrDefault(x => x.Key == "NumberOfPostsShown");
            if (setting != null && int.TryParse(setting.Value, out int number))
            {

                return number;
            }
            else
            {
                return 2;
            }
        }
        public void EditNumberOfDisplays(int limit)
        {
           var existingPost =  _context.settings.FirstOrDefault(x => x.Key == "NumberOfPostsShown");
            existingPost.Value = limit.ToString();
            _context.SaveChanges();
        }
    }
}
