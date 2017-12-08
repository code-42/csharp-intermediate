namespace Lecture_33___Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    // Read this as ShippingCalculator implements IShippingCalculator
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }



}
