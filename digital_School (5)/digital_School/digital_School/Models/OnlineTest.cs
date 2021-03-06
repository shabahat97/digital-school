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
    
    public partial class OnlineTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OnlineTest()
        {
            this.OnlineTestAnswers = new HashSet<OnlineTestAnswer>();
            this.OnlineTestQuestionOptions = new HashSet<OnlineTestQuestionOption>();
        }
    
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public bool IsMultiple { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ClassId { get; set; }
        public string Duration { get; set; }
        public int Role_Id { get; set; }
        public int CourseId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public Nullable<int> SchoolId { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual OnlineTest OnlineTest1 { get; set; }
        public virtual OnlineTest OnlineTest2 { get; set; }
        public virtual RoleName RoleName { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnlineTestAnswer> OnlineTestAnswers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnlineTestQuestionOption> OnlineTestQuestionOptions { get; set; }
        public virtual Tbl_Class Tbl_Class { get; set; }
    }
}
