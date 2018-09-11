using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
           
            string str=null;

           // throw new NotImplementedException("You need to implement this function.");


           //switch case to convert DNA strand to its RNA complement 
            
            for (int i = 0; i < nucleotide.Length; i++)
            {

               switch (nucleotide[i])
               {
                   case  'G' :
                  str +="C";
                   break;

                   case  'C' :
                   str +="G";
                   break;

                   case  'T' :
                    str +="A";
                   break;

                   case  'A' :                 
                   str +="U";
                   break;
                   
                   default:
                   System.Console.WriteLine("invalid entry");
                   break;
               }

            }

            return str;

        }
    }
}
