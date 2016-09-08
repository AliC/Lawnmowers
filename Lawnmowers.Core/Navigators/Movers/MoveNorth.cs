namespace Lawnmowers.Core.Navigators
{
    public class MoveNorth : IMover
    {
        private readonly Mower _mower;

        public MoveNorth(Mower mower)
        {
            _mower = mower;
        }

        public void Move()
        {
            Position destination = new Position(_mower.Position.X, _mower.Position.Y + 1, _mower.Position.Heading);

            _mower.Move(destination);
        }
    }
}