//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolEMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int id { get; set; }
        public int scheduleTypeId { get; set; }
        public string scheduleFile { get; set; }
    
        public virtual ScheduleType ScheduleType { get; set; }
    }
}
