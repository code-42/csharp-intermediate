using System;

namespace Lecture_22___Constructors
{
    public class Car : Vehicle
    {
        // Use :base keyword to call one of the constructors of the Vehicle class
        // because Vehicle class does not have a default constructor
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}