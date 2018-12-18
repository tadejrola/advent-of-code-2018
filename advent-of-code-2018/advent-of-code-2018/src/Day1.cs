using System.Collections.Generic;
using System.IO;

namespace advent_of_code_2018.src
{
    internal class Day1
    {
        public int getFrequency()
        {
            var lines = File.ReadAllLines("../../src/inputs/day1/input.txt");
            int frequency = 0;
            for (var i = 0; i < lines.Length; i += 1)
            {
                var line = int.Parse(lines[i]);
                frequency += line;
            }
            return frequency;
        }

        public int getDoubledFrequency()
        {
            var lines = File.ReadAllLines("../../src/inputs/day1/input.txt");
            int frequency = 0;
            Dictionary<int, int> tempFrequencies = new Dictionary<int, int>();
            tempFrequencies[frequency] = frequency;
            int i = 0;

            while (i < lines.Length)
            {
                var line = int.Parse(lines[i]);
                frequency += line;
                if (tempFrequencies.ContainsKey(frequency))
                    return frequency;

                tempFrequencies[frequency] = frequency;

                i++;
                if (i == lines.Length)
                {
                    i = 0;
                }
            }
            return 0;
        }
    }
}