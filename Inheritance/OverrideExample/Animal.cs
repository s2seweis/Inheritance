using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.OverrideExample
{
    // Base Class (Parent Class or Superclass): 
    internal class Animal
    {
        public Animal()
        {

        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        // Virtual keyword allows us to override the make sound method from deriving classes
        // Keyword virtual is used in the base class and keyword override is used in the derived class
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }
    }
}
