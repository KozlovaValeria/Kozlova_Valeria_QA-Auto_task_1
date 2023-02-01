
using Task_5;

namespace UniversityUnitTests
{
    [TestClass]
    public class PersonUnitTests
    {
        public static Adress defAdress = new(78, 121, "Minskaya", "Minsk");
        public static Person Valeria = new("Valeria", "Kozlova", defAdress);

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckFirstNameNullNegative()
        {
            Person per2 = Valeria;
            per2.FirstName = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckLastNameNullNegative()
        {
            Person per2 = Valeria;
            per2.LastName = null;
        }
        [TestMethod]
        public void CheckPersonEqualsPositive()
        {
            Person per3 = Valeria;
            Person per4 = Valeria;

            Assert.IsTrue(per3.Equals(per4));
            Assert.AreEqual(per3.GetHashCode(), per4.GetHashCode());
        }

        [TestMethod]
        public void CheckPersonEqualsNegative()
        {
            Person per3 = Valeria;
            Person per4 = new Person("Ivan", "Pirozkov", new Adress(11, 23, "Linkova", "Vitebsk"));

            Assert.IsFalse(per3.Equals(per4));
        }

        [TestMethod]
        public void CheckFullNameLengthPositive()
        {
            Person per1 = new Person("Valeria", "Kozlova", defAdress);

            Assert.AreEqual(14, per1.FullNameLength());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckFullNameLengthNegative()
        {
            Person per2 = new Person("Valeriaaa", "Kozlvaaa", defAdress);
        }
    }
}
