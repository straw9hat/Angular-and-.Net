//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication15.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan_details
    {
        public long Applicant_Id { get; set; }
        public Nullable<long> Car_Id { get; set; }
        public Nullable<long> Loan_Id { get; set; }
        public Nullable<decimal> amount_taken { get; set; }
    
        public virtual Applicant_details Applicant_details { get; set; }
        public virtual Vehicle_details Vehicle_details { get; set; }
        public virtual Loan_schemes Loan_schemes { get; set; }
    }
}
