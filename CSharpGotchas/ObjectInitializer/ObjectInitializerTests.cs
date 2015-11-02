using System;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas.ObjectInitializer
{
    public class ObjectInitializerTests
    {
        [Fact]
        public void when_exception_is_thrown_while_using_object_initializer_then_object_is_null()
        {
            SampleClass target = null;

            try
            {
                // Y = 2 will throw exception
                target = new SampleClass { X = 1, Y = 2 };
            }
            catch
            {
            }

            target.Should().BeNull();
        }

        [Fact]
        public void when_exception_is_thrown_while_using_regular_constructor_then_object_is_not_null()
        {
            SampleClass target = null;

            try
            {
                target = new SampleClass();
                target.X = 1;
                target.Y = 2; // This throws exception
            }
            catch
            {
            }

            target.Should().NotBeNull();
        }
    }
}
