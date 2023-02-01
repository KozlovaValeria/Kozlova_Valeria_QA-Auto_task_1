namespace Task_5
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                CheckSumFirstLastName(value, _lastName);
                _firstName = value;      
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                CheckSumFirstLastName(value, _firstName);
                _lastName = value;
            }
        }
       
        public Adress Adress { get; set; }
        public object Value { get; }

        public Person(string firstName, string lastName, Adress adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;  
        }

        public Person()
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is Person person
                && person.FirstName == FirstName
                && person.LastName == LastName
                && person.Adress.Equals(Adress);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + LastName.GetHashCode() + Adress.GetHashCode();
        }

        public void CheckSumFirstLastName(string value, string name)
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));
            if (name == null) { name = ""; }
            if (value.Length + name.Length > 15)
            {
                throw new ArgumentException("First Name + Last Name must be < 15");
            }
        }

        public int FullNameLength()
        {
            return FirstName.Length + LastName.Length;  
        }
    }
}

       
