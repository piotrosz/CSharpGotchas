namespace CSharpGotchas.StaticReadonly
{
    class ScoreInfoWrapperStaticConstructor
    {
        private static readonly Score score = new Score();

        static ScoreInfoWrapperStaticConstructor()
        {
            score.Increment();
            score.Increment();
            score.Increment();
        }

        public int Score { get { return score.Value; } }
    }
}