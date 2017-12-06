using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    /*
     Encapsulation - objects should hide their implementation detail
     and reveal what they can do as opposed to how they do it.
    */

    public class Person
    {
        // Declare private field
        private DateTime _birthdate;

        // Access modifier to access private field
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        // Access modifier to access private field
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new object
            var person = new Person();
            
            // Access modifiers to set fields
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
