using System;
using System.Collections.Generic;

namespace Assignment_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");

            string str;

            TextAnalyzer textAnalyzer = new TextAnalyzer(out str);

            SortedList<char, int> textAnalyzerStats = textAnalyzer.statistics();

            Console.WriteLine("Initialized text: " + str);
            Console.WriteLine();
            Console.WriteLine("Statistics:");
            foreach (KeyValuePair<char, int> entry in textAnalyzerStats)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
