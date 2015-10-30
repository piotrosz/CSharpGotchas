using System;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas.Init
{
    public class InitTests
    {
        [Fact]
        public void when_exception_is_thrown_during_shorthand_init_then_object_is_null()
        {
            SampleClass target = null;

            try
            {
                target = new SampleClass { X = 1, Y = 2 };
            }
            catch
            {
            }

            target.Should().BeNull();
        }

        [Fact]
        public void when_exception_is_thrown_during_init_then_object_is_not_null()
        {
            SampleClass target = null;

            try
            {
                target = new SampleClass();
                target.X = 1;
                target.Y = 2;
            }
            catch
            {
            }

            target.Should().NotBeNull();
        }
    }
}
