using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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