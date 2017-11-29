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

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}