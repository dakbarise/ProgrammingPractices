namespace MovingZerosToTheEnd.UnitTests
{
    [TestClass]
    public class MoveZeroesSolutionTests
    {
        [TestMethod]
        public void MoveZeroes_PositiveNumbers_ShouldBeOrderedCorrectly()
        {
            var response = MoveZeroesSolution.MoveZeroes(
                    new int[]
                    {
                        1, 2, 0, 1, 0, 1, 0, 3, 0, 1
                    });
            CollectionAssert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, response);
        }

        [TestMethod]
        public void MoveZeroes_WithNegativeNumbers_ShouldBeOrderedCorrectly()
        {
            var response = MoveZeroesSolution.MoveZeroes(
                    new int[]
                    {
                        1, -2, 0, -1, 0, 1, 0, 3, 0, 1
                    });
            CollectionAssert.AreEqual(new int[] { 1, -2, 1, -1, 3, 1, 0, 0, 0, 0 }, response);
        }

        [TestMethod]
        public void MoveZeroes_EmptyList_ShouldReturnEmptyList()
        {
            var response = MoveZeroesSolution.MoveZeroes(new int[] {});
            CollectionAssert.AreEqual(new int[] {}, response);
        }
    }
}