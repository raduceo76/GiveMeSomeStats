using GiveMeSomeStats.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiveMeSomeStats
{
    public interface IStats
    {
        StatModel Process(string inputString);
    }
}
