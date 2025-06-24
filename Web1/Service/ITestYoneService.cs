using Web1.Models;

namespace Web1.Service
{
    public interface ITestYoneService
    {
        TestYoneTitle GetTestYone();
    }
    public class TestYoneService : ITestYoneService
    {
        public TestYoneTitle GetTestYone()
        {

            return new TestYoneTitle
            {
                Title = "Test Yonbetimiyle Neler Sagliyoruz?",
                DescriptionTitle = "IoT Destekli Cozumler",
                Icon = "cirle.png",
                Icon2 = "cirle2.png",
                blocks = new List<TestYone>
                    {
                        new TestYone{Name = "Yazilim kalitesini Arttiyoruz"},
                        new TestYone{Name = "Olası Hataları Önceden\r\nBelirliyoruz"},
                        new TestYone{Name = "Oluşabilecek Riskleri\r\nÖnlüyoruz"},
                        new TestYone{Name = "Zaman ve Maliyetten\r\nTasarruf Sağlıyoruz"}

                    }
            };
            
        }
    }
}
