using Task_5;
using Task_6;

Teacher teacher1 = new Teacher(
    new Course("Math", "Math for everyone"),
    new Person(
        "Valeria",
        "Romanovskaya",
        new Adress(78, 121, "Minskaya", "Minsk")),
    324521);

Teacher teacher2 = new Teacher(
    new Course("Language", "English"),
    new Person(
        "Anna",
        "Ivanova",
        new Adress(21, 45, "Shustovskaya", "Minsk")),
    987897);

SupportStaff supportstaff1 = new SupportStaff(
    new Person(
        "Anastasia",
        "Skubo",
        new Adress(11, 4, "Bogdanovicha", "Vitebsk")),
    765432,
    "Cleaner");

SupportStaff supportstaff2 = new SupportStaff(
    new Person(
        "Alexander",
        "Petrov",
        new Adress(190, 22, "Kupala", "Mogilev")),
    112454,
    "Security");

DegreeTeacher degreeteacher1 = new DegreeTeacher(
    "Doctor of science",
    "Professor",
    new Course("Math", "Math for everyone"),
    new Person(
        "Lev",
        "Uspenski",
        new Adress(9, 21, "Moskovskaya", "Vitebsk")),
    876543);

DegreeTeacher degreeteacher2 = new DegreeTeacher(
    "Candidate of science",
    "Assistant",
    new Course("Biology", "How biology affects our life"),
    new Person(
        "Irina",
        "Ivanova",
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
    new Building(32,"Department of Math",
                    new List<Room>
                    {
                        new Room(101, "Lecture"),
                        new Room(102, "Laboratory"),
                        new Room(103, "Seminary"),
                        new Room(104, "Common"),
                        new Room(110, "Lecture 2"),
                        new Room(112, "Laboratory 2")
                      
                    }),

     new Building(42,"Department of Biology",
                    new List <Room>
                    {
                        new Room(105, "Lecture"),
                        new Room(206, "Laboratory"),
                        new Room(207, "Seminary"),
                        new Room(101, "Common")
                    }),

     new Building(67, "Department of Informatics",
                    new List <Room>
                    {
                        new Room(101, "Lecture"),
                        new Room(310, "Laboratory"),
                        new Room(311, "Seminary"),
                        new Room(312, "Common")
                    })
};

Person rector = new Person("Roman", "Kaktysh", new Adress(67, 105, "Shishkova", "Minsk"));

Adress legalAdress = new Adress(103, 35, "Bogdanovicha", "Minsk");
University BGUIR = new University(employees, rector, buildings, legalAdress);

DegreeTeacher newTeacher = new DegreeTeacher(
    "Candidate of science",
    "Assistant",
    new Course("German language", "How biology affects our life"),
    new Person(
        "Ivan",
        "  Popov",
        new Adress(99, 5, "Repina", "Minsk")),
    222222);


Console.WriteLine(BGUIR.AddEmployee(newTeacher));

//task 5.1

Console.WriteLine("Lastname start with I:");

var letterEmployees = new List<UniversityEmployee>();

letterEmployees = employees.Where(x => x.Person.LastName.StartsWith("I")).OrderBy(x => x.TaxId).ToList();
foreach (UniversityEmployee employee in letterEmployees)
{
    Console.WriteLine($"{employee.Person.LastName + " " + employee.TaxId}");
}

//task 5.2
Console.WriteLine("Teachers read course Math:");

var courseEmployees = new List<UniversityEmployee>();

courseEmployees = employees.Where(x => x is Teacher teacher && teacher.Course.NameCourse == "Math").ToList();
foreach(UniversityEmployee employee in courseEmployees)
{
   Console.WriteLine($"{employee.Person.FirstName + " " + employee.Person.LastName}");
}

//task 5.3 

Console.WriteLine("TaxId and position:");

var FilteredPositionList = employees.Select(universityEmployee => universityEmployee.TaxId.ToString() + " " +
universityEmployee.GetOfficialDuties()).ToList();

foreach (var taxIdPosition in FilteredPositionList)
{
    Console.WriteLine($"{taxIdPosition}");
}

//task 5.4

Console.WriteLine("Buildings with number room 101:");

var filteredBuildings = new List<Building>();
filteredBuildings = buildings.Where(x => x.Rooms.Select(room => room.NumberRoom).ToList().Contains(101)).ToList();

foreach (Building building in filteredBuildings)
{
    Console.WriteLine(building.NameBuilding + " " + building.NumberBuilding);
}

//task 5.5

var maxCountRoom = buildings.Select(x => x.Rooms.Count).Max();
var targetBuildings = buildings.Where(x => x.Rooms.Count == maxCountRoom);

foreach (Building building in targetBuildings)
{
    Console.WriteLine("Max room's count: " + building.NameBuilding + " " + building.NumberBuilding);
}

//task 5.6

var groupedEmployees = employees.GroupBy(x => x.Person.LastName);
int lastNamesMaxCount = groupedEmployees.Select(x => x.Count()).Max();
var lastNameMaxCount = groupedEmployees.Where(x => x.Count() == lastNamesMaxCount).Select(x => x.Key).FirstOrDefault();
Console.WriteLine("LastName: " + lastNameMaxCount + " " +  "Employees: " + lastNamesMaxCount );