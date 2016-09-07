namespace Lawnmowers.Core.Navigators
{
    public class MoveSouth : Mover
    {
        public MoveSouth(Mower mower) : base(mower)
        {
        }

        public override void Move()
        {
            Position newPosition = new Position(_mower.Position.X, _mower.Position.Y - 1, _mower.Position.Heading);

            Move(newPosition);
        }
    }
}