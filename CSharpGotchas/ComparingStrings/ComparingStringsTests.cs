using System;
using FluentAssertions;
using Xunit;

namespace CSharpGotchas.ComparingStrings
{
    public class ComparingStringsTests
    {
        [Fact]
        public void compare_strings()
        {
            const string literal1 = "ß";
            const string literal2 = "ss";

            string.Equals(literal1, literal2).Should().BeFalse();
            string.Equals(literal1, literal2, StringComparison.CurrentCulture).Should().BeTrue();
            string.Equals(literal1, literal2, StringComparison.OrdinalIgnoreCase).Should().BeFalse();
        }
    }
}

// Microsoft guidelines:
//* Use overloads that explicitly specify the string comparison rules for string operations. 
//  Typically, this involves calling a method overload that has a parameter of type StringComparison.
//* Use StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase for comparisons as your safe default 
//  for culture-agnostic string matching.
//* Use comparisons with StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase for better performance.
//* Use string operations that are based on StringComparison.CurrentCulture when you display output to the user.
//* Use the non-linguistic StringComparison.Ordinal or StringComparison.OrdinalIgnoreCase values instead of 
//  string operations based on CultureInfo.InvariantCulture when the comparison is linguistically irrelevant 
//  (symbolic, for example).
//* Use the String.ToUpperInvariant method instead of the String.ToLowerInvariant method when you normalize 
//  strings for comparison.
//* Use an overload of the String.Equals method to test whether two strings are equal.
//* Use the String.Compare and String.CompareTo methods to sort strings, not to check for equality.
//* Use culture-sensitive formatting to display non-string data, such as numbers and dates, in a user interface. 
//  Use formatting with the invariant culture to persist non-string data in string form.
