using System.ComponentModel.DataAnnotations;

namespace Web1.DTO
{
    public class PartnerDTO
    {
        public int Id { get; set; }
        public string? Logo { get; set; }
       
       public IFormFile?  LogoFile {  get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsNoneDesktop { get; set; }
        public bool IsNoneMobile { get; set; }
        public bool? IsNoneTablet { get; set; }
    }
}
