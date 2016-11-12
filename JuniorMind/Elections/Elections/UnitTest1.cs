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
            var candidates = new PollingStation( new Candidate[] { new Candidate("PNL", 3), new Candidate("PSD", 1), new Candidate("USR", 7)  });
            var expectedOrder = new PollingStation(new Candidate[] { new Candidate("PNL", 3), new Candidate("PSD", 1), new Candidate("USR", 7) });
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