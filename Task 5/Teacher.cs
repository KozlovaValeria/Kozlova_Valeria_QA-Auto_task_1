namespace Task_5
{
    public class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(Course course, Person person, int taxId): base(person, taxId)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName}{Person.LastName}, course is {Course.NameCourse}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Teacher teacher)
            {
                return teacher.Course.Equals(Course) &&
                    teacher.Person.Equals(Person) &&
                    teacher.TaxId == TaxId;
            }
            return false;
        }
    }
}
