namespace CSharpGotchas.StaticReadonly
{
    class ScoreInfoWrapperStatic
    {
        private static Score score = new Score();

        public void CalculateScore()
        {
            score.Increment();
        }

        public int Score { get { return score.Value; } }
    }
}