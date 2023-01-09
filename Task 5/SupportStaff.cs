namespace Task_5
{
    internal class SupportStaff : UniversityEmployee
    {
        public string Position { get; set; }
        public SupportStaff(Person person, int taxID, string position) : base(person, taxID)
        {
            Position = position;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, {Position}";
        }
    }
 }
