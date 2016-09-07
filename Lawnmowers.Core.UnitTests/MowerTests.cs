using NUnit.Framework;

namespace Lawnmowers.Core.UnitTests
{
    [TestFixture]
    public class MowerTests
    {
        [Test]
        public void When_Mower_Position_Is_Valid_Then_Mower_Is_Deployed()
        {
            Border border = new Border(5, 5);
            Mower mower = new Mower(border);

            mower.Deploy("1 2 N");

            Assert.IsTrue(mower.IsDeployed);
        }

        [Test]
        public void When_Mower_Position_Is_Not_Valid_Then_Mower_Is_Not_Deployed()
        {
            Border border = new Border(5, 5);
            Mower mower = new Mower(border);

            mower.Deploy("6 6 N");

            Assert.IsFalse(mower.IsDeployed);
        }
    }
}
