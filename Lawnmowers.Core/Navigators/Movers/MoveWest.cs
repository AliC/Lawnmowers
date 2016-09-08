namespace Lawnmowers.Core.Navigators
{
    public class MoveWest : IMover
    {
        protected readonly Mower _mower;

        public MoveWest(Mower mower)
        {
            _mower = mower;
        }

        public void Move()
        {
            Position destination = new Position(_mower.Position.X - 1, _mower.Position.Y, _mower.Position.Heading);

            _mower.Move(destination);
        }
    }
}