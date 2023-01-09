using System.Runtime.ExceptionServices;

namespace Task_5
{
    internal class UniversityEmployee
    {
    
        public Person Person { get; set; }
        public int TaxID { get; set; }

        public UniversityEmployee(Person person,int taxID)
        {
            Person = person;
            TaxID = taxID;
        }

        public virtual string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName} is an university employee";
        }
    }
}
