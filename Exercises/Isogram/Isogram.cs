using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Isogram
{
    internal class Isogram
    {
        public static bool IsIsogram(string word)
        {
            
            if (test(word) > word.Length)
            {
                return false;     
            }else
                return true;

        }
        private static int test(string word)
        {
            int times = 0;
            char[] frase = word.ToCharArray();
            for (int i = 0; i < frase.Length - 1; i++)
            {
                for (int j = 0; j < frase.Length - 1; j++)
                {
                    if (frase[i] == frase[j])
                    {
                        times++;
                    }
                    else
                        times = times;
                }
            }
            return times;
        }
    }
}
