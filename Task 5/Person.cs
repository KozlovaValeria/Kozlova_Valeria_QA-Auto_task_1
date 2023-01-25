﻿namespace Task_5
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
                _firstName = value;
                CheckSumFirstLastName();
                
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
                _lastName = value;
                CheckSumFirstLastName();
          
            }
        }
       
        public Adress Adress { get; set; }

        public Person(string firstName, string lastName, Adress adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;  
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
        public void CheckSumFirstLastName()
        {
            if (FirstName != null && LastName != null)
            {
                if (FirstName.Length + LastName.Length > 15)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}

       
