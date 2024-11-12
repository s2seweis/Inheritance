using System;

namespace Inheritance.SealedExample
{
    // Use sealed just before the class keyword, this way you seal class from inheritance
    //internal sealed class Employee : Person
    internal class Employee : Person
    {
        public string Jobtitle { get; set; }
        public int EmployeeID { get; set; } 
        public Employee(string name, int age, string jobtitle, int employeeID) : base(name, age) 
        {
            Jobtitle=jobtitle;
            EmployeeID=employeeID;
            Console.WriteLine("Employee (derived class) constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersoInfo();
            Console.WriteLine($"Job Title: {Jobtitle}, Employee ID: {EmployeeID} ");
        }
    }
}

