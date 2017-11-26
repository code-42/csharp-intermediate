﻿using System;
using System.Runtime.InteropServices;

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

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            
           ..


            // Instantiate a new Stopwatch object
            var stopwatch = new Stopwatch();
            var input = "";

            while (true)
            {

                input = Console.ReadLine();

                if (input == "s")
                {
                    stopwatch.Start();
                }
                else if (input == "x")
                {
                    stopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("Error");
                    break;
                }

                Console.WriteLine("Duration: " + stopwatch.Duration());
            }

        }
    }
}