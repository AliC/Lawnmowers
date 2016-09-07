using System;
using System.Collections.Generic;
using System.Linq;

namespace Lawnmowers.Core.Navigators
{
    public abstract class HeadingChange : INavigator
    {
        protected const string _headings = "NESW";

        protected readonly Mower _mower;

        public HeadingChange(Mower mower)
        {
            _mower = mower;
        }

        public abstract void Navigate();

        protected static string Next(IEnumerable<char> headings, string heading)
        {
            char newHeading;

            IEnumerable<char> nextHeading = headings.SkipWhile(h => !(h == heading[0])).Skip(1);

            if (nextHeading.Any())
            {
                newHeading = nextHeading.First();
            }
            else
            {
                newHeading = headings.First();
            }

            return newHeading.ToString();
        }
    }
}