using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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