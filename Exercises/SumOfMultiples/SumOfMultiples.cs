using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.SumOfMultiples
{
    internal static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiplesBase, int upperIndex)
        {
            int sum = 0;

            foreach (int value in multiples(multiplesBase, upperIndex))
            {
                sum += value;
            }
            return sum;
        }

        private static List<int> multiples(IEnumerable<int> multiplesBase, int upperIndex)
        {
            List<int> multiple = new();

            foreach (int value in multiplesBase)
            {
                if (value != 0)
                {
                    for (int i = value; i < upperIndex; i = i + value)
                    {
                            multiple.Add(i);
                    }
                }
            }
            return multiple.Distinct().ToList();
        }
    }
}
