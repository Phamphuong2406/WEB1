namespace Web1.Models
{
    public class FooterLinkItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public FooterLinkGroup FooterLinkGroup { get; set; }
    }

}
