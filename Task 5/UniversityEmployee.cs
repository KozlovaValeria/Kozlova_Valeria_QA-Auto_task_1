namespace Task_5
{
    public abstract class UniversityEmployee
    {
        private int _taxId;
        public Person Person { get; set; }
        public int TaxId
        {
            get
            {
                return _taxId;
            }
            set
            {
                if (value > 0)
                {
                    _taxId = value;
                }
            }
        }
        public UniversityEmployee(Person person,int taxId)
        {
            Person = person;
            _taxId = taxId;
        }
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
    }
}
