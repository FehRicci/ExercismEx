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

            while (bigIndex >= smallIndex)
            {
                int indexToTest = (bigIndex + smallIndex) / 2;
                if (input[indexToTest] == value)
                    return indexToTest;
                else if (input[indexToTest] < value)
                    smallIndex = indexToTest + 1;
                else
                    bigIndex = indexToTest - 1;
            }
            return -1;
        }
    }
}
