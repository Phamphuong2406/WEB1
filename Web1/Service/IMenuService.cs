using System.Security.Cryptography.X509Certificates;
using Web1.Models;

namespace Web1.Service
{
    public interface IMenuService
    {
        MenuButton  GetMenu();
    }
    public class MenuService : IMenuService
    {
        public MenuButton GetMenu()
        {
            return new MenuButton
            {
                ButtonTitle= "İletişim",
                menus = new List<Menu>
                {
new Menu{Title= "Çözüm ve Hizmetler"},
                 new Menu{Title= "Ürünler"},
                  new Menu{Title= "Teknolojiler"},
                   new Menu{Title= "İnsan Kaynakları"},
                    new Menu{Title= "Kurumsal"},
                }
            };

        }
    }
}
