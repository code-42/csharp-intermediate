using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        
        // Readonly modifier prevents Orders list from being reinitialized
        public readonly List<Order> Orders = new List<Order>();

        // Constructors
        public Customer(int id)
        {
            this.Id = id;
        }

        // Overloaded constructor
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