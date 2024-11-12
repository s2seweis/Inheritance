using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.OverrideExample
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

        public override void MakeSound()
        {
            // this will call the animals MakeSound method when the MakeSound method from dog is called
            base.MakeSound();
            Console.WriteLine("The dog has a voice ...");
        }
    }
}
// Summary:
// We can call the method from the base class via base.MakeSound() direct in the derived class
// With the override keyword we can override the method called in derived class;
// For this we need to set the the method in the base class to virtial
