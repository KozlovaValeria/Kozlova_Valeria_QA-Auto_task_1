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
        public override bool Equals(object? obj)
        {
            if (obj is SupportStaff supportStaff)
            {
                return supportStaff.Position == Position &&
                       supportStaff.TaxId == TaxId;
            }
            return this == obj;
        }
    }
 }
