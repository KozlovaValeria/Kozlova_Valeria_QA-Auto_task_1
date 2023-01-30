namespace Task_5
{
    public class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(Course course, Person person, int taxId): base(person, taxId)
        {
            Course = course;
        }
        public Teacher()
        {

        }
        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName}{Person.LastName}, course is {Course.NameCourse}";
        }
    }
}
