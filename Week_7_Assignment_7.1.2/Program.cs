using System.Text;
using Microsoft.VisualBasic;

namespace Week_7_Assignment_7._1._2
{
    internal class Program
    {
        //You are given two strings word1 and word2.Merge the strings by adding letters in alternating order, 
        //starting with word1.If a string is longer than the other, 
        //append the additional letters onto the end of the merged string.
        //Return the merged string.

        //O(n)
        public static string MergeWords(string word1, string word2)
        {
            var sb = new StringBuilder();

            int i = 0; //
          

            // Alternately
            while (i < word1.Length || i < word2.Length)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);

                }
                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                  
                }
                i++;
            }

            // Convert to Char array
            char[] chars = sb.ToString().ToCharArray();

            //O(n^2)
            // Selection Sort
            for (int j = 0; j < chars.Length; j++)
            {
                int minpos = j;
                for(int k = j; k < chars.Length; k++)
                {
                    if ((chars[k] < chars[minpos]))
                        minpos = k;
                }
               

                //Swap
                char temp = chars[j];
                chars[j] = chars[minpos];
                chars[minpos] = temp;
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqr";

            string merged = MergeWords(word1, word2);
            Console.WriteLine(merged);
            
        }
    }
}
