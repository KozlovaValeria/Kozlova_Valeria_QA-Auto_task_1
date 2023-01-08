
namespace Task_4
{
    internal class DegreeTeacher : Teacher
    {
        private string _scientificTitle;
        private string _teacherTitle;
        public string ScientificTitle { get { return _scientificTitle; } }
        public string TeacherTitle { get { return _teacherTitle; } }

        public DegreeTeacher(
            string scientificTitle,
            string teacherTitle,
            Course course,
            Person person,
            int taxID) : base(course, person, taxID)
        {
            _scientificTitle = scientificTitle;
            _teacherTitle = teacherTitle;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, " +
                   $"scientific title: {ScientificTitle}," +
                   $" teacher title is {TeacherTitle}, course: {Course.NameCourse}";
        }
    }
}
