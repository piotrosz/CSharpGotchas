namespace CSharpGotchas.NewVsOverride
{
    class ClassDerived : ClassBase
    {
        public override string VirtualMethod()
        {
            return "ClassDerived.VirtualMethod()";
        }

        public new string Foo()
        {
            return "ClassDerived.Foo()";
        }
    }
}
