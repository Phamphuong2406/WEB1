namespace Web1.Models
{
  
    public class FooterModel
    {
        public string Title { get; set; }
        public List<FooterLinkGroup> LinkGroups { get; set; }
        public List<FooterLogoApp> footerLogoApps { get; set; }
    }
    public class FooterLogoApp
    {
        public int Id { get; set; }
        public string NameApp { get; set; }
        public string LogoApp { get; set; }
    }

}
