namespace Lawnmowers.Core
{
    public class Lawn
    {
        public int X { get; }

        public int Y { get; }

        public Lawn(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Lawn Create(int x, int y)
        {
            return new Lawn(x, y);
        }
    }
}