using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.BinarySearch
{
    internal class BinarySearch
    {
        public static int Find(int[] input, int value)
        {
            int smaller = 0;
            int bigger = input.Length - 1;
            int tester;

           while (bigger > smaller)
            {
                tester = (bigger + smaller) / 2;
                if (input[tester] == value)
                    return tester;
                else if (input[tester] < value)
                    smaller = tester + 1;
                else
                    bigger = tester - 1;
            }
            return -1;

        }


    }
}
