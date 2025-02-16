using LogicProject;

namespace UnitTestsProject
{

    [TestClass]
    public class UnitTestsMathematics
    {
        [TestMethod]
        public void TestMethodSumEmptyMas()
        {
            // Arrange
            int[] mas = new int[] { };
            string expected = "Пустой массив!";
            string actual = "";

            // Act
            try
            {
                Mathematics.SumElements(mas);
            }
            catch (Exception e)
            {
                actual = e.Message;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodSumNormalMas()
        {
            // Arrange
            int[] mas = new int[] { 1, 2, 3, 4, 5 };
            int expected = 15;

            // Act
            int actual = Mathematics.SumElements(mas);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodSumOverflow()
        {
            // Arrange
            int[] mas = new int[] { 2000000000, 2000000000 };
            string expected = "Произошло исключение: Arithmetic operation resulted in an overflow.";
            string actual = "";

            // Act
            try
            {
                Mathematics.SumElements(mas);
            }
            catch (Exception e)
            {
                actual = e.Message;
            }

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
