using levelup.cli;
using NUnit.Framework;

using TechTalk.SpecFlow;
namespace levelup {
    class PositionTest
    {
        public Position pos=new Position(5,5);
        
        public PositionTest()
        {
            Position position = new Position();
            position.X =  5;
        }
    [Test]
            public void ValidPositionTest()
            {
                Assert.AreEqual(0, pos.X);
            }
    }

}


