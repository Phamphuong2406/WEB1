namespace Web1.Models
{
    public class Partners
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
    public class GeneralDesription
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<Partners> partners { get; set; }
    }
}
