using System.Collections.Generic;
using System.IO;

namespace advent_of_code_2018.src
{
    internal class Day2
    {
        public int getFrequency()
        {
            var lines = File.ReadAllLines("../../src/inputs/day2/input.txt");

            int totalDouble = 0;
            int totalTriple = 0;
            foreach (var line in lines)
            {
                Dictionary<char, int> pairs = new Dictionary<char, int>();
                for (char c = 'a'; c <= 'z'; c++)
                {
                    pairs.Add(c, 0);
                }
                char[] vs = line.ToCharArray();
                foreach (char c in vs)
                {
                    pairs[c]++;
                }
                if (pairs.ContainsValue(2) && pairs.ContainsValue(3))
                {
                    totalDouble++;
                    totalTriple++;
                }
                else if (pairs.ContainsValue(2))
                {
                    totalDouble++;
                }
                else if (pairs.ContainsValue(3))
                {
                    totalTriple++;
                }
            }

            return totalDouble * totalTriple;
        }
    }
}