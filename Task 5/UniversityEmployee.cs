namespace Task_5
{
    public abstract class UniversityEmployee : IComparable<UniversityEmployee>
    {
        private int _taxId;
        private Person _person;
        public Person Person
        {
            get
            {
                return _person;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Person can't be NULL");
                }
                _person = value;
            }
        }

        public int TaxId
        {
            get
            {
                return _taxId;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("TaxId can't be negative");
                }
                _taxId = value;
            }
        }

        public UniversityEmployee(Person person,int taxId)
        {
            Person = person;
            TaxId = taxId;       
        }

        public UniversityEmployee() { }

        public abstract string GetOfficialDuties();

        public override bool Equals(object? obj)
        {
            return obj is UniversityEmployee universityEmployee
                && universityEmployee.Person.Equals(Person)
                && universityEmployee.TaxId == TaxId;
        }

        public override int GetHashCode()
        {
            return Person.GetHashCode() + TaxId.GetHashCode();
        }

        public int CompareTo(UniversityEmployee? employee)
        {
            if (employee == null) return -1;
            return employee.Person.FullNameLength().CompareTo(Person.FullNameLength());
        }
    }
}
