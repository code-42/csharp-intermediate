using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_28___Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a new Circle
            var circle = new Circle();

            // Call the abstract Draw() method of Shape
            // implemented by the Circle class
            circle.Draw();

            // Declare a new Rectangle
            var rectangle = new Rectangle();

            // Call the abstract Draw() method of Shape
            // implemented by the Rectangle class
            rectangle.Draw();
        }
    }
}
