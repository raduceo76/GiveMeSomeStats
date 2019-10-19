using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GiveMeSomeStats.Tests
{
    [TestClass]
    public class StatsTests
    {
        [DataTestMethod]
        [DataRow("")]
        public void Process_InvalidInput(string input)
        {
            var statsUtilsMock = new Mock<IStatsUtil>();
            statsUtilsMock.Setup(x => x.ParseInput(It.IsAny<string>()))
                .Throws(new Exception());

            var statsMock = new Stats(statsUtilsMock.Object);

            var result = statsMock.Process(input);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.InvalidInput);
        }

        [DataTestMethod]
        [DataRow("1,2,3,4,5,6")]
        public void Process_Success(string input)
        {
            var statsUtilsMock = new Mock<IStatsUtil>();
            var parsedList = new List<int> { 1, 2, 3, 4, 5, 6 };
            int fakeResult = 1;
            statsUtilsMock.Setup(x => x.ParseInput(It.IsAny<string>()))
                .Returns(parsedList);
            statsUtilsMock.Setup(x => x.GetMax(It.IsAny<IEnumerable<int>>()))
                .Returns(fakeResult);
            statsUtilsMock.Setup(x => x.GetMin(It.IsAny<IEnumerable<int>>()))
                .Returns(fakeResult);
            statsUtilsMock.Setup(x => x.GetAvg(It.IsAny<IEnumerable<int>>()))
                 .Returns(fakeResult);
            statsUtilsMock.Setup(x => x.GetStd(It.IsAny<IEnumerable<int>>()))
                .Returns(fakeResult);

            var statsMock = new Stats(statsUtilsMock.Object);

            var result = statsMock.Process(input);

            Assert.IsNotNull(result);
            Assert.IsFalse(result.InvalidInput);
            Assert.AreEqual(fakeResult, result.MaxNumber);
            Assert.AreEqual(fakeResult, result.MinNumber);
            Assert.AreEqual(fakeResult, result.Mean);
            Assert.AreEqual(fakeResult, result.StDeviation);
        }

        // Other tests come here ...
    }
}
