namespace Task_5
{
    public class Person
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Adress Adress { get; set; }

        public Person(string firstName, string lastName, Adress adress) 
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Person person)
            {
                return person.FirstName == FirstName &&
                       person.LastName == LastName &&
                       person.Adress.Equals(Adress);
            }
            return false;
        }
    }
}
