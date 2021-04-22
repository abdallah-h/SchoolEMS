using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomReport))]
    public partial class Report
    {
    }
    public class CustomReport
    {
        public int id { get; set; }

        [Required]
        public string details { get; set; }
    }
}