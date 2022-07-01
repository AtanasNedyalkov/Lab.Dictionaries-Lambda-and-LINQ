using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._A_Miner_Task_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            string resource = string.Empty;
            while ((resource = Console.ReadLine()) != "stop")
                
            {
                
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = quantity;
                }
                else
                {
                    resources[resource] += quantity;
                }
                

            }
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
