using System.ComponentModel.DataAnnotations;

namespace Web1.ViewModel
{
    public class SubscribeViewModel
    {
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        public string Email { get; set; }
    }
}
