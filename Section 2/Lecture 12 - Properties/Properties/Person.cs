using System;

namespace Properties
{
    public class Person
    {
        // Shortcut to declare properties - prop, tab code snippet
        // Convention to put properties at top
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        // Constructor after properties
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // Calculated properties after constructor
        public int Age
        {
            // No set() accessor method because Birthdate is set in the constructor
            // because you don't normally need to change someone's birthdate
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}