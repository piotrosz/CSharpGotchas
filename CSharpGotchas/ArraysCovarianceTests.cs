using System;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas
{
    public class ArraysCovarianceTests
    {
        [Fact]
        public void when_objects_array_is_assigned_to_string_array_then_only_strings_can_be_assigned()
        {
            var names = new string[5];
            object[] objectNames = names;

            Action assign1 = () => objectNames[0] = "hello";
            assign1.ShouldNotThrow();

            Action assign2 = () => objectNames[1] = new object();
            assign2.ShouldThrow<ArrayTypeMismatchException>();

            Action assign3 = () => objectNames[1] = 1;
            assign3.ShouldThrow<ArrayTypeMismatchException>();
        }
    }
}
