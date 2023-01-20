namespace Task_6
{
    public class Building : UniversityAsset
    {
        private int _numberBuilding;
        public int NumberBuilding {
            get
            {
                return _numberBuilding;
            }
            set
            {
                if(value > 0 && value < 10000) 
                { 
                    _numberBuilding = value;
                }
            }
        }
        public string NameBuilding { get; set; }
        public List<Room> Rooms { get; set; }

        public Building(int numberBuilding, string nameBuilding, List<Room> rooms)
        {
            _numberBuilding = numberBuilding;
            NameBuilding = nameBuilding;
            Rooms = rooms;
        }
    }
}
