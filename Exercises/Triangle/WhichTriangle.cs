using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Triangle
{
    internal class WhichTriangle
    {
        public string triangleConditions(double sideOne, double sideTwo, double sideThree)
        {
            WhichTriangle triangle = new WhichTriangle();
            if (sideOne + sideTwo >= sideThree || sideOne + sideThree >= sideTwo || sideTwo + sideThree >= sideOne)
            {
                return triangle.TriangleType(sideOne, sideTwo, sideThree);
            }
            else
                return "It's not a triangle";
        }

        private string TriangleType(double sideOne, double sideTwo, double sideThree)
        {
            
            if (sideOne == sideTwo && sideOne == sideThree)
            {
                return "Equilateral Triangle";
            }
            else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                return "Isosceles Triangle";
            }
            else if (sideOne != sideTwo && sideTwo != sideThree && sideOne != sideThree)
            {
                return "Scalene Triangle";
            }
            else
                return "It's not a triangle";

        }
    }
}
