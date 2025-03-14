using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackFun.Data
{
    public class Bowlers
    {
        [Key]
        public int BowlerID { get; set; }
        [Required]
        public string? BowlerFirstName { get; set; }
        [Required]
        public string? BowlerMiddleInit { get; set; }
        [Required]
        public string? BowlerLastName { get; set; }
        [Required]
        public int TeamID { get; set; } // Foreign key reference
        [ForeignKey("TeamID")]
        public Teams TeamName { get; set; }
        [Required]
        public string BowlerAddress { get; set; }
        [Required]
        public string BowlerCity { get; set; }
        [Required]
        public string BowlerState { get; set; }
        [Required]
        public int BowlerZip { get; set; }
        [Required]
        public string BowlerPhoneNumber { get; set; }
    }
}
