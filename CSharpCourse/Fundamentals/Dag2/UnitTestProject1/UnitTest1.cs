using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpDag2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CleanUpArrayTest()
        {
            string[] testArray = new string[] { "   Cajza ", "-Simon ", "Sa m''''" };
            string[] expectedArray = new string[] { "Cajza", "Simon", "Sa m" };

            Program.CleanUpArray(testArray);

            for (int i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], testArray[i]);
            }

        }
        [TestMethod]
        public void SplitStringTest()
        {
            string testString = "   Cajza, -Simon , Sa m''''";
            string[] expectedArray = new string[] { "   Cajza", " -Simon ", " Sa m''''" };

            string[] testArray = Program.SplitString(testString, ',');

            for (int i = 0; i < expectedArray.Length; i++)
            {
                Assert.AreEqual(expectedArray[i], testArray[i]);
            }

        }
        [TestMethod]
        public void ArrayIsValidTest()
        {
            string[] array = new string[] { "Cajza", "Simon", "Sam" };

            bool result = Program.ArrayIsValid(array, true);

            Assert.IsTrue(result);
        }   
    }
}
