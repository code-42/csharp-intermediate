using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Default parameterless constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overloading constuctors
        public Customer(int id)
            // Use this keyword to pass execution to another constructor in this class
            : this() // initializes Orders list
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // initializes Id and Orders
        {
            this.Name = name;
        }
    }
}