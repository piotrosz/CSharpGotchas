using FluentAssertions;
using Xunit;

namespace CSharpGothas
{
    public class GetTypeOnNullableTypeTests
    {
        [Fact]
        public void GetType_returns_int_instead_of_nullable_of_int()
        {
            int? test = 0;
            var fullName = test.GetType().FullName;
            fullName.Should().Be("System.Int32");
        }
    }
}
