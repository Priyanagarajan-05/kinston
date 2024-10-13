using System.ComponentModel.DataAnnotations;

namespace Kinston_eUniversity.Models
{
    public class CourseModule
    {
        [Key]
        public int ModuleId { get; set; }
        public int CourseId { get; set; } // Foreign key
        public string ModuleTitle { get; set; }
        public string ModuleContent { get; set; }
    }
}
