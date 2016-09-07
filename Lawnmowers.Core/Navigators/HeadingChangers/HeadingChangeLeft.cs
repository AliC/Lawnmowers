using System.Linq;

namespace Lawnmowers.Core.Navigators
{
    public class HeadingChangeLeft : HeadingChange
    {
        public HeadingChangeLeft(Mower mower) : base(mower)
        {
        }

        public override void Navigate()
        {
            _mower.Position.Heading = Next(_headings.Reverse(), _mower.Position.Heading);
        }
    }
}