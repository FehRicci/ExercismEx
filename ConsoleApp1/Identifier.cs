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
            //string[] separar = frase.Split("-");
           // separar[1].ToUpper();


            Convertedor(frase);
            Testando(frase);
            
            /*sb.Replace("\0", "CTRL");
            for (int i = 0; i <= 9; i++)
            {
                sb.Replace(i.ToString(), ""); 
            }
           
            
            sb.Replace("-","");
            sb.ToString().ToUpperInvariant();
           
            /*sb.Replace(, "");
            sb.Replace("[α-ω]", " ");*/
           
        }

        private static StringBuilder Convertedor(string frase)
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append(frase);
        }
        private static StringBuilder Trocando(string frase)
        {
            return Convertedor(frase).Replace(" ","_");

        }
        private static string Outro(string frase)
        {
            return Convertedor(frase).Replace("\0", "CTRL");
        }
        private static string Testando(string frase)
        {
            return Regex.Replace(frase,"[^a-zA-z]", "");
        }
    }
}
