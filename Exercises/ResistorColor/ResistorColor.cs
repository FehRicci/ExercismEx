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
             int i = 0;
            for (i = 0; i < Colors().Length; i++)
            {
                if (Colors()[i] == color.ToLower())
                    return i;
            }
            return -1;
          
        }

        public static string[] Colors()
        {
           return new string[10]{"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
        }
    }
}
