using System.Runtime.ExceptionServices;

namespace Task_5
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(Course course, Person person, int taxID): base(person, taxID)
        {
            Course = course;
         }

        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName}{Person.LastName}, course is {Course.NameCourse}";
        }
    }
}
