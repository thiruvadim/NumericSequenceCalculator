using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator;

namespace NumericSequenceCalculator_UnitTests
{
    /// <summary>
    /// Summary description for NumericSequenceCalculatorExpectedValuesUnitTests
    /// </summary>
    [TestClass]
    public class NumericSequenceCalculatorExpectedValuesUnitTests
    {
        private Numbers numericCal;
        public NumericSequenceCalculatorExpectedValuesUnitTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }       

        [TestMethod]
        public void GetAllNumbersUpto_10_TestMethod()
        {
            numericCal = new Numbers();
            var result = numericCal.getNumberSequence(10);
            Assert.AreEqual(result, "1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        }

        [TestMethod]
        public void GetOddNumbersUpto_10_TestMethod()
        {
            numericCal = new OddNumbers();
            var result = numericCal.getNumberSequence(10);
            Assert.AreEqual(result, "1, 3, 5, 7, 9");
        }

        [TestMethod]
        public void GetEvenNumbersUpto_10_TestMethod()
        {
            numericCal = new EvenNumbers();
            var result = numericCal.getNumberSequence(10);
            Assert.AreEqual(result, "2, 4, 6, 8, 10");
        }

        [TestMethod]
        public void GetSpecialNumbersUpto_15_TestMethod()
        {
            numericCal = new SpecialNumbers();
            var result = numericCal.getNumberSequence(15);
            Assert.AreEqual(result, "1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z");
        }

        [TestMethod]
        public void GetFibonacciNumbersUpto_10_TestMethod()
        {
            numericCal = new FibonacceNumbers();
            var result = numericCal.getNumberSequence(10);
            Assert.AreEqual(result, "1, 1, 2, 3, 5, 8, 13, 21, 34, 55");
        }
    }
}
