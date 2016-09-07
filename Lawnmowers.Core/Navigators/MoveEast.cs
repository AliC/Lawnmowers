namespace Lawnmowers.Core.Navigators
{
    public class MoveEast : IMover
    {
        private readonly Mower _mower;

        public MoveEast(Mower mower)
        {
            _mower = mower;
        }

        public void Move()
        {
            Position newPosition = new Position(_mower.Position.X + 1, _mower.Position.Y, _mower.Position.Heading);

            if(_mower.WithinBorders(newPosition))
            {
                _mower.Position = newPosition;
            }
        }
    }
}