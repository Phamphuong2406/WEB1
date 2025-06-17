using Web1.Models;

namespace Web1.Service
{
    public interface IHeaderService
    {
        Header GetHeader();
    }
    public class HeaderService : IHeaderService
    {
        public Header GetHeader()
        {
            return new Header
            {
                title = "Bilgi Teknolojilerinde\r\n23 Yıllık Tecrübe",
image = "Rectangle.png",
                description = "Müşterilerimizin yüksek kalite seviyelerini koruyabilmeleri için farklı sektörlerde tecrübe kazanmış uzman kadrolarımızla Proje Yönetimi, İş Analizi ve Test Yönetimi hizmetleri sunmaktayız.",
LabelButton = "Kayıt Ol"
            };
        }
    }
}
