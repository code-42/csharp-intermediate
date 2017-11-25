using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this() // initializes Orders list
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            //: this(id) // initializes Id and Orders
        {
            this.Name = name;
        }
    }
}