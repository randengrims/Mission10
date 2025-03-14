using System.ComponentModel.DataAnnotations;

namespace FullStackFun.Data
{
    public class Teams
    {
        [Key]
        public int TeamID { get; set; } // Primary Key

        [Required]
        public string TeamName { get; set; } // Team Name
    }
}
