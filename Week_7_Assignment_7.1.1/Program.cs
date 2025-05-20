using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
namespace Week_7_Assignment_7._1._1
{
    internal class Program
    {
        //You are a student who has recently taken an exam with your classmates.
        //However, the professor has not yet provided the students with a sorted list of exam scores.
        //To make things easier, you write a program to sort exam scores in ascending order 
        //using the selection sort algorithm.This way, you can obtain the sorted list of scores 
        //and see how you performed compared to your classmates.
        //Also, you choose selection sort since that is an easy way of implementation.

        // Pseudo code
        // Declare a variable called "temp" to the switch
        // Declare a variable called "LowestScorePosition to keep track of the first element position
        // To Conduct Selection Sort start with the first element then compare with next element
        //  Make sure to avoid swipping with self
        static void SelectionSort(int[] scores)
        {
            //Selection Sort
            int LowestScorePosition = 0;
            int temp = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                LowestScorePosition = i;

                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[LowestScorePosition])
                    {
                        LowestScorePosition = j;
                    }
                }
                if (LowestScorePosition != i)
                {
                    temp = scores[i];
                    scores[i] = scores[LowestScorePosition];
                    scores[LowestScorePosition] = temp;
                }
            }

        }
            // Insertion Sort
            static void InsertionSort(int[] MathScores) {
                int Temp = 0;
                int LowestPosition = 0;

                for (int i = 1; i < MathScores.Length; i++)
                {
                    Temp = MathScores[i];
                    LowestPosition = i;
                    while(LowestPosition > 0 && MathScores[LowestPosition - 1] > Temp)
                    {
                        MathScores[LowestPosition] = MathScores[LowestPosition -1];
                        LowestPosition--;
                    }
                    MathScores[LowestPosition] = Temp; 
                }
            }
        
    static void Main(string[] args)
    {
        int[] scores = { 80, 75, 90, 60, 55, 89, 92, 98, 99 };

        int[] MathScores = { 60, 55, 89, 92, 98, 99, 90, 75, 80 };

        SelectionSort(scores);
        InsertionSort(MathScores);
        
            Console.WriteLine("Selection Sorted in Ascending order: ");
            foreach (int i in scores)
            {
                Console.Write(i + "  ");
            }

         
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Insertion Sorted in Ascending order: ");
            foreach(int i in MathScores)
            {
                Console.Write(i + "  ");

            }
        }
    }
}
