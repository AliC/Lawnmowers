namespace Lawnmowers.Core.Navigators
{
    public class MoveForward : INavigator
    {
        private readonly Mower _mower;

        public MoveForward(Mower mower)
        {
            _mower = mower;
        }

        public void Navigate()
        {
            IMover mover = MoverFactory.Create(_mower);
            mover.Move();
        }
    }
}