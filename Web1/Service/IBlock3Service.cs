using Web1.Models;

namespace Web1.Service
{
    public interface IBlock3Service
    {
        Block3Title GetBlock3();
    }
    public class Block3Service : IBlock3Service
    {
        public Block3Title GetBlock3()
        {

            return new Block3Title
            {
                Title = "Test Yonbetimiyle Neler Sagliyoruz?",
                DescriptionTitle = "IoT Destekli Cozumler",
                Icon = "cirle.png",
                Icon2 = "cirle2.png",
                blocks = new List<Block3>
                    {
                        new Block3{Name = "Yazilim kalitesini Arttiyoruz"},
                        new Block3{Name = "Olası Hataları Önceden\r\nBelirliyoruz"},
                        new Block3{Name = "Oluşabilecek Riskleri\r\nÖnlüyoruz"},
                        new Block3{Name = "Zaman ve Maliyetten\r\nTasarruf Sağlıyoruz"}

                    }
            };
            
        }
    }
}
