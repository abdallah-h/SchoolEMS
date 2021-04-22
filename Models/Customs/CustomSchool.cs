using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomSchool))]
    public partial class School
    {
    }
    public class CustomSchool
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
        public string schoolName { get; set; }

        [Required]
        public string schoolAddress { get; set; }

        [Required]
        public string mobile { get; set; }
    }
}