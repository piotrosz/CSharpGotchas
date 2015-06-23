namespace CSharpGotchas.PassingReferenceTypeAsArgument
{
    class ArgumentsTester
    {
        public void AssignNull(SampleReferenceType argument)
        {
            argument = null;
        }

        public void ChangeProperty(SampleReferenceType argument)
        {
            argument.Greeting = "Changed";
        }

        public void AssignNullRef(ref SampleReferenceType argumentRef)
        {
            argumentRef = null;
        }

        public void ChangePropertyRef(ref SampleReferenceType argumentRef)
        {
            argumentRef.Greeting = "Changed";
        }
    }
}
