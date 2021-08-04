using System;
using Xunit;
using src;

namespace tests
{
    public class MeanCalculatorTests
    {
        MeanCalculator calculator;
        public MeanCalculatorTests()
        {
            calculator = new MeanCalculator();
        }

        [Fact]
        public void ShouldCalculate()
        {
            double[] input = new double[] { 5, 5, 5 };
            var actual = calculator.Calculate(input);
            var expected = 5;

            Assert.Equal(expected, actual);
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
