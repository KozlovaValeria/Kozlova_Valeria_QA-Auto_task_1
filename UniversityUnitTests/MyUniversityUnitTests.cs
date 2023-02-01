
using Task_5;
using Task_6;

namespace UniversityUnitTests
{

    [TestClass]
    public class MyUniversityUnitTests
    {
        public static Adress defAdress = new(78, 121, "Minskaya", "Minsk");
        public static Rector defRector = new(new Person("Roman", " Kaktysh", defAdress), 653224);

        [TestMethod]
        public void CheckUniversityEqualsPositive()
        {
            Rector rector1 = defRector;
            Adress legalAdress = defAdress;
            Teacher emp1 = new ();
            Teacher emp2 = new ();
            List<UniversityEmployee> employees = new List<UniversityEmployee> { emp1, emp2 };
            Building bul1 = new Building();
            Building bul2 = new Building();
            List<Building> buildings = new List<Building> { bul1, bul2 };
            University BGU = new University(employees, rector1, buildings, legalAdress);

            Rector rector2 = defRector;
            Adress legalAdress2 = defAdress;
            Teacher emp3 = new ();
            Teacher emp4 = new ();
            List<UniversityEmployee> employees2 = new List<UniversityEmployee> { emp3, emp4 };
            Building bul3 = new Building();
            Building bul4 = new Building();
            List<Building> buildings2 = new List<Building> { bul3, bul4 };
            University BSUIR = new University(employees2, rector2, buildings2, legalAdress2);

            Assert.IsTrue(BGU.Equals(BSUIR));
            Assert.AreEqual(BGU.GetHashCode(), BSUIR.GetHashCode());
        }

        [TestMethod]
        public void CheckUniversityEqualsNegative()
        {
            Rector rector1 = defRector;
            Adress legalAdress = defAdress;
            Teacher emp1 = new Teacher();
            Teacher emp2 = new Teacher();
            List<UniversityEmployee> employees = new List<UniversityEmployee> { emp1, emp2 };
            Building bul1 = new Building();
            Building bul2 = new Building();
            List<Building> buildings = new List<Building> { bul1, bul2 };
            University BGU = new University(employees, rector1, buildings, legalAdress);

            Rector rector2 = new Rector(new Person("Ivan", " Ivanov", new Adress(2, 5, "Bogdan", "Brest")), 777665);
            Adress legalAdress2 = new Adress(3, 3, "Bogdanov", "Minsk");
            Teacher emp3 = new Teacher();
            Teacher emp4 = new Teacher();
            List<UniversityEmployee> employees2 = new List<UniversityEmployee> { emp3, emp4 };
            Building bul3 = new Building();
            Building bul4 = new Building();
            List<Building> buildings2 = new List<Building> { bul3, bul4 };
            University BSUIR = new University(employees2, rector2, buildings2, legalAdress2);

            Assert.IsFalse(BGU.Equals(BSUIR));
        }

    }
}
