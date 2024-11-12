using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.InheritanceExample
{
    internal class IndexExampleInheritance
    {
        public IndexExampleInheritance()
        {

            IndexExampleMethod();
        }

        private void IndexExampleMethod()
        {
            Dog mydog = new Dog();

            // inherits the eat method from animal class
            //mydog.Eat();
            // use the bark method defined in the dog class
            //mydog.Bark();

            //Collie mycollie = new Collie();
            //mycollie.Eat();
            //mycollie.Bark();
            //mycollie.GoingNuts();

            Cat mycat = new Cat();
            mycat.Meaow();
            mycat.Eat();

            //Console.WriteLine("Hello World from IndexExample class!");
        }
    }
}

/*
 Summary: 
 1. Base Class
 A base class is a general class from which other classes inherit.
 It provides common properties and methods that derived classes can use or override.)

 2. Derived Class
 A derived class inherits from a base class.
 It can use members of the base class and also define its own additional members.

 Types of inheritance:
    (Easy accessible)
 1. Single Inheritance, A derived class inherits from only one base class. This is the most common type of inheritance in C#.
 2. Multilevel Inheritance, A class can inherit from a derived class, creating a chain of inheritance.
 3. Hierarchical Inheritance, Multiple derived classes inherit from the same base class.
    (where a class inherits from multiple classes, is only possible through interfaces)
 4. Multiple Inheritance (via Interfaces)
 */
