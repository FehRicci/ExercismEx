using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.SumOfMultiples
{
    internal static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            List<int> result = new List<int>();
            foreach (int multiple in multiples)
            {
                for (int i = 1; i < max; i++)
                {
                    if ((i % multiple) == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            int sum = 0;
            List<int> uniqueMultiples = result.Distinct().ToList();
            
            foreach (int value in uniqueMultiples)
            {
                sum += value;
            }
            return sum;
        }
    }
}
