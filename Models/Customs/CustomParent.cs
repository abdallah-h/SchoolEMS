using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomParent))]
    public partial class Parent
    {
    }
    public class CustomParent
    {
        public int id { get; set; }

        [RegularExpression(@"^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$", ErrorMessage = "Please Enter valid Email")]
        [Required(ErrorMessage ="Please Enter Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirmation of Password")]
        [Compare("password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string confirmPassword { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        public System.DateTime birthdate { get; set; }

        [Required]
        public string mobile { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string nationalId { get; set; }

        [Required]
        public int genderId { get; set; }

        [Required]
        public int cityId { get; set; }

        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
    }
}