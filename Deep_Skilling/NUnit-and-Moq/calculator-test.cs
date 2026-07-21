using NUnit.Framework;

class Calculator
{
    public int Add(int a,int b)
    {
        return a + b;
    }
}

[TestFixture]

class CalculatorTest
{
    [Test]

    public void TestAddition()
    {
        Calculator c =
        new Calculator();

        int result =
        c.Add(2,3);

        Assert.AreEqual(5,result);
    }
}