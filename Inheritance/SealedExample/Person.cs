using System;

namespace Inheritance.SealedExample
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Person (base class) constructor called");
        }

        public void DisplayPersoInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }


        /// <summary>
        /// Increases the age of the person by a specified number of years.
        /// </summary>
        /// <param name="years">The number of years to increase the age by</param>
        /// <returns>Returns the new age after aging</returns>
        public int BecomeOlder(int years)
        {
            Age += years;

            return Age;
        }
    }
}
