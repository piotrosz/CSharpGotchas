namespace CSharpGotchas.Overloading
{
    class Derived : Base
    {
        public override string Foo(int x)
        {
            return "Derived.Foo(int)";
        }

        public string Foo(object obj)
        {
            return "Derived.Foo(object)";
        }
    }
}
