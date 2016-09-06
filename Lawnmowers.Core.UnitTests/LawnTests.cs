using NUnit.Framework;

namespace Lawnmowers.Core.UnitTests
{
    [TestFixture]
    public class LawnTests
    {
        [Test]
        public void When_Coordinates_Are_Five_By_Five_Then_Lawn_Is_Created_Five_By_Five()
        {
            int expectedX = 5;
            int expectedY = 5;

            Lawn actualLawn = Lawn.Create("5 5");

            Assert.IsNotNull(actualLawn);
            Assert.IsNotNull(actualLawn.Border);
            Assert.That(actualLawn.Border.X, Is.EqualTo(expectedX));
            Assert.That(actualLawn.Border.Y, Is.EqualTo(expectedY));
        }

        [Test]
        public void When_Mower_Position_Is_Valid_Then_Mower_Is_Deployed()
        {
            Mower mower = new Mower();
            Lawn lawn = Lawn.Create("5 5");

            lawn.DeployMower(mower, "1 2 N");

            Assert.IsTrue(mower.IsDeployed);
        }

        [Test]
        public void When_Mower_Position_Is_Not_Valid_Then_Mower_Is_Not_Deployed()
        {
            Mower mower = new Mower();
            Lawn lawn = Lawn.Create("5 5");

            lawn.DeployMower(mower, "6 6 N");

            Assert.IsFalse(mower.IsDeployed);
        }
    }
}
