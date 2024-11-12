using System;

namespace Inheritance.ConstructorExample
{
    // The Employee class inherits from the Person base class
    internal class Employee : Person
    {
        public string Jobtitle { get; set; }
        public int EmployeeID { get; set; } 
        // Constructor of the Employee class/ derived class constructor
        // It takes 'name' and 'age' parameters and passes them to the base class constructor (Person)
        public Employee(string name, int age, string jobtitle, int employeeID) : base(name, age) // calling the base class constructor 
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

/*
1. Inheritance: The Employee class extends the Person class, inheriting its properties and methods.
2. Base Constructor Call: The : base(name, age) part calls the constructor of the Person class, passing the name and age parameters.
3. Constructor Message: A message is displayed when the Employee constructor is invoked, indicating that this part of the code has executed.
#*/