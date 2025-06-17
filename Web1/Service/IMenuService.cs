using System.Security.Cryptography.X509Certificates;
using Web1.Models;

namespace Web1.Service
{
    public interface IMenuService
    {
        List<Menu> GetMenu();
    }
    public class MenuService : IMenuService
    {
        public List<Menu> GetMenu()
        {
            return new List<Menu>()
            {
                new Menu{Title= "Çözüm ve Hizmetler"},
                 new Menu{Title= "Ürünler"},
                  new Menu{Title= "Teknolojiler"},
                   new Menu{Title= "İnsan Kaynakları"},
                    new Menu{Title= "Kurumsal"},
                    new Menu{Title="İletişim"}
            };

        }
    }
}
