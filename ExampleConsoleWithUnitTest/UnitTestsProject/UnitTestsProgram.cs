using ExampleConsoleProject;
using LogicProject;

namespace UnitTestsProject
{

    [TestClass]
    public class UnitTestsProgram
    {
        [TestMethod]
        public void TestMethodSumElementsInMoneyMas()
        {
            // Arrange
            Money[] moneys = new Money[]
            {
                new Money(11, 5),
                new Money(100, 5),
                new Money(11, 105)
            };
            double expected = 123.15;

            // Act
            double actual = Program.SumMoneysInRubles(moneys);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }

}
