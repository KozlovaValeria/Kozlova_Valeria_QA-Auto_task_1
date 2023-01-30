using Task_5;
namespace Task_6
{
    public class University
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

        public University()
        {

        }
        public override bool Equals(object? obj)
        {
            return obj is University university
                && university.Rector.Equals(Rector)
                && university.LegalAdress.Equals(LegalAdress);
        }

        public override int GetHashCode()
        {
            return Rector.GetHashCode() + LegalAdress.GetHashCode();
        }

        public bool AddEmployee(UniversityEmployee employee)
        {
            if (Employees.Contains(employee))
            {
                return false;
            }
            Employees.Add(employee);
            return true;
        }

        public bool AddUniversityEmployee(UniversityEmployee employee)
        {
            if (CheckTaxId(employee.TaxId))
            {
                Employees.Add(employee);
                return true;
            }
            else
            {
                return false;
            }    
        }

        private bool CheckTaxId(int taxId)
        {
            return taxId > 0;
        }
    }
}
