namespace Lawnmowers.Core
{
    public class Lawn
    {
        public Border Border { get; set; }

        public Lawn(int x, int y)
        {
            Border = new Border(x, y);
        }

        public static Lawn Create(int x, int y)
        {
            return new Lawn(x, y);
        }
    }
}