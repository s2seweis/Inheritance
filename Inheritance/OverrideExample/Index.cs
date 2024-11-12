using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.OverrideExample
{
    internal class IndexExampleOverride
    {
        public IndexExampleOverride()
        {
            IndexExampleMethod();
        }

        private void IndexExampleMethod()
        {

            //Animal animal = new Animal();
            //animal.MakeSound();
            Console.WriteLine("Dog Methods: ");
            Dog dog = new Dog();
            dog.MakeSound();

            Console.WriteLine("Cat Methods: ");
            Cat cat = new Cat();
            cat.MakeSound();


            //Console.WriteLine("Hello from OverrideExample class!");

        }
     }
}
