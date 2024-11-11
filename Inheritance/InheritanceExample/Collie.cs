using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.InheritanceExample
{
    //Collie inherits from class dog but also from class animal
    internal class Collie: Dog
    {
        public Collie()
        {

        }

        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
    }
}
