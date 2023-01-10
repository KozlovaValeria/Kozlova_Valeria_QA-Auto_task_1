using Task_5;

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

UniversityEmployee[] employees = new UniversityEmployee[]
{
    teacher1,
    teacher2,
    supportstaff1,
    supportstaff2,
    degreeteacher1,
    degreeteacher2
};

foreach (UniversityEmployee employee in employees)
{
    Console.WriteLine(employee.GetOfficialDuties());
}
Console.WriteLine("Teachers: ");

foreach (UniversityEmployee employee in employees)
{
    if (employee is Teacher)
    {
        Console.WriteLine($"{employee.Person.FirstName}{employee.Person.LastName}");
    }
}

