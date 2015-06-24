using System;

namespace CSharpGotchas.Closures
{
    class Pair
    {
        private readonly Tuple<int, int> pair;

        public Pair(int inside, int outside)
        {
            this.pair = new Tuple<int, int>(inside, outside);
        }

        public int Inside { get { return this.pair.Item1; } }

        public int Outside { get { return this.pair.Item2; } }
    }
}
