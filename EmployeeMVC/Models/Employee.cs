using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public class Employee
    {
       [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string DeptName { get; set; }
        
    }
}
