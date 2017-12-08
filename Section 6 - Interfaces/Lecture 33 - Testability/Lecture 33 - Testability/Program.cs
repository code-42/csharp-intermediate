using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_33___Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}
