using System;
using FluentAssertions;
using Xunit;

namespace CSharpGothas.RethrowingException
{
    public class RethrowingExceptionTests
    {
        class MyClass
        {
            public void ThrowException()
            {
                int zero = 0;
                var result = 1 / zero;
            }
        }

        [Fact]
        public void exception_thrown_with_full_stack_trace()
        {
            Action throwingException = () =>
            {
                try
                {
                    var c = new MyClass();
                    c.ThrowException();
                }
                catch (Exception exception)
                {
                    throw;
                }
            };

            throwingException
                .ShouldThrow<DivideByZeroException>()
                .And.StackTrace.Should().Contain(".MyClass.ThrowException()");
        }

        [Fact]
        public void exception_thrown_with_no_full_stack_trace()
        {
            Action throwingException = () =>
            {
                try
                {
                    var c = new MyClass();
                    c.ThrowException();
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            };

            throwingException
                .ShouldThrow<DivideByZeroException>()
                .And.StackTrace.Should().NotContain(".MyClass.ThrowException()");
        }
    }
}
