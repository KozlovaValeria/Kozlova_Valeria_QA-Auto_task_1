namespace Task_4
{
    internal class SubjectScore
    {
        private int _score;
        public string SubjectName { get; set; }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _score = value;
                }
            }
        }
        public SubjectScore(int score, string subjectName)
        {
            Score = score;
            SubjectName = subjectName;
        }
    }
}
