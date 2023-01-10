namespace Task_5
{
    internal class Course
    { 
        public string NameCourse { get; set; }
        public string DescriptionCourse { get; set; }

        public Course(string nameCourse, string descriptionCourse)
        {
            NameCourse = nameCourse;
            DescriptionCourse = descriptionCourse;
        }
    }
}
