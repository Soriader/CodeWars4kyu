using CodeWars4kyu;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWarsTest;

public class MysteryFunction
{
    [Test]
    public void MysteryTest()
    {
        Assert.AreEqual(5, MysteryFunctionTask.Mystery(6));
        Assert.AreEqual(13, MysteryFunctionTask.Mystery(9));
        Assert.AreEqual(26, MysteryFunctionTask.Mystery(19));
        
        Assert.AreEqual(6, MysteryFunctionTask.MysteryInv(5));
        Assert.AreEqual(9, MysteryFunctionTask.MysteryInv(13));
        Assert.AreEqual(19, MysteryFunctionTask.MysteryInv(26));
    }
}