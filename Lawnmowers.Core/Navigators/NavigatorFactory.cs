using System;

namespace Lawnmowers.Core.Navigators
{
    public static class NavigatorFactory
    {
        public static INavigator Create(Mower mower, char instruction)
        {
            switch (instruction)
            {
                case 'L':
                {
                    return new HeadingChangeLeft(mower);
                }

                case 'R':
                {
                    return new HeadingChangeRight(mower);
                }

                case 'M':
                {
                    return new MoveForward(mower);
                }

                default:
                {
                    throw new Exception("Unknown instruction");
                }
            }
        }
    }
}