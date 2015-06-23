using FluentAssertions;
using Xunit;

namespace CSharpGotchas.NewVsOverride
{
    public class NewVsOverrideTests
    {
        [Fact]
        public void when_base_assigned_to_derived_then_virtual_is_derived_and_new_is_base()
        {
            ClassBase cBase;
            var cDerived = new ClassDerived();
            cBase = cDerived;

            cBase.VirtualMethod().Should().Be("ClassDerived.VirtualMethod()");
            cBase.Foo().Should().Be("ClassBase.Foo()");
        }
    }
}
