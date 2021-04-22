using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomGrade))]
    public partial class Grade
    {
        
    }
    public class CustomGrade
    {
        public int id { get; set; }

        [Required]
        public int gradeTypeId { get; set; }

        [Required]
        public string gradeFile { get; set; }

        public virtual GradeType GradeType { get; set; }
    }
}