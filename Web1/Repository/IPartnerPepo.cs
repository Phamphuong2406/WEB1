using Microsoft.EntityFrameworkCore;
using Web1.Data;
using Web1.DTO;

namespace Web1.Repository
{
    public interface IPartnerPepo
    {
        List<PartnerDTO> getAllPartner();
        void addNewPartner(PartnerDTO model);
    }
    public class PartnerRepo : IPartnerPepo
    {
        private readonly AppDbContext _context;
        public PartnerRepo(AppDbContext context)
        {
            _context = context;
            _context = context;

        }
        public List<PartnerDTO> getAllPartner()
        {
            return _context.partners.Select(x => new PartnerDTO
            {
                Id = x.Id,
                Name = x.Name,
                Logo = x.Logo,
                IsNone = x.IsNone,
            }).ToList();
        }
        public void addNewPartner(PartnerDTO model)
        {
            var partner = new Partner
            {
                Name = model.Name,
                Logo = model.Logo,
                IsNone = true,

            };
            _context.partners.Add(partner);
            _context.SaveChanges();
        }
    }
}
