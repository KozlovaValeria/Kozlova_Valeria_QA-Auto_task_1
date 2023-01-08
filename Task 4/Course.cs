namespace Task_4
{
    internal class Course
    {
        private string _nameCourse;
        private string _descriptionCourse;
        public string NameCourse { get { return _nameCourse; } }
        public string DescriptionCourse { get { return _descriptionCourse; } }

        public Course(string nameCourse, string descriptionCourse)
        {
            _nameCourse = nameCourse;
            _descriptionCourse = descriptionCourse;

        }
    }
}
