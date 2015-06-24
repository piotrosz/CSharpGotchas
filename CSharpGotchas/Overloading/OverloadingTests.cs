using FluentAssertions;
using Xunit;

namespace CSharpGotchas.Overloading
{
    // from Jon Skeet

    public class OverloadingTests
    {
        [Fact]
        public void when_int_passed_to_foo_in_derived_then_overload_with_object_argument_is_chosen()
        {
            var derived = new Derived();
            derived.Foo(10).Should().Be("Derived.Foo(object)");
        }
    }
}
