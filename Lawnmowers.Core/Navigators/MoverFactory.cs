using System;

namespace Lawnmowers.Core.Navigators
{
    public class MoverFactory
    {
        public static IMover Create(Mower mower)
        {
            switch (mower.Position.Heading)
            {
                case "N":
                    {
                        return new MoveNorth(mower);
                    }

                case "E":
                    {
                        return new MoveEast(mower);
                    }

                case "S":
                    {
                        return new MoveSouth(mower);
                    }

                case "W":
                    {
                        return new MoveWest(mower);
                    }

                default:
                    {
                        throw new Exception("Unknown heading");
                    }
            }
        }
    }
}