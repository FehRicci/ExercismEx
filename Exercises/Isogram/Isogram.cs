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
            if (word != "")
            {
                if (CheckingLetters(word) >= word.Length)
                {
                    return false;
                }
                else
                    return true;
            }
            else
                return true;

        }
        private static int CheckingLetters(string word)
        {
            int times = 0;
            char[] frase = word.ToLower().ToCharArray();
            for (int i = 0; i < frase.Length - 1; i++)
            {
                for (int j = frase.Length - 1 ; j >= 0; j--)
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
