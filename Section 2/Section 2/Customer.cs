using System.Collections.Generic;

// Section 2 Lecture 10

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        // Constructors
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // Calls default ctor
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();            
            // cannot reinitialize Orders because of readonly keyword
        }
    }
}