using System.ComponentModel.DataAnnotations;

namespace Web1.Data
{
    public class IntroductoryPost
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Posteddate {get; set;}
    }
}
