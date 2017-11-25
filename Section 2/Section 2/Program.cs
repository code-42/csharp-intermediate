using System;

// Section 2 Lecture 10

namespace Classes
{
    class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }

    }
}