using advent_of_code_2018.src.day1;
using System;

namespace advent_of_code_2018
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Day1 day1 = new Day1();
            var frequency = day1.getFrequency();
            Console.WriteLine("RESULT DAY 1:");
            Console.WriteLine(frequency);
            Console.ReadLine();
        }
    }
}