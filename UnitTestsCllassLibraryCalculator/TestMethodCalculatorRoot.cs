using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;

namespace UnitTestsCllassLibraryCalculator
{
    [TestClass]
    public class TestMethodCalculatorRoot
    {
        private Calculator calculator = new Calculator();

        [TestMethod]
        public void CalculatorRoot_64_8Returned()
        {
            //Arrange
            double num = 64;
            double expected = 8;

            //Act
            double actual = calculator.CalculatorRoot(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRoot_minus60_minus1Returned()
        {
            //Arrange
            double num = -60;
            double expected = -1;

            //Act
            double actual = calculator.CalculatorRoot(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}