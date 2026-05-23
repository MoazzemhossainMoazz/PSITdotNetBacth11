using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employeelist = new List<Employee>();
            Employee employee1 = new Employee()
            {
                Name = "Sakib",
                DOB = new DateTime(1992, 3, 2),
                JoinDate = new DateTime(2020, 1, 2),
                GradeName=Employee.Grade.Junior,
                RolePlays = "Developer"
            };

            Employee employee2 = new Employee() 
            { Name = "Tamim", DOB = new DateTime(1993, 4, 3), JoinDate = new DateTime(2023, 1, 3), GradeName = Employee.Grade.Senior, RolePlays ="Developer" 
            };
            Employee employee3 = new Employee() 
            { Name = "Mushfiq", DOB = new DateTime(1991, 4, 3), JoinDate = new DateTime(2023, 3, 3), GradeName = Employee.Grade.Lead, RolePlays = "HR" 
            };

            Employeelist.Add(employee1);
            Employeelist.Add(employee2);
            Employeelist.Add(employee3);

            Console.WriteLine($"ID\tName\tDOB\tJoinDate\tGrade\tRolePlays");
            foreach (var employee in Employeelist)
            {
                Console.WriteLine(employee.Id + "\t" + employee.Name + "\t" + employee.DOB.ToShortDateString() + "\t" + employee.JoinDate.ToShortDateString() + "\t" + employee.GradeName + "\t" + employee.RolePlays);
            }
            

        }
    }
}
