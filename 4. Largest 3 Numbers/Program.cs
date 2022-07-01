using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedNumbers = numbers.OrderByDescending(number => number).ToArray();
            Console.Write($"{sortedNumbers[0]} {sortedNumbers[1]} {sortedNumbers[2]}");

        }
    }
}
