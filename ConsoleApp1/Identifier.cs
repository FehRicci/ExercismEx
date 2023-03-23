using System;
using System.Collections.Generic;
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
           
        }

        private static StringBuilder Converter(string frase)
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append(frase);
        }
        private static StringBuilder Replace1(string frase)
        {
            return Converter(frase).Replace(" ", "_");

        }
        private static string Replace2(string frase)
        {
            return frase.Replace("\0", "CTRL");
        }
        private static string Omit4(string frase)
        {
            return Regex.Replace(frase, "[^a-zA-z]", "");
        }

        private static string camelCase(string frase)
        {
            return Regex.Replace(frase, "-.", m => m.Value.ToUpper().Substring(1));

        }
    }
}
