using System.ComponentModel.DataAnnotations;

namespace Kinston_eUniversity.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfessorName { get; set; }
        public string Department { get; set; }
        public string Status { get; set; } // active/suspended
        public DateTime? SuspensionStartDate { get; set; }
        public DateTime? SuspensionEndDate { get; set; }
    }
}
