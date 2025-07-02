using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Data
{
    public class IntroductoryPost
    {
        [Key]
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string Content { get; set; }
        public string? Image { get; set; }
        public DateTime Posteddate { get; set; }
        public DateTime ExpireAt { get; set; }
        [ForeignKey("Users")]
        public int PosterId { get; set; }
        public int? DisplayOrder { get; set; }
        public string Url { get; set; }
        public bool? IsNone { get; set; }
        public Users User { get; set; }
    }
}
