using FluentAssertions;
using Xunit;

namespace CSharpGotchas.StaticReadonly
{
    public class StaticReadonlyTests
    {
        [Fact]
        public void when_static_readonly_then_score_is_always_0()
        {
            var wrapper = new ScoreInfoWrapperStaticReadOnly();

            wrapper.Increment();
            wrapper.Score.Should().Be(0);
            wrapper.Increment();
            wrapper.Score.Should().Be(0);
            wrapper.Increment();
            wrapper.Score.Should().Be(0);
        }

        [Fact]
        public void when_static_only_then_score_is_incremented()
        {
            var wrapper = new ScoreInfoWrapperStatic();

            wrapper.Increment();
            wrapper.Score.Should().Be(1);
            wrapper.Increment();
            wrapper.Score.Should().Be(2);
            wrapper.Increment();
            wrapper.Score.Should().Be(3);
        }

        [Fact]
        public void when_called_in_static_constructor_then_score_is_incremented()
        {
            var wrapper = new ScoreInfoWrapperStaticConstructor();

            wrapper.Score.Should().Be(3);
        }
    }
}
