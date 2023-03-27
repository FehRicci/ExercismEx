using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises.Pangram
{
    internal class Pangram
    {

        public static bool checkPangram(string frase)
        {
            frase = Regex.Replace(frase, " ", "").ToLower();

            bool test = true;


            string allLetters = "abcdefghijklmnopqrstuvwxyz";
            var letters = allLetters.ToCharArray();


            for (int i = 0; i < letters.Length; i++)
            {
                if (frase.Contains(letters[i]))
                    test = true;
                else
                {
                    test = false;
                    break;
                }
     
            }

            return test;
        }

    }
}
