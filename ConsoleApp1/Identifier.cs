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
            StringBuilder sb = new StringBuilder();
            string[] separar = frase.Split("-");
            separar[1].ToUpper();

            sb.Append(separar);
            sb.Replace(" ", "_");
            sb.Replace("\0", "CTRL");
            for (int i = 0; i <= 9; i++)
            {
                sb.Replace(i.ToString(), ""); 
            }
           
            
            sb.Replace("-","");
            sb.ToString().ToUpperInvariant();
           
            /*sb.Replace(, "");
            sb.Replace("[α-ω]", " ");*/
            return sb.ToString();
        }
    }
}
