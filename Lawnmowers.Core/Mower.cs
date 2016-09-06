namespace Lawnmowers.Core
{
    public class Mower
    {
        public Position Position { get; set; }

        public bool IsDeployed
        {
            get
            {
                return Position != null;
            }
        }
    }
}