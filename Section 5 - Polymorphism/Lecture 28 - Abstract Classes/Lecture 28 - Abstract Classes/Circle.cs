using System;

namespace Lecture_28___Abstract_Classes
{
    public class Circle : Shape
    {
        // Override the abstract Draw() method declared in the Shape class
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
}
