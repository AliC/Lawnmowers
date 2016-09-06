using System;

namespace Lawnmowers.Core
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Heading { get; set; }

        public Position(string position)
        {
            string[] xyz = position.Split(' ');

            X = Convert.ToInt32(xyz[0]);
            Y = Convert.ToInt32(xyz[1]);
            Heading = xyz[2];
        }
    }
}