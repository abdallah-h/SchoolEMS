using System.ComponentModel.DataAnnotations;

namespace SchoolEMS.Models
{
    [MetadataType(typeof(CustomAttendance))]
    public partial class Attendance
    {
    }
    public class CustomAttendance
    {
        public int id { get; set; }

        [Required]
        public int attendanceTypeId { get; set; }

        [Required]
        public string attendanceFile { get; set; }

        public virtual AttendanceType AttendanceType { get; set; }
    }
}