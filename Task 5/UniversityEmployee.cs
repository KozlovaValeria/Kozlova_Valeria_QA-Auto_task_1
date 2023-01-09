using System.Runtime.ExceptionServices;

namespace Task_5
{
    internal abstract class UniversityEmployee
    {
        private int _taxID;
        public Person Person { get; set; }
        public int TaxID
        {
            get
            {
                return _taxID;
            }
            set
            {
                if (value > 0)
                {
                    _taxID = value;
                }
            }
        }
        public UniversityEmployee(Person person,int taxID)
        {
            Person = person;
            _taxID = taxID;
        }
        public abstract string GetOfficialDuties();
        
    }
}
