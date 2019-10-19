using System;
using System.Collections.Generic;
using System.Text;

namespace GiveMeSomeStats.Models
{
    public class StatModel
    {
        public bool InvalidInput { get; set; }
        public int MaxNumber { get; set; }
        public int MinNumber { get; set; }
        public double Mean { get; set; }
        public double StDeviation { get; set; }
    }
}
