using System;
using Xunit;
using src;

namespace tests
{
    public class FrequenciesCalculatorTests
    {
        FrequenciesCalculator calculator;
        public FrequenciesCalculatorTests()
        {
            calculator = new FrequenciesCalculator();
        }

        [Fact]
        public void ShouldCalculate()
        {
            double[] input = new double[] { 5, 6, 10, 40, 78, 79, 99 };
            var frequencies = calculator.Calculate(input);

            Assert.Equal(2, frequencies[0].Count);
        }

        [Fact]
        public void ShouldHaveCorrectMinMaxForBin()
        {
            double[] input = new double[] { 5, 6, 10, 40, 78, 79, 99 };
            var frequencies = calculator.Calculate(input);

            Assert.Equal(0, frequencies[0].Min);
            Assert.Equal(9, frequencies[0].Max);
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
