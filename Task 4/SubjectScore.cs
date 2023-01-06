namespace Task_4
{
    internal class SubjectScore
    {
        private string _subjectName;
        private int _score;
        public int Score { get { return _score; } }
        public string SubjectName { get { return _subjectName; } }
        public SubjectScore(int score, string subjectName)
        {
            _score = score;
            _subjectName = subjectName;
        }
    }
}
