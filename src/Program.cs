using System;
using System.IO;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = ReadFile();
            var meanCalculator = new MeanCalculator();
            var mean = meanCalculator.Calculate(file);

            Console.WriteLine($"mean value is {mean}");

            var frequenciesCalculator = new FrequenciesCalculator();
            var bins = frequenciesCalculator.Calculate(file);

            foreach(var bin in bins)
            {
                Console.WriteLine($"frequencies for {bin.Min}-{bin.Max} is {bin.Count}");
            }

            var standardDeviationCalculator = new StandardDeviationCalculator();
            var sd = standardDeviationCalculator.Calculate(file);

            Console.WriteLine($"standard deviation is {sd}");
        }

        static double[] ReadFile()
        {
            var file = File.ReadAllText("SampleData.csv").Split(",");
            return Array.ConvertAll(file, i => double.Parse(i));
        }
    }
}
