namespace Task_5
{
    internal class SupportStaff : UniversityEmployee
    {
        private string _position;
        public string Position { get { return _position; } }
        public SupportStaff(Person person, int taxID, string position) : base(person, taxID)
        {
            _position = position;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, {Position}";
        }
    }
 }
