namespace Task_5
{
    internal class Adress
    {
        private int _home;
        private int _flat;
        public string Street { get; set; }
        public string City { get; set; }
        public int Home
        {
            get
            {
                return _home;
            }
            set
            {
                if (value > 0 && value < 1000)
                {
                    _home = value;
                }
            }
        }
        public int Flat
        {
            get
            {
                return _flat;
            }
            set
            {
                if (value > 0 && value < 1000)
                {
                    _flat = value;
                }
            }
        }  
        public Adress(int home, int flat, string street, string city)
        {
            _home = home; 
            _flat = flat;
            Street = street; 
            City = city;
        }

    }
}
