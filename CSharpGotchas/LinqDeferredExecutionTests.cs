using System.Linq;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas
{
    public class LinqDeferredExecutionTests
    {
        [Fact]
        public void linq_defers_execution()
        {
            var array = new[] {"a", "b", "a", "a"};

            var filteringValue = "a";
            var results1 = array.Where(x => x == filteringValue);

            filteringValue = "b";
            var results2 = array.Where(x => x == filteringValue);

            results1.Count().Should().Be(1);
            results2.Count().Should().Be(1);
        }
    }
}
