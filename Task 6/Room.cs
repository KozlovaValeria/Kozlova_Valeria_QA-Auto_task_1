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
            return obj is Room room
                && room.NumberRoom == NumberRoom
                && room.Appointment == Appointment;
        }
        public override int GetHashCode()
        {
            return NumberRoom.GetHashCode() + Appointment.GetHashCode();
        }
    }
}
