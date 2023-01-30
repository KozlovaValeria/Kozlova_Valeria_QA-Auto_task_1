using Task_5;
using Task_6;

namespace UniversityUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CheckAddEmployeePositive()
        {
            University BGGGU = new University();
            BGGGU.Employees = new List<UniversityEmployee>();
            Teacher employee = new Teacher();

            Assert.IsTrue(BGGGU.AddEmployee(employee));
        }

        [TestMethod]
        public void CheckAddEmployeeNegative()
        {
            University BGGGU = new University();
            Teacher emp = new Teacher(new Course("Math", "Math"), new Person("Ivan", "Ivanov", new Adress(3, 2, "Bobr", "Minsk")), 33);
            Teacher emp2 = new Teacher(new Course("Math", "Math"), new Person("Ivan", "Ivanov", new Adress(3, 2, "Bobr", "Minsk")), 33);
            BGGGU.Employees = new List<UniversityEmployee> { emp,emp2};

            Assert.IsFalse(BGGGU.AddEmployee(emp2));
        }

        [TestMethod]
        public void CheckAddUniversityEmployeePositive()
        {
            University BGGGU = new University();
            BGGGU.Employees = new List<UniversityEmployee>();
            Teacher employee = new Teacher();
            employee.TaxId = 666666;

            Assert.IsTrue(BGGGU.AddUniversityEmployee(employee));
        }


        [TestMethod]
        public void CheckFullNameLengthPositive()
        {
            Person per1 = new Person("Valeria", "Kozlova", new Adress(78, 121, "Minskaya", "Minsk"));
            Assert.AreEqual(14, per1.FullNameLength());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckFullNameLengthNegative()
        {
            Person per2 = new Person("Valeriaaa", "Kozlvaaa", new Adress(78, 1, "Minskaya", "Minsk"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckPersonNullNegative()
        {
            SupportStaff per2 = new SupportStaff(new Person("Valeri", "Kozlva", new Adress(78, 1, "Minskaya", "Minsk")), 665433,"jj");
            per2.Person = null;
        }

        [TestMethod]  
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckFirstNameNullNegative()
        {
            Person per2 = new Person("Valeria", "Kozlva", new Adress(78, 1, "Minskaya", "Minsk"));
            per2.FirstName = null;   
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckLastNameNullNegative()
        {
            Person per2 = new Person("Valeria", "Kozlva", new Adress(78, 1, "Minskaya", "Minsk"));
            per2.LastName = null;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckTaxIdNegative()
        {
            Teacher teac2 = new Teacher(new Course("Math", "Matttth"), new Person("Valeriaaa", "Kozlooova", new Adress(78, 121, "Minskaya", "Minsk")), -65442);
        }

        [TestMethod]
        public void CheckCompareToUniversityEmployee()
        {
            Teacher t1 = new Teacher(new Course("Math", "M"), new Person("Valeria", "Kozlova", new Adress(78, 121, "Min", "Minsk")), 32);
            Teacher t2 = new Teacher(new Course("Math", "M"), new Person("Valeria", "Kozl", new Adress(78, 121, "Min", "Minsk")), 32);

            int result = t1.CompareTo(t2);
            Assert.AreEqual(-1, result);

            result = t2.CompareTo(t1);
            Assert.AreEqual(1, result);

            t1.Person.LastName = "Kozl";
            result= t2.CompareTo(t1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CheckPersonEqualsPositive()
        {
            Person per3 = new Person("Valeria", "Kozlova", new Adress(78, 121, "Minskaya", "Minsk"));
            Person per4 = new Person("Valeria", "Kozlova", new Adress(78, 121, "Minskaya", "Minsk"));

            Assert.IsTrue(per3.Equals(per4));
            Assert.AreEqual(per3.GetHashCode(), per4.GetHashCode());
        }

        [TestMethod]
        public void CheckPersonEqualsNegative()
        {
            Person per3 = new Person("Valeria", "Kozlova", new Adress(78, 121, "Minskaya", "Minsk"));
            Person per4 = new Person("Ivan", "Pirozkov", new Adress(11, 23, "Linkova", "Vitebsk"));

            Assert.IsFalse(per3.Equals(per4));
            Assert.AreNotEqual(per3.GetHashCode() , per4.GetHashCode());
        }

        [TestMethod]
        public void CheckUniversityEmployeeEqualsNegative()
        {
            UniversityEmployee per3 = new Teacher(new Course("Ma", "Matttth"), new Person("Valeria", "Kozlva", new Adress(78, 121, "Minskaya", "Minsk")), 6666);
            UniversityEmployee per4 = new Teacher(new Course("Math", "Matth"), new Person("Val", "Kozl", new Adress(78, 1, "Minsya", "Minsk")), 55);

            Assert.IsFalse(per3.Equals(per4));
            Assert.AreNotEqual(per3.GetHashCode(), per4.GetHashCode());
        }

        [TestMethod]
        public void CheckUniversityEmployeeEqualsPositive()
        {
            UniversityEmployee per3 = new Teacher(new Course("Ma", "Matttth"), new Person("Valeria", "Kozlva", new Adress(7, 1, "Minskaya", "Minsk")), 6666);
            UniversityEmployee per4 = new Teacher(new Course("Ma", "Matttth"), new Person("Valeria", "Kozlva", new Adress(7, 1, "Minskaya", "Minsk")), 6666);

            Assert.IsTrue(per3.Equals(per4));
            Assert.AreEqual(per3.GetHashCode(), per4.GetHashCode());
        }

        //adress
        [TestMethod]
        public void CheckAdressEqualsPositive()
        {
            Adress adr1 = new Adress(78, 121, "Minskaya", "Minsk");
            Adress adr2 = new Adress(78, 121, "Minskaya", "Minsk");

            Assert.IsTrue(adr1.Equals(adr2));
            Assert.AreEqual(adr1.GetHashCode(), adr2.GetHashCode());
        }

        [TestMethod]
        public void CheckAdressEqualsNegative()
        {
            Adress adr1 = new Adress(78, 121, "Minskaya", "Minsk");
            Adress adr2 = new Adress(1, 87, "Ivanova", "Brest");

            Assert.IsFalse(adr1.Equals(adr2));
            Assert.AreNotEqual(adr1.GetHashCode(), adr2.GetHashCode());
        }

        [TestMethod]
        public void CheckAdressNumbersNegative()
        {
            Adress adr1 = new Adress(-7, 121, "Minskaya", "Minsk");
            Adress adr2 = new Adress(1, 2340, "Ivanova", "Brest");

            Assert.AreEqual(0, adr1.Home);
            Assert.AreEqual(0, adr2.Flat);
        }
        //room
        [TestMethod]
        public void CheckRoomEqualsNegative()
        {
            Room room1 = new Room(123, "Laboratory");
            Room room2 = new Room(321, "Class");

            Assert.IsFalse(room1.Equals(room2));
            Assert.AreNotEqual(room1.GetHashCode(), room2.GetHashCode());
        }

        [TestMethod]
        public void CheckRoomEqualsPositive()
        {
            Room room1 = new Room(123, "Laboratory");
            Room room2 = new Room(123, "Laboratory");

            Assert.IsTrue(room1.Equals(room2));
            Assert.AreEqual(room1.GetHashCode(), room2.GetHashCode());
        }

        [TestMethod]
        public void CheckRoomNumberNegative()
        {
            Room room1 = new Room(-333, "Laboratory");
            Room room2 = new Room(10001, "Laboratory");

            Assert.AreEqual(0,room1.NumberRoom);
            Assert.AreEqual(0,room2.NumberRoom);
        }

        //building
        [TestMethod]
        public void CheckBuildingEqualsPositive()
        {
            Building bul1 = new Building(22, "Biologi center", new List<Room> { new Room(101, "Lecture"),
                                                                                new Room(107, "Lecture 2")});
            Building bul2 = new Building(22, "Biologi center", new List<Room> { new Room(101, "Lecture"),
                                                                                new Room(107, "Lecture 2")});

            Assert.IsTrue(bul1.Equals(bul2));
            Assert.AreEqual(bul1.GetHashCode(), bul2.GetHashCode());
        }

        [TestMethod]
        public void CheckBuildingEqualsNegative()
        {
            Building bul1 = new Building(1, "Math center", new List<Room> { new Room(1, "Lecture 4"),
                                                                            new Room(2, "Lecture 8")});
            Building bul2 = new Building(22, "Biologi center", new List<Room> { new Room(101, "Lecture"),
                                                                                new Room(107, "Lecture 2")});

            Assert.IsFalse(bul1.Equals(bul2));
            Assert.AreNotEqual(bul1.GetHashCode(), bul2.GetHashCode());
        }

        [TestMethod]
        public void CheckBuildingNumberNegative()
        {
            Building bul1 = new Building(-987, "Math center", new List<Room> { new Room(1, "Lecture 4"),
                                                                            new Room(2, "Lecture 8")});
            Building bul2 = new Building(11000, "Biologi center", new List<Room> { new Room(101, "Lecture"),
                                                                                new Room(107, "Lecture 2")});

            Assert.AreEqual(0, bul1.NumberBuilding);
            Assert.AreEqual(0, bul2.NumberBuilding);
        }

        //course
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
            Assert.AreNotEqual(c1.GetHashCode(), c2.GetHashCode());
        }

        //university
        [TestMethod]
        public void CheckUniversityEqualsPositive()
        {
            Rector rector1 = new Rector(new Person("Roman", " Kaktysh", new Adress(87, 9, "Bogdanovicha", "Minsk")), 653224);
            Adress legalAdress = new Adress(103, 35, "Bogdanovicha", "Minsk");
            Teacher emp1 = new Teacher();
            Teacher emp2 = new Teacher();
            List<UniversityEmployee> employees = new List<UniversityEmployee> { emp1, emp2 };
            Building bul1 = new Building();
            Building bul2 = new Building();
            List<Building> buildings = new List<Building> { bul1, bul2 };
            University BGU = new University(employees, rector1, buildings, legalAdress);

            Rector rector2 = new Rector(new Person("Roman", " Kaktysh", new Adress(87, 9, "Bogdanovicha", "Minsk")), 653224);
            Adress legalAdress2 = new Adress(103, 35, "Bogdanovicha", "Minsk");
            Teacher emp3 = new Teacher();
            Teacher emp4 = new Teacher();
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
            Rector rector1 = new Rector(new Person("Roman", " Kaktysh", new Adress(87, 9, "Bogdanovicha", "Minsk")), 653224);
            Adress legalAdress = new Adress(103, 35, "Bogdanovicha", "Minsk");
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
            Assert.AreNotEqual(BGU.GetHashCode(), BSUIR.GetHashCode());
        }

    }
}