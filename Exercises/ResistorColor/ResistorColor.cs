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
            string[] listColors = Colors();

            for (int i = 0; i < listColors.Length; i++)
            {
                if (listColors[i] == color.ToLower())
                    return i;
            }
            return -1;
        }

        public static string[] Colors() => new string[]{"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
    }
}
