using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.InheritanceExample;
using Inheritance.AccessModifiersExample;
using Inheritance.OverrideExample;
using Inheritance.ConstructorExample;
using Inheritance.SealedExample;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndexExampleInheritance indexExample = new IndexExampleInheritance();
            //IndexAccessModifiersExample example = new IndexAccessModifiersExample();
            //IndexExampleOverride indexExampleOverride = new IndexExampleOverride();

            // calls the new object and the constructor of the new object calls the methods
            //IndexConstructorExample indexConstructorExample = new IndexConstructorExample();
            // calls the methods direct
            //indexConstructorExample.IndexConstructorExampleMethod();

            IndexSealedExample indexSealedExample = new IndexSealedExample();

            Console.ReadKey();
        }

    }
}
