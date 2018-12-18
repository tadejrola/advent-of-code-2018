using System.Collections.Generic;
using System.IO;

namespace advent_of_code_2018.src
{
    internal class Day1
    {
        public int getFrequency()
        {
            var lines = File.ReadAllLines("../../src/inputs/input.txt");
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
            var lines = File.ReadAllLines("../../src/inputs/input.txt");
            int frequency = 0;
            List<int> tempFrequencies = new List<int>();
            tempFrequencies.Add(frequency);
            int i = 0;

            while (i < lines.Length)
            {
                var line = int.Parse(lines[i]);
                frequency += line;
                tempFrequencies.Add(frequency);
                if (tempFrequencies.FindAll(x => x == frequency).Count == 2)
                {
                    return frequency;
                }
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