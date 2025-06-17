using Web1.Models;

namespace Web1.Service
{
    public interface IBlock6Service
    {
        Block6 GetBlock6();
    }
    public class  Block6Service: IBlock6Service
    {
        public Block6 GetBlock6()
        {
            return new Block6
            {
                Icon= "Users.png",
                Title= "Bize Ulaşın",
                Description= "Çözüm, hizmet ve ürünlerimiz hakkında detaylı bilgi için bizimle irtibata geçin.",
                TitleButton= "Bize Ulaşın"
            };
        }
    }
}
