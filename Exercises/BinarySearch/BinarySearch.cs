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
            int smallIndex = 0;
            int bigIndex = input.Length - 1;
            int indexTester;

           while (bigIndex >= smallIndex)
            {
                indexTester = (bigIndex + smallIndex) / 2;
                if (input[indexTester] == value)
                    return indexTester;
                else if (input[indexTester] < value)
                    smallIndex = indexTester + 1;
                else
                    bigIndex = indexTester - 1;
            }
            return -1;
        }
    }
}
