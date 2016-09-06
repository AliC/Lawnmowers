namespace Lawnmowers.Core
{
    public struct Border
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Border(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}