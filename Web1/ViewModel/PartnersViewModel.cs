using Web1.DTO;
using Web1.Models;

namespace Web1.ViewModel
{
    public class PartnersViewModel
    {
        public string? title { get; set; }
        public string? description { get; set; }
        public int? displaySetting {  get; set; }
        public int NumberOfColumns { get; set; }
        public List<PartnerDTO> partners { get; set; }
    }
}
