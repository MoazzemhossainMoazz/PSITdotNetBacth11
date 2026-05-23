using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    internal class Employee
    {
        static int idCounter = 0;
        public Employee()
        {
            Id = ++idCounter;
        }

        
        public enum Grade
        {
            Junior = 1,
            Mid,
            Senior,
            Lead,
            Manager
        }

        public int Id { get; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoinDate { get; set; }
        public Grade GradeName { get; set; } 
        public string RolePlays { get; set; }
    }
}
