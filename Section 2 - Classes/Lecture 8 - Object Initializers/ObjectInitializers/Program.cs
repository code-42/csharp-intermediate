using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{

    public class Person
    {
        public string FirstName;
        public string LastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Ed",
                LastName = "D"
            };

            Console.WriteLine(person.FirstName);
        }
    }
}
