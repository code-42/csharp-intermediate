

// Section 2 Lecture 13

using System;

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Ed";
            Console.WriteLine(cookie["name"]);
        }

    }
}