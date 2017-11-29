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
            list.Add("My Name"); // no boxing
            list.Add(DateTime.Today); // boxing

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add(null);
        }
    }
}
