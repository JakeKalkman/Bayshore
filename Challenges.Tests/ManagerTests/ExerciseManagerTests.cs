using Challenges.Domain.Interfaces;
using Challenges.Domain.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenges.Tests.ManagerTests
{
    [TestClass]
    public class ExerciseManagerTests
    {
        private readonly IExerciseManager exerciseManager;

        public ExerciseManagerTests()
        {
            exerciseManager = new ExerciseManager();
        }

        [TestMethod]
        public void IsNumberAPalidrome_ShouldReturnTrue()
        {
            var expectedResult = true;
            var input = "121";

            var result = exerciseManager.IsNumberPalidrome(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void IsNumberAPalidrome_ShouldReturnFalse()
        {
            var expectedResult = false;
            var input = "123";

            var result = exerciseManager.IsNumberPalidrome(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SpiralMatrixToNumber_ShouldReturnCorrectMatrix()
        {
            var expectedResult = "20 21 22 23 24 <br>19 6 7 8 9 <br>18 5 0 1 10 <br>17 4 3 2 11 <br>16 15 14 13 12 <br>";
            var input = 24;

            var result = exerciseManager.SpiralMatrixToNumber(24);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
