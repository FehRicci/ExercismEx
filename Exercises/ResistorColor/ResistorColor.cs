using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.ResistorColor
{
    internal class ResistorColor
    {
        public static int ColorCode(string color)
        {
            switch (color.ToLower())
            {
                case "black":
                    return 0;
                case "brown":
                    return 1;
                case "red":
                    return 2;
                case "orange":
                    return 3;
                case "yellow":
                    return 4;
                case "green":
                    return 5;
                case "blue":
                    return 6;
                case "violet":
                    return 7;
                case "grey":
                    return 8;
                case "white":
                    return 9;
                default:
                    return 10;
            }
            
        }

        public static string[] Colors()
        {
           return new string[10]{"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
        }
    }
}
