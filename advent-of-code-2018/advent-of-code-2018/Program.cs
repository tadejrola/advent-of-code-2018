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
            Console.ReadLine();
        }
    }
}