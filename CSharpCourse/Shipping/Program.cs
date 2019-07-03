using System;

namespace shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ShippingService();
            var letter = new Letter(254, false, false);

            decimal shipping = service.CalculateShipping(letter, "2019");
            Console.WriteLine(shipping);
        }
    }
}
