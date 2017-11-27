using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_Classes
{
    public class Person
    {
        // Declare fields
        public string Name;

        // Declare method 
        public void Introduce(string to)
        {
            // Format string to display name on console
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // Declare static method
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare instance member
            var person = Person.Parse("Ed");
            person.Introduce("Mosh");
        }
    }
}
