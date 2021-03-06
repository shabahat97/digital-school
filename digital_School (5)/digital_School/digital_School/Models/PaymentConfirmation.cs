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
    
    public partial class PaymentConfirmation
    {
        public int Payment_Id { get; set; }
        public int BankId { get; set; }
        public string Account_No { get; set; }
        public int TransactionTypeId { get; set; }
        public string TransactionSlipNumber { get; set; }
        public string SlipUrl { get; set; }
        public int UserId { get; set; }
        public string IBAN { get; set; }
    
        public virtual Bank Bank { get; set; }
        public virtual Client Client { get; set; }
        public virtual TranscationType TranscationType { get; set; }
    }
}
