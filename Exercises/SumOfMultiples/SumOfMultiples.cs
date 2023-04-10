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
            int sum = 0;

            foreach (int value in multiplesList(multiples, max))
            {
                sum += value;
            }
            return sum;
        }

        private static List<int> multiplesList(IEnumerable<int> multiples, int max)
        {
            List<int> multipleList = new();

            foreach (int multiple in multiples)
            {
                for (int i = 1; i < max; i++)
                {
                    if (multiple != 0 && (i % multiple) == 0)
                        multipleList.Add(i);
                }
            }
            return multipleList.Distinct().ToList();
        }
    }
}
