using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            // RateCalculator() is visible because it's part of the same assembly
            // but not visible in Main()
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic accessible from Main().");
        }
    }
}