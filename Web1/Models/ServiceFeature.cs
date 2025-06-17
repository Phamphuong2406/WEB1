namespace Web1.Models
{
    public class GeneralServiceFeature
    {
        public string SectionTitle { get; set; }
        public string SectionDescription { get; set; }
        public List<ServiceFeature> serviceFeature { get; set; }
    }
    public class ServiceFeature
    {
        public string Icon { get; set; }       
        public string Title { get; set; } 
        public string Description { get; set; }
        
    }

}
