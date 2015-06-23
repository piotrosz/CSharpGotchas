namespace CSharpGotchas.StaticReadonly
{
    class ScoreInfoWrapperStaticReadOnly
    {
        private static readonly Score score = new Score();

        public void CalculateScore()
        {
            score.Increment();
        }

        public int Score { get { return score.Value; } }
    }
}
