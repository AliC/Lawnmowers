using Lawnmowers.Core.Navigators;

namespace Lawnmowers.Core
{
    public class Mower
    {
        private readonly Border _border;

        public Mower(Border border)
        {
            _border = border;
        }

        public Position Position { get; set; }

        public bool IsDeployed
        {
            get
            {
                return Position != null;
            }
        }

        public string Status()
        {
            return string.Join(" ", Position.X, Position.Y, Position.Heading);
        }

        public void Deploy(string position)
        {
            Position deploymentTarget = Position.Create(position);

            if (WithinBorders(deploymentTarget))
            {
                Position = deploymentTarget;
            }
        }

        public void Navigate(string instructions)
        {
            foreach(char instruction in instructions)
            {
                INavigator navigator = NavigatorFactory.Create(this, instruction);
                navigator.Navigate();
            }
        }

        public void Move(Position destination)
        {
            if (WithinBorders(destination))
            {
                Position = destination;
            }
        }

        private bool WithinBorders(Position position)
        {
            if (position.X <= _border.X && position.Y <= _border.Y)
            {
                return true;
            }

            return false;
        }

    }
}