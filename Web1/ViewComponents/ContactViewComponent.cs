using Microsoft.AspNetCore.Mvc;
using Web1.Service;

namespace Web1.ViewComponents
{
    public class ContactViewComponent :ViewComponent
    {
        private IContactService _contactService;
        public ContactViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IViewComponentResult Invoke()
        {
            var data = _contactService.GetContact();
            return View(data);
        }
    }
}
