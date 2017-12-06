using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;

namespace Lecture_21___Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
            // RateCalculator not visible because its protection level is internal
            // Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
