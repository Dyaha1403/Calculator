using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;
using System;

namespace UnitTestsCllassLibraryCalculator
{
    [TestClass]
    public class TestMethodCalculationResultPlus
    {
        private Calculator calculator = new Calculator();

        [TestInitialize]
        public void InputOperation()
        {
            calculator.operation = "+";
        }

        [TestMethod]
        public void CalculationResult_6plus7_13Returned()
        {
            //Arrange
            calculator.num_1 = "6";
            calculator.num_2 = "7";
            string expected = "13";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculationResult_56plus10_66Returned()
        {
            //Arrange
            calculator.num_1 = "56";
            calculator.num_2 = "10";
            string expected = "66";

            //Act
            string actual = calculator.CalculationResult();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
