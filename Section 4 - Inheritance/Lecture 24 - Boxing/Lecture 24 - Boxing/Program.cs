using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_24___Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);  // boxing because 1 is a value
            list.Add("My Name"); // string is a reference, so no boxing 
            list.Add(DateTime.Today); // structure, so boxing

            // var number = (int) list[1]; // InvalidCastException

            // Generic list so will not boxing
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Ed");
            Console.WriteLine(names[0]);
        }
    }
}
