namespace Task_5
{
    public class Adress
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
        public override bool Equals(object? obj)
        {
            return obj is Adress adress
                && adress.City == City
                && adress.Street == Street
                && adress.Flat == Flat
                && adress.Home == Home;
        }
        public override int GetHashCode()
        {
            return City.GetHashCode() + Street.GetHashCode() + Flat.GetHashCode() + Home.GetHashCode();
        }
    }
}
