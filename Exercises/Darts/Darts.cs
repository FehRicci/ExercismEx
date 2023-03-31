using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Darts
{
    internal class Darts
    {
        public static int Score(double x, double y)
        {
            if (RadiusFormula(x, y) <= 1)
                return 10;
            else if (RadiusFormula(x, y) > 1 && RadiusFormula(x, y) <= 5)
                return 5;
            else if (RadiusFormula(x, y) > 5 && RadiusFormula(x, y) <= 10)
                return 1;
            else
                return 0;
        }

        private static double RadiusFormula(double x, double y)
        {
            return Math.Sqrt((x*x) + (y*y));
        }
    }
}
