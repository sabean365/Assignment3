using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Calculator.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        private StringCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new StringCalculator();
        }
        
        [TestMethod]
        public void TestAdd_EmptyString_ReturnsZero()
        {
            var result = calculator.Add("");

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestAdd_One_ReturnsOne()
        {
            var result = calculator.Add("1");

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestAdd_OneTwo_ReturnsThree()
        {
            var result = calculator.Add("1,2");

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestAdd_MultipleNumbers_ReturnsSix()
        {
            var result = calculator.Add("1,2,3");

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Negatives not allowed: -1 -2")]
        public void TestAdd_Negative_ThrowException()
        {
            try
            {
                var result = calculator.Add("1,-1,-2");
                Assert.Fail("Exception should have been thrown.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
        }

        [TestMethod]
        public void TestAdd_GreaterThan1000_Return1001Ignored()
        {
            var result = calculator.Add("1001,1");

            Assert.AreEqual(1, result);
        }


    }
}
