//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exercises.ProteinTranslation
//{
//    internal class ProteinTranslation
//    {
//        //Codon               Protein
//        //AUG                 Methionine
//        //UUU, UUC            Phenylalanine
//        //UUA, UUG            Leucine
//        //UCU, UCC, UCA, UCG  Serine
//        //UAU, UAC            Tyrosine
//        //UGU, UGC            Cysteine
//        //UGG                 Tryptophan
//        //UAA, UAG, UGA       STOP

//        public static string[] Proteins(string strand)
//        {
//            strand = strand.Trim().ToUpper();
//            string stop = "UAA";
//            string[] test = strand.Split();
//            int endIndex = strand.LastIndexOf(stop);
//        }

//        private static string Stop()
//        {
//            string stop1 = "UAA";
//            string stop2 = "UAG";
//            string stop3 = "UGA";
//        }
//    }
//}
