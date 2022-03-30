using Microsoft.VisualStudio.TestTools.UnitTesting;
using STimers;

namespace STimeTest;

[TestClass]
public class STimeTest
{
    [TestMethod]
    public void TestTime()
    {
        // Проверка конструктора.
        var timer = new STime(10, 90, 10, 10);
        Assert.AreEqual(timer.Hours, 11);
        Assert.AreEqual(timer.Minutes, 30);

        // Проверка сложения
        timer += new STime(milliseconds: 2020);
        Assert.AreEqual(timer.Seconds, 12);
        Assert.AreEqual(timer.Milliseconds, 30);
    }
}
