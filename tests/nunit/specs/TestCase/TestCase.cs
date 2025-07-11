using NUnit.Framework;

namespace NUnitSamples;

[TestFixture]
public class TestCaseTests
{
    [TestCase(1, 1)]
    [TestCase(2, 1)]
    public void TestCaseTest(int input, int expected)
    {
        Assert.That(input, Is.EqualTo(expected));
    }

    [Test]
    public void Test()
    {
        Assert.Pass();
    }
}
