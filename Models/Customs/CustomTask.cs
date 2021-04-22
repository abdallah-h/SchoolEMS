using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomTask))]
    public partial class Task
    {
    }
    public class CustomTask
    {
        public int id { get; set; }

        [Required]
        public int semesterId { get; set; }

        [Required]
        public int courseId { get; set; }

        [Required]
        public string taskName { get; set; }

        [Required]
        public string taskDetails { get; set; }

        [Required]
        public string taskFile { get; set; }

        public virtual Course Course { get; set; }
        public virtual Semester Semester { get; set; }
    }
}