using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Web1.Service;
using Web1.ViewModel;

namespace Web1.ViewComponents
{
    public class PartnersViewComponent: ViewComponent
    {
        private readonly IPartnerService _partnerService;
        private readonly ISettingService _settingService;
        public PartnersViewComponent(IPartnerService partnerService, ISettingService settingService)
        {
            _partnerService = partnerService;
            _settingService = settingService;
        }
        public IViewComponentResult Invoke()
        {
            var displaySetting = _settingService.GetPartnerDisplayShape();
            var data = _partnerService.GetAllPartner()
                .OrderBy(x =>x.DisplayOrder).ToList();
            var vm = new PartnersViewModel
            {
                title = "Referanslarımız",
                description = "Bize güvenen ve beraber çalıştığımız iş ortaklarımız",
                displaySetting = displaySetting,
                partners = data
            };
            return View(vm);
        }
       
    }
}
