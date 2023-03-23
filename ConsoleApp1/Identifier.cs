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
                   
            
            return Converter(frase);
            
        }

        private  static String Converter(string frase)
        {
            
            if (frase.Contains("\0"))
            {
                return Replace2(frase);
            }else if (frase.Contains(" "))
            {
                return Replace1(frase);
            }else if (frase.Contains("-"))
            {
                return camelCase(frase);
            }else if(frase.Contains("[α-ω]")) {
                return Omit5(frase);
            }
            else
            {
                return Omit4(frase);
            }
            
        }
        private  static String Replace1(string frase)
        {
            return frase.Replace(" ", "_");

        }
        private  static string Replace2(string frase)
        {
            return frase.Replace("\0", "CTRL");
        }
        private static string Omit4(string frase)
        {
            return Regex.Replace(frase, "[^a-zA-z]", "");
        }
        private static string Omit5(string frase)
        {
            return Regex.Replace(frase, "[α-ω]", "");
        }
        private static string camelCase(string frase)
        {
            return Regex.Replace(frase, "-.", m => m.Value.ToUpper().Substring(1));
        }
    }
}
