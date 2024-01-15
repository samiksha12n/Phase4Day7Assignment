using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day7Assignment.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public string PCountry { get; set; }
        public string PType { get; set; }
    }
}
