using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ConstructorExample
{
    internal class IndexConstructorExample
    {
        public IndexConstructorExample()
        {
            IndexConstructorExampleMethod();
        }

        public void IndexConstructorExampleMethod()
        {
            //Employee joe = new Employee("Joe", 33, "Sales Rep", 12345);
            //joe.DisplayEmployeeInfo();

            Manager carl = new Manager("Carl", 45, "Manager", 121452, 10 );
            //carl.DisplayManagerInfo();
            carl.BecomeOlder(5);

            carl.DisplayPersoInfo();
            //Console.WriteLine("Hello from IndexConstructorExample class!");

            // Every class inherits from the Object class
        }
    }
}

// Constructors are special methods in a class that are executed when an instance of the class is created.

// #FirstAspect
// In the context of inheritance, the constructors of the base class are called before the constructors of the derived class.
// This ensures that the base class is properly initialized before any additional initialization in the derived class takes place.
// Proper Initialization: Ensures that all fields and properties of the base class are correctly set up before any operations of the derived class can take place. 
// This means that when creating an object of a derived, the constructor of the base class runs first to initialize its members. 

// #SecondAspect
// Consistent State: aintains a consistent and valid state across the object hierarchy 
// This ensures that both the base class and the derived class remain in a valid state throughout the objects lifetime. 
// By running the base class constructor first, we ensure that any dependencies or required initial states are establised. 

/*
 Why Constructor Inheritance is important?
Ensuring base class Initialization: The base class Person has fields Name and Age that must be initialized. 
By calling base(name, age), we ensure that these fields are set up before the Employee constructor continues with its own initialization
Avoiding Code Duplication: The initialization logic for Name and Age is centralizied in the Person class. 
If these fields were initialized separatly in every derived class, it would lead to code duplication and potential erros, 
if the initialization logic needed to be changed. 
 */