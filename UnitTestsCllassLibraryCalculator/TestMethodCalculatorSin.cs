using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryCalculator;

namespace UnitTestsCllassLibraryCalculator
{
    [TestClass]
    public class TestMethodCalculatorSin
    {
        private Calculator calculator = new Calculator();

        [TestMethod]
        public void CalculatorSin_30_0dot5Returned()
        {
            //Arrange
            double num = 30;
            double expected = 0.5;

            //Act
            double actual = calculator.CalculatorSin(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorSin_360_0Returned()
        {
            //Arrange
            double num = 360;
            double expected = 0;

            //Act
            double actual = calculator.CalculatorSin(num);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
