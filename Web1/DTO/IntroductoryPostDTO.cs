using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.DTO
{
    public class IntroductoryPostDTO
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Content { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        public DateTime ExpireAt { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? Posteddate { get; set; }
        public int? PosterId { get; set; }
        public string? Url { get; set; }
        public bool IsNone { get; set; }

    }
}
