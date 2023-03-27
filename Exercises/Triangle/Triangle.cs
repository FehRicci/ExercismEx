using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Triangle
{
    internal class Triangle
    {
        public string triangleConditions(double sideOne, double sideTwo, double sideThree)
        {
            WhichTriangle triangle = new WhichTriangle();
            if (sideOne + sideTwo >= sideThree || sideOne + sideThree >= sideTwo || sideTwo + sideThree >= sideOne)
            {
                if (IsEquilateral(sideOne, sideTwo, sideThree) == true)
                    return "Equilateral Triangle";
                else if (IsIsosceles(sideOne, sideTwo, sideThree) == true)
                    return "Isosceles Triangle";
                else
                    return "Scalene Triangle";
            }
            else
                return "It's not a triangle";
        }

        public static bool IsScalene(double side1, double side2, double side3)
        {
            if (side1 != side2 && side2 != side3 && side1 != side3)
                return true; 
            else 
                return false;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (side1 == side2 || side1 == side3 || side2 == side3) 
                return true;
            else 
                return false;
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3) 
                return true;
            else
                return false;
        }
    }
}
