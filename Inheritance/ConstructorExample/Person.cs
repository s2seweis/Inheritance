using System;

namespace Inheritance.ConstructorExample
{
    // The 'Person' class serves as the base class in this example.
    internal class Person
    {
        // Properties with private setters (read-only outside the class)
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Constructor that initializes the 'Name' and 'Age' properties
        public Person(string name, int age)
        {
            // Assigns the provided values to the properties
            Name = name;
            Age = age;

            // Indicates that the base class constructor has been called
            Console.WriteLine("Person (base class) constructor called");
        }

        // Method to display the information of the person
        public void DisplayPersoInfo()
        {
            // Prints the 'Name' and 'Age' properties to the console
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /*Called XML comments or the XML documentation*/

        /// <summary>
        /// Increases the age of the person by a specified number of years.
        /// </summary>
        /// <param name="years">The number of years to increase the age by</param>
        /// <returns>Returns the new age after aging</returns>
        public int BecomeOlder(int years)
        {
            // Increases the 'Age' property by the given number of years
            Age += years;

            // Returns the updated age
            return Age;
        }
    }
}
