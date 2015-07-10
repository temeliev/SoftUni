using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    using System.Collections.Generic;

    using LongestSubsequence;

    [TestClass]
    public class LongestSubsequnceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] input = "2 2 2".Split();
            List<int> numbers = LongestSubsequence.GetLongestSequence(input);

            Assert.AreEqual("2 2 2", string.Join(" ", numbers));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] input = "2 2 2 1 1 1 3".Split();
            List<int> numbers = LongestSubsequence.GetLongestSequence(input);

            Assert.AreEqual("2 2 2", string.Join(" ", numbers));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] input = "0".Split();
            List<int> numbers = LongestSubsequence.GetLongestSequence(input);

            Assert.AreEqual("0", string.Join(" ", numbers));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string[] input = "4 4 4 1 1 2 2 2 5 5 5 5".Split();
            List<int> numbers = LongestSubsequence.GetLongestSequence(input);

            Assert.AreEqual("5 5 5 5", string.Join(" ", numbers));
        }
    }
}
