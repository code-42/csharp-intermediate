using System;

namespace Methods
{
    public class Point
    {
        // Declare fields
        public int X;
        public int Y;

        // Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Method
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // Throw excption if newLocation is null
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            
            // Overloaded Move() method calls the other Move() method
            Move(newLocation.X, newLocation.Y);
        }
    }
}