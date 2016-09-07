using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Lawnmowers.Core.UnitTests
{
    public class MowTheLawnTests
    {
        [Test]
        public void Input_And_Output()
        {
            //TODO ADC: come up with way to define lines of input and interpret them for each usage
            // i.e. have the array ["5 5", "1 2 N"] execute as the creation of the lawn and the deployment of the mower
            
            Lawn lawn = Lawn.Create("5 5");

            Mower mower1 = new Mower(lawn.Border);
            mower1.Deploy("1 2 N");

            RemoteControl remoteControl = new RemoteControl();
            remoteControl.ConnectMower(mower1);
            remoteControl.Send("LMLMLMLMM");

            Assert.That(mower1.Status, Is.EqualTo("1 3 N"));

            Mower mower2 = new Mower(lawn.Border);
            mower2.Deploy("3 3 E");

            remoteControl.ConnectMower(mower2);
            remoteControl.Send("MMRMMRMRRM");

            Assert.That(mower2.Status, Is.EqualTo("5 1 E"));
        }
    }
}
