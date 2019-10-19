using System;
using System.Collections.Generic;
using System.Text;

namespace GiveMeSomeStats
{
    public interface IStatsUtil
    {
        IEnumerable<int> ParseInput(string inputStr);
        int GetMax(IEnumerable<int> input);
        int GetMin(IEnumerable<int> input);
        double GetAvg(IEnumerable<int> input);
        double GetStd(IEnumerable<int> input);
    }
}
