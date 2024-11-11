using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.InheritanceExample
{
    // So in order to inherit you are using the colon sign you use the class name of the class you want inherit from

    // Derived Class (Child Class or Subclass):
    // The class that inherits the members of the base class. 
    internal class Dog: Animal // Single Inheritance, a class inherits from another class
    {
        public Dog()
        {

        }
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
