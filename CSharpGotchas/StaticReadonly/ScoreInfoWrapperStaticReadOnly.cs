namespace CSharpGotchas.StaticReadonly
{
    class ScoreInfoWrapperStaticReadOnly
    {
        private static readonly Score score = new Score();

        public void Increment()
        {
            score.Increment();
        }

        public int Score { get { return score.Value; } }
    }
}
