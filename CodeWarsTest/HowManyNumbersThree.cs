namespace CodeWarsTest;

using CodeWars4kyu;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

public class HowManyNumbersThree
{
    [Test]
    public void HowManyNumbersThreeTest()
    {
        CollectionAssert.AreEqual(new List<long> { 8L, 118L, 334L }, HowManyNumbersThreeTask.FindAll(10, 3));
        CollectionAssert.AreEqual(new List<long> { 1L, 999L, 999L }, HowManyNumbersThreeTask.FindAll(27, 3));
        CollectionAssert.AreEqual(new List<long>(), HowManyNumbersThreeTask.FindAll(84, 4));
        CollectionAssert.AreEqual(new List<long> { 123L, 116999L, 566666L }, HowManyNumbersThreeTask.FindAll(35, 6));
    }
}