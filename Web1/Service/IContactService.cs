using Web1.Models;

namespace Web1.Service
{
    public interface IContactService
    {
        Contact GetContact();
    }
    public class ContactService : IContactService
    {
        public Contact GetContact()
        {
            return new Contact
            {
                Icon= "Users.png",
                Title= "Bize Ulaşın",
                Description= "Çözüm, hizmet ve ürünlerimiz hakkında detaylı bilgi için bizimle irtibata geçin.",
                TitleButton= "Bize Ulaşın"
            };
        }
    }
}
