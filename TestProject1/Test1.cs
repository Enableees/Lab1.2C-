using Lab1._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1._2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void Check1()
        {
            int[] arr = { 1, 4, 7, 8 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void Check2()
        {
            int[] arr = { 1, 7, 8, 2 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void Check3()
        {
            int[] arr = { 1, 6, 6, 8 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void Check4()
        {
            int[] arr = { 5 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void Check5()
        {
            int[] arr = { 3, 7 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void Check6()
        {
            int[] arr = { 8, 2 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void Check7()
        {
            int[] arr = { -1, 2 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void Check8()
        {
            int[] arr = { 1, -2 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void Check9()
        {
            int[] arr = { -1 };
            bool result = Logic.CheckOrder(arr);
            Assert.AreEqual(true, result);
        }
    }
}