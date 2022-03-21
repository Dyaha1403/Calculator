using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCalculator;

namespace UnitTestsCllassLibraryCalculator
{
    [TestClass]
    public class TestMethodCalculationResultDivision
    {
        private Calculator calculator = new Calculator();

        [TestInitialize]
        public void InputOperation()
        {
            calculator.operation = "/";
        }

        [TestMethod]
        public void CalculationResult_10div2_5Returned()
        {
            //Arrange
            calculator.num_1 = "10";
            calculator.num_2 = "2";
            string expected = "5";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationResult_56div10_5dot6Returned()
        {
            //Arrange
            calculator.num_1 = "56";
            calculator.num_2 = "10";
            string expected = "5,6";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationResult_56div0_ErrorReturned()
        {
            //Arrange
            calculator.num_1 = "56";
            calculator.num_2 = "0";
            string expected = "На ноль делить нельзя";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
