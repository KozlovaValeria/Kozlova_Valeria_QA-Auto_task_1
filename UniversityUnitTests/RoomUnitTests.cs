
using Task_6;

namespace UniversityUnitTests
{
    [TestClass]
    public class RoomUnitTests
    {
        public static Room defRoom = new(123, "Laboratory");

        [TestMethod]
        public void CheckRoomEqualsNegative()
        {
            Room room1 = defRoom;
            Room room2 = new Room(321, "Class");

            Assert.IsFalse(room1.Equals(room2));
        }

        [TestMethod]
        public void CheckRoomEqualsPositive()
        {
            Room room1 = defRoom;
            Room room2 = defRoom;

            Assert.IsTrue(room1.Equals(room2));
            Assert.AreEqual(room1.GetHashCode(), room2.GetHashCode());
        }

        [TestMethod]
        public void CheckRoomNumberNegative()
        {
            Room room1 = new Room(-333, "Laboratory");
            Room room2 = new Room(10001, "Laboratory");

            Assert.AreEqual(0, room1.NumberRoom);
            Assert.AreEqual(0, room2.NumberRoom);
        }
    }
}
