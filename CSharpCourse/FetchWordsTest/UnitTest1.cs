using Microsoft.VisualStudio.TestTools.UnitTesting;
using FetchWords;

namespace FetchWordsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void simple()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("AA bb CC");
            string[] expected = new string[] { "aa", "bb", "cc" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ignore_spaces()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("   aa    bb    cc    ");
            string[] expected = new string[] { "aa", "bb", "cc" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ignore_whitespaces()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("\r\n  \n aa \n\t\n   bb    cc  \t      ");
            string[] expected = new string[] { "aa", "bb", "cc" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ignore_strange_characters()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("\r\n; ,@  \n aa \" \n\t\n   bb    cc  \t      ");
            string[] expected = new string[] { "aa", "bb", "cc" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("   ")]
        [DataRow(" \r\n  \t  ")]
        public void empty(string s)
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered(s);
            string[] expected = new string[] { };
            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void correct_order()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("cc aa bb");
            string[] expected = new string[] { "aa", "bb", "cc" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void only_get_unique_words()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("aa bb cc aa bb cc cc cc cc");
            string[] expected = new string[] { "aa", "bb", "cc" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void order_by_word_length_then_alphabetic()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("ccc aaaa bb cc aaa bbb aa");
            string[] expected = new string[] {
                "aa",
                "bb",
                "cc",
                "aaa",
                "bbb",
                "ccc",
                "aaaa",
            };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void all_in_one()
        {
            var wf = new WordFetcher();

            string[] result = wf.GetUniqueWordsOrdered("\n    \r  @ \t:  CcC aAAa ccc $$$ bb cc \t AAA bbb aa  \n");
            string[] expected = new string[] {
                "aa",
                "bb",
                "cc",
                "aaa",
                "bbb",
                "ccc",
                "aaaa",
            };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}