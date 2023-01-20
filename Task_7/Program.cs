using Task_5;
using Task_6;

Teacher teacher1 = new Teacher(
    new Course("Math", "Math for everyone"),
    new Person(
        "Valeria",
        " Romanovskaya",
        new Adress(78, 121, "Minskaya", "Minsk")),
    324521);

Teacher teacher2 = new Teacher(
    new Course("Language", "English"),
    new Person(
        "Anna",
        " Petrova",
        new Adress(21, 45, "Shustovskaya", "Minsk")),
    987897);

SupportStaff supportstaff1 = new SupportStaff(
    new Person(
        "Anastasia",
        " Skubo",
        new Adress(11, 4, "Bogdanovicha", "Vitebsk")),
    765432,
    "Cleaner");

SupportStaff supportstaff2 = new SupportStaff(
    new Person(
        "Alexander",
        " Petrov",
        new Adress(190, 22, "Kupala", "Mogilev")),
    112454,
    "Security");

DegreeTeacher degreeteacher1 = new DegreeTeacher(
    "Doctor of science",
    "Professor",
    new Course("Chemistry", "Chemistry in our life"),
    new Person(
        "Lev",
        " Uspenski",
        new Adress(9, 21, "Moskovskaya", "Vitebsk")),
    876543);

DegreeTeacher degreeteacher2 = new DegreeTeacher(
    "Candidate of science",
    "Assistant",
    new Course("Biology", "How biology affects our life"),
    new Person(
        "Irina",
        "  Podolskaya",
        new Adress(77, 341, "Repina", "Gomel")),
    121189);

List<UniversityEmployee> employees = new List<UniversityEmployee>
{
    teacher1,
    teacher2,
    supportstaff1,
    supportstaff2,
    degreeteacher1,
    degreeteacher2
};

List<Building> buildings = new List<Building>
{
    new Building(
        32,
        "Department of Math",
        new List<Room>
        {
            new Room(101, "Lecture"),
            new Room(102, "Laboratory"),
            new Room(103, "Seminary"),
            new Room(104, "Common")
        }),

     new Building(
         42,
         "Department of Biology",
         new List <Room>
         {
             new Room(205, "Lecture"),
             new Room(206, "Laboratory"),
             new Room(207, "Seminary"),
             new Room(208, "Common")
         }),

     new Building(
         67,
         "Department of Informatics",
         new List <Room>
         {
             new Room(309, "Lecture"),
             new Room(310, "Laboratory"),
             new Room(311, "Seminary"),
             new Room(312, "Common")
         })
};

Rector rector1 = new Rector(
    new Person(
        "Roman",
        " Kaktysh",
        new Adress(87, 9, "Bogdanovicha", "Minsk")),
    653224);

Adress legalAdress = new Adress(103, 35, "Bogdanovicha", "Minsk");
University BSUIR = new University(employees, rector1, buildings, legalAdress);

DegreeTeacher newTeacher = new DegreeTeacher(
    "Candidate of science",
    "Assistant",
    new Course("German language", "How biology affects our life"),
    new Person(
        "Ivan",
        "  Popov",
        new Adress(99, 5, "Repina", "Minsk")),
    222222);

Console.WriteLine(BSUIR.AddEmployee(newTeacher));