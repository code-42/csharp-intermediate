using System;

namespace Lecture_33___Testability
{
    public class OrderProcessor
    {
        // Dependency on Interface make it more loose coupling
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // Now there is no reference to concrete class ShippingCalculator
            // Instead is is referencing the Interface IShippingCalculator
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
