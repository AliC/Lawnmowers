namespace Lawnmowers.Core.Navigators
{
    public class MoveSouth : IMover
    {
        private readonly Mower _mower;

        public MoveSouth(Mower mower)
        {
            _mower = mower;
        }

        public void Move()
        {
            Position newPosition = new Position(_mower.Position.X, _mower.Position.Y - 1, _mower.Position.Heading);

            if(_mower.WithinBorders(newPosition))
            {
                _mower.Position = newPosition;
            }
        }
    }
}