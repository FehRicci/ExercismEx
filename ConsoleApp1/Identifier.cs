using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Identifier
    {
        public static string Clean(String frase)
        {


            return Executando(frase);

        }

        private static String Executando(string frase)
        {
            return SpecialChar(Greek(camelCase(Space(Ctrl(frase)))));


        }
        private static String Space(string frase)
        {
            return frase.Replace(" ", "_");

        }
        private static string Ctrl(string frase)
        {
            return frase.Replace("\0", "CTRL");
        }
        private static string SpecialChar(string frase)
        {
            return Regex.Replace(frase, "[^a-zA-ZΑ-Ω_àḂḃçĐ]", "");
        }
        private static string Greek(string frase)
        {
            return Regex.Replace(frase, "[α-ω]", "");
        }
        private static string camelCase(string frase)
        {
            return Regex.Replace(frase, "-.", m => m.Value.ToUpper().Substring(1));
        }

    }
}
