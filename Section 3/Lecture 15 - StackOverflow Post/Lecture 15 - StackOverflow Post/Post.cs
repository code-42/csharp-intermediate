using System;

namespace Lecture_15___StackOverflow_Post
{
    public class Post
    {
        // Declare public properties
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        // Calculated property
        private int _vote = 0;

        // Vote property has logic to increase or decrease votes
        public int Vote(string vote)
        {
            // User keyboard input
            if (vote == "+")
                _vote++;

            // User keyboard input
            if (vote == "-")
                _vote--;

            return _vote;
        }
    }
}