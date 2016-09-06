using NUnit.Framework;

namespace Lawnmowers.Core.UnitTests
{
    [TestFixture]
    public class PositionTests
    {
        [Test]
        public void When_Input_Is_12N_Then_Position_Is_Created_12N()
        {
            int expectedX = 1;
            int expectedY = 2;
            string expectedHeading = "N";

            Position actualPosition = new Position("1 2 N");

            Assert.IsNotNull(actualPosition);
            Assert.That(actualPosition.X, Is.EqualTo(expectedX));
            Assert.That(actualPosition.Y, Is.EqualTo(expectedY));
            Assert.That(actualPosition.Heading, Is.EqualTo(expectedHeading));
        }

    }
}
