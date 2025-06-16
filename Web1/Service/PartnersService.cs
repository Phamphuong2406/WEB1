using System.Collections.Generic;
using Web1.Models;
using Web1.Repository;

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
                title = "Title1",
                description = "description1",
                partners = new List<Partners>
                {
                    new Partners
                    {
                Logo = "Conpany1.png",
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
                } }
                }
            };
        }
    }
}
