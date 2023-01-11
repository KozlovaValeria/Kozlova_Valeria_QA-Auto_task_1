namespace Task_6
{
    public class Room
    {
        public int NumberRoom { get; set; }
        public string Appointment { get; set; }
        public Room(int numberRoom, string appointment)
        {
            NumberRoom = numberRoom;
            Appointment = appointment;
        }
    }
}
