using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_27___Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a List object to hold the shapes
            var shapes = new List<Shape>();

            // Instantiate new shape objects
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            // Instantiate a canvas object
            var canvas = new Canvas();

            // Call the DrawShapes() method of the Canvas class
            // which calls the Draw() method for each kind of shape
            // in the Shape class
            canvas.DrawShapes(shapes);
        }
    }
}
