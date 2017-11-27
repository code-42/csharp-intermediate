using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Input;

/*
Exercises Section 2 Lecture 15

Exercise 1: Design a Stopwatch
Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
provide two methods: Start and Stop. We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan. Display the duration on the console.
We should also be able to use a stopwatch multiple times. So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice. 
*/

namespace Stopwatch
{
    class Program
    {

        static void Main(string[] args)
        {
            // Instantiate a new Stopwatch object
            var stopwatch = new Stopwatch();

            Console.WriteLine("Press spacebar to Start the Stopwatch");
            Console.WriteLine("\nPress Control+C to exit");

            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("\nStopwatch started at " + stopwatch.Start());
                    Console.WriteLine("\nPress spacebar again to stop");
                }
                //else if (input == " ")
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("\nStopwatch stopped at " + stopwatch.Stop());
                }


                //if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                //{
                //    //Console.WriteLine("Exit");
                //    Environment.Exit(0);
                //}
                //Console.WriteLine("Type s to Stop the Stopwatch");
                Console.WriteLine("\nDuration: " + stopwatch.Duration() + "\n");
                Console.WriteLine("Press spacebar to Start and Stop the Stopwatch");
                Console.WriteLine("\nPress Control+C to exit");
            } while (true);
        }
    }
}