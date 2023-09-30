namespace TDD3;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Rooter rooter = new Rooter();
        try
        {
            rooter.SquareRoot(-10);
        }
        catch (ArgumentOutOfRangeException e)
        {
            return;
        }
        Assert.Fail();
    }
}
