using Web1.Models;

namespace Web1.Service
{
    public interface IBlock3Service
    {
        List<Block3Title> GetBlock3();
    }
    public class Block3Service : IBlock3Service
    {
        public List<Block3Title> GetBlock3()
        {
            return new List<Block3Title>
            {
                new Block3Title
                {
                    Title = "Test Yonbetimiyle Neler Sagliyoruz?",
                    DescriptionTitle = "IoT Destekli Cozumler",
                    Icon = "cirle.png",
                    blocks = new List<Block3>
                    {
                        new Block3{Name = "Yazilim kalitesini Arttiyoruz"},
                        new Block3{Name = "Olası Hataları Önceden\r\nBelirliyoruz"},
                        new Block3{Name = "Oluşabilecek Riskleri\r\nÖnlüyoruz"},
                        new Block3{Name = "Zaman ve Maliyetten\r\nTasarruf Sağlıyoruz"}

                    }
                }
            };
        }
    }
}
