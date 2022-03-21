using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;

namespace UnitTestsCllassLibraryCalculator
{
    [TestClass]
    public class TestMethodCalculatorSquare
    {
        private Calculator calculator = new Calculator();

        [TestMethod]
        public void CalculatorSquare_minus5_25Returned()
        {
            //Arrange
            double num = -5;
            double expected = 25;

            //Act
            double actual = calculator.CalculatorSquare(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorSquare_2_4Returned()
        {
            //Arrange
            double num = 2;
            double expected = 4;

            //Act
            double actual = calculator.CalculatorSquare(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
