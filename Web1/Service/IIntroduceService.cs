using Web1.Models;

namespace Web1.Service
{
    public interface IIntroduceService
    {
        List<Introduce> GetIntroduce();
    }
    public class IntroduceService: IIntroduceService
    {
        public List<Introduce> GetIntroduce()
        {
            return new List<Introduce>
            {
                new Introduce
                {
                    title="Kalite ve Süreç Yönetimi",
                    description="Deneyimli kadromuz; birçok farklı sektörden deneyimli, PMP® sertifikasına sahip, uzman proje yöneticilerinden oluşmaktadır. Projelerinizin yönetimine destek olmak, zayıf olduğunu düşündüğünüz alanları güçlendirmek, uluslararası geçerliliği olan PMI® metodolojisini şirketinizde uygulamak ve geliştirmek için yanınızdayız.",
                    Image = "Illustration.png",
                },
                  new Introduce
                {
                    title="Test Yönetimi ve Analizi",
                    description="Danışmanlığını yürüttüğümüz projelerde yazılım hatalarını önlemek amacıyla gerçekleştirdiğimiz testleri her proje aşamasında manuel ya da test otomasyonu ile dikkatle uygulamaktayız. Deneyimli test ekibimiz, kurumlara yüksek kalitede yazılım testleri hizmeti ile baştan sona güvenli, kaliteli ve tatmin edici bir müşteri deneyimi sunmaktadır.",
                    Image = "Illustration.jpg",
                }
            };
        }
    }
}
