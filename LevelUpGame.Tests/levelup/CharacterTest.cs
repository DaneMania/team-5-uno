using levelup.cli;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace levelup
{
public class CharacterTest {
    private Character? testObj;

    string arbitraryName = "Arbitrary Name";

    [SetUp]
    public void SetUp()
    {
        testObj = new Character(arbitraryName);
    }

    [Test]
        public void CharacterHasNameAndMoveCountWhenInitialized()
        {
            Assert.AreEqual(arbitraryName, testObj.Name);
            Assert.AreEqual(0, testObj.moveCount());
        }
}
}

