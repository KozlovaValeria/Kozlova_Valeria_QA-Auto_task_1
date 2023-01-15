namespace Task_6
{
    public class Room
    {
        private int _numberRoom;
        public int NumberRoom
        {
            get
            {
                return _numberRoom;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    _numberRoom = value;
                }
            }
        }
        public string Appointment { get; set; }
        public Room(int numberRoom, string appointment)
        {
            _numberRoom = numberRoom;
            Appointment = appointment;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Room room)
            {
                return room.NumberRoom == NumberRoom &&
                       room.Appointment == Appointment;
            }
            return false;
        }
    }
}
