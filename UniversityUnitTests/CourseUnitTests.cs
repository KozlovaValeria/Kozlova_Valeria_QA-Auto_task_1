
using Task_5;

namespace UniversityUnitTests
{
    [TestClass]
    public class CourseUnitTests
    {
        [TestMethod]
        public void CheckCourseEqualsPositive()
        {
            Course c1 = new Course("Math", "Math for children");
            Course c2 = new Course("Math", "Math for children");

            Assert.IsTrue(c1.Equals(c2));
            Assert.AreEqual(c1.GetHashCode(), c2.GetHashCode());
        }
        [TestMethod]
        public void CheckCourseEqualsNegative()
        {
            Course c1 = new Course("Math", "Math for children");
            Course c2 = new Course("English", "English for everyone");

            Assert.IsFalse(c1.Equals(c2));
        }
    }
}
