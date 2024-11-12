using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.OverrideExample
{
    //Hierarchical Inheritance
    internal class Cat: Animal
    {
        public Cat()
        {

        }
        public void Meaow()
        {
            Console.WriteLine("Cat is meaowing!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The cat has a voice ...");
        }
    }
}
