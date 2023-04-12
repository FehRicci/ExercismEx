using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.DifferenceOfSquares
{
    internal class DifferenceOfSquares
    {
        public static int CalculateDifferenceOfSquares(int value)
        {
            int SumOfSquares = CalculateSumOfSquares(value);
            int SquareOfSum = CalculateSquareOfSum(value);

            if (SumOfSquares > SquareOfSum)
                return SumOfSquares - SquareOfSum;
            else
                return SquareOfSum - SumOfSquares;
        }

        public static int CalculateSquareOfSum(int value)
        {
            int sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum += i;
            }
            return sum*sum;
        }

        public static int CalculateSumOfSquares(int value)
        {
            int sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum = (i * i) + sum;
            }
            return sum;
        }
    }
}
