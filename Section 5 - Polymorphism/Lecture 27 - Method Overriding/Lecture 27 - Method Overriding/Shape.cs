using System;

namespace Lecture_27___Method_Overriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        // Because the Draw() method in the shape class was declared as virtual
        // it gives us the ability to override the Draw() method in the derived
        // classes at runtime.  That is Polymorphism -
        // If the shape is a circle, the Draw() method of the circle will be called.
        // If the shape is a rectangle, the Draw() method of rectangle will be called.
        public virtual void Draw()
        {

        }
    }

    public class Circle : Shape
    {
        // Implement the Draw() method for each shape
        // must use the override keyword because 
        // the Draw() method in the shape class was declared as virtual
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

}
