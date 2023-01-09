namespace Task_5
{
    internal class Adress
    {
        private string _street;
        private string _city;
        private int _home;
        private int _flat;
        public int Home { get { return _home; } set { _home = value; } }
        public int Flat { get { return _flat; } set { _flat = value; } }
        public string Street { get { return _street; } set { _street = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public Adress(int home, int flat, string street, string city)
        {
            _home = home; 
            _flat = flat;
            _street = street; 
            _city = city;
        }

    }
}
