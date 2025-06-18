using System.Collections.Generic;
using Web1.Models;


namespace Web1.Service
{
    public interface IPartnersService
    {
        GeneralDesription GetPartners();

    }
    public class PartnersService : IPartnersService
    {
        public GeneralDesription GetPartners()
        {
            return new GeneralDesription
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
                    Logo = "logo2.png"
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
                },
                    new Partners
                {
                    Name = "Company7",
                    Logo = "logo7.png"
                } ,
                        new Partners
                {
                    Name = "Company8",
                    Logo = "logo8.png"
                } ,
                            new Partners
                {
                    Name = "Company9",
                    Logo = "logo9.png"
                } 
                }
            };
        }
    }
}
