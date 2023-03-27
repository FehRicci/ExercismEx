using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Triangle
{
    internal class Triangle
    {
        public static bool triangleConditions(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne + sideTwo >= sideThree && sideOne + sideThree >= sideTwo && sideTwo + sideThree >= sideOne)
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsScalene(double side1, double side2, double side3)
        {
            if (triangleConditions(side1, side2, side3) == true && side1 != 0 && side1 != side2 && side2 != side3 && side1 != side3)
                return true;
            else
                return false;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (triangleConditions(side1, side2, side3) == true && side1 != 0 && (side1 == side2 || side1 == side3 || side2 == side3))
                return true;
            else
                return false;
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            if (triangleConditions(side1, side2, side3) == true && side1 != 0 && side1 == side2 && side2 == side3)
                return true;
            else
                return false;
        }
    }
}
