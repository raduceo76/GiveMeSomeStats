using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MathNet.Numerics.Statistics;

namespace GiveMeSomeStats
{
    public class StatsUtil : IStatsUtil
    {
        /// <summary>
        /// Gets integer list of comma separated string input
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public IEnumerable<int> ParseInput(string inputStr)
        {
            return inputStr.Split(",")
                .Select(x => int.Parse(x))
                .ToList();
        }

        /// <summary>
        /// Gets maximum number of the list
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetMax(IEnumerable<int> input)
        {
            return input.Max(x => x);
        }

        /// <summary>
        /// Gets minimun number of the list
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetMin(IEnumerable<int> input)
        {
            return input.Min(x => x);
        }

        /// <summary>
        /// Gets Avarage of the list and rounds to two decimal places
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double GetAvg(IEnumerable<int> input)
        {
            // rounds to two decimal points
            return Math.Round(input.Average() * 100) / 100;
        }
        /// <summary>
        /// Gets standard deviation of the list and rounds to two decimal places
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double GetStd(IEnumerable<int> input)
        {
            return Math.Round(
                input
                .Select(x => (double)x)
                .StandardDeviation() * 100) / 100;
        }
    }
}
