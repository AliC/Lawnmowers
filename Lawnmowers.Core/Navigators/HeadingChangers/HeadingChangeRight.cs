using System.Linq;

namespace Lawnmowers.Core.Navigators
{
    public class HeadingChangeRight : HeadingChange
    {
        public HeadingChangeRight(Mower mower) : base(mower)
        {
        }

        public override void Navigate()
        {
            _mower.Position.Heading = Next(_headings, _mower.Position.Heading);
        }
    }
}