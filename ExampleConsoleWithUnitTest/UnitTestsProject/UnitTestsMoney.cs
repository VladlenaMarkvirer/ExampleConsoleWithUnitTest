using LogicProject;

namespace UnitTestsProject
{

    [TestClass]
    public class UnitTestsMoney
    {
        [TestMethod]
        public void TestMethodCreateMoneyDefault()
        {
            // Arrange
            int rub = 0;
            int kop = 0;
            int count = 1;

            // Act
            Money m = new Money();

            // Assert
            Assert.IsTrue(m.Rub == rub && m.Kop==kop && Money.GetCount() == count);
        }
    }

}
