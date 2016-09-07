using System;

namespace Lawnmowers.Core
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Heading { get; set; }

        //TODO ADC: use one constructor to set the properties, have other constructors
        // call into the first one (DRY)
        public Position(string position)
        {
            string[] xyz = position.Split(' ');

            X = Convert.ToInt32(xyz[0]);
            Y = Convert.ToInt32(xyz[1]);
            Heading = xyz[2];
        }

        public Position(int x, int y, string heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }
    }
}