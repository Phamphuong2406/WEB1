using Web1.Repository;

namespace Web1.Service
{
    public interface ISettingService
    {
        int GetNumberOfPostsToShow();
        void UpdateNumberOfPostsToShow(int limit);
    }
    public class SettingService: ISettingService
    {
        private readonly IConfigurationRepo _configRepo;
        private readonly ILogger<UserService> _logger;
        public SettingService(IConfigurationRepo configRepo, ILogger<UserService> logger) { 
            _configRepo = configRepo;
            _logger = logger;
        }
        public int GetNumberOfPostsToShow()
        {
           return  _configRepo.getNumberOfDisplays();
        }
        public void UpdateNumberOfPostsToShow(int limit)
        {
            try
            {
                _configRepo.EditNumberOfDisplays(limit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi cấu hình");
                throw new ApplicationException("Không thể cấu hình, vui lòng thử lại.");
            }
        }
    }
}
