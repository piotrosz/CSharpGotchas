using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas.Closures
{
    // From Jon Skeet's 'C# in Depth' book

    public class ClosuresTests
    {
        [Fact]
        public void local_variable_is_captured_just_before_invocation()
        {
            string captured = "before x is created";
            Func<string> func = () =>
            {
                var result = captured;
                captured = "changed by x";
                return result;
            };

            captured = "directly before x is invoked";
            func().Should().Be("directly before x is invoked");
            captured.Should().Be("changed by x");
            
            captured = "before second invocation";
            func().Should().Be("before second invocation");
            captured.Should().Be("changed by x");
        }

        [Fact]
        public void capturing_in_loop()
        {
            var printers = new List<Func<int>>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(() => i);
            }

            foreach (var printer in printers)
            {
                printer().Should().Be(10);
            }
        }

        [Fact]
        public void local_variable_is_captured_2()
        {
            var increment = GetFunc();
            var result1 = increment();
            result1.Should().Be(1);
            var result2 = increment();
            result2.Should().Be(2);

            GetFunc()().Should().Be(1);
            GetFunc()().Should().Be(1);
        }

        public Func<int> GetFunc()
        {
            int counter = 0;
            Func<int> innerFunc = () =>
            {
                counter++;
                return counter;
            };
            return innerFunc;
        }

        [Fact]
        public void very_confusing_code_with_variables_scope()
        {
            var delegates = new Func<Pair>[2];
            int outside = 0;

            for (int i = 0; i < delegates.Length; i++)
            {
                int inside = 0;
                delegates[i] = () =>
                {
                    var result = new Pair(inside, outside);
                    outside++;
                    inside++;
                    return result;
                };
            }

            var first = delegates[0];
            var second = delegates[1];
            
            var result1 = first();
            result1.Inside.Should().Be(0);
            result1.Outside.Should().Be(0);
            
            var result2 = first();
            result2.Inside.Should().Be(1);
            result2.Outside.Should().Be(1);

            var result3 = first();
            result3.Inside.Should().Be(2);
            result3.Outside.Should().Be(2);

            var result4 = second();
            result4.Inside.Should().Be(0);
            result4.Outside.Should().Be(3);

            var result5 = second();
            result5.Inside.Should().Be(1);
            result5.Outside.Should().Be(4);
        }
    }
}
