using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomActivity))]
    public partial class Activity
    {
    }
    public class CustomActivity
    {
        public int id { get; set; }

        [Required]
        public string details { get; set; }
    }
}