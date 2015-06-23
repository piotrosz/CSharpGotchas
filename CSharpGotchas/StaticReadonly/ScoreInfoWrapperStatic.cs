namespace CSharpGotchas.StaticReadonly
{
    class ScoreInfoWrapperStatic
    {
        private static Score score = new Score();

        public void Increment()
        {
            score.Increment();
        }

        public int Score { get { return score.Value; } }
    }
}