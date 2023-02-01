using Task_5;
using Task_6;

namespace UniversityUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        public static Adress defAdress = new (78, 121, "Minskaya", "Minsk");
        public static Person Valeria = new("Valeria", "Kozlova", defAdress);
        public static Course defCourse = new Course("Math", "Math");

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckPersonNullNegative()
        {
            SupportStaff per2 = new SupportStaff(Valeria, 66, "jj");
            per2.Person = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckTaxIdNegative()
        {
            Teacher teac2 = new Teacher(defCourse, Valeria, -654);
        }

        [TestMethod]
        public void CheckUniversityEmployeeEqualsNegative()
        {
            UniversityEmployee per3 = new Teacher(new Course("Ma", "M"), Valeria, 66);
            UniversityEmployee per4 = new Teacher(defCourse, new Person("Val", "Kozl", new Adress(78, 1, "Minsya", "Minsk")), 55);

            Assert.IsFalse(per3.Equals(per4));
        }

        [TestMethod]
        public void CheckUniversityEmployeeEqualsPositive()
        {
            UniversityEmployee per3 = new Teacher(defCourse, Valeria, 66);
            UniversityEmployee per4 = new Teacher(defCourse, Valeria, 66);

            Assert.IsTrue(per3.Equals(per4));
            Assert.AreEqual(per3.GetHashCode(), per4.GetHashCode());
        }

        [TestMethod]
        public void CheckCompareToUniversityEmployee()
        {
            Teacher t1 = new Teacher(defCourse, new Person("Anna", "Kozlova", defAdress), 32);
            Teacher t2 = new Teacher(defCourse, new Person("Anna", "Kozl", defAdress), 32);

            int result = t1.CompareTo(t2);
            Assert.IsTrue(result < 0);

            result = t2.CompareTo(t1);
            Assert.IsTrue(result > 0);

            t1.Person.LastName = "Kozl";
            result = t2.CompareTo(t1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckAddEmployeePositive()
        {
            University BGGGU = new University();
            BGGGU.Employees = new List<UniversityEmployee>();
            Teacher employee = new Teacher();
           
            Assert.IsTrue(BGGGU.AddEmployee(employee));
            Assert.AreEqual(1, BGGGU.Employees.Count);
        }

        [TestMethod]
        public void CheckAddEmployeeNegative()
        {
            University BGGGU = new University();
            Teacher emp = new Teacher(defCourse, Valeria, 33);
            Teacher emp2 = new Teacher(new Course("Ma", "Math"), Valeria, 54);
            BGGGU.Employees = new List<UniversityEmployee> {emp,emp2};

            Assert.IsFalse(BGGGU.AddEmployee(emp2));
            Assert.AreEqual(2, BGGGU.Employees.Count);
        }

        [TestMethod]
        public void CheckAddUniversityEmployeePositive()
        {
            University BGGGU = new University();
            BGGGU.Employees = new List<UniversityEmployee>();
            Teacher employee = new Teacher();
            employee.TaxId = 666666;

            Assert.IsTrue(BGGGU.AddUniversityEmployee(employee));
            Assert.AreEqual(1,BGGGU.Employees.Count);
        }
    }
}