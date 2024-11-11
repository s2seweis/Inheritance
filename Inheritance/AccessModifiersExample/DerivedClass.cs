using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AccessModifiersExample
{
    internal class DerivedClass: AccessModifiers
    {
        public DerivedClass()
        {

        }

        public void AccessFields()
        {
            publicField = 1;
            protectedField = 2;
            
            //Inaccessible due to its protection level,
            //only accessible within the same class,
            //no matter if it's a field, poperty or method

            //privateField = 3;
        }
    }
}
