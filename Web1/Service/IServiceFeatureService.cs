using Web1.Models;

namespace Web1.Service
{
    public interface IServiceFeatureService
    {
        List<GeneralServiceFeature> getServiceFeature();
    }
    public class ServiceFeatureService : IServiceFeatureService
    {
        public List<GeneralServiceFeature> getServiceFeature()
        {
            return new List<GeneralServiceFeature>()
            {
                new GeneralServiceFeature
                {

                    SectionTitle = "Kalite ve Süreç Yönetimi",
                    SectionDescription = "Müşterilerimizin yüksek kalite seviyelerini koruyabilmeleri için farklı sektörlerde tecrübe kazanmış uzman kadrolarımızla Proje Yönetimi, İş Analizi ve Test Yönetimi hizmetleri sunmaktayız.",
                    serviceFeature = new List<ServiceFeature>
                    {
                         new ServiceFeature { Icon = "icon1.png", Title = "Döküman Analizi", Description = "Ante vulputate ut at accumsan et. Feugiat at tempus, est senectus amet, elementum." },
                          new ServiceFeature{Icon = "icon2.png", Title = "Kabul ve Değerlendirme", Description = "Ante vulputate ut at accumsan et. Feugiat at tempus, est senectus amet, elementum." },
                           new ServiceFeature { Icon = "icon3.png", Title = "İş Kuralları Analizi", Description = "Ante vulputate ut at accumsan et. Feugiat at tempus, est senectus amet, elementum." },
                          new ServiceFeature{Icon = "icon4.png", Title = "Akış Diyagramları", Description = "Ante vulputate ut at accumsan et. Feugiat at tempus, est senectus amet, elementum." },
                           new ServiceFeature { Icon = "icon5.png", Title = "Paydaş Analizi", Description = "Ante vulputate ut at accumsan et. Feugiat at tempus, est senectus amet, elementum." },
                          new ServiceFeature{Icon = "icon6.png", Title = "Prototipleme", Description = "Ante vulputate ut at accumsan et. Feugiat at tempus, est senectus amet, elementum." }
                    }
                }

            };
        }
    }
}