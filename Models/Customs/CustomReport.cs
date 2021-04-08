using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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