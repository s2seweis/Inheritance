using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ConstructorExample
{
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
