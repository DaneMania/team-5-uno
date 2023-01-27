using levelup.cli;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace levelup {
    class GameMapTest
    {
        GameMap testObj=new GameMap();

    [Test]
        public void TestMapCreatesPositionsWhenInitialized()
        {
            Assert.NotNull(testObj.positions);
            Assert.AreEqual(100, testObj.positions.Length);
            Position samplePosition = testObj.positions[4,3];
            Assert.AreEqual(4, samplePosition.X);
            Assert.AreEqual(3, samplePosition.Y);
            Assert.NotNull(testObj.startingPosition);
        }
    }
}

