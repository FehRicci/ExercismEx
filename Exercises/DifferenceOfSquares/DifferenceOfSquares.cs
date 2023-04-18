using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DifferenceOfSquares
{
    internal class DifferenceOfSquares
    {
        public static double CalculateDifferenceOfSquares(int value)
        {
            return Math.Abs(CalculateSumOfSquares(value) - CalculateSquareOfSum(value));
        }

        public static double CalculateSquareOfSum(int value)
        {
            int sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum += i;
            }
            return Math.Pow(sum,2);
        }

        public static double CalculateSumOfSquares(int value)
        {
            double sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum = Math.Pow(i,2) + sum;
            }
            return sum;
        }
    }
}
