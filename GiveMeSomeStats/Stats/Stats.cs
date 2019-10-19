using GiveMeSomeStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GiveMeSomeStats
{
    public class Stats : IStats
    {
        private readonly IStatsUtil _util;

        public Stats(IStatsUtil util)
        {
            _util = util;
        }
        /// <summary>
        /// Processes comma seprated list of integers and return stats.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public StatModel Process(string inputString)
        {
            var statModel = new StatModel();
            IEnumerable<int> inputCol = null;
            try
            {
                inputCol = _util.ParseInput(inputString).ToList();
            }
            catch (Exception ex)
            {
                if (_util == null)
                {
                    throw ex;
                }
                statModel.InvalidInput = true;
            }

            if (inputCol != null && inputCol.Any())
            {
                statModel.MaxNumber = _util.GetMax(inputCol);

                statModel.MinNumber = _util.GetMin(inputCol);

                statModel.Mean = _util.GetAvg(inputCol);

                statModel.StDeviation = _util.GetStd(inputCol);
            }
            else
            {
                statModel.InvalidInput = true;
            }

            return statModel;
        }
    }
}
