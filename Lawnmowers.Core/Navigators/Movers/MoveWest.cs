namespace Lawnmowers.Core.Navigators
{
    public class MoveWest : Mover
    {
        public MoveWest(Mower mower) : base(mower)
        {
        }

        public override void Move()
        {
            Position newPosition = new Position(_mower.Position.X - 1, _mower.Position.Y, _mower.Position.Heading);

            Move(newPosition);
        }
    }
}