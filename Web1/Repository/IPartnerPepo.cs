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
        void UpdatePartner(PartnerDTO model, string? imgUpdate);
        void DeletePartner(int idPartner);
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
                IsActive = data.IsActive
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
                Description = x.Description,
                DisplayOrder = x.DisplayOrder,
                IsNoneMobile = x.IsNoneMobile,
            }).ToList();
        }
        public void addNewPartner(PartnerDTO model, string logoImage)
        {
            var partner = new Partner
            {
                Name = model.Name,
                Logo = logoImage,
                Description = model.Description,
                IsActive = true
            };
            _context.partners.Add(partner);
            _context.SaveChanges();
        }
        public void UpdatePartner(PartnerDTO model, string? imgUpdate)
        {
            var partner = _context.partners.FirstOrDefault(x => x.Id == model.Id);
            if (partner != null)
            {
                if (imgUpdate != null)
                {
                    partner.Logo = imgUpdate;
                }
                partner.Name = model.Name;
                partner.Description = model.Description;
                partner.IsActive = model.IsActive;
                _context.SaveChanges();

            }
        }
        public void DeletePartner(int idPartner)
        {
            var partner = _context.partners.FirstOrDefault(x => x.Id == idPartner);
            if (partner != null)
            {
                _context.partners.Remove(partner);
                _context.SaveChanges();

            }
        }

    }
}
