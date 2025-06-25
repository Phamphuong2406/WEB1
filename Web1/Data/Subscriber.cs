using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Data
{
    public class Subscriber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int EmailId { get; set; }
        public string Email { get; set; }
        public DateTime TimeSent { get; set; }
        public string Status { get; set; }
    }
}
