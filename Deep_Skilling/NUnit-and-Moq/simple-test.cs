using NUnit.Framework;

[TestFixture]

class SimpleTest
{
    [Test]

    public void CheckValue()
    {
        int a = 10;

        Assert.AreEqual(10, a);
    }
}