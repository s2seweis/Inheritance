using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.AccessModifiersExample
{

    internal class AccessModifiers
    {
        // access modifiers, these 3 matter but there is an 
        public int publicField;
        protected int protectedField;
        private int privateField;

        public AccessModifiers()
        {
            //AccessModifiersMethod();
        }   

        public void AccessModifiersMethod()
        {
            Console.WriteLine($"Public: {publicField}, " + $"Protected: {protectedField}, Private: {privateField}" );
        }
    }
}
