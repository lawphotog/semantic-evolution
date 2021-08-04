using System;
using System.Linq;

namespace src
{
    public class StandardDeviationCalculator
    {
        private readonly MeanCalculator meanCalculator;
        public StandardDeviationCalculator()
        {
            meanCalculator = new MeanCalculator();
        }

        public double Calculate(double[] input)
        {
            if(!input.Any())
            {
                throw new Exception("invalid argument");
            }

            double result = 0;
            double mean = meanCalculator.Calculate(input);
            double sum = 0;
            for(int i = 0; i < input.Length; i++)
            {
                sum += Math.Pow(input[i] - mean, 2);
            }

            result = Math.Sqrt((sum) / (input.Count() -1 ));

            return result;
        }
    }
}