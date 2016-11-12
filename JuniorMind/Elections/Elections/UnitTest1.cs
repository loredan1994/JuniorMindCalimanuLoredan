using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Elections
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlphabeticalSort()
        {
            var USR = new Candidate("USR", 7);
            var PNL = new Candidate("PNL", 3);
            var PSD = new Candidate("PSD", 1);
            var candidates = new PollingStation(new Candidate[] { USR, PNL, PSD });
            var expectedOrder = new PollingStation(new Candidate[] { PNL, PSD, USR });
            Assert.AreEqual(expectedOrder, candidates);
        }

        [TestMethod]
        public void MyTest()
        {

            var firstPollingStation = new PollingStation(new Candidate[] {  new Candidate("PSD", 1), new Candidate("PNL", 3), new Candidate("USR", 7) });
            var secondPollingStation = new PollingStation(new Candidate[] { new Candidate("PNL", 4), new Candidate("PSD", 4), new Candidate("USR", 6) });
            PollingStation[] sortedStations = new PollingStation[] { firstPollingStation, secondPollingStation };
            Centralizer obj = new Centralizer(sortedStations);

            var expectedOrder = new PollingStation(new Candidate[] { new Candidate("USR", 13), new Candidate("PNL", 7), new Candidate("PSD", 5) });

            Assert.AreEqual(expectedOrder, obj.CentralizePollingStations());
        }

    }
}