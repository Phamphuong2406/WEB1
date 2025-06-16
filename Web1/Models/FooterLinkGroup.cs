namespace Web1.Models
{
   
    public class FooterLinkGroup
    {
        public int Id { get; set; }
        public string GroupTitle { get; set; }

        public int FooterModelId { get; set; } 
        public FooterModel FooterModel { get; set; }

        public List<FooterLinkItem> Links { get; set; }
    }

}
