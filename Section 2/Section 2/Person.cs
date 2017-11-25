using System;

// Section 2 Lecture 12

namespace Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        // Constructor
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // Calculated properties
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}