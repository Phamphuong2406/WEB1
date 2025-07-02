using Microsoft.EntityFrameworkCore;
using Web1.Data;
using Web1.DTO;

namespace Web1.Repository
{
    public interface IPartnerPepo
    {
        PartnerDTO getPartnerById(int partnerId);
        List<PartnerDTO> getAllPartner();
        void addNewPartner(PartnerDTO model, string logoImage);
    }
    public class PartnerRepo : IPartnerPepo
    {
        private readonly AppDbContext _context;
        public PartnerRepo(AppDbContext context)
        {
            _context = context;
            _context = context;

        }
        public PartnerDTO getPartnerById(int partnerId)
        {
            var data = _context.partners.FirstOrDefault(x => x.Id == partnerId);
            if (data == null)
            {
                return null;
            }
            var result = new PartnerDTO
            {
                Id = data.Id,
                Name = data.Name,
                Logo = data.Logo,
                IsNone = data.IsNone,
            };
            return result;
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
        public void addNewPartner(PartnerDTO model, string logoImage)
        {
            var partner = new Partner
            {
                Name = model.Name,
                Logo = logoImage,
                IsNone = true,

            };
            _context.partners.Add(partner);
            _context.SaveChanges();
        }
    }
}
