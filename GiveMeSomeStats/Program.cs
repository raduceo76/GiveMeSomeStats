using System;
using System.Collections.Generic;

namespace GiveMeSomeStats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"My input: {args[0]}");

            var statsProcessor = new Stats(new StatsUtil());

            var stats = statsProcessor.Process(args[0]);

            if (stats.InvalidInput)
             {
                Console.WriteLine("Invalid input. Please enter comma separated integers!");
            }
            else
            {
                Console.WriteLine($"Max number is: {stats.MaxNumber}");

                Console.WriteLine($"Min number is: {stats.MinNumber}");

                Console.WriteLine($"Average is: {stats.Mean}");

                Console.WriteLine($"Std Deviation is: {stats.StDeviation}");
            }

            Console.WriteLine("Press any key to close the window");
            Console.Read();
        }
    }
}
