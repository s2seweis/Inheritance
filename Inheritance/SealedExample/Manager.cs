using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SealedExample
{
    // By the use of the sealed keyword in the Employee class,
    // so any other class like  manager can not inherit from employee
    internal class Manager : Employee
    {
        public int TeamSize { get; set; }
        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize) : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
