using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises.SqueakyClean
{
    internal class TextCleaner
    {
        public string frase { get; private set; }

        public TextCleaner(string frase)
        {
            this.frase = frase;
        }

        public TextCleaner Space()
        {
            frase = frase.Replace(" ", "_");
            return this;
        }
        public TextCleaner Ctrl()
        {
            frase = frase.Replace("\0", "CTRL");
            return this;
        }
        public TextCleaner SpecialChar()
        {
            frase = Regex.Replace(frase, "[^a-zA-ZΑ-Ω_àḂḃçĐ]", "");
            return this;
        }
        public TextCleaner Greek()
        {
            frase = Regex.Replace(frase, "[α-ω]", "");
            return this;
        }
        public TextCleaner ConvetToCamelCase()
        {
            frase = Regex.Replace(frase, "-.", m => m.Value.ToUpper().Substring(1));
            return this;
        }
    }
}
