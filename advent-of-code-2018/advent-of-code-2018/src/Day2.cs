using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace advent_of_code_2018.src
{
    internal class Day2
    {
        public int getChecksum()
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

        public string getCommonChars()
        {
            var lines = File.ReadAllLines("../../src/inputs/day2/input.txt");
            Dictionary<string[], int> wordsAndTheirDifferences = new Dictionary<string[], int>();
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 1; j < lines.Length; j++)
                {
                    if (i == j)
                        break;
                    int numberOfDifferences = 0;
                    for (int k = 0; k < lines[i].Length; k++)
                    {
                        if (lines[i][k] != lines[j][k])
                            numberOfDifferences++;
                    }
                    string[] vs = new string[] { lines[i], lines[j] };
                    wordsAndTheirDifferences.Add(vs, numberOfDifferences);
                }
            }

            var keys = wordsAndTheirDifferences.OrderBy(kvp => kvp.Value).First().Key;
            string final = "";
            for (int i = 0; i < keys[0].Length; i++)
            {
                if (keys[0][i].ToString() == keys[1][i].ToString())
                {
                    final += keys[0][i];
                }
            }

            return final;
        }
    }
}