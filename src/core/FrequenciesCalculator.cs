using System;
using System.Linq;
using System.Collections.Generic;

namespace src
{
    public class FrequenciesCalculator
    {
        public List<Bin> Calculate(double[] input)
        {
            if(!input.Any())
            {
                throw new Exception("invalid argument");
            }

            var bins = CreateBins();

            foreach(var number in input)
            {
                foreach(var bin in bins)
                {
                    if(number >= bin.Min && number < bin.Max)
                    {
                        bin.Count++;
                    }
                }
            }

            return bins;
        }

        private static List<Bin> CreateBins() 
        {
            List<Bin> bins = new List<Bin>();
            int count = 0;
            for(int i = 0; i <= 100; i++)
            {
                if(count == 9)
                {
                    bins.Add(new Bin { 
                        Min = i-9,
                        Max = i
                    });

                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            return bins;
        }
    }
}