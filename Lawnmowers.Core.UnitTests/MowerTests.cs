using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lawnmowers.Core.UnitTests
{
    [TestFixture]
    public class MowerTests
    {
        [Test]
        public void When_Mower_Is_Created_Then_Mower_Is_Not_Deployed()
        {
            Mower mower = new Mower();

            Assert.IsFalse(mower.IsDeployed);
        }

        [Test]
        public void When_Mower_Is_Created_And_Position_Set_Then_Mower_Is_Deployed()
        {
            Mower mower = new Mower();
            mower.Position = new Position("0 0 N");

            Assert.IsTrue(mower.IsDeployed);
        }
    }

}
