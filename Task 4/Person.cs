namespace Task_4
{
    internal class Person
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
    }
}
