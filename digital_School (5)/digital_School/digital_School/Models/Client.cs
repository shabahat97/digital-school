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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Certificates = new HashSet<Certificate>();
            this.PaymentConfirmations = new HashSet<PaymentConfirmation>();
            this.ResultClients = new HashSet<ResultClient>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cnic { get; set; }
        public string Contact_No { get; set; }
        public string Image { get; set; }
        public int status { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual Status Status1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentConfirmation> PaymentConfirmations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResultClient> ResultClients { get; set; }
    }
}
