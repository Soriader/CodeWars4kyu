using CodeWars4kyu;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CodeWarsTest;

public class StringsMix
{
    [Test]
    public static void StringsMixTest()            
    {
        Assert.AreEqual("2:eeeee/2:yy/=:hh/=:rr", StringsMixTask.Mix("Are they here", "yes, they are here"));
        Assert.AreEqual("2:eeeee/2:yy/=:hh/=:rr", StringsMixTask.Mix("Are they here", "yes, they are here"));
        Assert.AreEqual("1:ooo/1:uuu/2:sss/=:nnn/1:ii/2:aa/2:dd/2:ee/=:gg", StringsMixTask.Mix("looping is fun but dangerous", "less dangerous than coding"));
        Assert.AreEqual("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt", StringsMixTask.Mix(" In many languages", " there's a pair of functions"));
        Assert.AreEqual("1:ee/1:ll/1:oo", StringsMixTask.Mix("Lords of the Fallen", "gamekult"));
        Assert.AreEqual("", StringsMixTask.Mix("codewars", "codewars"));
        Assert.AreEqual("1:nnnnn/1:ooooo/1:tttt/1:eee/1:gg/1:ii/1:mm/=:rr", StringsMixTask.Mix("A generation must confront the looming ", "codewarrs"));
    }
}