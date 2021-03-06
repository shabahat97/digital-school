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
    
    public partial class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostText { get; set; }
        public System.DateTime PostDate { get; set; }
        public int ThreadId { get; set; }
        public int CourseId { get; set; }
        public int ClassId { get; set; }
        public int SchoolId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Discussion Discussion { get; set; }
        public virtual Tbl_Class Tbl_Class { get; set; }
        public virtual RoleName RoleName { get; set; }
    }
}
