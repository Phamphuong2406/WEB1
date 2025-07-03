using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Data
{
    public class Partner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "DisplayOrder phải ≥ 1")]
        public bool IsActive  { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsNoneDesktop { get; set; }
        public bool IsNoneMobile { get; set; }
        public bool? IsNoneTablet { get; set; }

    }
}
