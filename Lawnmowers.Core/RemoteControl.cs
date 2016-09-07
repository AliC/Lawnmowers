namespace Lawnmowers.Core
{
    public class RemoteControl
    {
        private Mower _mower;

        public void ConnectMower(Mower mower)
        {
            _mower = mower;
        }

        public void Send(string instructions)
        {
            _mower.Navigate(instructions);
        }
    }
}