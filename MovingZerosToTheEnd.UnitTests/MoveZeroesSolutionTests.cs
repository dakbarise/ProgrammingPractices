namespace MovingZerosToTheEnd.UnitTests
{
    [TestClass]
    public class MoveZeroesSolutionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var response = MoveZeroesSolution.MoveZeroes(
                    new int[]
                    {
                        1, 2, 0, 1, 0, 1, 0, 3, 0, 1
                    });
            CollectionAssert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, response);
        }
    }
}