//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace digital_School.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseAssignToTeacher
    {
        public int Assign_Id { get; set; }
        public int Class_Id { get; set; }
        public int courseId { get; set; }
        public int School_Id { get; set; }
        public int TeacherId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Tbl_Class Tbl_Class { get; set; }
        public virtual School School { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
