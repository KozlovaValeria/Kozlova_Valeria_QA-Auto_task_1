namespace Task_6
{
    internal class Building
    {
        public int NumberBuilding { get; set; }
        public string NameBuilding { get; set; }
        public List<Room> Rooms { get; set; }

        public Building(int numberBuilding, string nameBuilding, List<Room> rooms)
        {
            NumberBuilding = numberBuilding;
            NameBuilding = nameBuilding;
            Rooms = rooms;
        }
    }
}
