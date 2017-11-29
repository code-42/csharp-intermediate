using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

            // Upcasting examples
            //StreamReader reader = new StreamReader(new FileStream());
            var list = new ArrayList();
            list.Add(1);
            list.Add("a string");
            list.Add(new Text());

            var anotherList = new List<int>();
            var anotherrList = new List<Shape>();

            // Downcasting
            // at runtime newShape type will be Text
            Shape newShape = new Text();
            // convert (cast) shape to Text
            Text text2 = (Text) newShape;
            // now we have access to every shape property
            text2.FontName = "Courier";
            Console.WriteLine(text2.FontName);


        }
    }
}
