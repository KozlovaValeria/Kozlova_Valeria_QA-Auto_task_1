using Task_5;
namespace Task_6
{
    public class University
    {
        public List<UniversityEmployee> Employees { get; set; }
        public Person Rector { get; set; }
        public List<Building> Buildings {get;set;}
        public Adress LegalAdress { get; set; }
        public University(
            List<UniversityEmployee> employees, 
            Person rector, 
            List <Building> buildings, 
            Adress legalAdress)
        {
            Employees = employees;
            Rector = rector;
            Buildings = buildings;
            LegalAdress = legalAdress;
        }
        public override bool Equals(object? obj)
        {
            if (obj is University university)
            {
                return university.Rector.Equals(Rector) &&
                       university.LegalAdress.Equals(LegalAdress);
            }
            return false;
        }
        public bool AddEmployee(UniversityEmployee employee)
        {
            foreach(UniversityEmployee existingEmployee in Employees)
            {
                if (existingEmployee.Equals(employee)) 
                {
                    return false;
                }
            }
            Employees.Add(employee);
            return true;
        } 
        
     
    }
}
