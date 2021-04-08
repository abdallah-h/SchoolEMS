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
    
    public partial class Parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parent()
        {
            this.Student = new HashSet<Student>();
        }
    
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public System.DateTime birthdate { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string nationalId { get; set; }
        public int genderId { get; set; }
        public int cityId { get; set; }
    
        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
    }
}
