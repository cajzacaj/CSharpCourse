// L�s uppgifterna med och utan Linq (g�r allts� tv� olika metoder)
using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class NumberListToNumberListTests
    {
        NumberListToNumberList x = new NumberListToNumberList();

        // Demo: dubblera alla tal i listan
        // Demo: dubblera alla tal i listan. Hoppa �ver negativa tal.

        [TestMethod]
        public void Add100ToEachNumber()
        {
            // Addera 100 till varje siffra i listan

            var input = new List<int> { 5, 15, 23, 200 };
            var expected = new List<int> { 105, 115, 123, 300 };
            List<int> result1 = x.Add100ToEachNumber(input);
            List<int> result2 = x.Add100ToEachNumberLinq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);
        }

        [TestMethod]
        public void GetNumbersHigherThan1000()
        {
            // Filtrera ut de tal som �r h�gre �n 1000

            var input = new List<int> { 1005, 6, 77, 200000, 666 };
            var expected = new List<int> { 1005, 200000 };
            List<int> result1 = x.GetNumbersHigherThan1000(input);
            List<int> result2 = x.GetNumbersHigherThan1000Linq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);

        }

        [TestMethod]
        public void GetNumbersDividableByFive()
        {
            // Filtrera ut de tal som �r delbara med fem

            var input = new List<int> { 20, 5, 6, 7, 10 };
            var expected = new List<int> { 20, 5, 10 };
            List<int> result1 = x.GetNumbersDividableByFive(input);
            List<int> result2 = x.GetNumbersDividableByFiveLinq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);
        }

        [TestMethod]
        public void DivideEachNumberBy100()
        {
            // Dela alla tal i listan med 100

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { 3, 2, -5, 10 };
            List<int> result1 = x.DivideEachNumberBy100(input);
            List<int> result2 = x.DivideEachNumberBy100Linq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);
        }

        [TestMethod]
        public void NegateEachNumber()
        {
            // Negera alla tal i listan

            var input = new List<int> { 10, 20, -30, 40 };
            var expected = new List<int> { -10, -20, 30, -40 };
            List<int> result1 = x.NegateEachNumber(input);
            List<int> result2 = x.NegateEachNumberLinq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);
        }

        [TestMethod]
        public void Add50ToFirstThreeElements()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 6, 16, 23, 200, 300 };
            var expected = new List<int> { 56, 66, 73, 200, 300 };
            List<int> result1 = x.Add50ToFirstThreeElements(input);
            List<int> result2 = x.Add50ToFirstThreeElementsLinq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);
        }

        [TestMethod]
        public void Add50ToFirstThreeElements_ShortList()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 6, 16 };
            var expected = new List<int> { 56, 66 };
            var result1 = x.Add50ToFirstThreeElements(input);
            var result2 = x.Add50ToFirstThreeElements(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);

        }

        [TestMethod]
        public void Add70ToEverySecondElement()
        {
            // Addera 70 till varannat element i listan

            var input = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            var expected = new List<int> { 1000, 2070, 3000, 4070, 5000 };
            List<int> result1 = x.Add70ToEverySecondElement(input);
            List<int> result2 = x.Add70ToEverySecondElementLinq(input);

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);

        }

        [TestMethod]
        public void CombineTwoMethods()
        {
            // Addera 50 till de tre f�rsta elementen i listan

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { -3, -2, 5, -10 };
            var result1 = x.DivideEachNumberBy100(x.NegateEachNumber(input));
            var result2 = x.DivideEachNumberBy100Linq(x.NegateEachNumberLinq(input));

            CollectionAssert.AreEqual(expected, result1);
            CollectionAssert.AreEqual(expected, result2);
        }

    }
}
