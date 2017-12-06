using System;

namespace Lecture_22___Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        // Comment out default constructor to show :base keyword in Car class
        //        public Vehicle()
        //        {
        //            Console.WriteLine("Vehicle is being initialized.");
        //        }

        // private field _registrationNumber created by ReSharper
        // automatically when making ctor + tab
        public Vehicle(string registrationNumber)
        {
            // do not need this keyword in c#
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}