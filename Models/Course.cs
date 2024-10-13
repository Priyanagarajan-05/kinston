using System.ComponentModel.DataAnnotations;

namespace Kinston_eUniversity.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int ProfessorId { get; set; } // Foreign key
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }
        public string CourseStatus { get; set; } // pending/approved/suspended/deleted
        public int BatchNumber { get; set; }
    }
}
