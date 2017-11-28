using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercise 2: Design a StackOverflow Post

Design a class called Post. This class models a StackOverflow post. It should have properties
for title, description and the date/time it was created. We should be able to up-vote or down-vote
a post. We should also be able to see the current vote value. In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.
In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting. You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number. And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail.
Educational tip: The aim of this exercise is to help you understand that classes should
encapsulate data AND behaviour around that data. Many developers (even those with years of
experience) tend to create classes that are purely data containers, and other classes that are
purely behaviour (methods) providers. This is not object-oriented programming. This is
procedural programming. Such programs are very fragile. Making a change breaks many parts
of the code.

*/
namespace StackOverflowPost
{
    class Post
    {
        public string _title { get; set; }
        public string _description { get; set; }
        public DateTime _created { get; set; }
        public int Vote { get; set; }

        public int _upVote { get; set; }
        public int _downVote { get; set; }

        public Post()
        {
            Console.WriteLine(Vote);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            do
            {
                var vote = Console.ReadLine();

                if (vote == "+")
                    post._upVote++;

                if (vote == "-")
                    post._downVote--;

            
            post._title = "My First Post";
            post._description = "I don't know what I'm doing.";
            post._created = DateTime.Now;

            Console.WriteLine(post._title + "\n" + post._description + "\n" + post._created);
            } while (true);
        }
    }
}
