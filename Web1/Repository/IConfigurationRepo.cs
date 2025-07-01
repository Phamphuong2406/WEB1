using Web1.Data;
using Web1.DTO;

namespace Web1.Repository
{
    public interface IConfigurationRepo
    {
        int getNumberOfDisplays();
        Settings getSettingById(int settingId);
        List<SettingDTO> getAllSetting();
        void AddNewSetting(SettingDTO model);
        void EditNumberOfDisplays(int limit);
        void EditSetting(SettingDTO model);
        void deleteSetting(int id);
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
        public Settings getSettingById(int settingId)
        {
            return _context.settings.FirstOrDefault(x => x.Id == settingId);
        }
        public List<SettingDTO> getAllSetting()
        {
            return _context.settings.Select( x=> new SettingDTO
            {
                Id = x.Id,
                Key = x.Key,
                Value = x.Value,
                Description = x.Description,

            }).ToList();
        }
        public void AddNewSetting(SettingDTO model)
        {
            _context.settings.Add(new Settings
            {
                Key = model.Key,
                Value = model.Value,
                Description = model.Description,
            });
            _context.SaveChanges();
        }
        public void EditNumberOfDisplays(int limit)
        {
           var existingPost =  _context.settings.FirstOrDefault(x => x.Key == "NumberOfPostsShown");
            existingPost.Value = limit.ToString();
            _context.SaveChanges();
        }
        public void EditSetting(SettingDTO model)
        {
            var settingUpdate = _context.settings.FirstOrDefault(x => x.Id == model.Id);
            if(settingUpdate != null)
            {
                settingUpdate.Description = model.Description;
                settingUpdate.Value = model.Value;
                _context.SaveChanges();
            }

            
        }
        public void deleteSetting(int id)
        {
            var settingdelete = _context.settings.FirstOrDefault(x => x.Id == id);
            if(settingdelete != null)
            {
                _context.settings.Remove(settingdelete);
                _context.SaveChanges();
            }
        }
    }
}
