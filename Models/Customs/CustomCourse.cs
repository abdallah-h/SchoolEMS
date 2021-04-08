using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomCourse))]
    public partial class Course
    {        
    }
    public class CustomCourse
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string courseCode { get; set; }

        [Required]
        public int semesterId { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}