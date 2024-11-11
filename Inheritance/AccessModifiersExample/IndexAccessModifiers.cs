using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AccessModifiersExample
{
    internal class IndexAccessModifiersExample
    {
        public IndexAccessModifiersExample()
        {
            IndexAccessModifiersExampleMethod();
        }

        private void IndexAccessModifiersExampleMethod()
        {
            AccessModifiers accessModifiers = new AccessModifiers();

            accessModifiers.AccessModifiersMethod();

            DerivedClass derivedClass = new DerivedClass();

            derivedClass.AccessFields();
            derivedClass.AccessModifiersMethod();

            //Console.WriteLine("Hello World from the IndexAccessModifiersExample class!");
        }

    }
}
