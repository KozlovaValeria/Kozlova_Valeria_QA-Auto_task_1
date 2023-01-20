namespace Task_5
{
    public class Course
    { 
        public string NameCourse { get; set; }
        public string DescriptionCourse { get; set; }

        public Course(string nameCourse, string descriptionCourse)
        {
            NameCourse = nameCourse;
            DescriptionCourse = descriptionCourse;
        }
        public override bool Equals(object? obj)
        {
            return obj is Course course
                && course.NameCourse == NameCourse
                && course.DescriptionCourse == DescriptionCourse;
        }
        public override int GetHashCode()
        {
            return NameCourse.GetHashCode() + DescriptionCourse.GetHashCode();
        }
    }
}
