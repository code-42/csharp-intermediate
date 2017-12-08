using System;

namespace Lecture_35___Multiple_Interfaces
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        // A class implements an interface
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }

    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {
        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}
