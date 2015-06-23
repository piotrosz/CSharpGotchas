using System.Diagnostics;

namespace CSharpGotchas.StaticReadonly
{
    [DebuggerDisplay("Score = {value}")]
    struct Score
    {
        public int Value { get; private set; }

        public void Increment()
        {
            this.Value++;
        }
    }
}