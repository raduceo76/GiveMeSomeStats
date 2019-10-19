using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GiveMeSomeStats.Tests
{
    [TestClass]
    public class StatUtilTests
    {
        protected readonly IStatsUtil _statUtil;
        
        public StatUtilTests()
        {
            _statUtil = new StatsUtil();
        }

        [DataTestMethod]
        [DataRow("1,2,3,4,5,6")]
        [DataRow("1")]
        [DataRow("0")]
        public void ParseInput_Test_Success(string stringList)
        {
            var result = _statUtil.ParseInput(stringList);

            Assert.IsTrue(result.Count() == stringList.Split(",").Length, $"{stringList} is not valid input");
        }

        [DataTestMethod]
        [DataRow(null)] 
        public void ParseInput_Test_Fail_NullReferenceException(string stringList)
        {
            Assert.ThrowsException<NullReferenceException>(() => _statUtil.ParseInput(stringList));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("1,a,3")]
        public void ParseInput_Test_Fail_FormatException(string stringList)
        {
            Assert.ThrowsException<FormatException>(() => _statUtil.ParseInput(stringList));
        }

        // Remaining tests come here ...
    }
}
