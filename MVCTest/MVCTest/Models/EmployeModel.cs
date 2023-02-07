using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class EmployeModel
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string MailID { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
    }
}