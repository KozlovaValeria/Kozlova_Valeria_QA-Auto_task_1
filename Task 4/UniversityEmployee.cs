using System.Runtime.ExceptionServices;

namespace Task_4
{
    internal class UniversityEmployee
    {
        private Person _person;
        private int _taxID;
        public Person Person { get { return _person; } }
        public int TaxID { get { return _taxID; } }

        public UniversityEmployee(Person person,int taxID)
        {
            _person = person;
            _taxID = taxID;
        }

        public virtual string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName} is an university employee";
        }
    }
}
