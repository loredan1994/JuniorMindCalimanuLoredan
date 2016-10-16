using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elections
{
    [TestClass]
    public class ElectionsTests
    {
   [TestMethod]
        public void MyTest()
        {

            var firstPollingStation = new PollingStation(new Candidate[] { new Candidate("PSD", 1), new Candidate("PNL", 3), new Candidate("ARD", 7) });
            var secondPollingStation = new PollingStation(new Candidate[] { new Candidate("PNL", 4), new Candidate("PSD", 4), new Candidate("ARD", 6) });
            PollingStation[] sortedStations = new PollingStation[] { firstPollingStation, secondPollingStation };
            Centralizer obj = new Centralizer(sortedStations);

            var expected = new PollingStation(new Candidate[] { new Candidate("ARD", 13), new Candidate("PNL", 7), new Candidate("PSD", 5) });

            Assert.AreEqual(expected, obj.CentralizePollingStations());
        }

    }
}