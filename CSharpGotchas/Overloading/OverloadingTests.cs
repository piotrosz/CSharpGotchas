using FluentAssertions;
using Xunit;

namespace CSharpGothas.Overloading
{
    // from Jon Skeet

    public class OverloadingTests
    {
        class Base
        {
            public virtual string Foo(int x)
            {
                return "Base.Foo(int)";
            }
        }

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

        [Fact]
        public void when_int_passed_to_foo_in_derived_then_overload_with_object_argument_is_chosen()
        {
            var derived = new Derived();
            derived.Foo(10).Should().Be("Derived.Foo(object)");
        }
    }
}
