using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpApplication.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpDept { get; set; }
    }
}