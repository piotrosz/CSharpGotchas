namespace CSharpGotchas.RethrowingException
{
    class MyClass
    {
        public void ThrowException()
        {
            int zero = 0;
            var result = 1 / zero;
        }
    }
}
