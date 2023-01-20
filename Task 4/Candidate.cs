namespace Task_4
{
    internal class Candidate
    {
        public Person Person { get; set; }
        public List<SubjectScore> SubjectScores { get; set; }
        
        public Candidate(Person person, List<SubjectScore> subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }
    }
}
