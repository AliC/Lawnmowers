namespace Lawnmowers.Core.Navigators
{
    public abstract class Mover : IMover
    {
        protected readonly Mower _mower;

        protected Mover(Mower mower)
        {
            _mower = mower;
        }

        protected void Move(Position newPosition)
        {
            if (_mower.WithinBorders(newPosition))
            {
                _mower.Position = newPosition;
            }
        }

        public abstract void Move();
    }
}