namespace Lawnmowers.Core.Navigators
{
    public class MoveEast : Mover
    {
        public MoveEast(Mower mower) : base(mower)
        {
        }

        public override void Move()
        {
            Position newPosition = new Position(_mower.Position.X + 1, _mower.Position.Y, _mower.Position.Heading);

            Move(newPosition);
        }
    }
}