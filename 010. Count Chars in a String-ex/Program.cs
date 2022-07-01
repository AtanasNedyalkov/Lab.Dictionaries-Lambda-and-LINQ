using System;
using System.Collections.Generic;
using System.Linq;

namespace _010._Count_Chars_in_a_String_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Where(x => x != ' ').ToArray();
            var countChar = new Dictionary<char, int>();
            foreach (var charecter in text)
            {
                if (!countChar.ContainsKey(charecter))
                {
                    countChar[charecter] = 0;
                }
                countChar[charecter]++;
            }
            foreach (var kvp in countChar)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
