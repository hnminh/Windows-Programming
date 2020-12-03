using System;
using System.Text;
using System.Collections.Generic;

namespace Assignment_2_2
{
    public class TextAnalyzer
    {
        string text;

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public TextAnalyzer(out string text)
        {
            initializeRandomText(out text);
            this.text = text;
        }

        public static void initializeRandomText(out string str)
        {
            StringBuilder result = new StringBuilder();
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                result.Append(chars[r.Next(chars.Length)]);
            }

            str = result.ToString();
        }

        public SortedList<char, int> statistics()
        {
            SortedList<char, int> stats = new SortedList<char, int>();

            foreach (char c in this.text)
            {
                if (stats.ContainsKey(c))
                {
                    stats[c]++;
                }
                else
                {
                    stats.Add(c, 1);
                }
            }
            return stats;
        }
    }
}
