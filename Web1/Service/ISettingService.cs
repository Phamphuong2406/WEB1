using System.Collections.Generic;
using Web1.Data;
using Web1.DTO;
using Web1.Repository;

namespace Web1.Service
{
    public interface ISettingService
    {
        int GetNumberOfPostsToShow();
        Settings GetSettingById(int id);
        List<SettingDTO> GetAllConfiguration();
        void AddnewSetting(SettingDTO model);
        void UpdateNumberOfPostsToShow(int limit);
        void UpdateDisplaySetting(SettingDTO setting);
        void DeleteDisplaySetting(int settingId);
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
        public Settings GetSettingById(int id)
        {
           
                return _configRepo.getSettingById(id);
        }
        public List<SettingDTO> GetAllConfiguration()
        {
            var config = _configRepo.getAllSetting();
            return config;
        }
        public void AddnewSetting(SettingDTO model)
        {
            try
            {
                _configRepo.AddNewSetting(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi câú hình");
                throw;
            }
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
        public void UpdateDisplaySetting(SettingDTO setting)
        {
            try
            {
                _configRepo.EditSetting(setting);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi cấu hình");
                throw new ApplicationException("Không thể cấu hình, vui lòng thử lại.");
            }
        }
        public void DeleteDisplaySetting(int settingId)
        {
            try
            {
                _configRepo.deleteSetting(settingId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Lỗi cấu hình");
                throw new ApplicationException("Không thể cấu hình, vui lòng thử lại.");
            }
        }
    }
}
