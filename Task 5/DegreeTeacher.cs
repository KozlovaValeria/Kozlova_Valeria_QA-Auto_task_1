namespace Task_5
{
   public class DegreeTeacher : Teacher
    {
        public string ScientificTitle { get; set; }
        public string TeacherTitle { get; set; }

        public DegreeTeacher(
            string scientificTitle,
            string teacherTitle,
            Course course,
            Person person,
            int taxId) : base(course, person, taxId)
        {
            ScientificTitle = scientificTitle;
            TeacherTitle = teacherTitle;
        }

        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, " +
                   $"scientific title: {ScientificTitle}," +
                   $" teacher title is {TeacherTitle}, course: {Course.NameCourse}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is DegreeTeacher degreeTeacher)
            {
                return degreeTeacher.ScientificTitle == ScientificTitle &&
                       degreeTeacher.TeacherTitle == TeacherTitle &&
                       degreeTeacher.TaxId == TaxId;            
            }
            return false;
        }
    }
}
