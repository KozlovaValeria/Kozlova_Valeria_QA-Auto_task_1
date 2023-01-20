namespace Task_5
{
    public class SupportStaff : UniversityEmployee
    {
        public string Position { get; set; }
        public SupportStaff(Person person, int taxId, string position) : base(person, taxId)
        {
            Position = position;
        }
        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, {Position}";
        }
    }
 }
