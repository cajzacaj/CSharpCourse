using Microsoft.VisualStudio.TestTools.UnitTesting;
using shipping;
using System;

namespace TestShipping
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(25)]
        [DataRow(50)]
        public void shipping_should_cost_88kr_for_0_to_50grams_recommended_letters_not_bulky_2019(int weight)
        {
            var service = new ShippingService();
            var letter = new Letter(weight, true, false);
            decimal fee = service.CalculateShipping(letter, "2019");

            Assert.AreEqual(88, fee);
        }

        [TestMethod]
        [DataRow(251)]
        [DataRow(400)]
        [DataRow(500)]
        public void shipping_should_cost_54kr_for_251_to_500grams_regular_letters_not_bulky1_2019(int weight)
        {
            var service = new ShippingService();
            var letter = new Letter(weight, false, false);
            decimal fee = service.CalculateShipping(letter, "2019");

            Assert.AreEqual(54, fee);
        }
        [TestMethod]
        [DataRow(251)]
        [DataRow(400)]
        [DataRow(500)]
        public void shipping_should_cost_54kr_for_251_to_500grams_regular_letters_not_bulky1_2018(int weight)
        {
            var service = new ShippingService();
            var letter = new Letter(weight, false, false);
            decimal fee = service.CalculateShipping(letter, "2019");

            Assert.AreEqual(54, fee);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(2001)]
        public void method_should_throw_argumentexception_when_weigth_is_below_0_or_above_2000(int weight)
        {
            Letter letter;

            Assert.ThrowsException<ArgumentException>(() =>
            letter = new Letter(weight, false, false)
            );
        }

    }
}
