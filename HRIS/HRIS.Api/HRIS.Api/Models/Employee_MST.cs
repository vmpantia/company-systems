//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRIS.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_MST
    {
        public System.Guid InternalID { get; set; }
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeType { get; set; }
        public System.Guid Department_InternalID { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
