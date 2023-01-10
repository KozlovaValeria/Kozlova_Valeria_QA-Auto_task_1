namespace Task_5
{
    internal abstract class UniversityEmployee
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
    }
}
