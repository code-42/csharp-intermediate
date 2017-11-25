using System;

// Section 2 Lecture 12

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);
        }

    }
}