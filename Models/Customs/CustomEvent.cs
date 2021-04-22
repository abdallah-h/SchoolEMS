using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomEvent))]
    public partial class Event
    {
    }
    public class CustomEvent
    {
        public int id { get; set; }

        [Required]
        public string details { get; set; }
    }
}