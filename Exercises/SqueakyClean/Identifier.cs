using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises.SqueakyClean
{
    internal class Identifier
    {
        public static string Clean(string frase)
        {
            return new TextCleaner(frase)
                .Space()
                .Greek()
                .ConvetToCamelCase()
                .Ctrl()
                .SpecialChar()
                .frase;
        }
    }
}
