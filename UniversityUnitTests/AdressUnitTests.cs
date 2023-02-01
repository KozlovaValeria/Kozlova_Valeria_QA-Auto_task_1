
using Task_5;

namespace UniversityUnitTests
{
    [TestClass]
    public class AdressUnitTests
    {
        public static Adress defAdress = new(78, 121, "Minskaya", "Minsk");

        [TestMethod]
        public void CheckAdressEqualsPositive()
        {
            Adress adr1 = defAdress;
            Adress adr2 = defAdress;

            Assert.IsTrue(adr1.Equals(adr2));
            Assert.AreEqual(adr1.GetHashCode(), adr2.GetHashCode());
        }

        [TestMethod]
        public void CheckAdressEqualsNegative()
        {
            Adress adr1 = defAdress;
            Adress adr2 = new Adress(1, 87, "Ivanova", "Brest");

            Assert.IsFalse(adr1.Equals(adr2));
        }

        [TestMethod]
        public void CheckAdressNumbersNegative()
        {
            Adress adr1 = new Adress(-7, 121, "Minskaya", "Minsk");
            Adress adr2 = new Adress(1, 2340, "Ivanova", "Brest");

            Assert.AreEqual(0, adr1.Home);
            Assert.AreEqual(0, adr2.Flat);
        }
    }
}
