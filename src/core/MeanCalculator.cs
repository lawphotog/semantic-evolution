using System;
using System.Linq;

namespace src
{
    public class MeanCalculator
    {
        private readonly SumCalculator sumCalculator;
        public MeanCalculator()
        {
            sumCalculator = new SumCalculator();
        }

        public double Calculate(double[] input)
        {
            if(!input.Any())
            {
                throw new Exception("invalid argument");
            }

            double sum = sumCalculator.Calculate(input);
            return sum/input.Length;
        }
    }
}
