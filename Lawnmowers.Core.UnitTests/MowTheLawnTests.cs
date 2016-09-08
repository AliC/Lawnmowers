using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Lawnmowers.Core.UnitTests
{
    public class MowTheLawnTests
    {
        [Test]
        public void Input_And_Output()
        {
            string input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";

            string[] inputLines = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            IList<Mower> mowers = new List<Mower>();

            Lawn lawn = Lawn.Create(inputLines[0]);

            RemoteControl remoteControl = new RemoteControl();

            for (int i = 1; i < inputLines.Length - 1; i += 2)
            {
                Mower mower = new Mower(lawn.Border);
                mower.Deploy(inputLines[i]);

                remoteControl.ConnectMower(mower);
                remoteControl.Send(inputLines[i + 1]);

                mowers.Add(mower);
            }

            Assert.That(mowers.Count, Is.EqualTo(2));
            Assert.That(mowers[0].Status, Is.EqualTo("1 3 N"));
            Assert.That(mowers[1].Status, Is.EqualTo("5 1 E"));
        }
    }
}
