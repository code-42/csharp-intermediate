using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_23___Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Text();
            //Text text = (Text)shape;

            // Both text and shape objects are actually
            // pointing to/referencing the same object in memory
            // but you cant see the same properties of each object
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); // 100
            Console.WriteLine(shape.Width); // 100
        }
    }
}
