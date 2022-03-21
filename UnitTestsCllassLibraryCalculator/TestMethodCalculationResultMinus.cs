using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCalculator;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsCllassLibraryCalculator
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestMethodCalculationResultMinus
    {
        private Calculator calculator = new Calculator();

        [TestInitialize]
        public void InputOperation()
        {
            calculator.operation = "-";
        }

        [TestMethod]
        public void CalculationResult_8minus7_1Returned()
        {
            //Arrange
            calculator.num_1 = "8";
            calculator.num_2 = "7";
            string expected = "1";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationResult_56minus10_46Returned()
        {
            //Arrange
            calculator.num_1 = "56";
            calculator.num_2 = "10";
            string expected = "46";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
