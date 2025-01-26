using CodeWars4kyu;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWarsTest;

public class GettingAlongWithIntegerPartitions
{
    [Test]
    public void GettingAlongWithIntegerPartitionsTest()
    {
        Assert.AreEqual("Range: 1 Average: 1.50 Median: 1.50", GettingAlongWithIntegerPartitionsTask.Part(2));
        Assert.AreEqual("Range: 2 Average: 2.00 Median: 2.00", GettingAlongWithIntegerPartitionsTask.Part(3));
        Assert.AreEqual("Range: 3 Average: 2.50 Median: 2.50", GettingAlongWithIntegerPartitionsTask.Part(4));
        Assert.AreEqual("Range: 5 Average: 3.50 Median: 3.50", GettingAlongWithIntegerPartitionsTask.Part(5));
    }
}