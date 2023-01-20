using Task_5;
namespace Task_6
{
    internal class University
    {
        public List<UniversityEmployee> Employees { get; set; }
        public Rector Rector { get; set; }
        public List<Building> Buildings {get;set;}
        public Adress LegalAdress { get; set; }
        public University(
            List<UniversityEmployee> employees, 
            Rector rector, 
            List <Building> buildings, 
            Adress legalAdress)
        {
            Employees = employees;
            Rector = rector;
            Buildings = buildings;
            LegalAdress = legalAdress;
        }
    }
}
