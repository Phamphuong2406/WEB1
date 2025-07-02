using Web1.Data;
using Web1.DTO;
using Web1.Repository;

namespace Web1.Service
{
    public interface IPartnerService
    {
        PartnerDTO GetPartnerById(int partnerId);
        List<PartnerDTO> GetAllPartner();
        void createPartner(PartnerDTO partnerDTO, string imageUpload);
    }
    public class PartnerService: IPartnerService
    {
        private readonly IPartnerPepo _partnerPepo;
        public PartnerService(IPartnerPepo partnerPepo) {
        _partnerPepo = partnerPepo;
        
        }
        public PartnerDTO GetPartnerById(int partnerId)
        {
            try
            {
                return _partnerPepo.getPartnerById(partnerId);
            }
            catch (Exception)
            {
                throw new ApplicationException("Không thể thêm bài viết, vui lòng thử lại.");
            }
            
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
        public void createPartner(PartnerDTO partnerDTO, string imageUpload ) {
            try
            {
                _partnerPepo.addNewPartner(partnerDTO, imageUpload);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
