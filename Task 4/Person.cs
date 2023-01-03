namespace Task_4
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public Adress Adress;

        public Person(string firstName, string lastName, Adress adress) 
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
        }
    }
}
