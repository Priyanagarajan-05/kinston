using System.ComponentModel.DataAnnotations;

namespace Kinston_eUniversity.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StudentName { get; set; }
        public string Department { get; set; }
        public int? CurrentCourseId { get; set; } // Foreign key to Course
        public DateTime? CourseStartDate { get; set; }
        public DateTime? CourseEndDate { get; set; }
        public string CourseStatus { get; set; } // in_progress/completed/incomplete
    }
}
