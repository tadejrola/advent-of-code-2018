using System.IO;

namespace advent_of_code_2018.src.day1
{
    internal class Day1
    {
        public int getFrequency()
        {
            var lines = File.ReadAllLines("../../src/day1/input.txt");
            int frequency = 0;
            for (var i = 0; i < lines.Length; i += 1)
            {
                var line = int.Parse(lines[i]);
                frequency += line;
            }
            return frequency;
        }
    }
}