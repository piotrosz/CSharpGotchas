using System;

namespace CSharpGotchas.ObjectInitializer
{
    public class SampleClass
    {
        public int X { get; set; }

        public int Y
        {
            get => -1;
            set => throw new NotImplementedException();
        }
    }
}
