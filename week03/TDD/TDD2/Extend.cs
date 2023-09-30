using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Text;

namespace TDD;

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void BasicRooterTest()
    {
        // Create an instance to test:
        Rooter rooter = new Rooter();
        // Try a range of values:
        for (double expectedResult = 1e-8;
   expectedResult < 1e+8;
   expectedResult = expectedResult * 3.2)
        {
            RooterOneValue(rooter, expectedResult);
        }
    }

    private void RooterOneValue(Rooter rooter, double expectedResult)
    {
        double input = expectedResult * expectedResult;
        double actualResult = rooter.SquareRoot(input);
        Assert.AreEqual(expectedResult, actualResult,
        delta: expectedResult / 1000);
    }
}
