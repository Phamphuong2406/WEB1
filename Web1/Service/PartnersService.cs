using System.Collections.Generic;
using Web1.Models;


namespace Web1.Service
{
    public interface IPartnersService
    {
        List<GeneralDesription> GetPartners();

    }
    public class PartnersService : IPartnersService
    {
        public List<GeneralDesription> GetPartners()
        {
            return new List<GeneralDesription>
            {
                  new GeneralDesription
            {
                title = "Referanslarımız",
                description = "Bize güvenen ve beraber çalıştığımız iş ortaklarımız",
                partners = new List<Partners>
                {
                    new Partners
                    {
                Logo = "logo1.png",
                Name="Company1"
                    },
                    new Partners
                {
                    Name = "Company2",
                    Logo = "logo2.jpg"
                },
                    new Partners
                {
                    Name = "Company3",
                    Logo = "logo3.png"
                },
                    new Partners
                {
                    Name = "Company4",
                    Logo = "logo4.png"
                },
                    new Partners
                {
                    Name = "Company5",
                    Logo = "logo5.png"
                } ,
                new Partners
                {
                    Name ="Company6",
                    Logo="logo6.png"
                }
                }
                }
            };
        }
    }
}
