using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises.ProteinTranslation
{
    internal class ProteinTranslation
    {

        public static string[] Proteins(string strand)
        {
            string[] codon = new string[strand.Length / 3];
            int arryIndex = 0;

            for (int i = 0; i <= strand.Length - 3; i = i + 3)
            {
                codon[arryIndex] = strand.Substring(i, 3);
                arryIndex++;
            }

            List<string> proteins = new();

            for (int i = 0; i <= codon.Length - 1; i++)
            {
                if (CodonStopsTranslation(codon[i]))
                    break;
                else
                    proteins.Add(ProteinListTranslation(codon[i]));
            }

            return proteins.ToArray();
        }

        private static bool CodonStopsTranslation(string Codons)
        {
            if (Codons == "UAA" || Codons == "UAG" || Codons == "UGA")
                return true;
            else
                return false;
        }

        //Codon               Protein
        //AUG                 Methionine
        //UUU, UUC            Phenylalanine
        //UUA, UUG            Leucine
        //UCU, UCC, UCA, UCG  Serine
        //UAU, UAC            Tyrosine
        //UGU, UGC            Cysteine
        //UGG                 Tryptophan
        //UAA, UAG, UGA       STOP

        private static string ProteinListTranslation(string Codons)
        {
            if (Codons == "AUG")
                return "Methionine";
            else if (Codons == "UUU" || Codons == "UUC")
                return "Phenylalanine";
            else if (Codons == "UUA" || Codons == "UUG")
                return "Leucine";
            else if (Codons == "UCU" || Codons == "UCC" || Codons == "UCA" || Codons == "UCG")
                return "Serine";
            else if (Codons == "UAU" || Codons == "UAC")
                return "Tyrosine";
            else if (Codons == "UGU" || Codons == "UGC")
                return "Cysteine";
            else if (Codons == "UGG")
                return "Tryptophan";
            else
                return string.Empty;
        }
    }
}
