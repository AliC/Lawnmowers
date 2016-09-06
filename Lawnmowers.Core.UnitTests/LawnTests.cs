using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Lawn actualLawn = Lawn.Create(expectedX, expectedY);

            Assert.IsNotNull(actualLawn);
            Assert.IsNotNull(actualLawn.Border);
            Assert.That(actualLawn.Border.X, Is.EqualTo(expectedX));
            Assert.That(actualLawn.Border.Y, Is.EqualTo(expectedY));
        }
    }
}
