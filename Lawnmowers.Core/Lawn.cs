using System;

namespace Lawnmowers.Core
{
    public class Lawn
    {
        public Border Border { get; set; }

        public Lawn(int x, int y)
        {
            Border = new Border(x, y);
        }

        public static Lawn Create(string coordinates)
        {
            string[] xy = coordinates.Split(' ');
            int x = Convert.ToInt32(xy[0]);
            int y = Convert.ToInt32(xy[1]);

            return new Lawn(x, y);
        }

        public void DeployMower(Mower mower, Position position)
        {
            if(WithinBorders(position))
            {
                mower.Position = position;
            }
        }

        private bool WithinBorders(Position position)
        {
            if(position.X <= Border.X && position.Y <= Border.Y)
            {
                return true;
            }

            return false;
        }
    }
}