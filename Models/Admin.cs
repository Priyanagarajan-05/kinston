using System.ComponentModel.DataAnnotations;

namespace Kinston_eUniversity.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string AdminName { get; set; }
    }
}
