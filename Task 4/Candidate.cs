namespace Task_4
{
    internal class Candidate
    {
        public Person Person;
        public SubjectScore[] SubjectScores;
        
        public Candidate(Person person, SubjectScore[] subjectScores)
        {
            Person = person;
            SubjectScores = subjectScores;
        }
    }
}
