using Task_5;

namespace Task_6
{
    public class Rector : UniversityEmployee
    {
        public Rector(Person person, int taxId) : base(person, taxId)
        {

        }
        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}";
        }
    }
}
