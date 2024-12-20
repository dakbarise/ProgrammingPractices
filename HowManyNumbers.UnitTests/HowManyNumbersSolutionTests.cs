
namespace HowManyNumbers.UnitTests
{
    [TestClass]
    public class HowManyNumbersSolutionTests
    {
        [TestMethod]
        public void ExampleTests()
        {
            CollectionAssert.AreEqual(HowManyNumbersSolution.FindAll(10, 3), new List<long> { 8L, 118L, 334L });
            CollectionAssert.AreEqual(HowManyNumbersSolution.FindAll(27, 3), new List<long> { 1L, 999L, 999L });
            CollectionAssert.AreEqual(HowManyNumbersSolution.FindAll(84, 4), new List<long>());
            CollectionAssert.AreEqual(HowManyNumbersSolution.FindAll(35, 6), new List<long> { 123L, 116999L, 566666L });
        }
    }
}