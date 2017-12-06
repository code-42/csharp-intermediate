using System;

namespace Lecture_28___Abstract_Classes
{
    public class Rectangle : Shape
    {
        // Override the abstract Draw() method declared in the Shape class
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}
