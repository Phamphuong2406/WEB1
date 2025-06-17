using Web1.Models;

namespace Web1.Service
{
    public interface IFooterService
    {
        List<FooterModel> GetSampleFooter();
    }
    public class FooterService: IFooterService
    {
        public List<FooterModel> GetSampleFooter()
        {
            return new List<FooterModel> {   new FooterModel
            {
                Title = "© Copyright 2010-2021 - Can Çevik",
                LinkGroups = new List<FooterLinkGroup>
            {
                new FooterLinkGroup
                {
                    GroupTitle = "Çözüm ve Hizmetler",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem { Text = "Yazılım Geliştirme", Url = "#" },
                        new FooterLinkItem { Text = "Outsourcing", Url = "#" },
                        new FooterLinkItem { Text = "Kalite ve Süreç Yönetimi", Url = "#" },
                        new FooterLinkItem { Text = "Danışmanlık", Url = "#" },
                        new FooterLinkItem { Text = "Danışmanlık", Url = "#" },
                          new FooterLinkItem { Text = "IoT Destekli Çözümler", Url = "#" }
                    }
                },
                new FooterLinkGroup
                {
                    GroupTitle = "Ürünler",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem { Text = "Eğitim Yönetim Sistemi", Url = "#" },
                        new FooterLinkItem { Text = "İnsan Sermayesi Yönetim Sistemi", Url = "#" },
                        new FooterLinkItem { Text = "Müşteri İlişkileri Yönetim Sistemi", Url = "#" },
                        new FooterLinkItem { Text = "İçerik Yönetim Sistemi", Url = "#" }
                    }
                },
                new FooterLinkGroup
                {
                    GroupTitle = "Kurumsal",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem{Text = "Hakkımızda", Url="#"},
                        new FooterLinkItem{Text="Belge ve Yetkinlikler", Url="#"},
                        new FooterLinkItem{Text="İş Ortakları" , Url="#"}
                    }

                },
                  new FooterLinkGroup
                {
                    GroupTitle = "İletişim",
                    Links = new List<FooterLinkItem>
                    {
                        new FooterLinkItem{Text = "Bilgi İstek Formu", Url="#"},
                        new FooterLinkItem{Text="Uzman Talep Formu", Url="#"}
                    }

                }
            }
            }};
              
        }
    }
}
