using System;
using Xunit;
using src;

namespace tests
{
    public class StandardDeviationCalculatorTests
    {
        StandardDeviationCalculator calculator;
        public StandardDeviationCalculatorTests()
        {
            calculator = new StandardDeviationCalculator();
        }

        [Fact]
        public void ShouldCalculate()
        {
            double[] input = new double[] { 1, 8, 7, 2, 22 };
            var actual = calculator.Calculate(input);

            Assert.Equal(Math.Round(8.396427812, 4), Math.Round(actual, 4));
        }

        [Fact]
        public void ShouldThrowException()
        {
            double[] input = new double[] { };
            Action action = () => calculator.Calculate(input);

            Exception exception = Assert.Throws<Exception>(action);
            Assert.Equal("invalid argument", exception.Message);
        }
    }
}
