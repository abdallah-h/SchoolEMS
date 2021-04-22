using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomSchedule))]
    public partial class Schedule
    {        
    }
    public class CustomSchedule
    {
        public int id { get; set; }

        [Required]
        public int scheduleTypeId { get; set; }

        [Required]
        public string scheduleFile { get; set; }

        public virtual ScheduleType ScheduleType { get; set; }
    }
}