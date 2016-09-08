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
            Position destination = new Position(_mower.Position.X + 1, _mower.Position.Y, _mower.Position.Heading);

            _mower.Move(destination);
        }
    }
}