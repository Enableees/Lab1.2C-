using Lab1._2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab1._2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CheckDigitOrder_IncreasingDigits()
        {
            int number = 1478;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_NotIncreasing()
        {
            int number = 1782;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_RepeatingDigits()
        {
            int number = 1668;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_SingleDigit()
        {
            int number = 5;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_TwoDigitsIncreasing()
        {
            int number = 37;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_TwoDigitsNotIncreasing()
        {
            int number = 82;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_NegativeIncreasing()
        {
            int number = -123;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_NegativeNotIncreasing()
        {
            int number = -132;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_Zero()
        {
            int number = 0;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_AllDigitsSame()
        {
            int number = 111;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }


        [TestMethod()]
        public void CheckDigitOrder_WithZeroInMiddle()
        {
            int number = 1023;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }

        [TestMethod()]
        public void CheckDigitOrder_WithZeroAtEnd()
        {
            int number = 1230;
            string result = Logic.CheckDigitOrder(number);
            Assert.AreEqual("Последовательность не упорядочена по возрастанию", result);
        }
    }
}