using System.Collections.Generic;

namespace Lecture_27___Method_Overriding
{
    public class Canvas
    {
        // Polymorphism - the Draw() method is implemented differently
        // depending on the shape object at runtime
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
