using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRIS.Api.Models
{
    public class EmployeeRecord
    {
        public Request_LST InputRequest { get; set; }
        public Employee_MST InputEmployee { get; set; }
    }
}