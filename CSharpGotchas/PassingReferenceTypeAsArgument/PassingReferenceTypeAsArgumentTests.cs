using FluentAssertions;
using Xunit;

namespace CSharpGotchas.PassingReferenceTypeAsArgument
{
    public class PassingReferenceTypeAsArgumentTests
    {
        [Fact]
        public void when_reference_type_passed_as_argument_then_reference_value_passed()
        {
            var argumentsTester = new ArgumentsTester();

            var sample1 = new SampleReferenceType();
            argumentsTester.AssignNull(sample1);

            sample1.Should().NotBeNull("Value reference passed not reference!");
 
            var sample2 = new SampleReferenceType();
            argumentsTester.ChangeProperty(sample2);
            
            sample2.Greeting.Should().Be("Changed");
        }

        [Fact]
        public void when_reference_type_passed_as_argument_and_ref_keyword_used_then_reference_passed()
        {
            var argumentsTester = new ArgumentsTester();

            var sample1 = new SampleReferenceType();
            argumentsTester.AssignNullRef(ref sample1);

            sample1.Should().BeNull("Reference passed with ref keyword");

            var sample2 = new SampleReferenceType();
            argumentsTester.ChangePropertyRef(ref sample2);

            sample2.Greeting.Should().Be("Changed");
        }
    }
}
