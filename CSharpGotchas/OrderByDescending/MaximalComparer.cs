using System.Collections.Generic;

namespace CSharpGotchas.OrderByDescending
{
    // http://codeblog.jonskeet.uk/2015/03/02/backward-compatibility-pain/
    class MaximalComparer<T> : IComparer<T>
    {
        private readonly IComparer<T> original;

        public MaximalComparer(IComparer<T> original)
        {
            this.original = original;
        }

        public int Compare(T first, T second)
        {
            int originalResult = original.Compare(first, second);
            return originalResult == 0 ? 0
                : originalResult < 0 ? int.MinValue
                : int.MaxValue;
        }
    }
}
