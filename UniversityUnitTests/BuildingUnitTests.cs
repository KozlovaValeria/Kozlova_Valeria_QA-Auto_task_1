
using Task_6;

namespace UniversityUnitTests
{
    [TestClass]
    public class BuildingUnitTests
    {
        public static Building defBuilding = new (22, "Biologi center", new List<Room> { });

        [TestMethod]
        public void CheckBuildingEqualsPositive()
        {
            Building bul1 = defBuilding;
            Building bul2 = defBuilding;

            Assert.IsTrue(bul1.Equals(bul2));
            Assert.AreEqual(bul1.GetHashCode(), bul2.GetHashCode());
        }

        [TestMethod]
        public void CheckBuildingEqualsNegative()
        {
            Building bul1 = new Building(1, "Math center", new List<Room> { });
            Building bul2 = defBuilding;

            Assert.IsFalse(bul1.Equals(bul2));
        }

        [TestMethod]
        public void CheckBuildingNumberNegative()
        {
            Building bul1 = new Building(-987, "Math center", new List<Room> {});
            Building bul2 = new Building(11000, "Biologi center", new List<Room> {});

            Assert.AreEqual(0, bul1.NumberBuilding);
            Assert.AreEqual(0, bul2.NumberBuilding);
        }
    }
}
