using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace CSharpGothas
{
    public class LinqCastVsOfTypeTests
    {
        [Fact]
        public void Test()
        {
            object[] array = {new object(), "abc", 1};

            var result = array.OfType<string>().ToList();
            result.Should().Contain("abc").And.HaveCount(1);

            Action action = () => array.Cast<string>().ToList();

            action.ShouldThrow<InvalidCastException>();
        }
    }
}
