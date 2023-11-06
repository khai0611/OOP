using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Animal
    {
        public double Weight;
        public double Height;
        public void Info()
        {
            Console.WriteLine("Height: " + Height + "\tWeight: " + Weight);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example

            Animal Dog = new Animal();
            Dog.Weight = 2; // Assign values ​​to object properties
            Dog.Height = 50;

            Animal Cat = new Animal();
            Cat.Weight = 1;
            Cat.Height = 30;
            
            Dog.Info(); //Call the object's methods
            Cat.Info();
            #endregion

            Console.ReadKey();
        }
    }
}
//What is OOP?
/// OOP stands for Object-Oriented Programming.
/// The four basic principles of object-oriented programming are:
/// Abstraction: Modeling the relevant attributes and interactions of entities as classes to define an abstract representation of a system.
/// Encapsulation: Hiding the internal state and functionality of an object and only allowing access through a public set of functions.
/// Inheritance: Ability to create new abstractions based on existing abstractions.
/// Polymorphism: Ability to implement inherited properties or methods in different ways across multiple abstractions

/// Accessibility:
/// public
/// protected
/// private
/// private protected
/// internal
/// protected internal
/// The default accessibility is private


