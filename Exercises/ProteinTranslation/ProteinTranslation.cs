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
            string[] parts = new string[strand.Length - 1];

            for (int i = 0; i <= strand.Length - 3; i = i + 3)
            {
                for (int j = 0; j <= strand.Length - 1; j++)
                {
                    parts[j] = strand.Substring(i, 3);
                }
            }
            string[] proteins = new string[parts.Length];

            foreach (string part in parts)
            {
                for (int i = 0; i <= proteins.Length - 3; i = i + 3) { }
            }


        }

        private static string StopCondition(string strand)
        {
            if (strand == "UAA" || strand == "UAG" || strand == "UGA")
                return "";
            else
                return ProteinList(strand);
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

        private static string ProteinList(string strand)
        {
            if (strand == "AUG")
                return "Methionine";
            else if (strand == "UUU" || strand == "UUC")
                return "Phenylalanine";
            else if (strand == "UUA" || strand == "UUG")
                return "Leucine";
            else if (strand == "UCU" || strand == "UCC" || strand == "UCA" || strand == "UCG")
                return "Serine";
            else if (strand == "UAU" || strand == "UAC")
                return "Tyrosine";
            else if (strand == "UGU" || strand == "UGC")
                return "Cysteine";
            else if (strand == "UGG")
                return "Tryptophan";
            else
                return "Another";

        }
    }
}
