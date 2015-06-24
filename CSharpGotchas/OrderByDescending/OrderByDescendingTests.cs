using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas.OrderByDescending
{
    // http://codeblog.jonskeet.uk/2015/03/02/backward-compatibility-pain/
    public class OrderByDescendingTests
    {
        [Fact]
        public void order_by_descending_does_not_work()
        {
            var comparer = new MaximalComparer<string>(Comparer<string>.Default);
            string[] input = { "apples", "carrots", "dougnuts", "bananas" };

            var sorted = input.OrderByDescending(x => x, comparer);

            sorted.Should().ContainInOrder("carrots", "dougnuts", "apples", "bananas");
        }
    }
}
