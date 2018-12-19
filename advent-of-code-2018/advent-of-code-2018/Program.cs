using advent_of_code_2018.src;
using System;

namespace advent_of_code_2018
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Day1 day1 = new Day1();
            var frequency = day1.getFrequency();
            var repeatedFrequency = day1.getDoubledFrequency();
            Console.WriteLine("RESULT DAY 1 part1:");
            Console.WriteLine(frequency);
            Console.WriteLine("RESULT DAY 1 part2:");
            Console.WriteLine(repeatedFrequency);

            Day2 day2 = new Day2();
            var checksum = day2.getChecksum();
            var commonChars = day2.getCommonChars();
            Console.WriteLine("RESULT DAY 2 part1:");
            Console.WriteLine(checksum);

            Console.WriteLine("RESULT DAY 2 part2:");
            Console.WriteLine(commonChars);
            Console.ReadLine();
        }
    }
}