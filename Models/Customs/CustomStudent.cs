using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomStudent))]
    public partial class Student
    {
    }
    public class CustomStudent
    {
        public int id { get; set; }

        [Required]
        public int parentId { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string code { get; set; }

        [Required]
        public System.DateTime birthdate { get; set; }

        [Required]
        public int genderId { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public int age { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Parent Parent { get; set; }
    }
}