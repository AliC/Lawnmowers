using System;

namespace Lawnmowers.Core
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Heading { get; set; }

        public Position(int x, int y, string heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }

        public static Position Create(string position)
        {
            string[] xyz = position.Split(' ');

            int x = Convert.ToInt32(xyz[0]);
            int y = Convert.ToInt32(xyz[1]);
            string heading = xyz[2];

            return new Position(x, y, heading);
        }
    }
}