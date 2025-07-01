using Web1.DTO;
using Web1.Repository;

namespace Web1.Service
{
    public interface IPartnerService
    {
        List<PartnerDTO> GetAllPartner();
        void createPartner(PartnerDTO partnerDTO);
    }
    public class PartnerService: IPartnerService
    {
        private readonly IPartnerPepo _partnerPepo;
        public PartnerService(IPartnerPepo partnerPepo) {
        _partnerPepo = partnerPepo;
        
        }
        public List<PartnerDTO> GetAllPartner()
        {
            try
            {
               return  _partnerPepo.getAllPartner();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void createPartner(PartnerDTO partnerDTO) {
            try
            {
                _partnerPepo.addNewPartner(partnerDTO);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
