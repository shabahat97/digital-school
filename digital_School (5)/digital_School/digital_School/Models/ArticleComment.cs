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
    
    public partial class ArticleComment
    {
        public int CommentId { get; set; }
        public int ArticleId { get; set; }
        public string CommentDescription { get; set; }
        public int Rating { get; set; }
        public System.DateTime CommentedOn { get; set; }
    
        public virtual Article Article { get; set; }
    }
}
