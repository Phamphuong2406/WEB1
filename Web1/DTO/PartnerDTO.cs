namespace Web1.DTO
{
    public class PartnerDTO
    {
        public int? Id { get; set; }
        public string? Logo { get; set; }
       
       public IFormFile?  LogoFile {  get; set; }
        public string? Name { get; set; }
        public bool? IsNone { get; set; }
    }
}
