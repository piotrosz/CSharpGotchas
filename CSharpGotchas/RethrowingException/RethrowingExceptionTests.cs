using System;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas.RethrowingException
{
    public class RethrowingExceptionTests
    {
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
