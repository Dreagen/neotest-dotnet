using NUnit.Framework;

namespace NUnitSamples;

[TestFixture]
public class TestCaseTests
{
    [TestCase(1)]
    [TestCase(2)]
    public void TestCaseTest(int input)
    {
        Assert.That(input, Is.EqualTo(3));
    }

    [Test]
    public void Test()
    {
        Assert.Pass();
    }
}
