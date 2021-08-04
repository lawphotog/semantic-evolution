using System;
using System.Linq;

namespace src
{
    public class SumCalculator
    {
        public double Calculate(double[] input)
        {
            if(!input.Any())
            {
                throw new Exception("invalid argument");
            }

            double sum = 0;
            for(var i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
    }
}
